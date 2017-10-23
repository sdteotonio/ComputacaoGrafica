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
    class DrawLine : Draw
    {
        private double x0, x1, y0, y1;

        public void Draw(Point2D startPoint, Point2D endPoint, Color color)
        {
            this.color = color;
            x0 = startPoint.X;
            y0 = startPoint.Y;

            x1 = endPoint.X;
            y1 = endPoint.Y;

            double dx = x1 - x0;
            double dy = y1 - y0;

            double incl = 0;

            if (dx < 0)
            {
                Draw(endPoint, startPoint, color);
                return;
            }

            if (dy < 0)
            {
                incl = -1;
            }
            else
            {
                incl = 1;
            }
            //Definicao do D inicial
            double  d;

            //Ponto auxiliaar
            double[] auxPoint = { x0, y0 };

            SetPixel(auxPoint[0], auxPoint[1]);
            if (dx >= incl * dy) //M <= 1
            {
                if (dy < 0) // Y2 < Y1
                {
                    d = 2 * dy + dx;
                    while (auxPoint[0] < x1)
                    {
                        if (d < 0)
                        {
                            d += 2 * (dy + dx);
                            auxPoint[0]++;
                            auxPoint[1]--;
                        }
                        else
                        {
                            d += 2 * dy;
                            auxPoint[0]++;
                        }
                        SetPixel(auxPoint[0], auxPoint[1]);
                    }
                }
                else // Y1 < Y2
                {
                    d = 2 * dy - dx;
                    while (auxPoint[0] < x1)
                    {
                        if (d < 0)
                        {
                            d += 2 * dy;
                            auxPoint[0]++;
                        }
                        else
                        {
                            d += 2 * (dy - dx);
                            auxPoint[0]++;
                            auxPoint[1]++;
                        }
                        SetPixel(auxPoint[0], auxPoint[1]);
                    }
                }
            }
            else // M > 1
            {
                if (dy < 0) // Y2 < Y1
                {
                    d = dy + 2 * dx;
                    while (auxPoint[1] > y1)
                    {
                        if (d < 0)
                        {
                            d += 2 * dx;
                            auxPoint[1]--;
                        }
                        else
                        {
                            d += 2 * (dy + dx);
                            auxPoint[0]++;
                            auxPoint[1]--;
                        }
                        SetPixel(auxPoint[0], auxPoint[1]);
                    }
                }
                else // Y1 < Y2
                {
                    d = dy - 2 * dx;
                    while (auxPoint[1] < y1)
                    {
                        if (d < 0)
                        {
                            d += 2 * (dy - dx);
                            auxPoint[0]++;
                            auxPoint[1]++;
                        }
                        else
                        {
                            d += -2 * dx;
                            auxPoint[1]++;
                        }
                        SetPixel(auxPoint[0], auxPoint[1]);
                    }
                }
            }
            SetPixel(auxPoint[0], auxPoint[1]);


        }
        private void SetPixel(double tempX, double tempY)
        {
            bitmap.SetPixel(normalize.GetPointNormalized(tempX, (tempY * -1))[0], normalize.GetPointNormalized(tempX, (tempY * -1))[1], color);
        }
    }
}
