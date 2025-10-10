using BLL.DTOs;
using BLLProject.Interfaces;
using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace BLLProject.Repositories
{
    public class KepoiDataRepository : IKepoiDataRepository 
    {
        private readonly AppDbContext _dbContext;
        public KepoiDataRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<KepoiDataDto>> GetExistingDataByHashAsync(string fileHash, string userId)
        {
            var existing = await _dbContext.KepoiData
                .Where(x => x.FileHash == fileHash && x.AppUserId == userId)
                .ToListAsync();

            return existing.Select(k => (KepoiDataDto)k).ToList();
        }
        public async Task<List<KepoiData>> AddRangeAsync(List<KepoiData> records)
        {
            await _dbContext.KepoiData.AddRangeAsync(records);
            return records;
        }

        public async Task<string> GetFileHashAsync(IFormFile file)
        {
            using var sha256 = SHA256.Create();
            using var stream = file.OpenReadStream();
            var hashBytes = await sha256.ComputeHashAsync(stream);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
