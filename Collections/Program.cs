using System;
using System.Collections.Generic;  

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create a list of strings  
            Console.WriteLine("---------List--------");
            var names = new List<string>();  
            names.Add("shubham");  
            names.Add("Ankit");  
            names.Add("Peter");  
            names.Add("Irfan");  

             // Create a list of strings using collection initializer  
            //var names = new List<string>() {"Shubham", "Vimal", "Ratan", "Love" };  
    
            // Iterate list element using foreach loop  
            foreach (var name in names)  
            {  
                Console.WriteLine(name);  
            }  

            Console.WriteLine("--------HashSet--------");
            // Create a HashSet of strings  
            var names2 = new HashSet<string>();  
            names2.Add("shubham");  
            names2.Add("Ankit");  
            names2.Add("Peter");  
            names2.Add("Irfan");  
            names2.Add("Ankit");//will not be added  
            

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names2)  
            {  
                Console.WriteLine(name);  
            }  

            Console.WriteLine("--------SortedSet--------");    
            // Create a SortedSet of strings  
            var names3 = new SortedSet<string>();  
            names3.Add("Shubham");  
            names3.Add("Ankit");  
            names3.Add("Peter");  
            names3.Add("Irfan");  
            names3.Add("Ankit");//will not be added  
            
            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names3)  
            {  
                Console.WriteLine(name);  
            }  

            Console.WriteLine("--------Stack--------");

            Stack<string> names4 = new Stack<string>();  
            names4.Push("Shubham");  
            names4.Push("Peter");  
            names4.Push("James");  
            names4.Push("Ratan");  
            names4.Push("Irfan");  
    
            foreach (string name in names4)  
            {  
                Console.WriteLine(name);  
            }  
    
            Console.WriteLine("Peek element: "+names4.Peek());  
            Console.WriteLine("Pop: "+ names4.Pop());  
            Console.WriteLine("After Pop, Peek element: " + names4.Peek()); 
            
            Console.WriteLine("--------Queue--------");
            Queue<string> names5 = new Queue<string>();  
            names5.Enqueue("Shubham");  
            names5.Enqueue("Peter");  
            names5.Enqueue("James");  
            names5.Enqueue("Ratan");  
            names5.Enqueue("Irfan");  
    
            foreach (string name in names5)  
            {  
                Console.WriteLine(name);  
            }  
    
            Console.WriteLine("Peek element: "+names5.Peek());  
            Console.WriteLine("Dequeue: "+ names5.Dequeue());  
            Console.WriteLine("After Dequeue, Peek element: " + names5.Peek());      
            
            Console.WriteLine("--------LinkedList--------");
            // Create a LinkedList of strings  
            var names6 = new LinkedList<string>();  
            names6.AddLast("Shubham");  
            names6.AddLast("Ankit");  
            names6.AddLast("Peter");  
            names6.AddLast("Irfan");  
            
            //insert new element before "Peter"  
            LinkedListNode<String> node=names6.Find("Peter");  
            names6.AddBefore(node, "John");  
            names6.AddAfter(node, "Lucy");  
    
            // Iterate list element using foreach loop  
            foreach (var name in names6)  
            {  
                Console.WriteLine(name);  
            }  

            Console.WriteLine("--------Dictionary--------");
            Dictionary<string, string> names7 = new Dictionary<string, string>();  
            names7.Add("1","Shubham");  
            names7.Add("2","Peter");  
            names7.Add("3","James");  
            names7.Add("4","Ratan");  
            names7.Add("5","Irfan");  
    
            foreach (KeyValuePair<string, string> kv in names7)  
            {  
                Console.WriteLine(kv.Key+" "+kv.Value);  
            }

            Console.WriteLine("--------SortedDictionary--------");
            SortedDictionary<string, string> names8 = new SortedDictionary<string, string>();  
            names8.Add("1","Shubham");    
            names8.Add("4","Peter");    
            names8.Add("5","James");    
            names8.Add("3","Ratan");    
            names8.Add("2","Irfan");    
            foreach (KeyValuePair<string, string> kv in names8)  
            {  
                Console.WriteLine(kv.Key+" "+kv.Value);  
            }  

            Console.WriteLine("--------SortedList--------");
            SortedList<string, string> names9 = new SortedList<string, string>();  
            names9.Add("1","Shubham");    
            names9.Add("4","Peter");    
            names9.Add("5","James");    
            names9.Add("3","Ratan");    
            names9.Add("2","Irfan");    
            foreach (KeyValuePair<string, string> kv in names9)  
            {  
                Console.WriteLine(kv.Key+" "+kv.Value);  
            }  

        }
    }
}
