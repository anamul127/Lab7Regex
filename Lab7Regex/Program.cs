using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome! I will validate different kinds of input.\n");
            string FullName = Console.ReadLine();

            while (true)
            {
                Console.Write("\nPlease enter your name: ");
                FullName = Console.ReadLine();

                bool isName = IsFullName(FullName);
                if (isName)
                {
                    Console.WriteLine("You have entered a valid name!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid name, please try again!");
                } 
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write(FullName + ", please enter your email! ");
                string Email = Console.ReadLine();

                bool getEmail = IsEmail(Email);
                if (getEmail)
                {
                    Console.WriteLine("You have entered a valid email!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid email, please try again!");
                } 
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write(FullName + ", please enter your phone number in the following format: xxx-xxx-xxxx. ");
                string PhoneNumber = Console.ReadLine();

                bool getPhoneNumber = IsPhoneNumber(PhoneNumber);
                if (getPhoneNumber)
                {
                    Console.WriteLine("You have entered a valid phone number!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid phone number, please try again!");
                }

            }
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(FullName + " , please enter a date in the following format: dd/mm/yyyy. ");
                string Date = Console.ReadLine();

                bool GetDate = IsDate(Date);
                if (GetDate)
                {
                    Console.WriteLine("You have entered a date!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date, please try again!");
                }
            }
            while (true)
            {
                Console.Write("Do you want to try another integer [Y/N]?");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                    break; // Exit the inner while-loop and continue in the outer while loop.
                if (answer == "N")
                    return; 
            }
        }
        static bool IsFullName (string Name)
        {
            return Regex.IsMatch(Name, "[A-Z]{1}[a-z]{1,30}");
        }
        static bool IsEmail(string Email1)
        {
            return Regex.IsMatch(Email1, (@"[\w\.]{1,}@\w{1,}.\w{2,}"));
        }
        static bool IsPhoneNumber(string PhoneNumber1)
        {
            return Regex.IsMatch(PhoneNumber1, (@"\d{3}\-\d{3}\-\d{4}"));
        }
        static bool IsDate(string Date1)
        {
            return Regex.IsMatch(Date1, (@"\d{2}\/\d{2}\/\d{4}"));
        }

    }
}
