using System;
using System.Globalization;
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter beer time in format h:mm tt :");
            string timeString = Console.ReadLine();
            DateTime time;
            if (DateTime.TryParseExact(timeString, "h:mm tt",CultureInfo.InvariantCulture,DateTimeStyles.None, out time) == true)
            {
               DateTime startTime = DateTime.Parse("1:00 PM");
               DateTime endTime = DateTime.Parse("3:00 AM");
               if ((time>=endTime)&&(time<startTime))
               {
                   Console.WriteLine("{0} is non-beer time.",time);
               }
               else
               {
                   Console.WriteLine("{0} is beer time.",time);
               }
                {

                }
            }
        }
    }

