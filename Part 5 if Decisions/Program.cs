using System;

namespace Part_5_if_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            Console.WriteLine("Please make a selection for which program you would like");
            Console.WriteLine("Enter 1 for Stages");
            Console.WriteLine("Enter 2 for Hurricane");
            Console.WriteLine("Enter 3 for Dice Game");
            while (!Int32.TryParse(Console.ReadLine(), out selection))
                Console.WriteLine("Please enter a valid input");
            {
                if (selection == 1)
                    Stages();
                else if (selection == 2)
                    Hurricane();
                else if (selection == 3)
                    DiceGame();
            }


           

        }
        public static void Stages()
        {
            Console.WriteLine("Please enter a age");
            int age;
            while (!Int32.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Invalid input try again");
     
            if (age > 18)
                Console.WriteLine("Adult");

            else if (age <= 18 && age > 12)
                Console.WriteLine("Teen");

            else if (age <= 12 && age > 10)
                Console.WriteLine("Preteen");

            else if (age <= 10 && age > 5)
                Console.WriteLine("Child");

            else if (age <= 5 && age >= 0)
                Console.WriteLine("Toddler");

        
        }
        public static void Hurricane()
        {
            Console.WriteLine("Please enter a hurricane catagory level (1-5) to get it's speed");
            int category;
            while (!Int32.TryParse(Console.ReadLine(), out category))
                Console.WriteLine("Invalid input try again");
            switch (category)
            {
                case 1:
                    Console.WriteLine("That is from 74-95mph, 64-82kt or 119-153km/hr");
                    break;
                case 2:
                    Console.WriteLine("That is from 96-110mph, 83-95kt or 154-177km/hr");
                    break;
                case 3:
                    Console.WriteLine("That is from 111-130mph, 96-113kt or 178-209km/hr");
                    break;
                case 4:
                    Console.WriteLine("That is from 131-155mph, 114-135kt or 210-249km/hr");
                    break;
                case 5:
                    Console.WriteLine("That is greater 155mph, 135kt or 249km/hr");
                    break;
            }
        }
        public static void DiceGame()
        {
            Random generator = new Random();
            double money = 100;
            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);
            Console.WriteLine("Dice Game");
            Console.Write("Choices");
            Console.WriteLine("                    Returns");
            Console.WriteLine("For doubles pick 1           3x");
            Console.WriteLine("For not doubles pick 2       2.5x");
            Console.WriteLine("For even pick 3              2x");
            Console.WriteLine("For odd pick 4               2x");
            Console.WriteLine($"You currently have {money} dollars left");
            Console.WriteLine("please enter the amount you want to bet");
            int bet;
            while (!Int32.TryParse(Console.ReadLine(), out bet))
                Console.WriteLine("Invalid input try again ");
            Console.WriteLine("Now please enter what bet you would like to make");
            int pbet;
            while (!Int32.TryParse(Console.ReadLine(), out pbet))
                Console.WriteLine("Invalid input try again");
            Console.Write($"the first dice is {dice1}");
            Console.WriteLine($" the second dice is {dice2}");
            if (dice1 == dice2 && pbet == 1)
            {
                Console.WriteLine($"Congratulations you got doubles you now have {money + bet * 2} dollars");
            }
            else if (dice1 != dice2 && pbet == 1)
            {
                Console.WriteLine($"You did not get doubles you now have {money - bet} dollars");
            }
            else if (dice1 != dice2 && pbet == 2)
            {
                Console.WriteLine($"Congratulations you got not doubles you now ou have { money + bet * 1.5} dollars");
            }
            else if (dice1 == dice2 && pbet == 2)
            {
                Console.WriteLine($"You did not get not doubles you now have{money - bet} dollars");
            }
            else if (pbet == 3d && (dice1 + dice2 == 2 || dice1 + dice2 == 4 || dice1 + dice2 == 6 || dice1 + dice2 == 8 || dice1 + dice2 == 10 || dice1 + dice2 == 12))
            {
                Console.WriteLine($"Congratulations you got odd you now ou have { money + bet} dollars");
            }
            else if (pbet == 3 && (dice1 + dice2 != 2 || dice1 + dice2 != 4 || dice1 + dice2 != 6 || dice1 + dice2 != 8 || dice1 + dice2 != 10 || dice1 + dice2 != 12))
            {
                Console.WriteLine($"You did not get even sum you now have { money - bet} dollars");
            }
            else if (pbet == 4 && (dice1 + dice2 == 3 || dice1 + dice2 == 5 || dice1 + dice2 == 7 || dice1 + dice2 == 9 || dice1 + dice2 == 11))
            {
                Console.WriteLine($"Congratulations you got odd you now ou have {money + bet} dollars now");
            }
            else if (pbet == 4 && (dice1 + dice2 != 3 || dice1 + dice2 != 5 || dice1 + dice2 != 7 || dice1 + dice2 != 9 || dice1 + dice2 != 11))
            {
                Console.WriteLine($"You did not get odd sum you now have { money - bet} dollars");
            }
        }
    }
}
