using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    internal class SI
    {
        internal void CalSI()
        {
            float p=12000, r=2.2F, t=4.5F, si= (p*r*t)/100;
            Console.WriteLine(si);
        }
    }
}
