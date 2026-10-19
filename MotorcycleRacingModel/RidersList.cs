using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class RidersList:List<Riders>
    {
        public RidersList() { }
        public RidersList(IEnumerable<Riders> list) : base(list) { }
        public RidersList(IEnumerable<BaseEntity> list) : base(list.Cast<Riders>().ToList()) { }
    }
}
