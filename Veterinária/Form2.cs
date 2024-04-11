using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinária
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veterinária.VeterináriaDataSet.AnimalDataTable DataTable = new Veterinária.VeterináriaDataSet.AnimalDataTable();
            D
            DataTable.AddAnimalRow(textBox1.Text);
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
