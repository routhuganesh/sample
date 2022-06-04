using System.Threading.Tasks;
using Abp.Application.Services;
using sample.Authorization.Accounts.Dto;

namespace sample.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
