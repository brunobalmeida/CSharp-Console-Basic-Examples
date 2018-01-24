using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2BrunoPennaBDeAlmeidaP2
{
    class Program
    {
        //Class variables and constant declaration
        public const double PI = 3.14159;
        static double volume;

        //Overload methods to calculate the volumes 
        static void CalculateVolume(double radius)
        {
            volume = 4 * PI * (radius * radius * radius) / 3;
            Console.WriteLine("\nThe sphere volume is " + volume);

        }
        static void CalculateVolume(double radius, double height)
        {
            volume = PI * (radius * radius) * height;
            Console.WriteLine("\nThe Cylinder volume is " + volume);

        }
        static void CalculateVolume(double lenght, double width, double height)
        {
            volume = lenght * width * height;
            Console.WriteLine("\nThe prism volume is " + volume);

        }
        //Main program, which asks user to choose among three different shapes
        static void Main(string[] args)
        {
            string stringType, stringRadius, stringHeight, stringWidth, stringLength;
            int type;
            string choice = "";
            double radius, height, width, length;
            type = 0;
            radius = 0;
            height = 0;
            width = 0;
            length = 0;


            do
            {
                Console.WriteLine("\nWhat type of shape do you want to calculate the volume?");
                Console.WriteLine("\n1- Sphere");
                Console.WriteLine("2- Cylinder");
                Console.WriteLine("3- Rectangular prism");
                stringType = Console.ReadLine();
                type = int.Parse(stringType);

                switch (type)
                {
                    case 1:
                        Console.WriteLine("\n What is the Sphere radius?");
                        stringRadius = Console.ReadLine();
                        radius = double.Parse(stringRadius);
                        CalculateVolume(radius);
                        break;

                    case 2:
                        Console.WriteLine("\n What is the cylinder radius?");
                        stringRadius = Console.ReadLine();
                        radius = double.Parse(stringRadius);
                        Console.WriteLine("\n What is the cylinder height?");
                        stringHeight = Console.ReadLine();
                        height = double.Parse(stringHeight);
                        CalculateVolume(radius, height);
                        break;

                    case 3:
                        Console.WriteLine("\n What is the prism length?");
                        stringLength = Console.ReadLine();
                        length = double.Parse(stringLength);
                        Console.WriteLine("\n What is the prism width?");
                        stringWidth = Console.ReadLine();
                        width = double.Parse(stringWidth);
                        Console.WriteLine("\n What is the prism height?");
                        stringHeight = Console.ReadLine();
                        height = double.Parse(stringHeight);
                        CalculateVolume(length, width, height);
                        break;
                }

                Console.WriteLine("\nDo you want to do another calculation? y/n");
                choice = Console.ReadLine();
                if (choice!="y" && choice !="n")
                {
                    Console.WriteLine("This is not a valid option, the program will be closed");
                    choice = "n";
                    Console.ReadLine();
                }

            } while (choice == "y");
            
        }

    }
}
