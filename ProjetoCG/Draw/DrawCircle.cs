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
   
    class DrawCircle : Draw
    { 

        public void DrawFromCenter(double raio, Color color) {
            this.color = color;
            double x = 0;
            double y = raio;
            double d = (5 / 4) - raio;
            PlotarSimetricos(x, y);
            while (y > x)
            {
                if (d < 0) // E
                {
                    d += 2 * x + 3;
                }else // SE
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                PlotarSimetricos(x, y);
            }
        }
        /// <summary>
        /// Plotar pixels simetricos ao recebido
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void PlotarSimetricos(double x, double y) {
            this.bitmap.SetPixel(normalize.GetPointNormalized(x, y)[0], normalize.GetPointNormalized(x, y)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(y, x)[0], normalize.GetPointNormalized(y, x)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(y,-x)[0], normalize.GetPointNormalized(y, -x)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(x, -y)[0], normalize.GetPointNormalized(x, -y)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(-x, -y)[0], normalize.GetPointNormalized(-x, -y)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(-y, -x)[0], normalize.GetPointNormalized(-y, -x)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(-y, x)[0], normalize.GetPointNormalized(-y, x)[1], this.color);

            this.bitmap.SetPixel(normalize.GetPointNormalized(-x, y)[0], normalize.GetPointNormalized(-x, y)[1], this.color);

        }
    }
}
