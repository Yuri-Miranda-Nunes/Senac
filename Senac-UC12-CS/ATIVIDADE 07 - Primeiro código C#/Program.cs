using System;

namespace Aprendendo

{   
    class Program
    {
            static void Main(string[] args)
        {
            int x = 10;
            decimal d = 1.33m;
            double d2 = 1.44;
            float f = 1.55f;

            string s = " Conhecendo c# ";

            s = s + " uma Linguagem de Programação";

            int y = x + 5;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}