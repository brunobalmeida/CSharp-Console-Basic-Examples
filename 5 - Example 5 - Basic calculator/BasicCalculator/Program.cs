using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        //Method to check if the user is entering an integer number
        public static string CheckString(string input)
        {
            bool result;
            int number;
            result = int.TryParse(input, out number);
            while (!result)
            {
                Console.WriteLine("****ERROR**** Please type an integer number");
                input = Console.ReadLine();
                result = int.TryParse(input, out number);
            }
            return input;
        }
        //Method to check if the user is entering an double number
        public static string CheckStringDouble(string input)
        {
            bool result;
            double number;
            result = double.TryParse(input, out number);
            while (!result)
            {
                Console.WriteLine("****ERROR**** Please type a number");
                input = Console.ReadLine();
                result = double.TryParse(input, out number);
            }
            return input;
        }
        //Method to add two numbers
        public static double AddNumbers(double a, double b)
        {
            double result;
            result = a + b;
            return result;
        }
        //Method to Subtract two numbers
        public static double SubNumbers(double a, double b)
        {
            double result;
            result = a - b;
            return result;
        }
        //Method to multiply two numbers
        public static double MultNumbers(double a, double b)
        {
            double result;
            result = a * b;
            return result;
        }
        //Method to divide two numbers
        public static double DivNumbers(double a, double b)
        {
            double result;
            result = a / b;
            return result;
        }

        //Start the Main 
        static void Main(string[] args)
        {
            //Variables declaration
            string num1String, num2String, selectorString, finish;
            int selector;
            double num1, num2, result;
            selector = 0;
            result = 0;
            finish = "y";

            Console.WriteLine("\nReminder: This calculator works in RPN (Reverse Polish Notation)");

            Console.WriteLine("\nPlease insert the first number:");
            num1String = Console.ReadLine();
            num1String = CheckStringDouble(num1String);
            num1 = double.Parse(num1String);

            //Do-While to keep the program running until the user finish it

            Console.WriteLine("\nPlease insert the second number:");
            num2String = Console.ReadLine();
            num2String = CheckStringDouble(num2String);
            num2 = double.Parse(num2String);

            Console.WriteLine("\nPress: \n1 To Add \n2 To Subtract \n3 To Multiply \n4 To Divide");
            selectorString = Console.ReadLine();
            selectorString = CheckString(selectorString);
            selector = int.Parse(selectorString);

            //While to make sure the user is entenring a number between 1 and 5
            while (selector < 1 || selector > 4)
            {
                Console.WriteLine("Please, enter a number between 1 and 4");
                selectorString = Console.ReadLine();
                selectorString = CheckString(selectorString);
                selector = int.Parse(selectorString);
            }
            do
            {
                switch (selector)
                {
                    case 1:
                        result = AddNumbers(num1, num2);
                        num1 = result;
                        break;
                    case 2:
                        result = SubNumbers(num1, num2);
                        num1 = result;
                        break;
                    case 3:
                        result = MultNumbers(num1, num2);
                        num1 = result;
                        break;
                    case 4:
                        if (num2 == 0) //If the user tries to divide per 0, the program shows an error message
                        {
                            Console.WriteLine("******************ERROR******************\n");
                            Console.WriteLine("A number cannot be divided by zero");
                            Console.WriteLine("      The program will close      ");
                            Console.WriteLine("             Try again            ");
                            Console.WriteLine("\n******************ERROR******************");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        else
                        {
                            result = DivNumbers(num1, num2);
                            num1 = result;
                        }
                        break;
                }
                Console.WriteLine("\nThe result is " + result);
                Console.WriteLine("\nType Y to continue or any key to finish the program.");
                finish = Console.ReadLine();

                if (finish == "y" || finish == "Y")
                {
                    Console.WriteLine("\nPlease insert the next number:");
                    num2String = Console.ReadLine();
                    num2String = CheckStringDouble(num2String);
                    num2 = double.Parse(num2String);

                    Console.WriteLine("\nPress: \n1 To Add \n2 To Subtract \n3 To Multiply \n4 To Divide");
                    selectorString = Console.ReadLine();
                    selectorString = CheckString(selectorString);
                    selector = int.Parse(selectorString);

                    //While to make sure the user is entenring a number between 1 and 5
                    while (selector < 1 || selector > 4)
                    {
                        Console.WriteLine("Please, enter a number between 1 and 4");
                        selectorString = Console.ReadLine();
                        selectorString = CheckString(selectorString);
                        selector = int.Parse(selectorString);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }

            } while (finish == "y" || finish == "Y");

        }
    }
}
