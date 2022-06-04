using Abp.Application.Services;
using sample.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Services
{
    public interface ITeamAppService:IAsyncCrudAppService<TeamDto,Guid>
    {
    }
}
