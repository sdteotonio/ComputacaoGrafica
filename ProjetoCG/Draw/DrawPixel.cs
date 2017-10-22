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
    class DrawPixel : Draw
    {

        public void Draw(double positionX, double positionY, Color color)
        {
            this.color = color;
       
            bitmap.SetPixel(normalize.GetPointNormalized(positionX, -positionY)[0], normalize.GetPointNormalized(positionX, -positionY)[1], color);
        }
    }
}
