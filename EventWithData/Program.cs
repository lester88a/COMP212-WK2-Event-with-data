using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventWithData
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int rdd = rd.Next(1, 10);
            //New Counter Object
            Counter c = new Counter(rdd);
            c.ThresholdReached += c_ThresholdReached;
            Console.WriteLine("Press 'a' to increase the total.");
            while (Console.ReadKey(true).KeyChar == 'a' || 
                Console.ReadKey(true).KeyChar == 'b' ||
                Console.ReadKey(true).KeyChar == 'c')
            {
                c.Add(1);
            }
            Console.ReadKey();
        }
        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.",
                e.Threshold, e.TimeReached);
            //Environment.Exit(0);

        }
    }
}
