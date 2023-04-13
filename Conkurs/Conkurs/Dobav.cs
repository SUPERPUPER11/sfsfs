using Conkurs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conkurs
{
    public partial class Dobav : Form
    {
        private user17_PetrovEntities _context;
        private Form3 _form;
        public Dobav(user17_PetrovEntities user17_PetrovEntities,Form3 form3)
        {
            InitializeComponent();
            this._context = user17_PetrovEntities;
            this._form = form3; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.Meropr.Add(new Meropr()
            {
            Id_Meropr = Convert.ToInt32(textBox1.Text),
            Name_Meropr = textBox2.Text
            }); 
            _context.SaveChanges();
           
            this.Close();
        }
    }
}
