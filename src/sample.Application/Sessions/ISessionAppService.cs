using System.Threading.Tasks;
using Abp.Application.Services;
using sample.Sessions.Dto;

namespace sample.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
