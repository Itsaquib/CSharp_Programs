using System;
using System.Collections;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
          ArrayList arr = new ArrayList();
          arr.Add("AQuib");
          arr.Add(117);
          arr.Clear();
          arr.Add('s');
          arr.Add(10+20);
          arr.Add(19.2992);
           
          for(int i=0;i<arr.Count;i++)
          {
            Console.WriteLine(arr[i]);
          }
          
         
         }
    }
}       