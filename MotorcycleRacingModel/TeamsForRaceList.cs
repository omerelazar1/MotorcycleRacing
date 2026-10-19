using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TeamsForRaceList:List<TeamsForRace>
    {
        public TeamsForRaceList() { }
        public TeamsForRaceList(IEnumerable<TeamsForRace> list) : base(list) { }
        public TeamsForRaceList(IEnumerable<BaseEntity> list) : base(list.Cast<TeamsForRace>().ToList()) { }
    }
}
