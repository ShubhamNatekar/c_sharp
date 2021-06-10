using System;

namespace Generic
{
    //generic class
    class GenericClass<T>  
    {  
        public GenericClass(T msg)  
        {  
            Console.WriteLine(msg);  
        }
    }

    class Generic
    {
        //generic method
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);  
        }  

    }


    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen   = new GenericClass<string> ("This is generic class");  
            GenericClass<int>    genI  = new GenericClass<int>(101);  
            GenericClass<char>   getCh = new GenericClass<char>('I');
            Generic g1 = new Generic();
            g1.Show("This is generic method");  
            g1.Show(101);  
            g1.Show('I'); 
        }
    }
}
