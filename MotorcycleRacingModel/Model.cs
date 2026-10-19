using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Model:BaseEntity
    {
        private string modelDescription;

        public string ModelDescription { get => modelDescription; set => modelDescription = value; }
    }
}
