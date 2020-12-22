using System;
using System.Collections.Generic;
using System.Linq; 

namespace AddEmUp
{
    class Program
    {
        static int CheckInput(List<int> numbers, int sum)
        {
            Console.WriteLine("Please enter a number or \"ok\" to exit the program");
            string input =  Console.ReadLine();
            try
            {
                numbers.Add(int.Parse(input));//Check if the input is a number and recursively call function.
                CheckInput(numbers, sum);
            }
            catch(FormatException)//Check if the string is "ok" and if so exit. Else let the user know the input was not valid and ask again recusively.
            {
                if(input.ToLower() != "ok")
                {
                    Console.WriteLine("This is not a valid entry.");
                    CheckInput(numbers, sum);
                }
            }
            return(numbers.Sum());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckInput(new List<int>(), 0));//Print sum to user.
        }
    }
}
