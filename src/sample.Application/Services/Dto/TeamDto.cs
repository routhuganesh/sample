using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Services.Dto
{
    [AutoMapFrom(typeof(Team))]
    public class TeamDto:AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime createdTime { get; set; }
    }
}
