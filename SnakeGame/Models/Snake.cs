namespace SnakeGame.Models
{
    public class Snake
    {
        public List<Pixel> SnakeBody { get; set; }

        public Snake(int areaWidth, int areaHeight)
        {
            SnakeBody = new List<Pixel>();

            Pixel head = new Pixel
            {
                X = areaWidth / 2,
                Y = areaHeight / 2
            };

            SnakeBody.Add(head);
        }
    }
}