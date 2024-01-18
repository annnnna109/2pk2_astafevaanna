namespace ИГРА09
{
    internal class Program
    {
        //Объявление глобальных переменных
        static int mapSize = 25;
        static char[,] map = new char[mapSize, mapSize];
        static int playerY = mapSize / 2;
        static int playerX = mapSize / 2;
        static byte enemies = 10;
        static byte buffs = 5;
        static byte health = 5;
        static int PlayerHp = 50;
        static int EnemiesHp = 30;
        static int PlayerPower = 10;
        static int EnemiesPower = 5;
        static int NumSteps = 0;
        static int buffcount = 0;
        static int playerOldY;
        static int playerOldX;
        static int buffcounthelp = 0;
        static int enemycount = 0;

        enum Direction { Left, Right, Up, Down }

        static void Main(string[] args)//Основной метод
        {

            StartGame();
            Move();

        }

        static void GenerationMap()//Метод генерации карты
        {
            Random random = new Random();

            for (int i = 0; i < mapSize; i++)//Создание карты
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    map[i, j] = '_';

                }
            }

            map[playerX, playerY] = 'P';//Присвоение начальных координат
            int x;
            int y;

            while (enemies > 0)//Цикл создания врагов
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'E';
                    enemies--;


                }
            }

            while (buffs > 0)//Цикл создания баффов
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'B';
                    buffs--;
                }
            }

            while (health > 0)//Цикл создания аптечек
            {
                x = random.Next(mapSize);
                y = random.Next(mapSize);
                if (map[x, y] == '_')
                {
                    map[x, y] = 'H';
                    health--;
                }
            }

            UpdateMap();//обновление карты
        }

        static void Move()//метод передвижения
        {
            while (true)
            {
                if (PlayerHp > 0 && enemycount != 10)
                {
                    Console.SetCursorPosition(32, 0);
                    Console.Write($"Здоровье игрока: {PlayerHp}");//вывод здоровья игрока
                    Console.SetCursorPosition(32, 1);
                    Console.Write($"Сила игрока: {PlayerPower}");//вывод силы удара игрока
                    Console.SetCursorPosition(32, 2);
                    Console.Write($"Количество шагов: {NumSteps}");//вывод общего количества шагов
                }
                playerOldX = playerX;//Присвоение значения старым координатам
                playerOldY = playerY;
                switch (Console.ReadKey().Key)//Свитч на изменение координат
                {
                    case ConsoleKey.UpArrow:
                        if (playerY == 0)
                            playerY = playerY;
                        else
                            playerY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (playerY == 24)
                            playerY = playerY;
                        else
                            playerY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (playerX == 0)
                            playerX = playerX;
                        else
                            playerX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (playerX == 24)
                            playerX = playerX;
                        else
                            playerX++;
                        break;
                    case ConsoleKey.Escape:
                        Escape(); //метод выхода из игры
                        break;
                }

                Health();//метод лечения
                Fight();//метод боевки
                Buff();//метод баффа
                buffcount++;//Подсчет длительности баффа
                if (buffcount == buffcounthelp + 21)//Проверка на завершении баффа
                {
                    PlayerPower = 10;
                }
                Console.CursorVisible = false;
                map[playerOldY, playerOldX] = '_';//Затирание старого положения игрока
                Console.SetCursorPosition(playerOldX, playerOldY);//Установка курсора на место старых координат
                Console.Write('_');//Затирка старых координат
                map[playerY, playerX] = 'P';//Установка нового положения игрока
                Console.SetCursorPosition(playerX, playerY);//Перенос курсора на координаты нового положения
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('P');
                Console.ResetColor();//Замена текущего символа в данном месте на игрока

                if (playerX == playerOldX && playerY == playerOldY)
                    NumSteps = NumSteps;
                else
                    NumSteps++;//Счет шагов

                if (PlayerHp <= 0)
                    Fail(); //вывод экрана поражения

                if (enemycount == 10)
                    Win();

            }
        }


        static void UpdateMap()//метод обновления карты
        {
            Console.Clear();
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine(map[i, 0]);
            }


        }

        static void Fight()//метод боя
        {
            if (map[playerY, playerX] == 'E')
            {
                PlayerHp -= EnemiesPower;
                EnemiesHp -= PlayerPower;
                if (EnemiesHp > 0)
                {
                    Console.SetCursorPosition(playerOldX, playerOldY);
                    map[playerOldY, playerOldX] = 'E';
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write('E');
                    Console.ResetColor();
                    playerOldX = playerX;
                    playerOldY = playerY;

                }
                else
                {
                    EnemiesHp = 30;
                    enemycount++;
                }
            }
        }

        static void Health()//Метод лечения
        {
            if (map[playerY, playerX] == 'H')
            {
                Console.SetCursorPosition(playerOldX, playerOldY);
                map[playerOldY, playerOldX] = 'H';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('H');
                Console.ResetColor();
                playerOldX = playerX;
                playerOldY = playerY;
                PlayerHp = 50;
            }

        }
        static void Buff() //Метод баффа
        {
            if (map[playerY, playerX] == 'B')
            {
                Console.SetCursorPosition(playerOldX, playerOldY);
                map[playerOldY, playerOldX] = 'B';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write('B');
                Console.ResetColor();
                playerOldX = playerX;
                playerOldY = playerY;
                buffcounthelp = NumSteps;
                PlayerPower = 20;
            }
        }
        static void StartGame()// метод вывода начального экрана
        {
            Console.SetCursorPosition(37, 22);
            Console.WriteLine("N - начать новую игру");
            Console.SetCursorPosition(37, 23);
            Console.WriteLine("L - загрузить последнее сохранение");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.N:
                    GenerationMap();
                    break;
                case ConsoleKey.L:
                    //LoadGame();
                    break;
            }
        }
        static void Fail()
        {
            Console.Clear();
            Console.WriteLine("Вы проиграли");
            Console.Write($"Количество шагов: {NumSteps}");//вывод общего количества шагов
        }

        static void Win()
        {
            Console.Clear();
            Console.WriteLine("Вы выиграли");
            Console.Write($"Количество шагов: {NumSteps}");//вывод общего количества шагов
        }

        static void Escape()//метод выхода из игры
        {

            Console.Clear();
            Console.SetCursorPosition(40, 22);
            Console.WriteLine("sW - вернуться в игру ");
            Console.SetCursorPosition(40, 23);
            Console.WriteLine("T - сохранить и выйти");
            Console.SetCursorPosition(40, 24);
            Console.WriteLine("D - выйти без сохранения");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    UpdateMap();
                    break;
                case ConsoleKey.T:
                    {
                        Environment.Exit(0); // Сохраненить и выйти
                    }
                    break;
                case ConsoleKey.D:
                    Environment.Exit(0);
                    break;
            }
        }

        static void SaveProgress()
        {

        }
        static void LoadProgress()
        {

        }

    }
}