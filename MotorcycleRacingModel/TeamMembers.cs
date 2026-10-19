using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class TeamMembers:BaseEntity
    {
        private Teams teamID;
        private Riders riderID;

        public Teams TeamID { get => teamID; set => teamID = value; }
        public Riders RiderID { get => riderID; set => riderID = value; }
    }
}
