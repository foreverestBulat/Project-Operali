using Architecture.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Application.Entities
{
    public class Member : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
