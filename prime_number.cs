using System;

namespace hello
{
    class program
    {
        static void Main(string[] args)
        {
         // To print all the prime numbers 
         Console.WriteLine("Enter the lenght in between you want to print prime number ");
         int Prime = Convert.ToInt32(Console.ReadLine());
         for(int loop=1;loop<Prime;loop++)
         {
             int Count = 0;
             for(int in_loop=1;in_loop<=loop;in_loop++)
             {
                 
                 if(loop%in_loop==0)
                 {
                     Count++;
                 }
               }
            if(Count==2)
                 {
                     Console.WriteLine(loop);
                 }
         }

        }
    }
}