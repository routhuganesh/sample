using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using sample.Authorization;
using sample.Domain;
using sample.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Services
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class TeamAppService : AsyncCrudAppService<Team, TeamDto, Guid>, ITeamAppService
    {
        public TeamAppService(IRepository<Team, Guid> repository) : base(repository)
        {
        }
    }
}
