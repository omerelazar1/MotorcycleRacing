using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class MotorcyclesList:List<Motorcycles>
    {
        public MotorcyclesList() { }
        public MotorcyclesList(IEnumerable<Motorcycles> list) : base(list) { }
        public MotorcyclesList(IEnumerable<BaseEntity> list) : base(list.Cast<Motorcycles>().ToList()) { }
    }
}
