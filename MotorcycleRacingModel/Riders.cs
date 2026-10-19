using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Riders:Users
    {
        private DateTime startYear;
        private bool isActive;

        public DateTime StartYear { get => startYear; set => startYear = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
    }
}
