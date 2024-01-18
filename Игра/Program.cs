using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_16
{
    internal class Program
    {
        static int mapSize = 25; //размер карты 
        static char[,] map = new char[mapSize, mapSize]; //карта 
        //координаты на карте игрока 
        static int playerY = mapSize / 2;
        static int playerX = mapSize / 2;
        static byte enemies = 5; //количество врагов 
        static byte buffs = 5; //количество усилений 
        static int health = 5;  // количество аптечек 
        static void Main(string[] args)
        {
            GenerationMap();
            Move();
        }
        /// <summary> 
        /// генерация карты с расставлением врагов, аптечек, баффов 
        /// </summary> 
        static void GenerationMap()
        {
            Random random = new Random();
            //создание пустой карты 
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    map[i, j] = '_';
                }
            }

            map[playerY, playerX] = 'P'; // в чередину карты ставится игрок 

            //временные координаты для проверки занятости ячейки 
            int x;
            int y;
            //добавление врагов 
            while (enemies > 0)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                //если ячейка пуста  - туда добавляется враг 
                if (map[x, y] == '_')
                {
                    map[x, y] = 'E';
                    enemies--; //при добавлении врагов уменьшается количество нерасставленных врагов 
                }
            }
            //добавление баффов 
            while (buffs > 0)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                if (map[x, y] == '_')
                {
                    map[x, y] = 'B';
                    buffs--;
                }
            }
            //добавление аптечек 
            while (health > 0)
            {
                x = random.Next(0, mapSize);
                y = random.Next(0, mapSize);

                if (map[x, y] == '_')
                {
                    map[x, y] = 'H';
                    health--;
                }
            }

            UpdateMap(); //отображение заполненной карты на консоли 
        }

        private static void UpdateMap()
        {
            throw new NotImplementedException();
        }

        /// <summary> 
        /// перемещение персонажа 
        /// </summary> 
        static void Move()
        {
            //предыдущие координаты игрока 
            int playerOldY;
            int playerOldX;

            while (true)
            {
                playerOldX = playerX;
                playerOldY = playerY;

                //смена координат в зависимости от нажатия клавиш 
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        playerX--;
                        break;
                    case ConsoleKey.DownArrow:
                        playerX++;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerY--;
                        break;
                    case ConsoleKey.RightArrow:
                        playerY++;
                        break;
                }

                Console.CursorVisible = false; //скрытный курсов 

                //предыдущее положение игрока затирается 
                map[playerOldY, playerOldX] = '_';
                Console.SetCursorPosition(playerOldY, playerOldX);
                Console.Write('_');

                //обновленное положение игрока 
                map[playerY, playerX] = 'P';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('P');

            }
        }
        
    }
}       