using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMass : Form
    {
        public FormMass()
        {
            InitializeComponent();
        }

        //2
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //3
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "";
            textBoxN.Text = "";
            textBoxResult.Text = "";
            dataGridViewMass.Rows.Clear();
            dataGridViewMass.Columns.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //4
            int n, m, positiveElements = 0;
            float summ = 0, avg = 0;
            
            //5
            n = Convert.ToInt32(textBoxN.Text);
            m = Convert.ToInt32(textBoxM.Text);

            //6
            int[,] arrayA = new int[n, m];
            Random randomNum = new Random();

            //7
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    arrayA[i, j] = randomNum.Next(-50, 50);
                }
            }

            //8
            dataGridViewMass.RowCount = n;
            dataGridViewMass.ColumnCount = m;

            //9
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    dataGridViewMass.Rows[i].Cells[j].Value = arrayA[i, j];
                }
            }

            //10
            for (int j = 0; j <= m - 1; j++)
            {
                dataGridViewMass.Columns[j].Width = 50;
            }

            //11
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    if (arrayA[i, j] > 0)
                    {
                        summ += arrayA[i, j];
                        positiveElements += 1;
                    }
                }
            }

            //12
            avg = summ / positiveElements;
            textBoxResult.Text = $"Average = {Math.Round(avg, 5).ToString()}{Environment.NewLine}" +
                $"Number of positive element = {positiveElements.ToString()}";
        }
    }
}
