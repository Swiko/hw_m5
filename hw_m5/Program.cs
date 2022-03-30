using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_m5
{
    internal class Program
    {

        static string [] Divide(string userInput)
        {
            return userInput.Split();
        }

        static string ReverseSentence(string userInput)
        {
            string reverseInput = "";
            for (int i = Divide(userInput).Length - 1; i >=0; i --)
            {
                reverseInput += Divide(userInput)[i] + " "; 
            }
            return reverseInput;
        }

        static void Main(string[] args)
        {

            // First task
            Console.WriteLine("Input you sentence: ");
            string userInput = Console.ReadLine();

            string [] divide = Divide(userInput);

            foreach(var e in divide)
            {
                Console.WriteLine(e);
            }

            // Second task

            Console.WriteLine(ReverseSentence(userInput));

        }
    }
}
