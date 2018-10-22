using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentElement = 1;
            double currentMaxElement = -1.7e+308;
            int currentNumber = 0;
            int currentMaxNumber = 0;

            while (currentElement != 0)
            {
                Console.WriteLine("Введите текущий элемент. Чтобы завершить последовательность введите 0");

                try
                {
                    currentElement = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод");
                    return;
                }

                if (currentElement != 0)
                {
                    currentNumber++;
                    if (currentElement >= currentMaxElement)
                    {
                        currentMaxElement = currentElement;
                        currentMaxNumber = currentNumber;
                    }
                }
            }
            if (currentNumber == 0)
            {
                Console.WriteLine("Нет элементов в последовательности. Вы ввели только 0");
            }
            else
            {
                Console.WriteLine($"Номер максимального элемента в последовательности: {currentMaxNumber}");
            }
        }
    }
}
