using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice;
            DogClass dog = new DogClass();


            do // DO - While to keep the program running until the user ends it
            {
                Console.Clear();
                Console.WriteLine("\n***************MENU***************");
                Console.WriteLine("\nA- Display dog's information");
                Console.WriteLine("B- Add a new dog");
                Console.WriteLine("C- Edit an existing dog");
                Console.WriteLine("D- Exit the program");
                Console.WriteLine("\n***************MENU***************");

                Console.WriteLine("\nPlease type the letter corresponding to your choice.");
                menuChoice = Console.ReadLine();

                /*While to error proof the program in case the 
                user types somthing different from a single letter*/
                while (menuChoice.Length > 1 || menuChoice.Length == 0 || char.IsDigit(menuChoice[0]))
                {
                    Console.WriteLine("Please Type A, B, C or D to close the program");
                    menuChoice = Console.ReadLine();
                }

                //Switch to manage the options
                switch (menuChoice)
                {
                    case "A":
                    case "a":
                        dog.DisplayDogInformation();
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "B":
                    case "b":
                        dog.AddNewDog();
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "C":
                    case "c":
                        dog.EditDogInformation();
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "D":
                    case "d":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (menuChoice != "D" && menuChoice != "d");




            Console.ReadKey();
        }
    }
}
