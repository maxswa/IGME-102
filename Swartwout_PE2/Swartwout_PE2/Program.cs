using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swartwout_PE2
{
    // Class: Character
    // Author: Max Swartwout
    // Purpose: Store attributes of a character
    public class Character
    {
        public const int attrCount = 5;
        public string[] attributes = new string[attrCount];
        public int[] values = new int[attrCount];
        public string name;
        public int totalPts;
        
        public Character()
        {
            zeroAttr();
        }

        // Method: ptsLeft
        // Purpose: Returns the ammount of points left to assign
        // Restrictions: None
        public int ptsLeft()
        {
            return totalPts - values.Sum();
        }

        // Method: zeroAttr
        // Purpose: Zeroes the attribute values
        // Restrictions: None
        public void zeroAttr()
        {
            for (int i=0; i<attrCount; i++)
            {
                values[i] = 0;
            }
        }
    }
    class Program
    {
        // Method: Main
        // Purpose: Prompts for and reads in all aspects of the user's character
        // Restrictions: Some non-numerical inputs will crash the program
        static void Main(string[] args)
        {
            Character mainChar = new Character();
            Console.WriteLine("Enter your name: ");
            mainChar.name = Console.ReadLine();
            Console.WriteLine("Enter total attribute points: ");
            mainChar.totalPts = Int32.Parse(Console.ReadLine());
            for (int i=0; i<Character.attrCount; i++)
            {
                Console.WriteLine("Enter the name of attribute " + (i + 1) + ": ");
                mainChar.attributes[i] = Console.ReadLine();
            }
            while(mainChar.ptsLeft() != 0)
            {
                for(int i=0; i<Character.attrCount; i++)
                {
                    Console.WriteLine("You have " + mainChar.ptsLeft() + " attribute points left.");
                    Console.WriteLine("Enter the point value of " + mainChar.attributes[i] + ": ");
                    mainChar.values[i] = Int32.Parse(Console.ReadLine());
                }
                if(mainChar.ptsLeft() > 0)
                {
                    Console.WriteLine("You have not utilized all of your points! Enter them again.");
                    mainChar.zeroAttr();
                }
                else if(mainChar.ptsLeft() < 0)
                {
                    Console.WriteLine("You have used more than the total points allowed! Try again.");
                    mainChar.zeroAttr();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Name: " + mainChar.name);
            for (int i=0; i<Character.attrCount; i++)
            {
                Console.WriteLine(mainChar.values[i] + " " + mainChar.attributes[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Total: " + mainChar.totalPts);
        }
    }
}
