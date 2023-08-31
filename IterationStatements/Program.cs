using System.Runtime.CompilerServices;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers(int num)
        {
            for (num = 1000; num >= -1000; num--);
            Console.WriteLine(num);
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else 
            {
                Console.WriteLine($"{num1} does not equal {num2}"); 
            }
        }
        //Write a method to check whether a given number is even or odd
        public static string OddEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("This is an even number.");
            }
            else
            {
                Console.WriteLine("This is an odd number.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number is positive!");
            }
            else
            {
                Console.WriteLine("This number is negative.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckAge()
        {
            Console.WriteLine("Please input your current age:");
            var voterAge = int.TryParse(Console.ReadLine(), out int age);
            if (age >= 18)
            {
                Console.WriteLine("Welcome citizen! You are approved to vote!");
            }
            else
            {
                Console.WriteLine("Unfortunately, you have not attained voting age.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            
        }
    }
}
