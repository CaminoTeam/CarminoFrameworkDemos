using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace CaminoServer
{
    public class RotateLabel : Label
    {
        public int Rotation { get; set; }
        public string RotateText { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.Rotation);
            e.Graphics.DrawString(this.RotateText, this.Font, b, 0f, 0f);
            base.OnPaint(e);
        }
    }
}
