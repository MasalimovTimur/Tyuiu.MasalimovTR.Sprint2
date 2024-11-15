using System.Runtime.Serialization.Formatters;
using Tyuiu.MasalimovTR.Sprint2.Task0.V25.Lib;

namespace Tyuiu.MasalimovTR.Sprint2.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            

            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)  *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив):               *");
            Console.WriteLine("* (True, True, True, False, False, False), при x = 205, y = 159           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:"); 
                for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            };
            Console.ReadKey();
        }
    }
}
