using System;

namespace Stoljnjak
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, r, O;
            P = double.Parse(Console.ReadLine());
            r = Math.Sqrt(P / Math.PI);
            O = 2 * r * Math.PI;
            Console.WriteLine(Math.Round(O,5));

        }
    }
}
