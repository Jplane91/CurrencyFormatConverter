using System;
using System.Globalization;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in the first dollar amount");
            double amount1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the second dollar amount");
            double amount2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter in the third dollar amount");
            double amount3 = double.Parse(Console.ReadLine());

            double sum = (amount1 + amount2 + amount3);
            double average = (sum / 3);

            Console.WriteLine("\nThe sum of the three totals comes out to {0} ", sum);
            Console.WriteLine("The average of the three totals comes out to {0:##.##} ", average);

            if (amount1 > amount2 && amount1 > amount3)
            {
                Console.WriteLine("\n{0} is the highest amount entered", amount1);
                if (amount2 < amount3)
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount2);
                }

                else
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount3);

                }


            }

            else if (amount2 > amount1 && amount2 > amount1)
            {
                Console.WriteLine("\n{0} is the highest amount entered", amount2);
                if (amount1 < amount3)
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount1);
                }

                else
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount3);

                }



            }

            else 
            {
                Console.WriteLine("\n{0} is the highest amount entered", amount3);
                if (amount1 < amount2)
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount1);
                }

                else
                {
                    Console.WriteLine("{0} is the lowest amount entered", amount2);

                }

            }

            Console.WriteLine("\nThe total in dollars comes out to ${0:##.###}", sum);
            Console.WriteLine("The total in kronas comes out to {0:##.###} kr", sum);
            Console.WriteLine("The total in yen comes out to ¥{0:##}", sum);
            Console.WriteLine("The total in bahts comes out to ฿{0:##.###}", sum);

        }
    }
}
