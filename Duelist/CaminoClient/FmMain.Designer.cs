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
            this.LCardPlayer2 = new System.Windows.Forms.Label();
            this.LManaPlayer2 = new System.Windows.Forms.Label();
            this.LHealthPlayer2 = new System.Windows.Forms.Label();
            this.PBAvatarPlayer2 = new System.Windows.Forms.PictureBox();
            this.LPlayer2Info = new System.Windows.Forms.Label();
            this.PBAvatarPlayer1 = new System.Windows.Forms.PictureBox();
            this.LCardPlayer1 = new System.Windows.Forms.Label();
            this.LManaPlayer1 = new System.Windows.Forms.Label();
            this.LHealthPlayer1 = new System.Windows.Forms.Label();
            this.LPlayer1Info = new System.Windows.Forms.Label();
            this.FLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.PBButton = new System.Windows.Forms.PictureBox();
            this.LButtonDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBButton)).BeginInit();
            this.SuspendLayout();
            // 
            // LPlayerName
            // 
            this.LPlayerName.AutoSize = true;
            this.LPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.LPlayerName.Location = new System.Drawing.Point(855, 73);
            this.LPlayerName.Name = "LPlayerName";
            this.LPlayerName.Size = new System.Drawing.Size(176, 24);
            this.LPlayerName.TabIndex = 0;
            this.LPlayerName.Text = "Unknown Player";
            this.LPlayerName.Visible = false;
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.BackColor = System.Drawing.Color.Transparent;
            this.LStatus.Location = new System.Drawing.Point(841, 173);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(218, 24);
            this.LStatus.TabIndex = 1;
            this.LStatus.Text = "Awaiting connection";
            // 
            // BtJoinGame
            // 
            this.BtJoinGame.BackColor = System.Drawing.Color.Transparent;
            this.BtJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtJoinGame.Location = new System.Drawing.Point(895, 12);
            this.BtJoinGame.Name = "BtJoinGame";
            this.BtJoinGame.Size = new System.Drawing.Size(95, 38);
            this.BtJoinGame.TabIndex = 2;
            this.BtJoinGame.Text = "Start";
            this.BtJoinGame.UseVisualStyleBackColor = false;
            this.BtJoinGame.Click += new System.EventHandler(this.BtJoinGame_Click);
            // 
            // LCardPlayer2
            // 
            this.LCardPlayer2.AutoSize = true;
            this.LCardPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LCardPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.LCardPlayer2.Location = new System.Drawing.Point(252, 126);
            this.LCardPlayer2.Name = "LCardPlayer2";
            this.LCardPlayer2.Size = new System.Drawing.Size(102, 24);
            this.LCardPlayer2.TabIndex = 19;
            this.LCardPlayer2.Text = "Card: 0/0";
            // 
            // LManaPlayer2
            // 
            this.LManaPlayer2.AutoSize = true;
            this.LManaPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LManaPlayer2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LManaPlayer2.Location = new System.Drawing.Point(252, 86);
            this.LManaPlayer2.Name = "LManaPlayer2";
            this.LManaPlayer2.Size = new System.Drawing.Size(83, 24);
            this.LManaPlayer2.TabIndex = 18;
            this.LManaPlayer2.Text = "MP: 0/0";
            // 
            // LHealthPlayer2
            // 
            this.LHealthPlayer2.AutoSize = true;
            this.LHealthPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LHealthPlayer2.Location = new System.Drawing.Point(252, 50);
            this.LHealthPlayer2.Name = "LHealthPlayer2";
            this.LHealthPlayer2.Size = new System.Drawing.Size(76, 24);
            this.LHealthPlayer2.TabIndex = 17;
            this.LHealthPlayer2.Text = "HP: 30";
            // 
            // PBAvatarPlayer2
            // 
            this.PBAvatarPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PBAvatarPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("PBAvatarPlayer2.Image")));
            this.PBAvatarPlayer2.Location = new System.Drawing.Point(9, 9);
            this.PBAvatarPlayer2.Margin = new System.Windows.Forms.Padding(0);
            this.PBAvatarPlayer2.Name = "PBAvatarPlayer2";
            this.PBAvatarPlayer2.Size = new System.Drawing.Size(240, 240);
            this.PBAvatarPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAvatarPlayer2.TabIndex = 16;
            this.PBAvatarPlayer2.TabStop = false;
            // 
            // LPlayer2Info
            // 
            this.LPlayer2Info.AutoSize = true;
            this.LPlayer2Info.BackColor = System.Drawing.Color.Transparent;
            this.LPlayer2Info.Location = new System.Drawing.Point(252, 18);
            this.LPlayer2Info.Name = "LPlayer2Info";
            this.LPlayer2Info.Size = new System.Drawing.Size(91, 24);
            this.LPlayer2Info.TabIndex = 15;
            this.LPlayer2Info.Text = "Player 2";
            // 
            // PBAvatarPlayer1
            // 
            this.PBAvatarPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PBAvatarPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("PBAvatarPlayer1.Image")));
            this.PBAvatarPlayer1.Location = new System.Drawing.Point(1652, 9);
            this.PBAvatarPlayer1.Name = "PBAvatarPlayer1";
            this.PBAvatarPlayer1.Size = new System.Drawing.Size(240, 240);
            this.PBAvatarPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAvatarPlayer1.TabIndex = 24;
            this.PBAvatarPlayer1.TabStop = false;
            // 
            // LCardPlayer1
            // 
            this.LCardPlayer1.AutoSize = true;
            this.LCardPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LCardPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.LCardPlayer1.Location = new System.Drawing.Point(1517, 129);
            this.LCardPlayer1.Name = "LCardPlayer1";
            this.LCardPlayer1.Size = new System.Drawing.Size(102, 24);
            this.LCardPlayer1.TabIndex = 23;
            this.LCardPlayer1.Text = "Card: 0/0";
            // 
            // LManaPlayer1
            // 
            this.LManaPlayer1.AutoSize = true;
            this.LManaPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LManaPlayer1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LManaPlayer1.Location = new System.Drawing.Point(1517, 89);
            this.LManaPlayer1.Name = "LManaPlayer1";
            this.LManaPlayer1.Size = new System.Drawing.Size(83, 24);
            this.LManaPlayer1.TabIndex = 22;
            this.LManaPlayer1.Text = "MP: 0/0";
            // 
            // LHealthPlayer1
            // 
            this.LHealthPlayer1.AutoSize = true;
            this.LHealthPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LHealthPlayer1.Location = new System.Drawing.Point(1517, 53);
            this.LHealthPlayer1.Name = "LHealthPlayer1";
            this.LHealthPlayer1.Size = new System.Drawing.Size(76, 24);
            this.LHealthPlayer1.TabIndex = 21;
            this.LHealthPlayer1.Text = "HP: 30";
            // 
            // LPlayer1Info
            // 
            this.LPlayer1Info.AutoSize = true;
            this.LPlayer1Info.BackColor = System.Drawing.Color.Transparent;
            this.LPlayer1Info.Location = new System.Drawing.Point(1517, 19);
            this.LPlayer1Info.Name = "LPlayer1Info";
            this.LPlayer1Info.Size = new System.Drawing.Size(91, 24);
            this.LPlayer1Info.TabIndex = 20;
            this.LPlayer1Info.Text = "Player 1";
            // 
            // FLPMain
            // 
            this.FLPMain.BackColor = System.Drawing.Color.Transparent;
            this.FLPMain.Location = new System.Drawing.Point(13, 264);
            this.FLPMain.Name = "FLPMain";
            this.FLPMain.Size = new System.Drawing.Size(1640, 697);
            this.FLPMain.TabIndex = 25;
            // 
            // PBButton
            // 
            this.PBButton.BackColor = System.Drawing.Color.Transparent;
            this.PBButton.Image = ((System.Drawing.Image)(resources.GetObject("PBButton.Image")));
            this.PBButton.Location = new System.Drawing.Point(1659, 264);
            this.PBButton.Name = "PBButton";
            this.PBButton.Size = new System.Drawing.Size(233, 350);
            this.PBButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBButton.TabIndex = 26;
            this.PBButton.TabStop = false;
            this.PBButton.Click += new System.EventHandler(this.PBButton_Click);
            // 
            // LButtonDesc
            // 
            this.LButtonDesc.AutoSize = true;
            this.LButtonDesc.BackColor = System.Drawing.Color.Transparent;
            this.LButtonDesc.Location = new System.Drawing.Point(1655, 617);
            this.LButtonDesc.Name = "LButtonDesc";
            this.LButtonDesc.Size = new System.Drawing.Size(181, 24);
            this.LButtonDesc.TabIndex = 27;
            this.LButtonDesc.Text = "Setting Up Game";
            this.LButtonDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LButtonDesc);
            this.Controls.Add(this.PBButton);
            this.Controls.Add(this.FLPMain);
            this.Controls.Add(this.PBAvatarPlayer1);
            this.Controls.Add(this.LCardPlayer1);
            this.Controls.Add(this.LManaPlayer1);
            this.Controls.Add(this.LHealthPlayer1);
            this.Controls.Add(this.LPlayer1Info);
            this.Controls.Add(this.LCardPlayer2);
            this.Controls.Add(this.LManaPlayer2);
            this.Controls.Add(this.LHealthPlayer2);
            this.Controls.Add(this.PBAvatarPlayer2);
            this.Controls.Add(this.LPlayer2Info);
            this.Controls.Add(this.BtJoinGame);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LPlayerName);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPlayerName;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button BtJoinGame;
        private System.Windows.Forms.Label LCardPlayer2;
        private System.Windows.Forms.Label LManaPlayer2;
        private System.Windows.Forms.Label LHealthPlayer2;
        private System.Windows.Forms.PictureBox PBAvatarPlayer2;
        private System.Windows.Forms.Label LPlayer2Info;
        private System.Windows.Forms.PictureBox PBAvatarPlayer1;
        private System.Windows.Forms.Label LCardPlayer1;
        private System.Windows.Forms.Label LManaPlayer1;
        private System.Windows.Forms.Label LHealthPlayer1;
        private System.Windows.Forms.Label LPlayer1Info;
        private System.Windows.Forms.FlowLayoutPanel FLPMain;
        private System.Windows.Forms.PictureBox PBButton;
        private System.Windows.Forms.Label LButtonDesc;
    }
}

