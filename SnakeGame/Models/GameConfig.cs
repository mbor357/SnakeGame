namespace SnakeGame.Models
{
    public class GameConfig
    {
        public int AreaHeight { get; set; }
        public int AreaWidth { get; set; }
        public Difficulty GameDifficulty { get; set; }

        public GameConfig()
        {
            AreaHeight = 10;
            AreaWidth = 10;
            GameDifficulty = Difficulty.Easy;
        }
    }

    public enum Difficulty
    {
        Easy = 0, 
        Medium = 1,
        Hard = 2
    }
}
