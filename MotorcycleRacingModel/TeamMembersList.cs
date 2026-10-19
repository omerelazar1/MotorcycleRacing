using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TeamMembersList:List<TeamMembers>
    {
        public TeamMembersList() { }
        public TeamMembersList(IEnumerable<TeamMembers> list) : base(list) { }
        public TeamMembersList(IEnumerable<BaseEntity> list) : base(list.Cast<TeamMembers>().ToList()) { }
    }
}
