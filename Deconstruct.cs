using System;

namespace C7Examples
{
    public class Deconstruct
    {
        public Deconstruct()
        {
            Run();
        }

        private void Run()
        {
            int hour;
            int min;
            int sec;

            (hour, min, sec) = GetTime();
            Console.WriteLine($"{hour}:{min}:{sec}");

            (int a, int b, int c) = GetTime();
            Console.WriteLine($"{a}:{b}:{c}");
        }

        private (int, int, int) GetTime()
        {
            return (1, 2, 3);
        }
    }
}
