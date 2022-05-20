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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Addform F = new Addform();
            F.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Searchform F = new Searchform();
            F.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Editform F = new Editform();
            F.Show();
        }

        private void PatientsList_Click(object sender, EventArgs e)
        {
            List F = new List();
            F.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IDs_Click(object sender, EventArgs e)
        {
            IDs F = new IDs();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finance F = new Finance();
            F.Show();
        }
    }
}
