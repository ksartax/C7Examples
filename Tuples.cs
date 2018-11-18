using System;
using System.Collections.Generic;

namespace C7Examples
{
    public class Tuples
    {
        public Tuples()
        {
            var time = GetTime();
            Console.WriteLine($"{time.Item1}:{time.Item2}:{time.Item3}");
            var (hour, min, sec) = GetTime2();
            var time2 = GetTime2();
            Console.WriteLine($"{hour}:{min}:{sec}");
            Console.WriteLine($"{time2.hour}:{time2.min}:{time2.sec}");

            var dictionary = new Dictionary<(int, int), string>
            {
                { (10, 20), "numer 10 | i numer 20" }
            };
            Console.WriteLine(dictionary[(10, 20)]);
        }

        public (int, int, int) GetTime()
        {
            return (1, 2, 3);
        }

        public (int hour, int min, int sec) GetTime2()
        {
            return (1, 2, 3);
        }
    }
}
