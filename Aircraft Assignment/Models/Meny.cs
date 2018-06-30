using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Assignment.Models
{
    class Meny
    {
        
        public static void startMeny()
        {
            AirHangar hanger = new AirHangar();
            int userInput = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Buy Airplane");
                Console.WriteLine("2. Buy Helicopter");
                Console.WriteLine("3. Sell Aircrafts");
                Console.WriteLine("4. Show Aircrafts");
                Console.WriteLine("5. Lift Off!");
                Console.WriteLine("6. Quit");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    

                    case 1:
                        Console.WriteLine("Enter the name of the airplane you want to buy");
                        string buyAirplane = Console.ReadLine().ToLower();
                        
                        Console.WriteLine("How many would you like to buy");
                        int amountAirplane = Convert.ToInt32(Console.ReadLine());
                        
                        hanger.AddAirplanes(buyAirplane, amountAirplane);

                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the Helicopter you want to buy");
                        string buyHeli = Console.ReadLine().ToLower();

                        Console.WriteLine("How many would you like to buy");
                        int amountHeli = Convert.ToInt32(Console.ReadLine());
                        
                        hanger.AddHelicopter(buyHeli, amountHeli);

                        break;
                    case 3:

                        Console.WriteLine("Enter the name of the aircraft you want to sell");
                        var sellName = Console.ReadLine().ToLower();

                        Console.WriteLine("Enter the amount you would like to sell");
                        int sellAmount = Convert.ToInt32(Console.ReadLine());

                        hanger.Sell(sellName, sellAmount);
                        Console.ReadKey();
                        break;

                    case 4:
                      
                        Console.WriteLine(hanger.GetAllInfo());
                        Console.WriteLine("Press any key to return to the meny");
                        Console.ReadKey();
                        
                        break;
                    case 5:
                        
                        Console.WriteLine("Enter the name of the aircraft you want to liftoff");
                        string fly = Console.ReadLine();
                        Console.WriteLine(hanger.LiftOff(fly));
                        Console.WriteLine("Press any key to return to the meny");
                        Console.ReadKey();
                        break;
                        
                }
                
            } while (userInput != 6);

        }
    }
}
