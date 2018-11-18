using static System.Console;

namespace C7Examples
{
    public class PatternExample
    {
        public PatternExample()
        {
            PrintSum(10);
        }

        public void PrintSum(object o)
        {
            if (o is null) return;
            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += 1;
                }

                WriteLine($"Suma : {sum}");
            }

            return;
        }
    }
}
