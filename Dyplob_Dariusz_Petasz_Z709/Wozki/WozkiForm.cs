using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyplom_Dariusz_Petasz_Z709.Wozki
{
    public partial class WozkiForm : Form
    {
        RysujWozek tmp = new RysujWozek();
        Graphics g;
        StanWypWozki stanWyp = new Wypelnienie1();
        float x1 = 20.00f, x2 = 20.00f, x3 = 20.00f, x4 = 20.00f;
        public WozkiForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            stanWyp.Wypelnienie(tmp);
            tmp.Zascenie(g);
            tmp.Scena(g);
            tmp.Wozek1(g, x1);
            tmp.Wozek2(g, x2);
            tmp.Wozek3(g, x3);
            tmp.Wozek4(g, x4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1+=0.55f;
            
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x1 -= 0.55f;
            
            pictureBox1.Invalidate();
        }

        
    }
}
