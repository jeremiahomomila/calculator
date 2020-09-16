using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("WELCOME TO MY FIRST PROJECT");
            Console.WriteLine("\n");
            Console.WriteLine("HAVE FUN CALCULATING!!");
            Console.WriteLine("------------------------\n");

            bool endApp = false;

            Console.WriteLine("Simple Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;


                Console.Write("Enter a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not a invalid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }


                Console.Write("Enter another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }




                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine($"Your result: {result:N2}\n");
                }


                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }


                Console.WriteLine("------------------------\n");


                Console.Write("Press 'q' and Enter to quit the program, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
