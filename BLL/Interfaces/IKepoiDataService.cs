using BLL.DTOs;
using Microsoft.AspNetCore.Http;

namespace BLL.Interfaces
{
    public interface IKepoiDataService
    {
        Task<List<KepoiDataDto>> ProcessCsvAsync(IFormFile file, string userId);
        Task<List<KepoiDataDto>> ParseCsvFileAsync(IFormFile file);
    }
}
