using System;

namespace Swartwout_PE1
{
    class Program
    {
        //Main Method
        //Author: Maxwell Swartwout
        //Purpose: Playing around with the console
        static void Main(string[] args)
        {
            int jeff = 10;
            string num = "20";
            string input;
            for (int i = 0; i < 10; i++)
            {
                jeff += jeff;
                Console.WriteLine("Maxwell Swartwout " + jeff);
            }
            jeff += Int32.Parse(num);
            Console.WriteLine(jeff);

            Console.WriteLine("Say something: ");
            input = Console.ReadLine();
            Console.WriteLine("You just said: " + input);
        }
    }
}