using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Teams:BaseEntity
    {
        private string teamName;
        private DateTime establishDate;

        public string TeamName { get => teamName; set => teamName = value; }
        public DateTime EstablishDate { get => establishDate; set => establishDate = value; }
    }
}
