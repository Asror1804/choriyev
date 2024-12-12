

using System;

class Program
{
    static void Main()
    {
        Console.Write("10-lik sanoq sistemasidagi sonni kiriting: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        // 16-lik sanoq sistemasiga o'tish
        string hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper();

        Console.WriteLine($"16-lik sanoq sistemasidagi qiymati: {hexadecimalNumber}");
    }
}