using System;

namespace hello
{
    class Calc
    {
        public int sum(int Num1, int Num2)
        {
            int result;
            result = Num1 + Num2;
            return result;
        }
        static void Main(string[] args)
        {
            Calc Add = new Calc();
            int value = Add.sum(100,240);
            Console.WriteLine("sum of the number is " +value);
            
        
        }
    }
}