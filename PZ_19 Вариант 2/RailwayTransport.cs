using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19_Вариант_2
{

    public class RailwayTransport : Transport
    {
        // Конструктор для инициализации атрибутов базового класса 
        public RailwayTransport(double distance, double cost, double price) : base(distance, cost, price)
        {
        }

        // Реализация абстрактных методов базового класса 
        public override void TransportCargo()
        {
            Console.WriteLine("Перевозка груза в наземных условиях на расстояние " + distance);
        }

        public override double CalculateCost()
        {
            double totalCost = distance * cost;
            Console.WriteLine("Стоимость перевозки груза в наземных условиях: " + totalCost);
            return totalCost;
        }
    }
    
}
