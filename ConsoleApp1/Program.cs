using System;

namespace ConsoleApp1
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввести значениея A и B");
            int A= Convert.ToInt32(Console.ReadLine());
            int  B= Convert.ToInt32(Console.ReadLine());
          
            int P=(A+B)*2; 
            int S=A*B;

            Console.WriteLine($"вывести результат: {P}, {S}") ;

            Console.ReadKey();

        }
    }
}




