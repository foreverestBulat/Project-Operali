using Architecture.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Application.Entities
{
    public class Event : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DateTime { get; set; }
        public virtual List<Member> CastMembers { get; set; }
    }
}
