using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Календарь");
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц (1-12): ");
            int month = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            Console.WriteLine($"{currentDate.ToString("MMMM yyyy")}");
            Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

            int currentDayOfWeek = (int)currentDate.DayOfWeek;

            for (int i = 0; i < currentDayOfWeek; i++)
            {
                Console.Write("   ");
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,3}");
                currentDayOfWeek++;

                if (currentDayOfWeek == 7)
                {
                    Console.WriteLine();
                    currentDayOfWeek = 0;
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("\n\nВведите любую клавишу для продолжения или 'q' для выхода.");
            var key = Console.ReadKey();
            if (key.KeyChar == 'q')
            {
                break;
            }
        }
    }
}
