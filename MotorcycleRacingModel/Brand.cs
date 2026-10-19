using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Brand:BaseEntity
    {
        private string brandName;
        private string brandDescription;

        public string BrandName { get => brandName; set => brandName = value; }
        public string BrandDescription { get => brandDescription; set => brandDescription = value; }
    }
}
