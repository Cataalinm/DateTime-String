using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in anything, just don't leave this empty. ");
            string empty = Console.ReadLine();
            if (string.IsNullOrEmpty(empty))
                Console.WriteLine("You only had one job.. don't leave the string empty :(");
            else
                Console.WriteLine("I knew I can count on you not to let this string empty. Well done!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            string firstString = "Marco ", secondString = "POLO";
            Console.WriteLine("I say " + firstString + "you say " + secondString);
            Console.WriteLine("Toghether we say " + string.Concat(firstString, secondString));
            string upperString = firstString.ToUpper();
            string lowerString = secondString.ToLower();
            Console.WriteLine("I said we say " + string.Format("{0}{1}", upperString, lowerString));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(" -----LOTTERY----- ");
            Console.WriteLine("Enter 6 numbers between 1 and 49 with a space between them");
            string lottery = Console.ReadLine();
            string winning = "4 16 29 37 39 44";
            Console.WriteLine("You numbers are : " + lottery);
            Console.WriteLine("You are allowed to change one number, if you wish to.");
            Console.WriteLine("y - Make changes      n - I don't wish to change anything");
            char choice = Convert.ToChar(Console.ReadLine());
            if(choice == 'y')
            {
                Console.WriteLine("Please enter the number you are willing to change: ");
                string oldnumber = Console.ReadLine();
                if (lottery.Contains(oldnumber) == false)
                {
                    Console.WriteLine("The number you entered is not one of your old numbers, no change will be made. ");

                }
                else
                {
                    Console.WriteLine("Please enter the new number: ");
                    string newnumber = Console.ReadLine();
                    lottery = lottery.Replace(oldnumber, newnumber);
                    Console.WriteLine("Your numbers after the change you made are :" + lottery);
                }
            }

            Console.WriteLine("The winning numbers are : " + winning);
            if (string.Compare(lottery, winning) == 0)
            {
                Console.WriteLine("Congratulations! You won the lottery. ");
            }
            else
                Console.WriteLine("We are sorry you didn't win today. Better luck next time!");
            Console.WriteLine("Press any key to close this program...");
            Console.ReadKey();
        }
    }
}
