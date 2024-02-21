using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19_Вариант_2
{
    public abstract class Transport
    {
        
            // Атрибуты класса  расстояние, стоимость и цена 
            protected double distance;
            protected double cost;
            protected double price;

            // Конструктор для инициализации атрибутов 
            public Transport(double distance, double cost, double price)
            {
                this.distance = distance;
                this.cost = cost;
                this.price = price;
            }

            // Абстрактные методы для перевозки груза и расчета стоимости перегрузки 
            public abstract void TransportCargo();
            public abstract double CalculateCost();

            // Перегрузка операторов + и - для вывода общей информации по доставке всех объектов 
            public static Transport operator +(Transport t1, Transport t2)
            {
                double totalCost = t1.CalculateCost() + t2.CalculateCost();
                double totalPrice = t1.price + t2.price;
                double totalDistance = t1.distance + t2.distance;

                Console.WriteLine("Общая информация по доставке:");
                Console.WriteLine("Стоимость: " + totalCost);
                Console.WriteLine("Цена: " + totalPrice);
                Console.WriteLine("Расстояние: " + totalDistance);

                return null;
            }

            public static Transport operator -(Transport t1, Transport t2)
            {
                double totalCost = t1.CalculateCost() - t2.CalculateCost();
                double totalPrice = t1.price - t2.price;
                double totalDistance = t1.distance - t2.distance;

                Console.WriteLine("Общая информация по доставке:");
                Console.WriteLine("Стоимость: " + totalCost);
                Console.WriteLine("Цена: " + totalPrice);
                Console.WriteLine("Расстояние: " + totalDistance);

                return null;
            }
       
    }
}
