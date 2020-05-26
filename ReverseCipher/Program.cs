using System;

namespace ReverseCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter message you want to decript");
            string input = Console.ReadLine();
            
            string inputTranslated = "";

            int i = input.Length - 1;

            while( i >= 0){
                inputTranslated = inputTranslated + input[i];
                i =  i -1;
            }
            Console.WriteLine(inputTranslated);

        }
    }
}
