namespace Snake
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OnlinePlayersLabel = new System.Windows.Forms.Label();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ServerIpTextbox = new System.Windows.Forms.TextBox();
            this.ServerIpLabel = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.OnlinePlayers = new System.Windows.Forms.RichTextBox();
            this.SnakePicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnakePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // OnlinePlayersLabel
            // 
            this.OnlinePlayersLabel.AutoSize = true;
            this.OnlinePlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlinePlayersLabel.Location = new System.Drawing.Point(11, 9);
            this.OnlinePlayersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OnlinePlayersLabel.Name = "OnlinePlayersLabel";
            this.OnlinePlayersLabel.Size = new System.Drawing.Size(123, 20);
            this.OnlinePlayersLabel.TabIndex = 5;
            this.OnlinePlayersLabel.Text = "Online Players";
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Enabled = false;
            this.StartGameBtn.Location = new System.Drawing.Point(191, 340);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(195, 23);
            this.StartGameBtn.TabIndex = 6;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(191, 311);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(89, 23);
            this.ConnectBtn.TabIndex = 7;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(286, 311);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 23);
            this.DisconnectBtn.TabIndex = 8;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ServerIpTextbox
            // 
            this.ServerIpTextbox.Location = new System.Drawing.Point(286, 206);
            this.ServerIpTextbox.Name = "ServerIpTextbox";
            this.ServerIpTextbox.Size = new System.Drawing.Size(100, 20);
            this.ServerIpTextbox.TabIndex = 9;
            // 
            // ServerIpLabel
            // 
            this.ServerIpLabel.AutoSize = true;
            this.ServerIpLabel.Location = new System.Drawing.Point(188, 210);
            this.ServerIpLabel.Name = "ServerIpLabel";
            this.ServerIpLabel.Size = new System.Drawing.Size(92, 13);
            this.ServerIpLabel.TabIndex = 10;
            this.ServerIpLabel.Text = "Server IP Address";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(286, 276);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.UsernameTextbox.TabIndex = 11;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(217, 280);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(63, 13);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "Username";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(254, 245);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 13;
            this.PortLabel.Text = "Port";
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(286, 241);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(100, 20);
            this.PortTextbox.TabIndex = 14;
            // 
            // OnlinePlayers
            // 
            this.OnlinePlayers.Enabled = false;
            this.OnlinePlayers.Location = new System.Drawing.Point(15, 44);
            this.OnlinePlayers.Name = "OnlinePlayers";
            this.OnlinePlayers.ReadOnly = true;
            this.OnlinePlayers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OnlinePlayers.Size = new System.Drawing.Size(167, 319);
            this.OnlinePlayers.TabIndex = 15;
            this.OnlinePlayers.Text = "";
            // 
            // SnakePicturebox
            // 
            this.SnakePicturebox.Image = global::Snake.Properties.Resources.snake;
            this.SnakePicturebox.Location = new System.Drawing.Point(191, 44);
            this.SnakePicturebox.Name = "SnakePicturebox";
            this.SnakePicturebox.Size = new System.Drawing.Size(195, 150);
            this.SnakePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SnakePicturebox.TabIndex = 16;
            this.SnakePicturebox.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 375);
            this.Controls.Add(this.SnakePicturebox);
            this.Controls.Add(this.OnlinePlayers);
            this.Controls.Add(this.PortTextbox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.ServerIpLabel);
            this.Controls.Add(this.ServerIpTextbox);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.OnlinePlayersLabel);
            this.Name = "ClientForm";
            this.Text = "Snake Multiplayer Client";
            ((System.ComponentModel.ISupportInitialize)(this.SnakePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OnlinePlayersLabel;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.TextBox ServerIpTextbox;
        private System.Windows.Forms.Label ServerIpLabel;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.RichTextBox OnlinePlayers;
        private System.Windows.Forms.PictureBox SnakePicturebox;
    }
}

