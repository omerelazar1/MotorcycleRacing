using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class RacesList:List<Races>
    {
        public RacesList() { }
        public RacesList(IEnumerable<Races> list) : base(list) { }
        public RacesList(IEnumerable<BaseEntity> list) : base(list.Cast<Races>().ToList()) { }
    }
}
