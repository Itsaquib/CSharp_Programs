using System;

namespace hello
{
    class program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter the number you want to reverse:-");
         int num = Convert.ToInt32(Console.ReadLine());
         int rev=0;
         int dummy = num;
         while(num>0)
         {
            int  x = num % 10;
             rev = rev * 10 + x;
             num = num / 10;
         }
         if(rev==dummy)
         {
             Console.WriteLine(dummy + " is palindrome number of this " + rev);
         }
         else
         Console.WriteLine(dummy + " is not a Palindrome number of this " + rev);
        }
    }
}