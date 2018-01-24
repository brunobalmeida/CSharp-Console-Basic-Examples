using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2BrunoPennaBarbosaDeAlmeidaP1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variable declaration
            string student, age, monthString;
            int studentSelect, studentAge, month, regFee, intFee;
            double tuition, HST;
            //Checking if the student is international or Canadian
            Console.WriteLine("\nAre you a Canadian citizen or an International Student?");
            Console.WriteLine("\nPress:");
            Console.WriteLine("\n1 - Canadian Citizen");
            Console.WriteLine("\n2 - International Student\n");
            student = Console.ReadLine();
            studentSelect = int.Parse(student);
            //Code to make sure the user will type 1 or 2; 
            while (studentSelect < 1 || studentSelect > 2)
            {
                Console.WriteLine("\nPlease press 1 or 2\n");
                student = Console.ReadLine();
                studentSelect = int.Parse(student);
            }
            //Checking the student age
            Console.WriteLine("\nHow old are you?\n");
            age = Console.ReadLine();
            studentAge = int.Parse(age);
            //Checking the registered month
            Console.WriteLine("\n In which month have you been registered?\n");
            Console.WriteLine("\n1-January \n2- February \n3- March \n4- April \n5- May \n6- June");
            Console.WriteLine("7- July \n8- August \n9- September \n10- October \n11- November \n12- December");
            monthString = Console.ReadLine();
            month = int.Parse(monthString);
            //Code to make sure the user will type a number between 1 and 12; 
            while (month < 1 || month > 12)
            {
                Console.WriteLine("\nPlease press a number between 1 and 12\n");
                monthString = Console.ReadLine();
                month = int.Parse(monthString);
            }

            regFee = 0;
            intFee = 0;
            tuition = 0;        //Making sure the variables are set to zero 
            //Setting up the logic to calculate the tuition based on the age 
            if (studentAge <= 18)
            {
                tuition = 300;
            }
            else if (studentAge <= 49 && studentAge >= 19)
            {
                tuition = 500;
            }
            else if (studentAge >= 50)
            {
                tuition = 400;
            }

            Console.WriteLine("\nThe Student's age is: " + studentAge);
            if (studentSelect == 1)
            {
                Console.WriteLine("The student is Canadian.");
            }
            else
            {
                Console.WriteLine("The student is an International Student.");
                intFee = 100;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    regFee = 220;
                    Console.WriteLine("Registration semester: Winter");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    regFee = 150;
                    Console.WriteLine("Registration semester: Summer");
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    regFee = 250;
                    Console.WriteLine("Registration semester: Fall"); ;
                    break;
            }

            Console.WriteLine("\nBase Tuition: " + tuition);

            if (studentSelect == 2)
            {
                Console.WriteLine("International student fee: " + intFee);
            }
            else
            {
                intFee = 0;
            }

            Console.WriteLine("Registration fee for semester: " + regFee);

            HST = (tuition + regFee + intFee) * 0.13;
            Console.WriteLine("The HST is: " + HST);

            tuition = tuition + HST + intFee + regFee;
            Console.WriteLine("\nThe Final total is: " + tuition);

            Console.ReadLine();

        }
    }
}