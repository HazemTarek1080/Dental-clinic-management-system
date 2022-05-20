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
    public partial class IDs : Form
    {
        controller controllerobj;
        public IDs()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("please enter the required fields");
            }

            else
            {
                DataTable dt = controllerobj.search_ID(textBox1.Text,textBox2.Text,textBox3.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                if(dt==null)
                {
                    MessageBox.Show("Patient is not registered");
                }
            }
        }

        private void IDs_Load(object sender, EventArgs e)
        {
            controllerobj = new controller();
        }
    }
}
