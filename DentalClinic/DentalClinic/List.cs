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
    public partial class List : Form

    {
        controller controllerobj;
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.select_patient();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void List_Load(object sender, EventArgs e)
        {
            controllerobj = new controller();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerobj.select_Diagnosedpatient();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
