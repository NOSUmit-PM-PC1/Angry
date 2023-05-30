using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry
{
    class Birds
    {
    }

    class GameHero
    {
        protected int x, y;
        int r;
        protected Graphics gr;

        public GameHero(Graphics UserGR)
        {
            x = 100;
            y = 100;
            r = 10;
            gr = UserGR;
        }

        public void Show()
        {
            gr.FillEllipse(Brushes.Red,x - r, y-r, 2*r, 2*r);
        }
    }

    class GameHeroXY: GameHero
    {
        public GameHeroXY(Graphics UserGR, int UserX, int UserY):base(UserGR)
        {
            x = UserX;
            y = UserY;
        }
    }

    class GameHeroXYPicture : PictureBox
    {
        Form owner;
        public GameHeroXYPicture(Form UserOwner, string FileName, int UserX, int UserY)
        {
            owner = UserOwner;
            this.Left = UserX;
            this.Top = UserY;
            this.Load(FileName);
            this.Width = 40;
            this.Height = 40;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
