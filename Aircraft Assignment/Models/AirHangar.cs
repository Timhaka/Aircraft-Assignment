using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Assignment.Models
{
    class AirHangar
    {
        public List<Aircrafts> myHangar { get; set; }


        public AirHangar()
        {
            myHangar = new List<Aircrafts>();
        }

        public void AddAirplanes(string namePlane, int amount)
        {
            int x;
            if (amount <= 0)
            {
                Console.WriteLine($"You cant buy {amount} Airplanes, please enter name and amount");
                Console.WriteLine("Press any key to return to the meny");
                Console.ReadKey();
            }
            else if (namePlane == "")
            {
                Console.WriteLine($"You cant buy a Airplane without a name");
                Console.WriteLine("Press any key to return to the meny");
                Console.ReadKey();
            }

            else
                for (x = 0; x < amount; x++)
            {
                myHangar.Add(new Airplane(namePlane, amount));
            }
            

        }

        public void AddHelicopter(string nameHeli, int amount)
        {
            int x;
            if (amount <= 0)
            {
                Console.WriteLine($"You cant buy {amount} Helicopters");
                Console.WriteLine("Press any key to return to the meny");
                Console.ReadKey();
            }
            else if (nameHeli == "")
            {
                Console.WriteLine($"You cant buy a Helicopter without a name");
                Console.WriteLine("Press any key to return to the meny");
                Console.ReadKey();
            }

            else
            for (x = 0; x < amount; x++)
            {
                Helicopter hel = new Helicopter(nameHeli, amount);
                myHangar.Add(hel);
            }
            
        }


        public void Sell(string name, int amount)
        {
            
            //lambda
            // myHangar.RemoveAll(x => x.Name == name);
            
               int count = 0;
                for (int y = myHangar.Count - 1; y >= 0; y--)
                {
                    if (myHangar[y].Name == name)
                    {
                        
                         count++;
                        
                    }
                }
            
                int x = 0;
                if (amount < count)
                {

                    for (int y = myHangar.Count - 1; y >= 0; y--)
                     {
                        if (myHangar[y].Name == name)
                         {
                           myHangar[y].AmountInStock = myHangar[y].AmountInStock - amount;
                         }
                     }

                Console.WriteLine($"Selling {amount} aircraft by the name {name}");

                    for (int i = myHangar.Count - 1; i >= 0; i--)
                    {
                        if (myHangar[i].Name == name && x < amount)
                        {  
                            myHangar.RemoveAt(i);
                            x++;
                        }
                    }

                }
                else if (amount > count)
                {
                    Console.WriteLine($"You dont have enough {name} in your hanger! You only have {count} {name}!");
                    Console.WriteLine("Please retry, press any key to return to the meny");
                
                }
        }

        public string LiftOff(string name)
        {
            string temp = "";



            for (int x = 0; x < myHangar.Count; x++)
            {
                if (myHangar[x].Name == name)
                {
                    temp = $"Starting Engine: {myHangar[x].EngineSound()}" + Environment.NewLine;
                    break;
                }
                else
                {
                    temp = $"No Aircraft with that name in your Hangar";
                }
            }


            return temp;
        }

        public string GetAllInfo()
        {
            string information = "";
            foreach (Aircrafts air in myHangar)
            {
                information += air.ToString() + Environment.NewLine;
                
            }
            
            return "In Hangar contains: \n"+ information;
        }
        
    }
}
