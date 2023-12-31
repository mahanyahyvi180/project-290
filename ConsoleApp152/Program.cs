using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp152
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = "abcdefghijklmabcdefghijklm";
            char[] searchLetters = { 'c', 'a', '$' };

            Console.WriteLine($"First 'c' is located at index" + letters.IndexOf('c'));
            Console.WriteLine($"First 'a' starting at 1 is located at index" + letters.IndexOf('a', 1));
            Console.WriteLine("First '$' in the 5 positions starting at 3" + $"is located at index" + letters.IndexOf('$', 3, 5));

            Console.WriteLine($"\nLast 'c' is located at index" + letters.LastIndexOf('c'));

            Console.WriteLine("Last 'a' up to position 25 is located at" + "index" + letters.LastIndexOf('a', 25));
            Console.WriteLine("Last '$' in the 5 positions ending at 15" + "is located at index" + letters.LastIndexOf('$', 15, 5));

            Console.WriteLine("\nFirst\"def\"is located at index" + letters.IndexOf("def"));

            Console.WriteLine("First \"def\" starting at 7 is located at" + "index" + letters.IndexOf("def", 7));
            Console.WriteLine("First \"hello\" in the 15 position" + "starting at 5 is located at index" + letters.IndexOf("hello", 5, 15));

            Console.WriteLine("\nLast \"def\"is located at index" + letters.LastIndexOf("def"));
            Console.WriteLine("Last\"def\" up to position 25 is located" + "at index" + letters.LastIndexOf("def", 25));
            Console.WriteLine("Last\"hello\"in the 15 positions" + "ending at 20 is located at index" + letters.LastIndexOf("hello", 20, 15));

            Console.WriteLine("\nFirst 'c','a' or '$' is" + "located at index" + letters.IndexOfAny(searchLetters));
            Console.WriteLine("First 'c' 'a' or '$' starting at 7 is" + "located at index" + letters.IndexOfAny(searchLetters,7));
            Console.WriteLine("First 'c','a' or '$' in the 5 positions" + "starting at 7 is located at index" + letters.IndexOfAny(searchLetters, 7, 5));

            Console.WriteLine("\nLast 'c','a' or '$' is" + "located at index" + letters.LastIndexOfAny(searchLetters));

            Console.WriteLine("Last 'c','a' or '$' up to position 1 is" + "located at index" + letters.LastIndexOfAny(searchLetters, 1));

            Console.WriteLine("Last 'C','a' or '$' in the 5 positions" + "ending at 25 is located at index" + letters.LastIndexOfAny(searchLetters, 25, 5));

            Console.ReadLine();
            
        }
    }
}
