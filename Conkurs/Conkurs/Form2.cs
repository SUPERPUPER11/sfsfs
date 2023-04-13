using Conkurs.Models;
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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
          
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "user17_PetrovDataSet.Active". При необходимости она может быть перемещена или удалена.
            this.activeTableAdapter.Fill(this.user17_PetrovDataSet.Active);
            toolStripStatusLabel1.Text = $"Всего активов:{dataGridView1.Rows.Count - 1}";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            this.Hide();
            form.ShowDialog();
        }

        private void перейтиНаТаблицуМероприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
 }
