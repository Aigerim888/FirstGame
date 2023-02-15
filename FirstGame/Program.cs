
namespace FirstGame;
class Program
{
    static void Main()
    {
        private static Game _game = new Game();

    static void Main()
    {
        while (_game.GetWinner() == Winner.None)
        {
            PrintGame();
            char name = char.Parse(Console.ReadLine());
            _game.Turn(name);
            Console.WriteLine(_game.counter);
        }
        PrintGame();

        Winner winner = _game.GetWinner();
        if (winner == Winner.None)
        {
            Console.WriteLine("Победитель ничья");
        }
        else if (winner == Winner.Win)
        {
            Console.WriteLine("Вы победили");

        }
        else
        {
            Console.WriteLine("Вы проиграли");
        }
        Console.ReadKey(true);
    }

    static void PrintGame()
    {
        Console.WriteLine("Угадайте слово");
        Console.WriteLine(_game.result);

    }
}
