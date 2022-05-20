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
    public partial class Addform : Form
    {
        controller controllerobj;
        public Addform()
        {

            InitializeComponent();
            controllerobj = new controller();
            DataTable dt= controllerobj.get_operations();
            comboBox1.DisplayMember = "OpName";
            comboBox1.DataSource = dt;
            

        }
        private void Addform_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please enter all the fields");
            }

            else
            {
                try
                {
                    int result = controllerobj.insert_patient(textBox1.Text, textBox2.Text, Int16.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("Insertion failed!");
                    }
                    else
                    {

                        MessageBox.Show("Patient was added successfully");
                    }
                }

                catch
                {
                    MessageBox.Show("Insertion failed, make sure to enter the data correctly");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" )
            {
                MessageBox.Show("please enter the Patient ID");
            }

            else
            {

                int result = controllerobj.delete_patient(textBox4.Text);
                if (result == 0)
                {
                    MessageBox.Show("deletion failed!");
                }
                else
                {
                    MessageBox.Show("Patient was deleted successfully");
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox10.Text == "" || textBox6.Text == "" || textBox4.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please enter all the required fields(ID,Age,date,tel.,occupation,address)");
            }

            else
            {
                try
                {
                    int result = controllerobj.update_patient(Int16.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("Updated failed!");
                    }
                    else
                    {
                        MessageBox.Show("Patient was updated successfully");
                    }
                }

                catch
                {
                    MessageBox.Show("update failed, make sure to enter the data correctly");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || comboBox2.SelectedItem.ToString() == "" || comboBox1.SelectedItem.ToString() == "" || textBox14.Text == "" || textBox13.Text == "" )
            {
                MessageBox.Show("Please enter all the fields");
            }

            else

            {
                try
                {
                    DataTable dt = controllerobj.check_patient(textBox9.Text);

                    if (dt != null)

                    {
                        DataRowView oDataRowView = comboBox1.SelectedItem as DataRowView;
                        string sValue = string.Empty;

                        if (oDataRowView != null)
                        {
                            sValue = oDataRowView.Row["OpName"] as string;
                        }

                        int result = controllerobj.insert_Diagnosis(textBox9.Text,textBox14.Text ,textBox10.Text, textBox11.Text, comboBox2.SelectedItem.ToString(),sValue, Int16.Parse(textBox12.Text), Int16.Parse(textBox13.Text), (Int16.Parse(textBox12.Text) - Int16.Parse(textBox13.Text)));
                        if (result == 0)
                        {
                            MessageBox.Show("insertion failed!");
                        }
                        else
                        {
                            MessageBox.Show("Data was inserted successfully");
                        }


                    }

                    else
                    {
                        MessageBox.Show("patient is not registered!");
                    }
                }

                catch
                {
                    MessageBox.Show("Insertion failed, make sure to enter the data correctly");
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox9.Text=="" ||  textBox13.Text=="" || comboBox1.SelectedItem.ToString()=="" || comboBox2.SelectedItem.ToString()=="")
            {
                MessageBox.Show("enter the required fields(ID,Tooth,Operation,paid)");
            }

            else
            {
                try
                {
                    DataRowView oDataRowView = comboBox1.SelectedItem as DataRowView;
                    string sValue = string.Empty;

                    if (oDataRowView != null)
                    {
                        sValue = oDataRowView.Row["OpName"] as string;
                    }

                    int result = controllerobj.update_paid(textBox9.Text, comboBox2.SelectedItem.ToString(), sValue, Int16.Parse(textBox13.Text));
                    if (result == 0)
                    {
                        MessageBox.Show("update failed");
                    }
                    else
                    {
                        MessageBox.Show("paid amount was updated successfully");
                    }
                }

                catch
                {
                    MessageBox.Show("update failed, make sure to enter the data correctly");
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView oDataRowView = comboBox1.SelectedItem as DataRowView;
            string sValue = string.Empty;

            if (oDataRowView != null)
            {
                sValue = oDataRowView.Row["OpName"] as string;
            }

            int value = controllerobj.get_OPprice(sValue);
            textBox12.Text = value.ToString();




        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox9.Text=="" || comboBox2.SelectedItem.ToString()=="" || comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please enter the required fileds(ID,Tooth,Operation)");

            }

            else
            {
                try
                {
                    DataRowView oDataRowView = comboBox1.SelectedItem as DataRowView;
                    string sValue = string.Empty;

                    if (oDataRowView != null)
                    {
                        sValue = oDataRowView.Row["OpName"] as string;
                    }

                    int result = controllerobj.delete_operation(textBox9.Text, comboBox2.SelectedItem.ToString(), sValue);
                    if (result == 0)
                    {
                        MessageBox.Show("Operation was not found");
                    }
                    else
                    {
                        MessageBox.Show("Operation was deleted successfully successfully");
                    }
                }

                catch
                {
                    MessageBox.Show("deletion failed, make sure to enter the data correctly");
                }
            }

            }
        }
    }
    

