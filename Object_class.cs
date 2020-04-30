using System;

namespace hello
{
    class Program
    {
        int id;
        string name;
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.id = 101;
            p1.name ="AQUIb shaikh";

            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
          
        }
    }
}