using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Canvas : Form
    {
        private Shape _food = new Shape();
        private readonly List<Shape> _snake = new List<Shape>();

        public Canvas()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;

            new Settings();

            var head = new Shape { X = 10, Y = 5 };
            _snake.Clear();
            _snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            var maxXPos = pbCanvas.Size.Width / Settings.Width;
            var maxYPos = pbCanvas.Size.Height / Settings.Height;

            var random = new Random();
            _food = new Shape {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
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

            pbCanvas.Invalidate();
        }

        private void PbCanvas_Paint(object sender, PaintEventArgs e)
        {
            var canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                for (var i = 0; i < _snake.Count; i++)
                {
                    var snakeColor = i == 0 ? Brushes.Black : Brushes.Green;

                    DrawSnakeBodyHead(canvas, snakeColor, i);
                    DrawFood(canvas);
                }
            }
            else
            {
                var gameOver = "Oops! You ate yourself.\n" +
                               "Your final score is: " + Settings.Score;

                lblGameOver.ForeColor = Color.Red;
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void DrawFood(Graphics canvas)
        {
            canvas.FillEllipse(Brushes.Red,
                new Rectangle(_food.X * Settings.Width,
                    _food.Y * Settings.Height, Settings.Width, Settings.Height));
        }

        private void DrawSnakeBodyHead(Graphics canvas, Brush snakeColor, int i)
        {
            canvas.FillRectangle(snakeColor,
                new Rectangle(_snake[i].X * Settings.Width,
                    _snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));
        }

        private void MovePlayer()
        {
            for (var i = _snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    var maxXPos = pbCanvas.Size.Width / Settings.Width;
                    var maxYPos = pbCanvas.Size.Height / Settings.Height;

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

                    if (_snake[i].X < 0)
                        _snake[i].X = maxXPos;

                    if (_snake[i].Y < 0)
                        _snake[i].Y = maxYPos;

                    if (_snake[i].X > maxXPos)
                        _snake[i].X = 0;

                    if (_snake[i].Y > maxYPos)
                        _snake[i].Y = 0;

//                    if (CollideWithBorders(i, maxXPos, maxYPos))
//                        Die();

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

        private bool CollideWithFood()
        {
            return _snake[0].X == _food.X && 
                   _snake[0].Y == _food.Y;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            var circle = new Shape
            {
                X = _snake[_snake.Count - 1].X,
                Y = _snake[_snake.Count - 1].Y
            };

            _snake.Add(circle);

            Settings.Score += Settings.Points;
            Settings.Speed += 1;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
            StartGameBtn.Enabled = true;
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            StartGameBtn.Enabled = false;
            PlayersListBox.Enabled = false;
            PlayerNameTxtBox.Enabled = false;
            pbCanvas.Enabled = true;
            
            StartGame();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            var player = PlayerNameTxtBox.Text;
            PlayersListBox.Items.Add(player);

            ConnectBtn.Enabled = false;
        }
    }
}