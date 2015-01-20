using System;
    class JoroFootballer
    {
        static void Main()
        {
            string leap = Console.ReadLine() ;
            int holidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());

            int totalWeekends = 52;
            int normalWeekends = totalWeekends - hometownWeekends;
            double gamesCount = hometownWeekends * 1d +
                                normalWeekends * 2d / 3d +
                                holidays * 1d / 2d;
            if (leap == "t")
            {
                gamesCount = gamesCount + 3;
            }
            Console.WriteLine((int)gamesCount);
        }
    }

