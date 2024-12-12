

using System;

class Program
{
    static void Main()
    {
        Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // 8-lik sanoq sistemasiga o'tish
        string octalNumber = Convert.ToString(decimalNumber, 8);

        Console.WriteLine($"8-lik sanoq sistemasidagi qiymati: {octalNumber}");
    }
}