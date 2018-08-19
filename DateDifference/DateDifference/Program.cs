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
            string date1 = Console.ReadLine();
            DateTime dateFirst = DateTime.Parse(date1);

            
            Console.Write("Please enter your second date: ");

            //turns input into DateTime
            string date2 = Console.ReadLine();
            DateTime dateSecond = DateTime.Parse(date2);

            //Subtracts the second date from the first
            TimeSpan days = dateSecond.Subtract(dateFirst);

            //Allows for absolute number answer 
            TimeSpan duration = days.Duration();

            //this is when I tried to add in a comma and it didn't work.
            //string total = duration.TotalDays.ToString();
            //string totals = string.Format("{0:N}", total);
  
            //Prints the total number of days
            Console.WriteLine($"The number of days between these dates is : {duration.TotalDays}");

            Console.ReadLine();

            
        }
    }
}
