using System;

namespace Constructor
{
    public class Employee  
    {  
        public int id;   
        public String name;  
        public float salary;  
        
        public Employee()
        {
             Console.WriteLine("inside the default Constructor ");     
        }
        
        public Employee(int i, String n,float s)  
        {  
            id = i;  
            name = n;  
            salary = s;  
        }  
        public void display()  
        {  
            Console.WriteLine(id + " " + name+" "+salary);  
        }  

   }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(101, "shubham", 890000f);  
            Employee e2 = new Employee(102, "sagar", 490000f);  
            e1.display();  
            e2.display();     
        }
    }
}