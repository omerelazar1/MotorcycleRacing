using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class ResultsList:List<Results>
    {
        public ResultsList() { }
        public ResultsList(IEnumerable<Results> list) : base(list) { }
        public ResultsList(IEnumerable<BaseEntity> list) : base(list.Cast<Results>().ToList()) { }
    }
}
