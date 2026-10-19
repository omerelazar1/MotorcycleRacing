using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class ModelList:List<Model>
    {
        public ModelList() { }
        public ModelList(IEnumerable<Model> list) : base(list) { }
        public ModelList(IEnumerable<BaseEntity> list) : base(list.Cast<Model>().ToList()) { }
    }
}
