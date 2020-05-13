using System;

namespace ColorGame
{
    class Program
    {
        public static string[] ColorsText = new string[] { "green", "black", "white", "red", "yellow", "Purpule", "Some Color", "Blue", "Gold"};
        public static string[] Colors = new string[] {"white", "red", "yellow", "green", "blue", "gray"};
       

        static void Main(string[] args)
        {
            int i = 0;
            int score = 0;
            PrintScore(score);
            while (true)
            { 
                PrintText();
                string inputText = Console.ReadLine();
                string currentColor = (Console.ForegroundColor.ToString()).ToLower();
                if(inputText == currentColor)
                {
                    score++;
                }
                PrintScore(score);
                i++;
                
            }

        }

        private static void PrintText()
        {
            string randomColor = GetRandomElementFromArray(Colors);
            Console.ForegroundColor = GetColorFromConsoleEnums(randomColor);
            Console.WriteLine(GetRandomElementFromArray(ColorsText));
        }

        private static string GetRandomElementFromArray(string[] array)
        {
            Random random = new Random();
            return array[random.Next(0, array.Length)];
        }


        private static void PrintScore(int score)
        {
            Console.Clear();
            string line = new string('-', 30);
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{new string(' ',10)}score -- {score}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(line);
            Console.WriteLine();
        }

        public static ConsoleColor GetColorFromConsoleEnums(string color)
        {
            switch (color.ToLower())
            {
                case "white":
                    return ConsoleColor.White;
                case "red":
                    return ConsoleColor.Red;
                case "yellow":
                    return ConsoleColor.Yellow;
                case "green":
                    return ConsoleColor.Green;
                case "blue":
                    return ConsoleColor.Blue;
                case "gray":
                    return ConsoleColor.Gray;
                default:
                    return ConsoleColor.Black;

            }
        }
    }
}
