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
    class DrawPixel
    {
        public Bitmap bitmap { get; set; }
        private PictureBox pictureBox;
        private Color color;


        public DrawPixel(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void Draw(double positionX, double positionY, Color color)
        {

            this.color = color;

            double[] windowMaxsSize = { pictureBox.Width, pictureBox.Height };

            Normalize normalize = new Normalize(pictureBox);

            drawPixel(normalize.getPointNormalized(positionX, -positionY));
        }
        private void drawPixel(int[] normalizedPoint)
        {
            Bitmap img = bitmap;
            img.SetPixel(normalizedPoint[0], normalizedPoint[1], color);
            pictureBox.Image = img;

        }


    }
}
