using BLL.DTOs;
using BLL.Interfaces;
using BLLProject.Interfaces;
using CsvHelper;
using CsvHelper.Configuration;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace BLLProject.Services
{
    public class KepoiDataService : IKepoiDataService
    {
        private readonly IUnitOfWork _unitOfWork;

        public KepoiDataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<KepoiDataDto>> ProcessCsvAsync(IFormFile file, string userId)
        {
            await _unitOfWork.BeginTransactionAsync(); // إضافة بداية transaction

            try
            {
                // 1. Generate file hash
                string fileHash = await _unitOfWork.KepoiDataRepository.GetFileHashAsync(file);

                // 2. Check if file already exists
                var existingData = await _unitOfWork.KepoiDataRepository.GetExistingDataByHashAsync(fileHash, userId);
                if (existingData.Any())
                {
                    await _unitOfWork.CommitTransactionAsync(); // commit في حالة البيانات الموجودة
                    return existingData;
                }

                // 3. Parse CSV
                var dtoRecords = await ParseCsvFileAsync(file); // إضافة await

                // 4. Map to entities and save
                var records = dtoRecords.Select(dto =>
                {
                    var model = (KepoiData)dto;
                    model.FileHash = fileHash;
                    model.AppUserId = userId;
                    return model;
                }).ToList();

                var savedRecords = await _unitOfWork.KepoiDataRepository.AddRangeAsync(records);
                await _unitOfWork.SaveChangesAsync(); // حفظ التغييرات
                await _unitOfWork.CommitTransactionAsync(); // commit النجاح

                return savedRecords.Select(k => (KepoiDataDto)k).ToList();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackTransactionAsync(); // rollback في حالة الخطأ
                throw;
            }
        }

        public async Task<List<KepoiDataDto>> ParseCsvFileAsync(IFormFile file) // غيرت لـ async
        {
            using var reader = new StreamReader(file.OpenReadStream());
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                MissingFieldFound = null,
                BadDataFound = null,
                TrimOptions = TrimOptions.Trim
            };

            using var csv = new CsvReader(reader, config);
            return await Task.Run(() => csv.GetRecords<KepoiDataDto>().ToList()); // جعلها async
        }
    }
}