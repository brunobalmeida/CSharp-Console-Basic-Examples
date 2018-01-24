using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClass
{
    class DogClass
    {
        private string name, breed, colour, gender;
        public DogClass() //Default constructor
        {
        }

        //Non-default constructor 
        public DogClass(string dogName, string dogBreed, string dogColour, string dogGender)
        {
            name = dogName;
            breed = dogBreed;
            colour = dogColour;
            gender = dogGender;
        }

        //Method to Display dog information. 
        public void DisplayDogInformation()
        {
            //If-Else to check if there is information already stored 
            if (name == null && breed == null && colour == null && gender == null)
            {
                Console.WriteLine("\nThere is no dog information stored, please add one.");
                return;
            }
            else //If not, then it will print the informations about the dog
            {
                Console.WriteLine("\n ***************Dog Information***************");
                Console.WriteLine("Name: {0}\nBreed: {1}\nColour: {2}\nGender: {3}", name, colour, breed, gender);
                Console.WriteLine("***************Dog Information***************");
            }

        }

        // Method to Add a new dog
        public void AddNewDog()
        {
            if (name == null && breed == null && colour == null && gender == null)
            {
                Console.WriteLine("\nWhat is the Dog's name?");
                name = Console.ReadLine();
                Console.WriteLine("\nWhat is the Dog's breed?");
                breed = Console.ReadLine();
                Console.WriteLine("\nWhat is the Dog's colour?");
                colour = Console.ReadLine();
                Console.WriteLine("\nWhat is the Dog's gender - MALE or FEMALE?");
                gender = Console.ReadLine();
                while (gender != "MALE" && gender != "FEMALE")
                {
                    Console.WriteLine("\nPlease type MALE or FEMALE for gender");
                    gender = Console.ReadLine();
                }

            }
            else //else to say if a dog record already exists
            {
                Console.WriteLine("\n ***************ERROR***************");
                Console.WriteLine("\nDog record already exists");
                Console.WriteLine("\n ***************ERROR***************");
            }


        }

        //Method to Edit the dog information
        public void EditDogInformation()
        {
            string menuChoice;

            //If there is no dog, the program will tell the user 
            if (name == null && breed == null && colour == null && gender == null)
            {
                Console.WriteLine("\nThere is no dog information stored, please add one.");
                return;
            }
            else
            {
                do
                {
                    DisplayDogInformation();
                    Console.WriteLine("\nWhat information do you want to edit?");
                    Console.WriteLine("A-Name \nB- Breed \nC-Color \nD-Gender\nOr Press E to return to menu");
                    menuChoice = Console.ReadLine();

                    /*While to error proof the program in case the 
                    user types somthing different from a single letter*/
                    while (menuChoice.Length > 1 || char.IsDigit(menuChoice[0]))
                    {
                        Console.WriteLine("Please Type A, B, C, D or E");
                        menuChoice = Console.ReadLine();
                    }
                    switch (menuChoice) //Switch to manage the options 
                    {
                        case "A":
                        case "a":
                            Console.WriteLine("Please type the new Dog's name");
                            name = Console.ReadLine();
                            break;

                        case "B":
                        case "b":
                            Console.WriteLine("Please type the new Dog's breed");
                            breed = Console.ReadLine();
                            break;

                        case "C":
                        case "c":
                            Console.WriteLine("Please type the new Dog's colour");
                            colour = Console.ReadLine();
                            break;

                        case "D":
                        case "d":
                            Console.WriteLine("Please type the new Dog's gender [MALE or FEMALE]");
                            gender = Console.ReadLine();
                            while (gender != "MALE" && gender != "FEMALE")
                            {
                                Console.WriteLine("\nPlease type MALE or FEMALE for gender");
                                gender = Console.ReadLine();
                            }
                            break;

                        case "E":
                        case "e":
                            return;
                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }

                } while (menuChoice != "E" && menuChoice != "e");
            }


        }
    }
}
