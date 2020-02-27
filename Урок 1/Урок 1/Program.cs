using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Анкета
            //Ихсонов Артур
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            //Console.Write("Введите ваше имя: "); // имя
            //string name = Console.ReadLine(); // ввод имени
            //Console.Write("Введите вашу фамилию: "); // фамилия
            //string surname = Console.ReadLine(); // ввод фамилии
            //Console.Write("Введите ваш возраст: "); // возраст
            //int age = Convert.ToInt32(Console.ReadLine()); // ввод возраста
            //Console.Write("Введите ваш рост: "); // рост
            //int growth = Convert.ToInt32(Console.ReadLine()); // ввод роста
            //Console.Write("Введите ваш вес: "); // вес
            //int weight = Convert.ToInt32(Console.ReadLine()); // ввод веса


            //Console.WriteLine($"Здравствуйте, {surname} {name}! ваш возраст {age}, рост {growth} см, вес {weight} кг. "); // вывод всех данных

            //Console.ReadKey(); // задержка черного экрана


            #endregion
            #region 2.Расчет индекса массы тела
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.

            //Console.WriteLine($"Здравствуйте, эта программа поможет вам рассчитать индекс массы тела!");
            //Console.Write("Введите свой вес в килограммах:");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите свой рост в метрах:");
            //double growth = Convert.ToDouble(Console.ReadLine());
            //double result = weight / (growth * growth);
            //Console.WriteLine($"Индекс массы тела равен {result}");

            //Console.ReadKey();
            #endregion
            #region 3.Расстояние между координатами
            ////Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            ////по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            ////Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);

            //Console.Write("Введите координату Y1:");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите координату Y2:");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите координату X1:");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите координату X2:");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine("Расстояние между точками {0:F}", result);

            //Console.ReadKey();
            #endregion
        }
    }
}
