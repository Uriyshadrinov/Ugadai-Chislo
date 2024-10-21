using System;

class GuessNumberGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        PlayGame();
    }

    static void PlayGame()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Загаданное число от 1 до 100
        int attempts = 0;
        bool guessed = false;

        Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

        while (!guessed)
        {
            Console.Write("Введи своё число: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userGuess))
            {
                attempts++;
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("Число больше!");
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Число число меньше!");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Ты угадал число за {attempts} попыток.");
                    guessed = true;
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введи правильное число.");
            }
        }

        Console.WriteLine("Игра окончена.");
    }
}
