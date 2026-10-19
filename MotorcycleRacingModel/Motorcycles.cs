using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Motorcycles:BaseEntity
    {
        private Riders riderID;
        private string brand;
        private string model;
        private DateTime year;
        private int numberOfOwners;

        public Riders RiderID { get => riderID; set => riderID = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public DateTime Year { get => year; set => year = value; }
        public int NumberOfOwners { get => numberOfOwners; set => numberOfOwners = value; }
    }
}
