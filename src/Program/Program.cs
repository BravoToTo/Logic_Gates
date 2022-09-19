using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            bool c = true;
            
            Console.WriteLine(GarageGate.Open(a,b,c));
        }
    }
}
