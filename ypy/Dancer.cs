using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ypy
{
    public enum Dance { Tango, Flamenko, Breakdance, Lezginka }
    public class Dancer
    {
        // данные класса
        public string name; //поле имени объекта
        public DateTime dateOfBirth; // поле дня рождения объекта
        public Dance dance; // поле для танца

        // конструктор класса
        public Dancer (string name, DateOnly ateOfBirth)
        {
            this.name = name;
            Dancer dancer = this; dateOfBirth = dateOfBirth;
        }

        // действия (интерфейс) класса 
        public void PrinfoIndo()
        {
            Console.WriteLine ($"танцор {name}, возраст {GetAge}. Танцует {dance}");
          
        }

        private int GetAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year;
 
        }
        
}   }
