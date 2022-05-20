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
    public partial class Editform : Form
    {
        controller controllerobj;
        public Editform()
        {
            InitializeComponent();
        }

        private void Editform_Load(object sender, EventArgs e)
        {
            controllerobj = new controller();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please enter the required fields");
            }

            else
            {
                try
                {
                    int result = controllerobj.insert_operation(textBox1.Text, Int16.Parse(textBox2.Text));
                    if (result == 0)
                    {
                        MessageBox.Show("Insertion failed!");
                    }
                    else
                    {
                        MessageBox.Show("Operation was added successfully");
                    }
                }

                catch
                {
                    MessageBox.Show("insertion failed, make sure to enter the data correctly");
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please enter the name of the operation to be deleted");
            }

            else
            {
                int result = controllerobj.delete_operation(textBox5.Text);
                if (result == 0)
                {
                    MessageBox.Show("Operation was not found");
                }
                else
                {
                    MessageBox.Show("Operation was deleted successfully");
                }
            }
        }

        private void EditPrice_Click(object sender, EventArgs e)
        {

            if (textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("please enter the required fields");

            }
            else
            {
                try
                {
                    int result = controllerobj.update_operation(textBox4.Text, Int16.Parse(textBox3.Text));
                    if (result == 0)
                    {
                        MessageBox.Show("Update failed!");
                    }
                    else
                    {
                        MessageBox.Show("Operation was updated successfully");
                    }
                }
                catch
                {
                    MessageBox.Show("Edit failed, make sure to enter the data correctly");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.select_operation();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
