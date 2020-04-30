using System;

namespace hello
{
    class program
    {
        static void Main(string[] args)
        {
         // fibonic series
         Console.WriteLine("Enter the lenght of fibo -");
         int Fibo = Convert.ToInt32(Console.ReadLine());
         int Start = 0;
         int Finish = 1;
         Console.WriteLine("The series of fibo is below -");
         Console.WriteLine(Start);
         Console.WriteLine(Finish);
         int count = 2;

         while(count<Fibo)
         {
             int Result = Start + Finish;
             Start = Finish;
             Finish = Result;
             Console.WriteLine(Result);
             count++;
         }

        }
    }
}