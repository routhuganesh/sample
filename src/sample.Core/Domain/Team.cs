using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Domain
{
    public class Team:AuditedEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime createdTime { get; set; }
    }
}
