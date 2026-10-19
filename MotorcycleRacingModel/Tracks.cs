using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Tracks:BaseEntity
    {
        private string trackDescription;

        public string TrackDescription { get => trackDescription; set => trackDescription = value; }
    }
}
