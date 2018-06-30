using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Assignment.Models
{
    class Aircrafts
    {
        
        public string Name { get; set; }
        public int SpeedInKM { get; set; }
        public int YearProduced { get; set; }
        public int AmountInStock { get; set; }
        public DateTime DateAdded { get; set; }

        public Aircrafts() { }
        public Aircrafts(string name)
        {
            
            this.Name = name;

        }

        public override string ToString()
        {
            string information = "";
            information += $"Name: {Name}\n";
            information += $"Speed In Km: {SpeedInKM}\n";
            information += $"Year Produced: {YearProduced}\n";
            information += $"Amount In Stock: {AmountInStock}\n";
            information += $"Date Added: {DateAdded}\n";

            return information;
        }

        public virtual string EngineSound()
        {
            return "Aircraft sounds!";
        }
        
    }
}
