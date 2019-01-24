namespace Snake
{
    partial class Canvas
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Enabled = false;
            this.pbCanvas.Location = new System.Drawing.Point(17, 16);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1156, 518);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1270, 538);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 46);
            this.lblScore.TabIndex = 2;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.UpdateScreen);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(360, 216);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(253, 46);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "lblGameOver";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.UpdateScreen);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1213, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connected Players";
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.ItemHeight = 16;
            this.PlayerListBox.Location = new System.Drawing.Point(1193, 48);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(232, 484);
            this.PlayerListBox.TabIndex = 4;
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameBtn.Location = new System.Drawing.Point(215, 541);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(175, 40);
            this.StartGameBtn.TabIndex = 7;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.Location = new System.Drawing.Point(17, 541);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(192, 41);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1449, 595);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerListBox);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Canvas";
            this.Text = "Snake Multiplayer";
            this.Load += new System.EventHandler(this.UpdateScreen);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCanvas_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox PlayerListBox;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button ConnectBtn;
    }
}

