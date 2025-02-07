using MicroservicePOC.Web.Models;

namespace MicroservicePOC.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
