using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcceptanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //задає кодування консолі при вихідному потоці (для української)
            Console.OutputEncoding = Encoding.UTF8;
            //Завдання 1
            Console.WriteLine("Завдання 1.\nВведіть число для конвертації (10 -> 16 СЧ)");
            Console.WriteLine("Результат: " +
                TaskOne.decToHex(Console.ReadLine()));
            Console.WriteLine("Введіть число для конвертації (10 -> 2 СЧ)");
            Console.WriteLine("Результат: " +
                TaskOne.decToBin(Console.ReadLine()));
            Console.WriteLine("Введіть число для конвертації (16 -> 2 СЧ)");
            Console.WriteLine("Результат: " +
                TaskOne.hexToBin(Console.ReadLine()));
            Console.WriteLine("Введіть число для конвертації (2 -> 16 СЧ)");
            Console.WriteLine("Результат: " +
                TaskOne.binToHex(Console.ReadLine()));

            Console.WriteLine("Натисніть будь-яку клавішу для продовження.");
            Console.ReadKey();
            //Завдання 2
            Console.WriteLine("Завдання 2. Задайте число N:");
            //цикл буде продовжуватись поки буде успішним парсинг
            while (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Результат: " +
                    TaskTwo.zipzap(number));
                Console.WriteLine("Задайте число знову або натисніть Enter для продовження.");
            }
            //Завдання 3
            Console.WriteLine("Завдання 3. Задайте радіус кола та координати точки (х, у)(після кожного значення Enter):");
            //цикл буде продовжуватись поки буде успішним парсинг
            while (double.TryParse(Console.ReadLine(), out double radius)
                && double.TryParse(Console.ReadLine(), out double cordinateX)
                && double.TryParse(Console.ReadLine(), out double cordinateY))
            {
                Console.WriteLine("Результат: " +
                    TaskThree.isInCircle(radius, cordinateX, cordinateY));
                Console.WriteLine("Задайте число знову або натисніть Enter для продовження.");
            }
            //Завдання 4
            List<int> asphalt;//список для зчитаних значень
            Console.WriteLine("Завдання 4. Задайте висоти асфальту (розділяючи комою; по закінченню Enter).");
            try
            {
                //вхідний рядок роділяється на масив рядків, роздільником виступає кома,
                //при цьому порожні елементи не беруться
                //отриманий string-масив одразу перетворюється у Список рядків
                asphalt = Console.ReadLine().Split(new char[] { ',' },
                    StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(Convert.ToInt32);
                Console.WriteLine("Результат: " +
                    TaskFour.getWaterAmount(asphalt.ToArray()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка! " + ex.Message);
            }

            Console.WriteLine("Натисніть будь-яку клавішу для продовження.");
            Console.ReadKey();
            //Завдання 5
            Console.WriteLine("Завдання 5. Задайте закритий ключ:");
            string key = Console.ReadLine();
            Console.WriteLine("Введіть дані:");
            Console.WriteLine("Підпис:\n" + TaskFive.createSign( key, Console.ReadLine()));
            Console.WriteLine("Натисніть будь-яку клавішу для продовження.");
            Console.ReadKey();
            //Завдання 6
            Console.WriteLine("Завдання 6. Відповідь:\n" +
                "Стійкість представленої функції залежить від довжини" +
                " ”secure password”, тому у випадку використання повного" +
                " перебору за 2^N часу, де N - кількість бітів " +
                "(при 52 бітах у 10-ти знаковому паролі).");
            //Завдання 7
            Console.Write("Завдання 7. Задайте координати королеви: ");
            //цикл буде продовжуватись поки буде успішним парсинг
            while (int.TryParse(Console.ReadLine(), out int posX)
                && int.TryParse(Console.ReadLine(), out int posY))
            {
                Console.WriteLine("Результат: ");
                foreach (var item in TaskSeven.getQueenPossiblePoints(posX, posY))
                {
                    Console.Write("[{0}], ", item);
                }
                Console.WriteLine("\nЗадайте координати знову або натисніть Enter для завершення.");
            }
        }
    }
}
