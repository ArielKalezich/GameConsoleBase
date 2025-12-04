namespace GameConsoleBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Interfaces.IGamePlay game = new Games.FluffyBirdGame();
            game.Play();
            game=new Games.TetrisGame();
            game.Play();
            game=new Games.PacManGame();
            game.Play();
		}
    }
}
