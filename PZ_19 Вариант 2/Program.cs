namespace PZ_19_Вариант_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeaTransport seaTransport = new SeaTransport(100, 10, 50);
            RailwayTransport railwayTransport = new RailwayTransport(200, 5, 30);
            AirTransport airTransport = new AirTransport(300, 20, 100);

            // Вызов методов перевозки груза и расчета стоимости перегрузки 
            seaTransport.TransportCargo();
            double seaTransportCost = seaTransport.CalculateCost();

            Console.WriteLine();

            railwayTransport.TransportCargo();
            double railwayTransportCost = railwayTransport.CalculateCost();

            Console.WriteLine();

            airTransport.TransportCargo();
            double airTransportCost = airTransport.CalculateCost();

            Console.WriteLine();

            // Вызов операторов + и - 
            Transport totalTransport = seaTransport + railwayTransport;
            Console.WriteLine();
            totalTransport = airTransport - railwayTransport;
        }
    }
}