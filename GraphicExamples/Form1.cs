using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Teal;
            Refresh();

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Green, 20);
            SolidBrush drawBrush = new SolidBrush(Color.Green);

            formGraphics.DrawEllipse(drawPen, 25, 25, 200, 200);
            formGraphics.FillEllipse(drawBrush, 25, 25, 200, 200);

            drawPen.Color = Color.Red;
            formGraphics.DrawArc(drawPen, 40, 65, 125, 125, 30, 300);

            drawBrush.Color = Color.White;
            Font drawFont2 = new Font("Stika Small", 45, FontStyle.Bold);
            formGraphics.DrawString ("Rams", drawFont2, drawBrush, 48, 88);
            Font drawFont3 = new Font("Stika small", 12, FontStyle.Bold);
            formGraphics.TranslateTransform(250, 80);
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("Rams Arcade", drawFont3, drawBrush, new Rectangle());
            formGraphics.ResetTransform();
        }
    }
}
