using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Results:BaseEntity
    {
        private string first;
        private string second;
        private string third;

        public string First { get => first; set => first = value; }
        public string Second { get => second; set => second = value; }
        public string Third { get => third; set => third = value; }
    }
}
