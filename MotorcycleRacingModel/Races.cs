using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Races:BaseEntity
    {
        private string raceName;
        private DateTime raceDate;
        private Tracks trackID;

        public string RaceName { get => raceName; set => raceName = value; }
        public DateTime RaceDate { get => raceDate; set => raceDate = value; }
        public Tracks TrackID { get => trackID; set => trackID = value; }
    }
}
