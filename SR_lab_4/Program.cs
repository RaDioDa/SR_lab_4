using System;

namespace SR_lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fail1 = 2;
            int fail2 = 86;
            int work = 3*3600;

            int m = (fail1 + fail2)/2;

            double tt = 0;
            int t = 0;

            for(int i = 0; t < work; i++)
            {
                t = (i*(i+1)/2) * m;
                tt += t;
            }
            Console.WriteLine(tt/3600);
        }
    }
}
