using ProjetoCG.Draw;
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

        public Principal()
        {
            InitializeComponent();
            txtLarguraDeTela.Text = ("Largura de tela:" + pictureBox1.Width + "x" + pictureBox1.Height);
            //Iniciar com cartesiano simples
            pictureBox1.Image = GetBitmapwWhitCartesian();
            triangulo();
        }

        private void triangulo()
        {
            DrawLine drawLine = new DrawLine(pictureBox1);
            drawLine.bitmap = GetBitmapwWhitCartesian();
            try
            {
                //1 linha
                double[] startPoint = { 50, 50 };
                double[] endPoint = { 100, 100 };
                drawLine.Draw(startPoint, endPoint, Color.Blue);
                // 2 linha 
                startPoint = new double[] { 100, 100 };
                endPoint = new double[] { 150, 50 };
                drawLine.Draw(startPoint, endPoint, Color.Blue);
                // 3 linha
                startPoint = new double[] { 50, 50 };
                endPoint = new double[] { 150, 50 };
                drawLine.Draw(startPoint, endPoint, Color.Blue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            pictureBox1.Image = drawLine.bitmap;
        }
        /// <summary>
        ///  Gerar um Bitmap com plano cartesiano
        /// </summary>
        /// <returns></returns>
        private Bitmap GetBitmapwWhitCartesian()
        {
            DrawLine drawLine = new DrawLine(pictureBox1);
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

            DrawPixel drawPixel = new DrawPixel(pictureBox1);
            drawPixel.bitmap = GetBitmapwWhitCartesian();
            try
            {
                drawPixel.Draw(double.Parse(textBox1.Text), double.Parse(textBox2.Text), Color.Blue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            pictureBox1.Image = drawPixel.bitmap;


        }
        /// <summary>
        /// Desenhar uma linha em um dos octantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {

            DrawLine drawLine = new DrawLine(pictureBox1);
            drawLine.bitmap = GetBitmapwWhitCartesian();
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
            pictureBox1.Image = drawLine.bitmap;
        }
    }
}
