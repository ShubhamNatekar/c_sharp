using System;

namespace Static
{
    //staric variable
    public class Account  
    { 
        public int accno;   
        public String name;  
        public static int count=0;
        public static float rateOfInterest;  
        public Account(int accno, String name)  
        {  
            this.accno = accno;  
            this.name = name;  
            count++;  
        }  
        //static constructor
        static Account()  
        {  
            rateOfInterest = 9.5f;  
        }  
          
        public void display()  
        {  
            Console.WriteLine(accno + " " + name + " " +rateOfInterest);  
        }  
    }  

    //static class
    public static class MyMath  
    {  
        public static float PI=3.14f;   
        public static int cube(int n){return n*n*n;}  
    }  



    class Program
    {
        static void Main(string[] args)
        {
            //for static variable
            Account a1 = new Account(101, "Shubham");  
            Account a2 = new Account(102, "Mahesh");  
            Account a3 = new Account(103, "Ajeet");  
            a1.display();  
            a2.display();  
            a3.display();  
            Console.WriteLine("Total Objects are: "+Account.count);  
            
            //for static class
            Console.WriteLine("Value of PI is: "+MyMath.PI);  
            Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));  
        }
    }
}
