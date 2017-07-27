namespace CaminoServer
{
    partial class UCUnit
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
            this.PBUnit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // PBUnit
            // 
            this.PBUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBUnit.Location = new System.Drawing.Point(0, 0);
            this.PBUnit.Margin = new System.Windows.Forms.Padding(0);
            this.PBUnit.Name = "PBUnit";
            this.PBUnit.Size = new System.Drawing.Size(200, 324);
            this.PBUnit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBUnit.TabIndex = 0;
            this.PBUnit.TabStop = false;
            this.PBUnit.Click += new System.EventHandler(this.PBUnit_Click);
            // 
            // UCUnit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PBUnit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCUnit";
            this.Size = new System.Drawing.Size(200, 324);
            ((System.ComponentModel.ISupportInitialize)(this.PBUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBUnit;
    }
}
