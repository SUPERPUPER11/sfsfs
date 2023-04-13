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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                List<Organization> org = user17_PetrovEntities.GetContext().Organization.ToList();
                Organization o = org.FirstOrDefault(p => p.Gmail == textBox1.Text && p.Password == textBox2.Text);
                if (o != null)
                {
                    Form2 form2 = new Form2();
                    form2.Owner = this;
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


       
    }
}

