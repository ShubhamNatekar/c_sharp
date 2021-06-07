using System;

namespace Destructor
{
    public class Employee  
    {  
        public Employee()  
        {  
            Console.WriteLine("Constructor Invoked");  
        }  
        ~Employee()  
        {  
            Console.WriteLine("Destructor Invoked");  
        }  
    }  

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
        }
    }
}
