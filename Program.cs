using System;
using System.Collections.Generic; 

namespace AddEmUp
{
    class Program
    {
        static int CheckInput(List<int> numbers)
        {
            int sum = 0;
            Console.WriteLine("Please enter a number or \"ok\" to exit the program");
            string input =  Console.ReadLine();
            try
            {
                numbers.Add(int.Parse(input));//Check if the input is a number and recursively call function.
                CheckInput(numbers);
            }
            catch(FormatException)//Check if the string is "ok" and if so exit. Else let the user know the input was not valid and ask again recusively.
            {
                if(input.ToLower() == "ok")
                {
                    foreach(var number in numbers)
                    {
                        sum += number;
                    }
                }
                else
                {
                    Console.WriteLine("This is not a valid entry.");
                    CheckInput(numbers);
                }
            }
            return(sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckInput(new List<int>()));//Print sum to user.
        }
    }
}
