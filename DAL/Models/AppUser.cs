using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public ICollection<KepoiData> KepoiDataList { get; set; } = new HashSet<KepoiData>();
    }
}
