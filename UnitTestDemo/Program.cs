
namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var gameOver = false;
            //Add game logic

            while (!gameOver)
            {
                player.TakeTurn();

                //add game logic
                gameOver = true;
            }

        }
    }
}