using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input)
        {
            if(input== null)
            {
               return null;
            }
         else if (input=="")
        {
                return "0,0";
        }
        else
        {
              int length= input.Length;
              string[] arrayOfWords= input.Split(' ');
              int numOfWords= arrayOfWords.Length;
              return $"{length},{numOfWords}:{input}";
        }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
