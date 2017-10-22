using ProjetoCG.Components;
using ProjetoCG.Draw;
using ProjetoCG.Objects;
using ProjetoCG.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG
{
    public partial class Principal : Form
    {
        public static PictureBox myPicturebox;
        public Bitmap mBitmap;
        public Principal()
        { 
            InitializeComponent();
            txtLarguraDeTela.Text = ("Tamamho da tela:" + pictureBox1.Width + "x" + pictureBox1.Height);
            myPicturebox = pictureBox1;
            //Iniciar com cartesiano simples
            ClearView();
        }

        private void ClearView()
        {
            mBitmap = GetBitmapwWhitCartesian();
            UpdateView();
        }

        private void UpdateView() {
            pictureBox1.Image = mBitmap;
        }
        private void DrawCircleMethod()
        {
            DrawCircle drawCircle = new DrawCircle();
            drawCircle.bitmap = mBitmap;
            drawCircle.DrawFromCenter(100, Color.Orange);
            
        }

        /// <summary>
        ///  Gerar um Bitmap com plano cartesiano
        /// </summary>
        /// <returns></returns>
        private Bitmap GetBitmapwWhitCartesian()
        {
            DrawLine drawLine = new DrawLine();
            //Desenhar Linha horizontal
            drawLine.Draw(new double[] { -(pictureBox1.Width / 2), 0 }, new double[] { (pictureBox1.Width / 2), 0 }, Color.Red);
            //Desenhar Linha Vertical
            drawLine.Draw(new double[] { 0, -(pictureBox1.Height / 2) }, new double[] { 0, (pictureBox1.Height / 2) }, Color.Red);
            return drawLine.bitmap;
        }
        /// <summary>
        /// Plotar um pixel na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            DrawPixel drawPixel = new DrawPixel();
            drawPixel.bitmap = mBitmap;
            try
            {
                drawPixel.Draw(double.Parse(textBox1.Text), double.Parse(textBox2.Text), Color.Blue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            UpdateView();


        }
        /// <summary>
        /// Desenhar uma linha em um dos octantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {

            DrawLine drawLine = new DrawLine();
            drawLine.bitmap = mBitmap;
            try
            {
                double[] startPoint = { double.Parse(px1.Text), double.Parse(py1.Text) };
                double[] endPoint = { double.Parse(px2.Text), double.Parse(py2.Text) };
                drawLine.Draw(startPoint, endPoint, Color.Blue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            UpdateView();
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            ClearView();
        }
    }
}
