using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EulerMain
{
    public class Problem1
    {
        public int execute()
        {
            List<int> multiples = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }
            Console.WriteLine(multiples.Sum());
            return multiples.Sum();
        }
    }
}
