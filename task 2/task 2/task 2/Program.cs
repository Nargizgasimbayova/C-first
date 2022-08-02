using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 100;
            int counter = 0;
            for (int i = number1; i < number2; i++)
            {
                if (i % 7 == 0)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine(counter);
            }

         }
    }
}
