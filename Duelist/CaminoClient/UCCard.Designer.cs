namespace CaminoClient
{
    partial class UCCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).BeginInit();
            this.SuspendLayout();
            // 
            // PBMain
            // 
            this.PBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBMain.Location = new System.Drawing.Point(0, 0);
            this.PBMain.Name = "PBMain";
            this.PBMain.Size = new System.Drawing.Size(200, 324);
            this.PBMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBMain.TabIndex = 0;
            this.PBMain.TabStop = false;
            this.PBMain.Click += new System.EventHandler(this.PBMain_Click);
            // 
            // UCCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PBMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(200, 324);
            ((System.ComponentModel.ISupportInitialize)(this.PBMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBMain;
    }
}
