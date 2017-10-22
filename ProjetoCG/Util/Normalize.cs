using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG.Util
{
    class Normalize
    {

        double ndcx, ndcy, dcx, dcy, maxX, minX, maxY, minY;
        private double[] window;
        public PictureBox environment = Principal.myPicturebox;
        public Normalize()
        {
            double[] windowReceive = { environment.Width, environment.Height };
            this.window = windowReceive;
            this.maxX = (environment.Width / 2);
            this.minX = -(environment.Width / 2);
            this.maxY = (environment.Height / 2);
            this.minY = -(environment.Height / 2);


        }

        public int[] GetPointNormalized(double x, double y)
        {
            userToNdc(x, y);
            int[] positionNormal = { 0, 0 };
            positionNormal[0] = Convert.ToInt32(dcx);
            positionNormal[1] = Convert.ToInt32(dcy);
            return positionNormal;
        }

        private void userToNdc(double worldX, double worldY)
        {
            ndcy = ((worldY - minY) / (maxY - minY));
            ndcx = ((worldX - minX) / (maxX - minX));

            // Console.WriteLine("ndcx = " + ndcx);
            // Console.WriteLine("ndcy = " + ndcy);

            ndcToDc(ndcx, ndcy);
        }

        public void ndcToDc(double ndcx, double ndcy)
        {
            dcx = Math.Round((window[0] - 1) * ndcx);
            //Console.WriteLine("dcx = " + dcx);

            dcy = Math.Round((window[1] - 1) * ndcy);
            //Console.WriteLine("dcy = " + dcy);

        }


    }
}
