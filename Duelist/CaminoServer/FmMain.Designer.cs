namespace CaminoServer
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
            this.LStatus = new System.Windows.Forms.Label();
            this.LPlayer2Info = new System.Windows.Forms.Label();
            this.LPlayer1Info = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FLPUnitsPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPHandPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPHandPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPUnitsPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LHealthPlayer1 = new System.Windows.Forms.Label();
            this.LManaPlayer1 = new System.Windows.Forms.Label();
            this.LCardPlayer1 = new System.Windows.Forms.Label();
            this.PBAvatarPlayer1 = new System.Windows.Forms.PictureBox();
            this.PBSpellPlayer1 = new System.Windows.Forms.PictureBox();
            this.PBAvatarPlayer2 = new System.Windows.Forms.PictureBox();
            this.PBSpellPlayer2 = new System.Windows.Forms.PictureBox();
            this.LCardPlayer2 = new System.Windows.Forms.Label();
            this.LManaPlayer2 = new System.Windows.Forms.Label();
            this.LHealthPlayer2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSpellPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSpellPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.BackColor = System.Drawing.Color.Transparent;
            this.LStatus.Location = new System.Drawing.Point(781, 527);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(318, 24);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "Waiting for player 1 to connect";
            // 
            // LPlayer2Info
            // 
            this.LPlayer2Info.AutoSize = true;
            this.LPlayer2Info.BackColor = System.Drawing.Color.Transparent;
            this.LPlayer2Info.Location = new System.Drawing.Point(243, 9);
            this.LPlayer2Info.Name = "LPlayer2Info";
            this.LPlayer2Info.Size = new System.Drawing.Size(91, 24);
            this.LPlayer2Info.TabIndex = 1;
            this.LPlayer2Info.Text = "Player 2";
            // 
            // LPlayer1Info
            // 
            this.LPlayer1Info.AutoSize = true;
            this.LPlayer1Info.BackColor = System.Drawing.Color.Transparent;
            this.LPlayer1Info.Location = new System.Drawing.Point(1523, 859);
            this.LPlayer1Info.Name = "LPlayer1Info";
            this.LPlayer1Info.Size = new System.Drawing.Size(91, 24);
            this.LPlayer1Info.TabIndex = 2;
            this.LPlayer1Info.Text = "Player 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FLPHandPlayer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.FLPUnitsPlayer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 570);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1520, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.FLPUnitsPlayer2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FLPHandPlayer2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(400, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1520, 450);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // FLPUnitsPlayer1
            // 
            this.FLPUnitsPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPUnitsPlayer1.Location = new System.Drawing.Point(3, 3);
            this.FLPUnitsPlayer1.Name = "FLPUnitsPlayer1";
            this.FLPUnitsPlayer1.Size = new System.Drawing.Size(1514, 344);
            this.FLPUnitsPlayer1.TabIndex = 0;
            this.FLPUnitsPlayer1.WrapContents = false;
            // 
            // FLPHandPlayer1
            // 
            this.FLPHandPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPHandPlayer1.Location = new System.Drawing.Point(3, 353);
            this.FLPHandPlayer1.Name = "FLPHandPlayer1";
            this.FLPHandPlayer1.Size = new System.Drawing.Size(1514, 94);
            this.FLPHandPlayer1.TabIndex = 1;
            this.FLPHandPlayer1.WrapContents = false;
            // 
            // FLPHandPlayer2
            // 
            this.FLPHandPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPHandPlayer2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLPHandPlayer2.Location = new System.Drawing.Point(3, 3);
            this.FLPHandPlayer2.Name = "FLPHandPlayer2";
            this.FLPHandPlayer2.Size = new System.Drawing.Size(1514, 94);
            this.FLPHandPlayer2.TabIndex = 1;
            this.FLPHandPlayer2.WrapContents = false;
            // 
            // FLPUnitsPlayer2
            // 
            this.FLPUnitsPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLPUnitsPlayer2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLPUnitsPlayer2.Location = new System.Drawing.Point(3, 103);
            this.FLPUnitsPlayer2.Name = "FLPUnitsPlayer2";
            this.FLPUnitsPlayer2.Size = new System.Drawing.Size(1514, 344);
            this.FLPUnitsPlayer2.TabIndex = 2;
            this.FLPUnitsPlayer2.WrapContents = false;
            // 
            // LHealthPlayer1
            // 
            this.LHealthPlayer1.AutoSize = true;
            this.LHealthPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LHealthPlayer1.Location = new System.Drawing.Point(1523, 893);
            this.LHealthPlayer1.Name = "LHealthPlayer1";
            this.LHealthPlayer1.Size = new System.Drawing.Size(76, 24);
            this.LHealthPlayer1.TabIndex = 5;
            this.LHealthPlayer1.Text = "HP: 30";
            // 
            // LManaPlayer1
            // 
            this.LManaPlayer1.AutoSize = true;
            this.LManaPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LManaPlayer1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LManaPlayer1.Location = new System.Drawing.Point(1523, 929);
            this.LManaPlayer1.Name = "LManaPlayer1";
            this.LManaPlayer1.Size = new System.Drawing.Size(83, 24);
            this.LManaPlayer1.TabIndex = 6;
            this.LManaPlayer1.Text = "MP: 0/0";
            // 
            // LCardPlayer1
            // 
            this.LCardPlayer1.AutoSize = true;
            this.LCardPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LCardPlayer1.ForeColor = System.Drawing.Color.Gold;
            this.LCardPlayer1.Location = new System.Drawing.Point(1523, 969);
            this.LCardPlayer1.Name = "LCardPlayer1";
            this.LCardPlayer1.Size = new System.Drawing.Size(102, 24);
            this.LCardPlayer1.TabIndex = 7;
            this.LCardPlayer1.Text = "Card: 0/0";
            // 
            // PBAvatarPlayer1
            // 
            this.PBAvatarPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PBAvatarPlayer1.Location = new System.Drawing.Point(1652, 780);
            this.PBAvatarPlayer1.Name = "PBAvatarPlayer1";
            this.PBAvatarPlayer1.Size = new System.Drawing.Size(240, 240);
            this.PBAvatarPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAvatarPlayer1.TabIndex = 8;
            this.PBAvatarPlayer1.TabStop = false;
            this.PBAvatarPlayer1.Click += new System.EventHandler(this.PBAvatarPlayer1_Click);
            // 
            // PBSpellPlayer1
            // 
            this.PBSpellPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.PBSpellPlayer1.Location = new System.Drawing.Point(1652, 453);
            this.PBSpellPlayer1.Name = "PBSpellPlayer1";
            this.PBSpellPlayer1.Size = new System.Drawing.Size(240, 311);
            this.PBSpellPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSpellPlayer1.TabIndex = 9;
            this.PBSpellPlayer1.TabStop = false;
            this.PBSpellPlayer1.Visible = false;
            this.PBSpellPlayer1.Click += new System.EventHandler(this.PBSpellPlayer1_Click);
            // 
            // PBAvatarPlayer2
            // 
            this.PBAvatarPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PBAvatarPlayer2.Location = new System.Drawing.Point(0, 0);
            this.PBAvatarPlayer2.Margin = new System.Windows.Forms.Padding(0);
            this.PBAvatarPlayer2.Name = "PBAvatarPlayer2";
            this.PBAvatarPlayer2.Size = new System.Drawing.Size(240, 240);
            this.PBAvatarPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAvatarPlayer2.TabIndex = 10;
            this.PBAvatarPlayer2.TabStop = false;
            this.PBAvatarPlayer2.Click += new System.EventHandler(this.PBAvatarPlayer2_Click);
            // 
            // PBSpellPlayer2
            // 
            this.PBSpellPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.PBSpellPlayer2.Location = new System.Drawing.Point(0, 248);
            this.PBSpellPlayer2.Name = "PBSpellPlayer2";
            this.PBSpellPlayer2.Size = new System.Drawing.Size(240, 311);
            this.PBSpellPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSpellPlayer2.TabIndex = 11;
            this.PBSpellPlayer2.TabStop = false;
            this.PBSpellPlayer2.Visible = false;
            this.PBSpellPlayer2.Click += new System.EventHandler(this.PBSpellPlayer2_Click);
            // 
            // LCardPlayer2
            // 
            this.LCardPlayer2.AutoSize = true;
            this.LCardPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LCardPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.LCardPlayer2.Location = new System.Drawing.Point(243, 117);
            this.LCardPlayer2.Name = "LCardPlayer2";
            this.LCardPlayer2.Size = new System.Drawing.Size(102, 24);
            this.LCardPlayer2.TabIndex = 14;
            this.LCardPlayer2.Text = "Card: 0/0";
            // 
            // LManaPlayer2
            // 
            this.LManaPlayer2.AutoSize = true;
            this.LManaPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LManaPlayer2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LManaPlayer2.Location = new System.Drawing.Point(243, 77);
            this.LManaPlayer2.Name = "LManaPlayer2";
            this.LManaPlayer2.Size = new System.Drawing.Size(83, 24);
            this.LManaPlayer2.TabIndex = 13;
            this.LManaPlayer2.Text = "MP: 0/0";
            // 
            // LHealthPlayer2
            // 
            this.LHealthPlayer2.AutoSize = true;
            this.LHealthPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LHealthPlayer2.Location = new System.Drawing.Point(243, 41);
            this.LHealthPlayer2.Name = "LHealthPlayer2";
            this.LHealthPlayer2.Size = new System.Drawing.Size(76, 24);
            this.LHealthPlayer2.TabIndex = 12;
            this.LHealthPlayer2.Text = "HP: 30";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LCardPlayer2);
            this.Controls.Add(this.LManaPlayer2);
            this.Controls.Add(this.LHealthPlayer2);
            this.Controls.Add(this.PBSpellPlayer2);
            this.Controls.Add(this.PBAvatarPlayer2);
            this.Controls.Add(this.PBSpellPlayer1);
            this.Controls.Add(this.PBAvatarPlayer1);
            this.Controls.Add(this.LCardPlayer1);
            this.Controls.Add(this.LManaPlayer1);
            this.Controls.Add(this.LHealthPlayer1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LPlayer1Info);
            this.Controls.Add(this.LPlayer2Info);
            this.Controls.Add(this.LStatus);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FmMain";
            this.Text = "Camino Demo - Duelist";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSpellPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAvatarPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSpellPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LPlayer2Info;
        private System.Windows.Forms.Label LPlayer1Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel FLPHandPlayer1;
        private System.Windows.Forms.FlowLayoutPanel FLPUnitsPlayer1;
        private System.Windows.Forms.FlowLayoutPanel FLPUnitsPlayer2;
        private System.Windows.Forms.FlowLayoutPanel FLPHandPlayer2;
        private System.Windows.Forms.Label LHealthPlayer1;
        private System.Windows.Forms.Label LManaPlayer1;
        private System.Windows.Forms.Label LCardPlayer1;
        private System.Windows.Forms.PictureBox PBAvatarPlayer1;
        private System.Windows.Forms.PictureBox PBSpellPlayer1;
        private System.Windows.Forms.PictureBox PBAvatarPlayer2;
        private System.Windows.Forms.PictureBox PBSpellPlayer2;
        private System.Windows.Forms.Label LCardPlayer2;
        private System.Windows.Forms.Label LManaPlayer2;
        private System.Windows.Forms.Label LHealthPlayer2;
    }
}

