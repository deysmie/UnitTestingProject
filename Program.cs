using System;

namespace UnitTestingProject
{
    public class Program
    {
        public static (int sumEven, int sumOdd) CheckOddEvenNumbers(int start, int end)
        {
            int even = 0;
            int odd = 0;
            for (int i = start; i <= end; i++)
            {
                
                if (i.isEven())
                {
                    even += i;
                }
                else
                {
                    odd += i;
                }
            }
            return (even, odd);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input Start Number");
            int startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Input End Number");
            int endNumber = int.Parse(Console.ReadLine());
            var output = CheckOddEvenNumbers(startNumber, endNumber);
            Console.WriteLine(output);
        }

        
    }
}
