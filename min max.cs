using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter the size of the sorting :-");
          int size =Convert.ToInt32(Console.ReadLine());

          int[] arr = new int[size];
          Console.WriteLine("Enter the numbers :-");
          for(int i=0;i<size;i++)
          {
              arr[i] = Convert.ToInt32(Console.ReadLine());
          }
          int min = arr[0];
          for(int i=0;i<size;i++)
          {
              if(min>arr[i])
              {
              min = arr[i];
              }
          }
          int max = arr[0];
          for(int i=0;i<size;i++)
          {
              if(max<arr[i])
              {
              max = arr[i];
              }
          }
          Console.WriteLine("Minimun number is " + min);
          Console.WriteLine("Maximum number is " + max);
          
        }
    }
}       