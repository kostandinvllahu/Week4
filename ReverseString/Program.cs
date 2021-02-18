using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse String");
            string word = null;
            int size = 0;
            string result = null;
            Console.WriteLine("Vendos fjalen per tu bere reverse");
            word = Console.ReadLine();
            size = word.Length - 1;
            while(size >= 0)
            {
                result += word[size];
                size--;
            }

            Console.WriteLine("Perfundimi eshte " + result);

        }
    }
}
