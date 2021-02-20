using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.

namespace Block_Diagram
{
    //Класс проверки 
    public class Simple_Test
    {

        static string Simple(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if ((n % i) == 0)
                    d++;
                i++;
            }
            if (d == 0)
                return "Простое число";
            else
                return "Не просто число";
        }

        //Подаётся 5, ожидается простое
        public void DoFive_ReturnSimple()
        {
            var number = 5;
            Console.WriteLine("Подаётся " + number + ", ожидается простое");
            Console.WriteLine("Результат работы : " + Simple(number));
        }

        public void DoTwelve_ReturnNoSimple()
        {
            //Подаётся 12, ожидается не простое
            var number = 12;
            Console.WriteLine("Подаётся " + number + ", ожидается не простое");
            Console.WriteLine("Результат работы : " + Simple(number));
        }
    }

    class Program
    {
        static void Main()
        {
            var TEST = new Simple_Test();
            TEST.DoFive_ReturnSimple();
            Console.WriteLine();
            TEST.DoTwelve_ReturnNoSimple();
            Console.ReadKey();
        }
    }
}
