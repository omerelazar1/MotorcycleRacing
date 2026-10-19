using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class BrandList:List<Brand>
    {
        public BrandList() { }
        public BrandList(IEnumerable<Brand> list):base(list) { }
        public BrandList(IEnumerable<BaseEntity>list):base(list.Cast<Brand>().ToList()) { }
    }
}
