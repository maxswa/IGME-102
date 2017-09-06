using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swartwout_PE3
{
    class Program
    {
        //Class: Main
        //Author: Max Swartwout
        //Purpose: Read in character values then print them out
        //Limitations: None
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] roles = new string[4] { "Troubleshooter", "Troublemaker", "Hero", "Villain" };
            string role = roles[rand.Next(0, 3)];
            string name;
            string society;
            int health = 100;
            string clearance;
            string power;
            int powerLvl = -1;

            Console.WriteLine("Your role is " + role);
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your secret society: ");
            society = Console.ReadLine();
            Console.WriteLine("Enter your clearance value: ");
            clearance = Console.ReadLine();
            Console.WriteLine("Enter your mutant power: ");
            power = Console.ReadLine();
            while(powerLvl < 0)
            {
                Console.WriteLine("Enter your mutant power level (1-10): ");
                if (!Int32.TryParse(Console.ReadLine(), out powerLvl))
                {
                    Console.WriteLine("Invalid entry! Please enter an integer.");
                    powerLvl = -1;
                }
                else if (powerLvl < 0 || powerLvl > 10)
                {
                    Console.WriteLine("Power level must be between 0 and 10.");
                    powerLvl = -1;
                }
            }
            powerLvl += 3;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Role: " + role);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Secret Society: " + society);
            Console.WriteLine("Clearance Value: " + clearance);
            Console.WriteLine("Mutant Power: " + power);
            Console.WriteLine("Power Level: " + powerLvl);
        }
    }
}
