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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxM.Text = "";
            textBoxN.Text = "";
            textBoxResult.Text = "";
            dataGridViewMass.Rows.Clear();
            dataGridViewMass.Columns.Clear();
        }
    }
}
