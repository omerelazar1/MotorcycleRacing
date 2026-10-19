using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TeamsList:List<Teams>
    {
        public TeamsList() { }
        public TeamsList(IEnumerable<Teams> list) : base(list) { }
        public TeamsList(IEnumerable<BaseEntity> list) : base(list.Cast<Teams>().ToList()) { }
    }
}
