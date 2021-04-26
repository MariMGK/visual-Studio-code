using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new PointF(0, this.Height), new PointF(this.Width, this.Height), Color.SlateBlue, Color.White), this.ClientRectangle);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
