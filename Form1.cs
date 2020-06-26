using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace MatrixCalc
{
    public partial class Form1 : Form
    {

        Random RandomMatrix = new Random();
        Matrix<double> MatrixA;
        Matrix<double> MatrixB;
        Matrix<double> Result;
        public Form1()
        {
            InitializeComponent();

            LeftMatrix.Init();
            RightMatrix.Init();
            ResultMatrix.Init();

            MatrixA = MatrixPreInit(LeftMatrix);
            MatrixB = MatrixPreInit(RightMatrix);
            Result = MatrixPreInit(ResultMatrix);
            
            //MatrixInit(LeftMatrix, MatrixA);
            //MatrixInit(RightMatrix, MatrixB);
            //MatrixInit(ResultMatrix, Result);
        }

        /*public void MatrixPreInit()
        {
            MatrixA = Matrix<double>.Build.Dense(LeftMatrix.RowCount, LeftMatrix.ColumnCount);
            MatrixB = Matrix<double>.Build.Dense(RightMatrix.RowCount, RightMatrix.ColumnCount);
            Result = Matrix<double>.Build.Dense(ResultMatrix.RowCount, ResultMatrix.ColumnCount);
        }*/

        public Matrix<double> MatrixPreInit(DataGridView dgv)
        {
            var matrix = Matrix<double>.Build.Dense(dgv.RowCount, dgv.ColumnCount);

            return matrix;
        }

        public void MatrixToGrid(DataGridView dgv, Matrix<double> matrix)
        {
            for (int j = 0; j < dgv.ColumnCount; j++)
            {
                for (int i = 0; i < dgv.RowCount; i++) dgv[j, i].Value = matrix[i, j];
            }
        }

        public void MatrixInit(DataGridView dgv, Matrix<double> matrix)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                    matrix[i, j] = Convert.ToDouble(dgv[j, i].Value);
            }
        }

        public void RandomGenerateMatrix(DataGridView dgv, Matrix<double> matrix)
        {
            int newNum;
            for(int i = 0; i < dgv.RowCount; i++)
            {               
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    newNum = RandomMatrix.Next(-99, 99);
                    matrix[i, j] = Convert.ToDouble(newNum);
                    dgv[j, i].Value = newNum;
                }
            }
        }

        private void LeftMatrix_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LeftMatrix.Fill();
            RightMatrix.Fill();
            ResultMatrix.Fill();
        }

        private void LeftMatrix_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            LeftMatrix.Fill();
            RightMatrix.Fill();
            ResultMatrix.Fill();
        }

        private void LeftMatrix_Resize(object sender, EventArgs e)
        {
            LeftMatrix.Fill();
            RightMatrix.Fill();
            ResultMatrix.Fill();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (LeftMatrix.ColumnCount == RightMatrix.ColumnCount && LeftMatrix.RowCount == RightMatrix.RowCount)
            {
                try
                {
                    MatrixInit(LeftMatrix, MatrixA);
                    MatrixInit(RightMatrix, MatrixB);
                    Result = MatrixA + MatrixB;
                    ResultMatrix.RowCount = Result.RowCount;
                    ResultMatrix.ColumnCount = Result.ColumnCount;
                    MatrixToGrid(ResultMatrix, Result);
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Обе матрицы должны быть одной размерности.");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (LeftMatrix.ColumnCount == RightMatrix.ColumnCount && LeftMatrix.RowCount == RightMatrix.RowCount)
            {
                try
                {
                    MatrixInit(LeftMatrix, MatrixA);
                    MatrixInit(RightMatrix, MatrixB);
                    Result = MatrixA - MatrixB;
                    ResultMatrix.RowCount = Result.RowCount;
                    ResultMatrix.ColumnCount = Result.ColumnCount;
                    MatrixToGrid(ResultMatrix, Result);
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Обе матрицы должны быть одной размерности.");
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            try
            {
                if (LeftMatrix.ColumnCount == RightMatrix.RowCount)
                {
                    MatrixInit(LeftMatrix, MatrixA);
                    MatrixInit(RightMatrix, MatrixB);
                    Result = MatrixA * MatrixB;
                    ResultMatrix.RowCount = Result.RowCount;
                    ResultMatrix.ColumnCount = Result.ColumnCount;
                    MatrixToGrid(ResultMatrix, Result);
                }
                else
                    MessageBox.Show("Количество столбоцв матрицы A должно быть равно количеству строк матрицы B.");
            }
            catch
            {
                MessageBox.Show("Некорректные элементы матрицы.");
            }
        }

        private void LeftRows_ValueChanged(object sender, EventArgs e)
        {
            var col = LeftMatrix.ColumnCount;
            LeftMatrix.ClearMatrix();
            LeftMatrix.Init((int)LeftRows.Value, col);
            MatrixA = MatrixPreInit(LeftMatrix);
        }

        private void LeftCols_ValueChanged(object sender, EventArgs e)
        {
            var row = LeftMatrix.RowCount;
            LeftMatrix.ClearMatrix();
            LeftMatrix.Init(row, (int)LeftCols.Value);
            MatrixA = MatrixPreInit(LeftMatrix);
        }

        private void RightRows_ValueChanged(object sender, EventArgs e)
        {
            var col = RightMatrix.ColumnCount;
            RightMatrix.ClearMatrix();
            RightMatrix.Init((int)RightRows.Value, col);
            MatrixB = MatrixPreInit(RightMatrix);
        }

        private void RightCols_ValueChanged(object sender, EventArgs e)
        {
            var row = RightMatrix.RowCount;
            RightMatrix.ClearMatrix();
            RightMatrix.Init(row, (int)RightCols.Value);
            MatrixB = MatrixPreInit(RightMatrix);
        }

        private void LeftMatrix_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);


            foreach(DataGridViewRow rw in this.LeftMatrix.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null) rw.Cells[i].Value = 0;
                }
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string vlCell = ((TextBox)sender).Text;
            bool temp = (vlCell.IndexOf(",") == -1);
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') && (vlCell.IndexOf(",") == -1) && (vlCell.Length != 0)) && !(vlCell.IndexOf("-") == -1))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void ClearA_Click(object sender, EventArgs e)
        {
            int bufRow = LeftMatrix.RowCount;
            int bufCol = LeftMatrix.ColumnCount;
            LeftMatrix.ClearMatrix();
            LeftMatrix.Init(bufRow, bufCol);
            //LeftRows.Value = bufRow;
            //LeftCols.Value = bufCol;
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            int bufRow = RightMatrix.RowCount;
            int bufCol = RightMatrix.ColumnCount;
            RightMatrix.ClearMatrix();
            RightMatrix.Init(bufRow, bufCol);
            //RightRows.Value = bufRow;
            //RightCols.Value = bufCol;
        }

        private void ClearResult_Click(object sender, EventArgs e)
        {
            int bufRow = ResultMatrix.RowCount;
            int bufCol = ResultMatrix.ColumnCount;
            ResultMatrix.ClearMatrix();
            ResultMatrix.Init(bufRow,bufCol);
        }

        private void DetLeft_Click(object sender, EventArgs e)
        {            
            if(LeftMatrix.RowCount == LeftMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(LeftMatrix, MatrixA);
                    label6.Text = "= " + Convert.ToString(MatrixA.Determinant());
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");

        }

        private void DetRight_Click(object sender, EventArgs e)
        {
            if(RightMatrix.RowCount == RightMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(RightMatrix, MatrixB);
                    label7.Text = "= " + Convert.ToString(MatrixB.Determinant());
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }          
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");
        }

        private void DetResult_Click(object sender, EventArgs e)
        {
            if(ResultMatrix.RowCount == ResultMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(ResultMatrix, Result);
                    label8.Text = "= " + Convert.ToString(Result.Determinant());
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");
        }

        private void InverseLeft_Click(object sender, EventArgs e)
        {
            if(LeftMatrix.RowCount == LeftMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(LeftMatrix, MatrixA);
                    if(MatrixA.Determinant() == 0) MessageBox.Show("Определитель не должен быть равен нулю.");
                    else
                    {
                        MatrixA = MatrixA.Inverse();
                        MatrixToGrid(LeftMatrix, MatrixA);
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");
        }

        private void InverseRight_Click(object sender, EventArgs e)
        {
            if (RightMatrix.RowCount == RightMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(RightMatrix, MatrixB);
                    if (MatrixB.Determinant() == 0) MessageBox.Show("Определитель не должен быть равен нулю.");
                    else
                    {
                        MatrixB = MatrixB.Inverse();
                        MatrixToGrid(RightMatrix, MatrixB);
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");
        }

        private void InverseResult_Click(object sender, EventArgs e)
        {
            if (ResultMatrix.RowCount == ResultMatrix.ColumnCount)
            {
                try
                {
                    MatrixInit(ResultMatrix, Result);
                    if (Result.Determinant() == 0) MessageBox.Show("Определитель не должен быть равен нулю.");
                    else
                    {
                        Result = Result.Inverse();
                        MatrixToGrid(ResultMatrix, Result);
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректные элементы матрицы.");
                }
            }
            else
                MessageBox.Show("Матрица должна быть квадратной.");
        }

        private void RandomA_Click(object sender, EventArgs e)
        {
            RandomGenerateMatrix(LeftMatrix, MatrixA);
        }

        private void RandomB_Click(object sender, EventArgs e)
        {
            RandomGenerateMatrix(RightMatrix, MatrixB);
        }

        private void TransA_Click(object sender, EventArgs e)
        {
            try
            {
                MatrixInit(LeftMatrix, MatrixA);
                MatrixA = MatrixA.Transpose();
                int temp = LeftMatrix.RowCount;
                LeftMatrix.RowCount = LeftMatrix.ColumnCount;
                LeftMatrix.ColumnCount = temp;
                MatrixToGrid(LeftMatrix, MatrixA);
            }
            catch
            {
                MessageBox.Show("Некорректные элементы матрицы.");
            }
        }

        private void TransB_Click(object sender, EventArgs e)
        {
            try
            {
                MatrixInit(RightMatrix, MatrixB);
                MatrixB = MatrixB.Transpose();
                int temp = RightMatrix.RowCount;
                RightMatrix.RowCount = RightMatrix.ColumnCount;
                RightMatrix.ColumnCount = temp;
                MatrixToGrid(RightMatrix, MatrixB);
            }
            catch
            {
                MessageBox.Show("Некорректные элементы матрицы.");
            }
        }

        private void LeftMulValuebtn_Click(object sender, EventArgs e)
        {
            try
            {
                MatrixInit(LeftMatrix, MatrixA);
                MatrixA = MatrixA.Multiply(Convert.ToInt32(LeftMulValue.Value));
                MatrixToGrid(LeftMatrix, MatrixA);
            }
            catch
            {
                MessageBox.Show("Некорректные элементы матрицы.");
            }
        }

        private void RightMulValuebtn_Click(object sender, EventArgs e)
        {
            try
            {
                MatrixInit(RightMatrix, MatrixB);
                MatrixB = MatrixB.Multiply(Convert.ToInt32(RightMulValue.Value));
                MatrixToGrid(RightMatrix, MatrixB);
            }
            catch
            {
                MessageBox.Show("Некорректные элементы матрицы.");
            }
        }

        private void LeftRigth_Click(object sender, EventArgs e)
        {
            MatrixInit(LeftMatrix, MatrixA);
            MatrixInit(RightMatrix, MatrixB);

            Matrix<double> TempMatrixA = MatrixA;
            Matrix<double> TempMatrixB = MatrixB;

            decimal tempRow = LeftRows.Value;
            LeftRows.Value = RightRows.Value;
            RightRows.Value = tempRow;

            decimal tempCol = LeftCols.Value;
            LeftCols.Value = RightCols.Value;
            RightCols.Value = tempCol;

            MatrixA = TempMatrixB;
            MatrixB = TempMatrixA;

            MatrixToGrid(LeftMatrix, MatrixA);
            MatrixToGrid(RightMatrix, MatrixB);

            
        }

        private void CopyLeft_Click(object sender, EventArgs e)
        {
            MatrixInit(LeftMatrix, MatrixA);
            MatrixInit(RightMatrix, MatrixB);
            MatrixInit(ResultMatrix, Result);

            LeftRows.Value = ResultMatrix.RowCount;
            LeftCols.Value = ResultMatrix.ColumnCount;

            MatrixA = Result;
            
            MatrixToGrid(LeftMatrix, MatrixA);
            MatrixToGrid(ResultMatrix, Result);
        }

        private void CopyRight_Click(object sender, EventArgs e)
        {
            MatrixInit(LeftMatrix, MatrixA);
            MatrixInit(RightMatrix, MatrixB);
            MatrixInit(ResultMatrix, Result);

            RightRows.Value = ResultMatrix.RowCount;
            RightCols.Value = ResultMatrix.ColumnCount;

            MatrixB = Result;

            MatrixToGrid(RightMatrix, MatrixB);
            MatrixToGrid(ResultMatrix, Result);
        }
    }
}
