using Microsoft.AspNetCore.Identity;

namespace MicroservicePOC.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
