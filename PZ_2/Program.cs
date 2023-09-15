namespace PZ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число");
            int c = int.Parse(Console.ReadLine());
            double p = 0;
            double q = 0;
            double r = 0; 
            if (d>0)
            {
                p = (17 *c ) - d;
            }
            if (d <= 0)

            { p = (Math.Log((2 * d) + 50)); }
            else

            if (p <= 11)
            {
                q = Math.Tan(c + Math.Pow(p, 2));
            }
            if (p > 11)

            { q = (p - c * d) / Math.Pow(p, 2) + c + d; }
            else
                r = Math.Pow(p + q, 3) - 11 ;
            Console.WriteLine("Результат:" + r);

            
        }
    }
}