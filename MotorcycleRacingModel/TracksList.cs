using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TracksList:List<Tracks>
    {
        public TracksList() { }
        public TracksList(IEnumerable<Tracks> list) : base(list) { }
        public TracksList(IEnumerable<BaseEntity> list) : base(list.Cast<Tracks>().ToList()) { }
    }
}
