using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
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
                Console.WriteLine("Please type an integer number");
                input = Console.ReadLine();
                result = int.TryParse(input, out number);
            }
            return input;
        }

        //Method for option 1 - even numbers
        static void EvenNumber()
        {
            string stringNumbers;
            int numbers, n, even;
            even = 0;

            Console.WriteLine("How many even numbers do you want?");
            stringNumbers = Console.ReadLine();
            stringNumbers = CheckString(stringNumbers);
            numbers = int.Parse(stringNumbers);
            //While to make sure the user will tipe a number greater than zero 
            while (numbers < 1)
            {
                Console.WriteLine("Please, type a number greater than zero");
                stringNumbers = Console.ReadLine();
                stringNumbers = CheckString(stringNumbers);
                numbers = int.Parse(stringNumbers);
            }
            Console.WriteLine(""); //This line is for esthetic purposes only 
            //"For" loop to print the numbers 
            for (n = 0; n < numbers; n++)
            {
                Console.WriteLine(even);
                even = even + 2;
            }

        }

        //Method for option 2 - Perfect square
        static void PerfectSquare()
        {
            string stringOption;
            int option, square;
            square = 0;
            option = 0;
            while (option != 2)
            {
                square++;
                Console.WriteLine("\n" + Math.Pow(square, 2));
                Console.WriteLine("\nTo continue press 1, to get back to Main Menu press 2");
                stringOption = Console.ReadLine();
                stringOption = CheckString(stringOption);
                option = int.Parse(stringOption);
                while (option < 1 || option > 2)
                {
                    Console.WriteLine("Please enter 1 to continue or 2 to get back to Main menu");
                    stringOption = Console.ReadLine();
                    stringOption = CheckString(stringOption);
                    option = int.Parse(stringOption);
                }

            }

        }

        static void Main(string[] args)
        {
            string stringMenu; //Variables declaration
            int menu;
            menu = 0;
            do //Loop to the menu options
            {
                Console.WriteLine("\nPlease type the number of your choice:");
                Console.WriteLine("\n1-Display even numbers \n2-Display perfect squares \n3-Exit the program\n");
                stringMenu = Console.ReadLine();
                //Call the method to check if the user is entering an integer number
                stringMenu = CheckString(stringMenu);
                menu = int.Parse(stringMenu);
                //While to make sure the user do not enter a number out of the menu range
                while (menu < 1 || menu > 3)
                {
                    Console.WriteLine("\nPlease type a number between 1 and 3");
                    Console.WriteLine("\n1-Display even numbers \n2-Display perfect squares \n3-Exit the program\n");
                    stringMenu = Console.ReadLine();
                    stringMenu = CheckString(stringMenu);
                    menu = int.Parse(stringMenu);
                }
                //Switch to call the proper method
                switch (menu)
                {
                    case 1:
                        EvenNumber();
                        break;
                    case 2:
                        PerfectSquare();
                        break;
                }

            } while (menu != 3);


        }
    }
}
