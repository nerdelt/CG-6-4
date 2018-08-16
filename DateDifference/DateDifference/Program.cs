using System;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will give you the number of days between two different dates.");
            Console.WriteLine("Please enter your date in the form MM/DD/YYYY");
            Console.Write("Please enter your first date: ");

            string date1 = Console.ReadLine();
            DateTime dateFirst = DateTime.Parse(date1);

            
            Console.Write("Please enter your second date: ");

            string date2 = Console.ReadLine();
            DateTime dateSecond = DateTime.Parse(date2);

            TimeSpan days = dateSecond.Subtract(dateFirst);
            TimeSpan duration = days.Duration();
  

            Console.WriteLine($"The number of days between these dates is : {duration.TotalDays}");

            Console.ReadLine();

            
        }
    }
}
