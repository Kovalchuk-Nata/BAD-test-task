using System;
using System.IO;

namespace test_task_BAD
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                // Додамо змінну з файлом
                string file = "C:\\Users\\Dell\\Desktop\\10m.txt";

                //Запишемо в список всі наші числа з файлу та зі странгу зробимо інтеджер
                List<int> numbers = File.ReadAllLines(file).Select(int.Parse).ToList();

                // Шукаємо максимальне значення
                Console.WriteLine("Max = " + numbers.Max());

                // Мінімальне
                Console.WriteLine("Min = " + numbers.Min());

                // Середнє
                Console.WriteLine("Average = " + numbers.Average());

                //Медіана
                Console.WriteLine("Median = " + median(numbers));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        // метод для пошуку медіани
        public static double median(List<int> num)
        {
            double median = 0;
            num.Sort();
            int count = num.Count;
            // Якщо кількість чисел парна, повертаємо cереднє арифметичне значення двох чисел що посередині
            if (count % 2 == 0)
            {
                median = (num[count / 2 - 1] + num[count / 2]) / 2.0;
            }
            // Якщо кількість чисел непарна, повертаємо значення по середині
            else
            {
                median = num[count / 2];
            }

            return median;
        }
    }
}
