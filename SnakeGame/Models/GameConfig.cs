namespace SnakeGame.Models
{
    public class GameConfig
    {
        public int AreaHeight { get; set; }
        public int AreaWidth { get; set; }
        public Difficulty GameDifficulty { get; set; }

        public GameConfig()
        {
            AreaHeight = 16;
            AreaWidth = 32;
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
