using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class Searchform : Form
    {
        controller controllerobj;
        public Searchform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" )

            {
                MessageBox.Show("please enter the Patient's ID");
            }

            else
            {
                DataTable dt = controllerobj.search_Dpatient(textBox1.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                DataTable dt1 = controllerobj.search_patient(textBox1.Text);
                dataGridView2.DataSource = dt1;
                dataGridView2.Refresh();

            }


        }

        private void Searchform_Load(object sender, EventArgs e)
        {
            controllerobj = new controller();
        }
    }
}
