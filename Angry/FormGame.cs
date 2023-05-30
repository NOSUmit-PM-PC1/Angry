using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry
{
    public partial class FormGame : Form
    {
        Graphics gr;
        public FormGame()
        {
            InitializeComponent();
            gr = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FormGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GameHeroXY h = new GameHeroXY(gr, e.X, e.Y);
                h.Show();
            }
            else
            {
                GameHeroXYPicture t = new GameHeroXYPicture(this, "images/angry.png", e.X, e.Y);
                this.Controls.Add(t);
            }
        }
    }
}
