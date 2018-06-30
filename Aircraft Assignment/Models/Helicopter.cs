using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Assignment.Models
{
    class Helicopter : Aircrafts
    { 
        private int NumberOfBlades { get; set; }
        private bool CanLandOnWater { get; set; }

        public Helicopter(string name, int amount) : base(name)
        {
            Random speed = new Random();
            Random year = new Random();

            this.SpeedInKM = speed.Next(500, 1000);
            this.NumberOfBlades = 4;
            this.YearProduced = year.Next(1900, 2017);
            this.AmountInStock = amount;
            this.DateAdded = DateTime.Now;
            this.CanLandOnWater = false;
        }

        public override string EngineSound()
        {
            return "whop whop whop";
        }

        public override string ToString()
        {
            string information = "";
            information += base.ToString();
            information += $"Number of Blades: {NumberOfBlades}\n";
            information += $"Can Land On Water: {CanLandOnWater}\n";

            return information;
        }

    }
}
