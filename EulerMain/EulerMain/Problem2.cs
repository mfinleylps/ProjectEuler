using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerMain
{
    class Problem2
    {
        public int execute()
        {
            List<int> evenFibs = new List<int>();
            int a = 0, b = 1, c = 0;
            while (c < 4000000) 
            {
                c = a + b;
                Console.WriteLine(c);
                if (c % 2 == 0) 
                {
                    evenFibs.Add(c);
                }
                a = b;
                b = c;
            }
            Console.WriteLine(evenFibs.Sum());
            return evenFibs.Sum();
        }
    }
}
