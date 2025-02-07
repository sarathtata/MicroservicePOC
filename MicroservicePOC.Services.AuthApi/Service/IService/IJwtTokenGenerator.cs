using MicroservicePOC.Services.AuthApi.Models;

namespace MicroservicePOC.Services.AuthApi.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
