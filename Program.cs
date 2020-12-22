using System;
using System.Collections.Generic; 

namespace AddEmUp
{
    class Program
    {
        static string GetInput()
        {
            return(Console.ReadLine());
        }

        static int CheckInput(List<int> numbers)
        {
            string input =  GetInput();
            try
            {
                numbers.Add(int.Parse(input));//check if the input is a number
            }
            catch(FormatException)//If not check if the string is "ok" and if so exit. Else let the user know the input was not valid.
            {
                if(input.ToLower() == "ok")
                {
                    int sum = 0;
                    foreach(var number in numbers)
                    {
                        sum += number;
                    }
                    return(sum);
                }
                else
                {
                    
                }
            }
        }

        static void Main(string[] args)
        {
            var numbers = new List<int>();
            CheckInput(numbers);
        }
    }
}
