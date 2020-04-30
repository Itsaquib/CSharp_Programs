using System;

namespace hello
{
    public class Emplyoee
    {
       public string Name,Profile,Address;
       public int Id,Phone_no;

        public void assign()
        {
            Console.WriteLine("Enter the Name  = ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the profile =");
            Profile = Console.ReadLine();
            Console.WriteLine("Enter the address = ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the Employee ID = ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PhoneNo = ");
            Phone_no = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("{0}",Name);
            Console.WriteLine("{0}",Profile);
            Console.WriteLine("{0}",Address);
            Console.WriteLine("{0}",Id);
            Console.WriteLine("{0}",Phone_no);
        }

        static void Main(string[] args)
        {
         Emplyoee Aquib = new Emplyoee();
         Aquib.assign();
         Aquib.display();
         Emplyoee Manish = new Emplyoee();
         Manish.assign();
         Manish.display();

        }
    }
}