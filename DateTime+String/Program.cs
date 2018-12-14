using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorry for not creating a class "Person" for this homework to make it cleaner, I did it kind of on the run. 
//Also I was thinking maybe I should've limited the number of days to 28/30/31(Even go a little further and make february with 29 for leap years) so sorry again. 


namespace DateTime_String
{
    class Program
    {

        public enum Gender
        {
            Female,
            Male
        }
        static void Main(string[] args)
        {

            int year, month, day;
            char gender;
            double age;

            Console.WriteLine("Please enter the day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the gender: ");
            gender = Convert.ToChar(Console.ReadLine());

            DateTime BirthDate = new DateTime(year,month,day);
            TimeSpan difference = DateTime.Now - BirthDate;

            //Here I took  a few days out because of the leap years. It's not perfect because depending on the year of birth it might substract a day less than it should. 
            
            age = difference.Days - difference.Days / 365 / 4;
            age = age/365;    

            Console.WriteLine("The person is " + (int)age + " years old. ");
            Console.WriteLine();

            int? gend = null;
            do
            {
                if(gender != 'F' && gender != 'M')
                {
                    Console.WriteLine("Wrong gender. Please try again.");
                    gender = Convert.ToChar(Console.ReadLine()); gend = (int)Gender.Female;
                }
                if (gender == 'M')
                {
                    gend = (int)Gender.Male;
                    if (age > 65)
                       Console.WriteLine("The male person is retired.");
                    else
                       Console.WriteLine("The male person will retire at 65 years old whic is in: " + (65 - (int)age) + " years. ");
                }
                if(gender == 'F')
                {
                    gend = (int)Gender.Female;
                    if (age > 63)
                       Console.WriteLine("The female person is retired.");
                    else
                       Console.WriteLine("The female person will retire at 63 years old which is in: " + (63 - (int)age) + " years. "); 
                }
            } while (gender != 'F' && gender != 'M');

            Console.WriteLine("Press any key to close this program..."); 
            Console.ReadKey();
        }
    }
}
