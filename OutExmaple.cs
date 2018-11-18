using System;

using static System.Console;

namespace C7Examples
{
    public class OutExmaple
    {
        public OutExmaple()
        {
            GetTime(out int hour, out int minute, out int secound);

            WriteLine($"{hour}:{minute}:{secound}");
        }

        public void GetTime(out int hour, out int minute, out int secound)
        {
            var time = DateTime.Now;

            hour = time.Hour;
            minute = time.Minute;
            secound = time.Second;
        }
    }
}
