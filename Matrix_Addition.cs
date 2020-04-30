using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string  AppName = "MatrixMul";
            string AppVersion = "1.0.0";
            string AuthorName = "AQUIb Shaikh";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Project : {0} Version {1} by {2}",AppName,AppVersion,AuthorName);
            Console.ResetColor();
            int i,j;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter the Size of Rows :-");
            int Rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Size of Column :-");
            int Column = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.Yellow;
            int[,] arr1 = new int[Rows,Column];
            Console.WriteLine("Enter the number for matrix 1 :-");
            for(i=0;i<Rows;i++)
            {
                for(j=0;j<Column;j++)
                {
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
             Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.Magenta;
            int[,] arr2 = new int[Rows,Column];
            Console.WriteLine("Enter the number for matrix 2 :-");
            for(i=0;i<Rows;i++)
            {
                for(j=0;j<Column;j++)
                {
                    arr2[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.DarkGray;
            int[,] arr3 = new int[Rows,Column];
            Console.WriteLine("The Sum of the matrix is = ");
            for(i=0;i<Rows;i++)
            {
                for(j=0;j<Column;j++)
                {
                    arr3[i,j] = arr1[i,j] + arr2[i,j];
                    Console.Write(" " +arr3[i,j]);
                }
                Console.WriteLine();
            }
          
        }
    }
}       