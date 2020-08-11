using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = '2';
            var fullName = "Dustin Tollett ";
            var today = DateTime.Now;
            Console.WriteLine("Hi, my name is" + " " + fullName + "the time is" + " " + today + " " + "I drink" + " " + numberOfCupsOfCoffee + " " + "cups of coffee per day!");
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Nice to meet you," + " " + userName);
            Console.WriteLine();
            Console.WriteLine("Please input a Number");
            Console.WriteLine();
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Please input another Number");
            Console.WriteLine();
            var secondNumberAsString = Console.ReadLine();
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            var sum = (firstOperand + secondOperand);
            var difference = (firstOperand - secondOperand);
            var product = (firstOperand * secondOperand);
            var quotient = (firstOperand / secondOperand);
            var remainder = (secondOperand % firstOperand);

            Console.WriteLine("When you add" + " " + firstOperand + " " + "with" + " " + secondOperand + " " + "the result is" + " " + sum);
            Console.WriteLine();
            Console.WriteLine("When you subtract" + " " + firstOperand + " " + "from" + " " + secondOperand + " " + "the result is" + " " + difference);
            Console.WriteLine();
            Console.WriteLine("When you multiply" + " " + firstOperand + " " + "by" + " " + secondOperand + " " + "the result is" + " " + product);
            Console.WriteLine();
            Console.WriteLine("When you divide" + " " + firstOperand + " " + "by" + " " + secondOperand + " " + "the result is" + " " + quotient);
            Console.WriteLine();
            Console.WriteLine("The remainder of" + " " + firstOperand + " " + "and" + " " + secondOperand + " " + "is equal to" + " " + remainder);
        }
    }
}
