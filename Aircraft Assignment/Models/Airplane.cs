using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Assignment.Models
{
    class Airplane : Aircrafts
    {
        private int NumberOfWings { get; set; }
        //Constructor
        public Airplane(string name, int amount) : base(name)
        {
            Random rand2 = new Random();
            Random rand1 = new Random();
            this.SpeedInKM = rand1.Next(500, 1000);
            this.NumberOfWings = 2;
            this.YearProduced = rand2.Next(1900, 2017);
            this.AmountInStock = amount;
            this.DateAdded = DateTime.Now;
            
        }


        public override string EngineSound()
        {
            return "nnneeaoowww";
        }

        public override string ToString()
        {
            string information = "";
            information += base.ToString();
            information += $"Number of Wings: {NumberOfWings}\n";

            return information;
        }

    }
}
