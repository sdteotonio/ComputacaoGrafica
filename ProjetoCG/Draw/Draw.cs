using ProjetoCG.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG.Draw
{
    abstract class Draw
    {
        protected PictureBox pictureBox;
        protected Normalize normalize;
        protected Color color;
        public Bitmap bitmap { get; set; }

        public Draw(PictureBox pictureBox) {
            this.pictureBox = pictureBox;
            this.normalize = new Normalize(pictureBox);
            this.bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        }
    }
}
