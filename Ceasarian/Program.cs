using System;

namespace Ceasarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caesar Cipher");
            string word = null;
            int shift = 0;
            Console.WriteLine("Vendos fjalen qe do te enkriptohet");
            word = Console.ReadLine();
            Console.WriteLine("Vendos nr e shtyrjes per tu konvertuar");
            shift = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    char text = (char)(((int)word[i] + shift - 65) % 26 + 65);
                    Console.Write(text + " ");
                }
                else
                {
                    char text = (char)(((int)word[i] + shift - 97) % 26 + 97);
                    Console.Write(text + " ");
                }
            }
        }
    }
}
