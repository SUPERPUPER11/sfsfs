using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conkurs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user17_PetrovDataSet.Moderator". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user17_PetrovDataSet.Meropr". При необходимости она может быть перемещена или удалена.
            this.meroprTableAdapter.Fill(this.user17_PetrovDataSet.Meropr);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dobav dobav = new Dobav(Models.user17_PetrovEntities._context,this);
            dobav.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                dataGridView1.Sort(nameMeroprDataGridViewTextBoxColumn,System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(nameMeroprDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Наименование")
            {
                dataGridView1.Columns[0].Visible = false; 
            }
            else if (comboBox1.SelectedItem == "Id")
            {
                dataGridView1.Columns[1].Visible = false;
            }

        }

        //private void SbrosButton_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Columns[1].Visible = true;
        //    dataGridView1.Columns[2].Visible = true;
        //    dataGridView1.Columns[3].Visible = true;
        //    dataGridView1.Columns[4].Visible = true;
        //    dataGridView1.Columns[5].Visible = true;
        //}
    }
}
