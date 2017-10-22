using ProjetoCG.Draw;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG.Objects
{
    class DrawObject
    {
        public static void DrawTriangle(Triangle t, Bitmap actualBitmap, Color color) {
            DrawLine drawline = new DrawLine();
            drawline.bitmap = actualBitmap;
            // Draw 1 linha
            drawline.Draw(new double[] { t.FirstPoint.X, t.FirstPoint.Y }, new double[] { t.SecondPoint.X, t.SecondPoint.Y }, color);
            // Draw 2 linha 
            drawline.Draw(new double[] { t.SecondPoint.X, t.SecondPoint.Y }, new double[] { t.ThirdPoint.X, t.ThirdPoint.Y }, color);
            // Draw 3 linha
            drawline.Draw(new double[] { t.ThirdPoint.X, t.ThirdPoint.Y }, new double[] { t.FirstPoint.X, t.FirstPoint.Y }, color);
        }
    }
}
