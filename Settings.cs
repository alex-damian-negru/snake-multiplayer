namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int FoodValue { get; set; }
        public static bool GameOver { get; set; }
        public static Direction Direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 7;
            Score = 0;
            FoodValue = 100;
            GameOver = false;
            Direction = Direction.Right;
        }
    }
}
