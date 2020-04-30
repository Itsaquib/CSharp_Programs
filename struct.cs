using System;

namespace hello
{
  struct library
  {
    string Book_Name, Book_Author,Name;
    int Book_id,Book_Price;

    public void student_detail()
    {
      Console.WriteLine("Enter your Name ");
       Name = Console.ReadLine();
    }
    public void Input()
      {
        Console.WriteLine("Enter the Book Name ");
        Book_Name = Console.ReadLine();
        Console.WriteLine("Enter the Book Author ");
        Book_Author = Console.ReadLine();
        Console.WriteLine("Enter the Book ID ");
        Book_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Book Price ");
        Book_Price = Convert.ToInt32(Console.ReadLine());
      }
      public void display()
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("student name = " + Name);
        Console.WriteLine("Book Name = {0}\nBook Author = {1}\nBook Id = {2}\nBook Price = {3}",Book_Name,Book_Author,Book_id,Book_Price);
        Console.ResetColor();
      }
  }
    class Program
    {
      
      
        static void Main(string[] args)
        {
         library L = new library();
         Console.WriteLine("Enter the Number of student = ");
         int Num = Convert.ToInt32(Console.ReadLine());
         for(int i=0;i<Num;i++)
         {
         L.student_detail();
         L.Input();
         L.display();
         }
         }
    }
}       