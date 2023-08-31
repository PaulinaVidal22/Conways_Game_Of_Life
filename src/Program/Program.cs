
namespace PII_Game_Of_Life
{
    class Program
{
    static void Main(string[] args)
    {
        BoardLoader boardLoader = new BoardLoader();
        GameLogic gameLogic = new GameLogic();
        Printer consoleRenderer = new Printer();
        GameOfLife gameOfLife = new GameOfLife(boardLoader, gameLogic, consoleRenderer);

        string filePath = @"Conways_Game_Of_Life\src\Program\board.txt";
        gameOfLife.Start(filePath);
    }
}

}
