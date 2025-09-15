using System;

namespace basic_calculator
{
    class Program
    {
        static double memory = 0;

        static double BasicOperations(double first_number, string operation, double second_number)
        {
            if (operation == "+")
            {
                return first_number + second_number;
            }
            else if (operation == "-")
            {
                return first_number - second_number;
            }
            else if (operation == "*")
            {
                return first_number * second_number;
            }
            else if (operation == "/" & second_number != 0)
            {
                return first_number / second_number;
            }
            else if (operation == "%")
            {
                return first_number % second_number;
            }
            else
            {
                Console.WriteLine("Incorrect operation");
                return 0;
            }
        }

        static double OtherOperations(double first_number, string operation)
        {
            if (operation == "/x")
            {
                return 1 / first_number;
            }
            else if (operation == "**")
            {
                return first_number * first_number;
            }
            else if (operation == "sr")
            {
                return Math.Sqrt(first_number);
            }
            else if (operation == "m+")
            {
                memory += first_number;
                return memory;
            }
            else if (operation == "m-")
            {
                memory -= first_number;
                return memory;
            }
            else
            {
                memory = first_number;
                return memory;
            }
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("memory = " + memory);
                Console.WriteLine("write a number");
                double first_number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("write an operation");
                string operation = Console.ReadLine();
                
                if (((operation == "/x" || operation == "**" || operation == "m+" || operation == "m-" || operation == "mr") & first_number != 0) || (operation == "sr" & first_number > 0))
                {
                    Console.WriteLine(OtherOperations(first_number, operation));
                }
                
                else if (operation == "+" || operation == "-" || operation == "*" || operation ==  "/" || operation == "%")
                {
                    Console.WriteLine("write a number");
                    double second_number = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(BasicOperations(first_number, operation, second_number));
                }
                
                else
                {
                    Console.WriteLine("Incorrect operation");
                }
            }
        }
    }
}
