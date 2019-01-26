using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameForm : Form
    {
        private Circle _food = new Circle();
        private readonly List<BodyPart> _snake = new List<BodyPart>();

        public GameForm()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            var head = new BodyPart { X = 10, Y = 5 };

            _snake.Clear();
            _snake.Add(head);

            PointsLabel.Text = Settings.Score.ToString();

            GenerateFood();
        }
            
        private void UpdateScreen(object sender, EventArgs e)
        {

            if (Input.KeyPressed(Keys.Right) && Settings.Direction != Direction.Left)
                Settings.Direction = Direction.Right;

            if (Input.KeyPressed(Keys.Left) && Settings.Direction != Direction.Right)
                Settings.Direction = Direction.Left;

            if (Input.KeyPressed(Keys.Up) && Settings.Direction != Direction.Down)
                Settings.Direction = Direction.Up;

            if (Input.KeyPressed(Keys.Down) && Settings.Direction != Direction.Up)
                Settings.Direction = Direction.Down;

            MovePlayer();

            GamePictureBox.Invalidate();
        }

        private void MovePlayer()
        {
            for (var i = _snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    var maxXPos = GamePictureBox.Size.Width / Settings.Width;
                    var maxYPos = GamePictureBox.Size.Height / Settings.Height;

                    switch (Settings.Direction)
                    {
                        case Direction.Right:
                            _snake[i].X++;
                            break;

                        case Direction.Left:
                            _snake[i].X--;
                            break;

                        case Direction.Up:
                            _snake[i].Y--;
                            break;

                        case Direction.Down:
                            _snake[i].Y++;
                            break;
                    }

                    for (var j = 1; j < _snake.Count; j++)
                        if (CollideWithBody(i, j))
                            Die();

                    if (CollideWithBorders(i, maxXPos, maxYPos))
                        Die();

                    if (CollideWithFood())
                        Eat();
                }
                else
                {
                    _snake[i].X = _snake[i - 1].X;
                    _snake[i].Y = _snake[i - 1].Y;
                }
            }
        }

        private void GenerateFood()
        {
            var maxXPos = GamePictureBox.Size.Width / Settings.Width;
            var maxYPos = GamePictureBox.Size.Height / Settings.Height;

            var random = new Random();
            _food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private bool CollideWithFood()
        {
            return _snake[0].X == _food.X &&
                   _snake[0].Y == _food.Y;
        }

        private void Eat()
        {
            var bodyPart = new BodyPart()
            {
                X = _snake[_snake.Count - 1].X,
                Y = _snake[_snake.Count - 1].Y
            };

            _snake.Add(bodyPart);

            Settings.Score += Settings.FoodValue;
            PointsLabel.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private bool CollideWithBody(int i, int j)
        {
            return _snake[i].X == _snake[j].X &&
                   _snake[i].Y == _snake[j].Y;
        }

        private bool CollideWithBorders(int i, int maxXPos, int maxYPos)
        {
            return _snake[i].X < 0 ||
                   _snake[i].Y < 0 ||
                   _snake[i].X >= maxXPos ||
                   _snake[i].Y >= maxYPos;
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void DrawFood(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Red,
                new Rectangle(_food.X * Settings.Width,
                    _food.Y * Settings.Height, Settings.Width, Settings.Height));
        }

        private void DrawSnakeBodyHead(Graphics graphics, Brush snakeColor, int i)
        {
            graphics.FillRectangle(snakeColor,
                new Rectangle(_snake[i].X * Settings.Width,
                    _snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
        }

        private void GamePictureBox_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            if (!Settings.GameOver)
            {
                for (var i = 0; i < _snake.Count; i++)
                {
                    var snakeColor = i == 0 ? Brushes.Black : Brushes.Green;

                    DrawSnakeBodyHead(graphics, snakeColor, i);
                    DrawFood(graphics);
                }
            }
            else
            {
                var gameOver = "Oops! You died.\n" +
                               "But you collected " + Settings.Score + " points though.\n" +
                               "Nicely done!" + "\n\n" + 
                               "Press Q to quit.";
                
                GameOverLabel.Text = gameOver;
                GameOverLabel.Visible = true;


                if (Input.KeyPressed(Keys.Q))
                    Close();
            }
        }
    }
}
