using System;

namespace Overloading
{   
    public class Cal
    {  
        public static int add(int a,int b)
        {  
            return a + b;  
        }
        //adding extra parameter  
        public static int add(int a, int b, int c)  
        {  
            return a + b + c;  
        }

        //changing data type
         public static float add(float a, float b)  
        {  
            return a + b;  
        }  
    }  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(12, 23));  
            Console.WriteLine(Cal.add(12, 23, 25));
            Console.WriteLine(Cal.add(12.4f,21.3f));  
        }
    }
}
