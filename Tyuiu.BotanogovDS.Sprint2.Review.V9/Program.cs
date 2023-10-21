using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint2.Review.V9.Lib;

namespace Tyuiu.BotanogovDS.Sprint2.Review.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич   | ИСТНб-23-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                 *");
            Console.WriteLine("* с координатами X,Y в заштрихованной области.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значения X, Y                                                   *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ваше значение X: " + x + " Ваше значение Y: " + y);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            bool res = ds.CheckDotInShadedArea(x, y);
            
            if (res)
            {
                Console.WriteLine("Ваша точка находится в закрашенной области");
            }
            else
            {
                Console.WriteLine("Ваша точка не находится в закрашенной области");
            }
            Console.ReadKey();
        }
    }
}
