using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rannum = new Random();
            int maxno = 100;
            int rng = 0;
            int[] logs = new int[maxno+1];
            do
            {
                rng = rannum.Next(1, maxno+1);
                logs[rng]++;
                Console.WriteLine(rng);
            }
            while (rng < maxno);
            for (int i = 0; i<maxno+1; i++ )
            {
                Console.WriteLine(Convert.ToString(i) + ' ' + Convert.ToString(logs[i]));
            }

        }
    }
}
