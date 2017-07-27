namespace CaminoClient
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.LPlayerName = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.BtJoinGame = new System.Windows.Forms.Button();
            this.PBRock = new System.Windows.Forms.PictureBox();
            this.PBPaper = new System.Windows.Forms.PictureBox();
            this.PBScissors = new System.Windows.Forms.PictureBox();
            this.LScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // LPlayerName
            // 
            this.LPlayerName.AutoSize = true;
            this.LPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LPlayerName.ForeColor = System.Drawing.Color.Red;
            this.LPlayerName.Location = new System.Drawing.Point(12, 971);
            this.LPlayerName.Name = "LPlayerName";
            this.LPlayerName.Size = new System.Drawing.Size(176, 24);
            this.LPlayerName.TabIndex = 0;
            this.LPlayerName.Text = "Unknown Player";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.BackColor = System.Drawing.Color.Transparent;
            this.LStatus.ForeColor = System.Drawing.Color.Red;
            this.LStatus.Location = new System.Drawing.Point(12, 1008);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(218, 24);
            this.LStatus.TabIndex = 1;
            this.LStatus.Text = "Awaiting connection";
            // 
            // BtJoinGame
            // 
            this.BtJoinGame.BackColor = System.Drawing.Color.Red;
            this.BtJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtJoinGame.ForeColor = System.Drawing.Color.White;
            this.BtJoinGame.Location = new System.Drawing.Point(16, 916);
            this.BtJoinGame.Name = "BtJoinGame";
            this.BtJoinGame.Size = new System.Drawing.Size(172, 38);
            this.BtJoinGame.TabIndex = 2;
            this.BtJoinGame.Text = "Join Server";
            this.BtJoinGame.UseVisualStyleBackColor = false;
            this.BtJoinGame.Click += new System.EventHandler(this.BtJoinGame_Click);
            // 
            // PBRock
            // 
            this.PBRock.BackColor = System.Drawing.Color.Transparent;
            this.PBRock.Image = ((System.Drawing.Image)(resources.GetObject("PBRock.Image")));
            this.PBRock.Location = new System.Drawing.Point(300, 476);
            this.PBRock.Name = "PBRock";
            this.PBRock.Size = new System.Drawing.Size(400, 500);
            this.PBRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBRock.TabIndex = 3;
            this.PBRock.TabStop = false;
            this.PBRock.Visible = false;
            this.PBRock.Click += new System.EventHandler(this.PBRock_Click);
            // 
            // PBPaper
            // 
            this.PBPaper.BackColor = System.Drawing.Color.Transparent;
            this.PBPaper.Image = ((System.Drawing.Image)(resources.GetObject("PBPaper.Image")));
            this.PBPaper.Location = new System.Drawing.Point(779, 476);
            this.PBPaper.Name = "PBPaper";
            this.PBPaper.Size = new System.Drawing.Size(400, 500);
            this.PBPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPaper.TabIndex = 4;
            this.PBPaper.TabStop = false;
            this.PBPaper.Visible = false;
            this.PBPaper.Click += new System.EventHandler(this.PBPaper_Click);
            // 
            // PBScissors
            // 
            this.PBScissors.BackColor = System.Drawing.Color.Transparent;
            this.PBScissors.Image = ((System.Drawing.Image)(resources.GetObject("PBScissors.Image")));
            this.PBScissors.Location = new System.Drawing.Point(1241, 476);
            this.PBScissors.Name = "PBScissors";
            this.PBScissors.Size = new System.Drawing.Size(400, 500);
            this.PBScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBScissors.TabIndex = 5;
            this.PBScissors.TabStop = false;
            this.PBScissors.Visible = false;
            this.PBScissors.Click += new System.EventHandler(this.PBScissors_Click);
            // 
            // LScore
            // 
            this.LScore.AutoSize = true;
            this.LScore.BackColor = System.Drawing.Color.Transparent;
            this.LScore.ForeColor = System.Drawing.Color.Red;
            this.LScore.Location = new System.Drawing.Point(12, 9);
            this.LScore.Name = "LScore";
            this.LScore.Size = new System.Drawing.Size(94, 24);
            this.LScore.TabIndex = 6;
            this.LScore.Text = "Score: 0";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LScore);
            this.Controls.Add(this.PBScissors);
            this.Controls.Add(this.PBPaper);
            this.Controls.Add(this.PBRock);
            this.Controls.Add(this.BtJoinGame);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LPlayerName);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FmMain";
            this.Text = "Camino - RockPaperScissors Demo";
            ((System.ComponentModel.ISupportInitialize)(this.PBRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPlayerName;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BtJoinGame;
        private System.Windows.Forms.PictureBox PBRock;
        private System.Windows.Forms.PictureBox PBPaper;
        private System.Windows.Forms.PictureBox PBScissors;
        private System.Windows.Forms.Label LScore;
    }
}

