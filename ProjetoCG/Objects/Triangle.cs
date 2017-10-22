using ProjetoCG.Components;
using ProjetoCG.Draw;
using ProjetoCG.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG.Objects
{
    class Triangle
    {
        public Point2D FirstPoint { get; set; }
        public Point2D SecondPoint { get; set ; }
        public Point2D ThirdPoint { get; set; }
        /// <summary>
        ///          Third
        ///           / \
        ///          /   \
        ///    First/_____\ Second
        /// </summary>
        /// <param name="firstPoint"></param>
        /// <param name="secondPoint"></param>
        /// <param name="thirdPoint"></param>
        /// 
        public Triangle() { }
        public Triangle(Matrix matrix) {
            try {
                // Getting FirstPoint
                FirstPoint = new Point2D(matrix.GetElement(0, 0), matrix.GetElement(1, 0));
                // Getting SecondPoint
                SecondPoint= new Point2D(matrix.GetElement(0, 1), matrix.GetElement(1, 1));
                // Getting ThirdPoint
                ThirdPoint = new Point2D(matrix.GetElement(0, 2),matrix.GetElement(1, 2));

            }
            catch (Exception ex) {
                Console.WriteLine("Falaha ao construir triangulo "+ ex.Message);
            }
        }
        public Matrix GetMatriz()
        {
            Matrix CordinateMatrix = new Matrix(2,3);
            // Set 1 ponto
            CordinateMatrix.SetElement(0, 0, FirstPoint.X);
            CordinateMatrix.SetElement(1, 0, FirstPoint.Y);

            //Set 2 ponto
            CordinateMatrix.SetElement(0, 1, SecondPoint.X);
            CordinateMatrix.SetElement(1, 1, SecondPoint.Y);

            //Set 3 ponto
            CordinateMatrix.SetElement(0, 2, ThirdPoint.X);
            CordinateMatrix.SetElement(1, 2, ThirdPoint.Y);

            return CordinateMatrix;
        }
    }
}
