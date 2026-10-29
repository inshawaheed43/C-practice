using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    internal class Operation
    {
        int a=10, b=20, c;

        //internal jeyword is being used for accessing internal or public classes
        //by using this keyword we can access the members of the class in which it is being used
        internal void Add()

        {
            c = a + b;
            Console.WriteLine(c);

        }
      internal  void Sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }
      internal  void Multi()

        {
            c = a * b;
            Console.WriteLine(c);

        }
      internal  void Div()
        {
            c = a / b;
            Console.WriteLine(c);
        }

    }
}
