using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent(); 
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            AddPlayer(UsernameTextbox.Text, GetRandomColor());

            ConnectBtn.Enabled = false;
            DisconnectBtn.Enabled = true;
            OnlinePlayers.Enabled = true;
            ServerIpTextbox.Enabled = false;
            PortTextbox.Enabled = false;
            UsernameTextbox.Enabled = false;
            StartGameBtn.Enabled = true;
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            OnlinePlayers.Clear();
            DisconnectBtn.Enabled = false;
            ConnectBtn.Enabled = true;
            ServerIpTextbox.Enabled = true;
            PortTextbox.Enabled = true;
            UsernameTextbox.Enabled = true;
            StartGameBtn.Enabled = false;
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm();

            gameForm.Show();
            gameForm.Activate();
        }

        private void AddPlayer(string text, Color color)
        {
            OnlinePlayers.SelectionStart = OnlinePlayers.TextLength;
            OnlinePlayers.SelectionLength = 0;

            OnlinePlayers.SelectionColor = color;
            OnlinePlayers.AppendText(text);
            OnlinePlayers.SelectionColor = OnlinePlayers.ForeColor;

            OnlinePlayers.AppendText(Environment.NewLine);
        }

        private Color GetRandomColor()
        {
            var random = new Random();
            var randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            return randomColor;
        }

    }
}