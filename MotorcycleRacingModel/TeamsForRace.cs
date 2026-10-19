using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TeamsForRace:BaseEntity
    {
        private Teams teamID;
        private Races raceID;

        public Teams TeamID { get => teamID; set => teamID = value; }
        public Races RaceID { get => raceID; set => raceID = value; }
    }
}
