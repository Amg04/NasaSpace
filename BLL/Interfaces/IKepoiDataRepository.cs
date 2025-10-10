using BLL.DTOs;
using DAL.Models;
using Microsoft.AspNetCore.Http;

namespace BLLProject.Interfaces
{
    public interface IKepoiDataRepository
    {
          Task<List<KepoiDataDto>> GetExistingDataByHashAsync(string fileHash, string userId);
        Task<List<KepoiData>> AddRangeAsync(List<KepoiData> records);
        Task<string> GetFileHashAsync(IFormFile file);
    }
}
