namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца (от 1 до 12):");
            int month = Convert.ToInt32(Console.ReadLine());

            int daysInMonth = GetDaysInMonth(year, month);
            Console.WriteLine("Количество дней в указанном месяце: " + daysInMonth);
        }

        static int GetDaysInMonth(int year, int month)
        {
            bool isLeapYear = IsLeapYear(year);

            switch (month)
            {
                case 2:
                    return isLeapYear ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            else if (year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}    