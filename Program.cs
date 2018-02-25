using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int number = 1; number < 31; number++) {
                if(number % 3 == 0) {
                    Console.Write("Fizz");
                }

                if(number % 5 == 0) {
                    Console.Write("Buzz");
                }
                
                if(number % 3 != 0 && number % 5 != 0) {
                    Console.Write(number);
                }
                
                Console.WriteLine();
            }
        }
    }
}
