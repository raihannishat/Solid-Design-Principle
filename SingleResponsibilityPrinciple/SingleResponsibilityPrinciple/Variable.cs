using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingleResponsibilityPrinciple
{
    public class Variable
    {
        public int count = 0;
        public List<string> cows { get; set; }
        public List<string> goats { get; set; }
        
        public void Example1()
        {
            count = cows.Count;
            Console.WriteLine($"Total Cows {count}");

            count = goats.Count;
            Console.WriteLine($"Total Gots {count}");
        }

        public void Example2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
