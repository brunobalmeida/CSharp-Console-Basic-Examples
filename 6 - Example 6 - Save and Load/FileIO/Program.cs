using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
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


        //Method to read the reservation file and write it on the console
        static void ShowReservation(string[,] tableArray)
        {
            int index;
            index = 1;
            for (int i = 0; i < tableArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < tableArray.GetLength(1); j++)
                {
                    Console.Write("{0}-{1} | ", index, tableArray[i, j]);
                    index++;
                }
            }
        }

        //Method to write on the reservation file 
        static void WriteReservation(string[,] writeArray)
        {
            StreamWriter writer;
            writer = new StreamWriter("reservation.txt");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    writer.WriteLine(writeArray[i, j]);
                }
            }
            writer.Close();
        }

        //Method to check if there is available seats
        static bool CheckAvailability(string[,] availableSeats)
        {
            bool seatBool;
            seatBool = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (availableSeats[i, j] == "Open")
                    {
                        seatBool = true;
                    }
                }
            }

            return seatBool;
        }

        //Main program
        static void Main(string[] args)
        {
            string optionString, tableString, nameString;
            string[,] seatArray;
            seatArray = new string[5, 5];
            int i, j, option, tableNumber, number, counter;
            bool result;
            option = 0;
            counter = 0;
            i = 0;
            j = 0;

            //Try-Catch to check if there is a file or not
            //In case of not, it will create a file
            try
            {
                StreamReader reader;
                reader = new StreamReader("reservation.txt");
                while (reader.EndOfStream == false)
                {
                    for (i = 0; i < 5; i++)
                    {
                        for (j = 0; j < 5; j++)
                        {
                            seatArray[i, j] = reader.ReadLine();
                        }
                    }
                }
                reader.Close();
                Console.Clear();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file has not been found, do you want to create a new one? Yes or No?");
                optionString = Console.ReadLine();
                if (optionString == "Yes" || optionString == "yes")
                {
                    StreamWriter writer;
                    writer = new StreamWriter("reservation.txt");

                    for (i = 0; i < 5; i++)
                    {
                        for (j = 0; j < 5; j++)
                        {
                            seatArray[i, j] = "Open";
                            writer.WriteLine(seatArray[i, j]);
                        }
                    }
                    writer.Close();
                }
                else
                {
                    Console.WriteLine("\n*********************************");
                    Console.WriteLine("\nSorry, but the program will be closed, try to create a new file.");
                    Console.WriteLine("\n*********************************");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            do //Do-While to keep the program running until the user asks to finish it
            {
                Console.WriteLine("\nPlease choose one of the options below:");
                Console.WriteLine("\n1 - Add a reservation;");
                Console.WriteLine("\n2 - Remove a reservation;");
                Console.WriteLine("\n3 - Close the program;\n");
                optionString = Console.ReadLine();
                optionString = CheckString(optionString);
                option = int.Parse(optionString);
                if (option < 1 || option > 3) //Userproof IF to assure the user will type a number between 1 and 3
                {
                    while (option < 1 || option > 3)
                    {
                        Console.WriteLine("\nPlease type a number between 1 and 3 for the menu.\n");
                        optionString = Console.ReadLine();
                        optionString = CheckString(optionString);
                        option = int.Parse(optionString);
                    }
                }

                if (option == 1) //Main IF to option 1 - add a reservation
                {
                    Console.Clear();
                    if (CheckAvailability(seatArray) == false) //Call the method to check seat availability 
                    {
                        Console.WriteLine("\n****************************************");
                        Console.WriteLine("\nSorry there is no seat available.");
                        Console.WriteLine("\n****************************************");
                    }
                    else //If available will ask for customers name and what table s/he wants
                    {
                        Console.WriteLine("\nWhat is your name?");
                        nameString = Console.ReadLine();
                        while (nameString.Length < 3)
                        {
                            Console.WriteLine("\nPlease type a name with more than 2 characters:");
                            nameString = Console.ReadLine();
                        }

                        ShowReservation(seatArray);
                        Console.WriteLine("\n\nWhich table do you want to?");
                        tableString = Console.ReadLine();
                        tableString = CheckString(tableString);
                        tableNumber = int.Parse(tableString);
                        while (tableNumber < 1 || tableNumber > 25)
                        {
                            Console.WriteLine("\nPlease type a table number between 1 and 25");
                            tableString = Console.ReadLine();
                            tableString = CheckString(tableString);
                            tableNumber = int.Parse(tableString);

                        }
                        i = (tableNumber - 1) / 5;
                        j = (tableNumber - 1) % 5;


                        if (seatArray[i, j] != "Open") //If to check if the specific seat is available or not
                        {
                            Console.Clear();
                            Console.WriteLine("\n****************************************");
                            Console.WriteLine("\n*****This seat is already reserved.*****");
                            Console.WriteLine("\n****************************************");
                        }
                        else
                        {
                            seatArray[i, j] = nameString;
                            Console.Clear();
                            ShowReservation(seatArray);
                            WriteReservation(seatArray);
                        }
                    }
                }
                else if (option == 2) //Main IF to option 2 - Remove a reservation
                {
                    Console.Clear();
                    ShowReservation(seatArray);
                    Console.WriteLine("\n\nPlease type the seat number or customers name:");
                    nameString = Console.ReadLine();
                    result = int.TryParse(nameString, out number); //Checking if user typed a name or a number
                    if (result == true)//Means that the user has typed a number
                    {
                        tableNumber = int.Parse(nameString);
                        while (tableNumber < 1 || tableNumber > 25)
                        {
                            Console.WriteLine("\nPlease type a table number between 1 and 25");
                            nameString = Console.ReadLine();
                            nameString = CheckString(nameString);
                            tableNumber = int.Parse(nameString);
                        }
                        i = (tableNumber - 1) / 5;
                        j = (tableNumber - 1) % 5;
                        seatArray[i, j] = "Open";
                        WriteReservation(seatArray);
                        ShowReservation(seatArray);
                    }
                    else
                    {
                        for (i = 0; i < 5; i++)
                        {
                            for (j = 0; j < 5; j++)
                            {
                                if (seatArray[i, j] == nameString)
                                {
                                    seatArray[i, j] = "Open";
                                    counter++;
                                }
                            }
                        }
                        if (counter == 0)
                        {
                            Console.WriteLine("****************[ERROR]****************");
                            Console.WriteLine("There is no reservation with this name.");
                            Console.WriteLine("****************[ERROR]****************");
                        }
                        WriteReservation(seatArray);
                        ShowReservation(seatArray);
                        counter = 0;
                    }

                }



            } while (option != 3); //Close the program


        }
    }
}

