using System;

namespace Part_5_if_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stages
            Console.WriteLine("Please enter a age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
                Console.WriteLine("Adult");

            else if (age <= 18 && age > 12)
                Console.WriteLine("Teen");

            else if (age <= 12 && age > 10)
                Console.WriteLine("Preteen");

            else if (age <= 10 && age > 5)
                Console.WriteLine("Child");

            else if (age <= 5)
                Console.WriteLine("Toddler");
        }
    }
}
