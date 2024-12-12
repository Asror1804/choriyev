
            using System;

class Program
        {
            static void Main()
            {
                Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                // 2-lik sanoq sistemasiga o'tish
                string binaryNumber = Convert.ToString(decimalNumber, 2);

                Console.WriteLine($"2-lik sanoq sistemasidagi qiymati: {binaryNumber}");
            }
        }



