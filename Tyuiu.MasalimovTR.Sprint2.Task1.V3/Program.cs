using Tyuiu.MasalimovTR.Sprint2.Task1.V3.Lib;

namespace Tyuiu.MasalimovTR.Sprint2.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Масалимов Т.Р. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Масалимов Тимур Рyсланович | РППб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),  *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив)      *");
            Console.WriteLine("* (True, False, False, False, False, False), при a = 185, b = 316, c = 134, d = 134           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результат:");

            DataService ds = new DataService();
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            };
            Console.ReadKey();
        }
    }
}
