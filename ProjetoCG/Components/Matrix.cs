using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCG.Components
{
    class Matrix
    {
        private int columns,rows;

        double[,] vector;
        public Matrix(int rows,int columns) {
            this.columns = columns;
            this.rows = rows;

            vector = new double[rows, columns];
        }
        public void SetElement(int row,int column,double element) {
            vector[row, column] = element;
        }
        public void PrintMatrix() {
            for (int i = 0; i < rows; i++) {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write(vector[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public double GetElement(int i, int j)
        {
            return vector[i,j];   
        }
    }
}
