using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for specific input about specific dates
            Console.WriteLine("This program will give you the number of days between two different dates.");
            Console.WriteLine("Please enter your date in the format MM/DD/YYYY.");
            Console.Write("Please enter your first date: ");

            //turns input into DateTime
            DateTime dateFirst = DateTime.Parse(Console.ReadLine());

            
            Console.Write("Please enter your second date: ");

            //turns input into DateTime
            DateTime dateSecond = DateTime.Parse(Console.ReadLine());

            //Subtracts the second date from the first
            TimeSpan days = dateSecond.Subtract(dateFirst);

            //Allows for absolute number answer 
            TimeSpan duration = days.Duration();
  
            //Prints the total number of days
            Console.WriteLine($"The number of days between these dates is : {duration.TotalDays:N0}");

            Console.ReadLine();

            
        }
    }
}
