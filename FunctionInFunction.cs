using System;

namespace C7Examples
{
    public partial class Program
    {
        public class FunctionInFunction
        {
            public FunctionInFunction()
            {
                Console.WriteLine(Run(10));
            }

            public int Run(int count)
            {
                return Sum(count).output;

                (int inout, int output) Sum(int elements) {
                    int _sum = 0;
                    for (int i = 0; i < elements; i++)
                    {
                        _sum += i;
                    }

                    return (elements, _sum);
                }
            }
        }
    }
}
