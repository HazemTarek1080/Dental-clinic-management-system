using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    class controller
    {
        private DBManager clinic; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public controller()
        {
            clinic = new DBManager(); // Create the DBManager Object
        }

        public int insert_patient(string Fname,string Lname,int age,string ID,string date,string phone,string occupation,string address)
        {
            string query = "insert into patient values (N'"+Fname+"',N'"+Lname+"',"+age+",'"+phone+"',N'"+address+"','"+date+"',N'"+occupation+ "','"+ID+"')";

                return clinic.ExecuteNonQuery(query);
        }

        

        public int update_patient(int age, string ID, string date, string phone, string occupation, string address)
        {

            string query = "update patient set age="+age+","+
                "Home_Address='"+address+"',"+
                "Visit_Date='"+date+"',"+
                "Occupation='"+occupation+"',"+
                "PhoneNumber='"+phone+"'"+
                "where ID='"+ID+"'";

            return clinic.ExecuteNonQuery(query);

        }
        public int delete_patient(string ID)

        {
            string query = "delete from patient " +
                "where ID='"+ID+"' ";

            return clinic.ExecuteNonQuery(query);
        }

        public int delete_operation(string ID,string tooth, string operation)
        {
            string query = "delete from Diagnosed_Patient " +
                "where Patient_ID='" + ID + "' and Tooth='" + tooth + "' and Operation='" + operation + "' ";

            return clinic.ExecuteNonQuery(query);
        }


        public DataTable select_patient()
        {
            string query = "select* from patient";
            return clinic.ExecuteReader(query);
        }

        public int insert_operation(string name,int price)
        {
            string query = "INSERT INTO operation VALUES ('" + name+"',"+price+")";
            return clinic.ExecuteNonQuery(query);
        }

        public int update_operation(string name, int price)
        {
            string query = "update operation set price=" + price + " where OpName='" + name + "'";
            return clinic.ExecuteNonQuery(query);
        }

        public int delete_operation(string name)
        {
            string query ="delete from operation "+
                "where OpName='"+name+"'";
                
                return clinic.ExecuteNonQuery(query);
        }

       

        public DataTable select_operation()
        {
            string query = "select* from operation";
            return clinic.ExecuteReader(query);
        }


        public DataTable check_patient(string ID)
        {
            string query = "select* from patient where ID='" + ID + "' ";
            return clinic.ExecuteReader(query);

        }


        public int insert_Diagnosis(string ID,string date,string medicalhistory,string diagnosis,string tooth,string operation,int paid,int cost,int remaining)
        {
            string query = "insert into Diagnosed_Patient values ('"+ID+"','"+date+"','"+medicalhistory+"','"+diagnosis+"','"+tooth+ "','"+operation+"',"+paid+","+cost+","+remaining+")";
            return clinic.ExecuteNonQuery(query);
        }

        

        public DataTable select_Diagnosedpatient()
        {
            string query = "select* from Diagnosed_Patient";
            return clinic.ExecuteReader(query);
        }

        public DataTable search_patient(string ID)
        {
            string query = "select First_Name, Last_name from patient " +
                "where ID='" + ID + "'  ";

            return clinic.ExecuteReader(query);

        }


        public DataTable search_Dpatient(string ID)
        {
            string query = "select* from Diagnosed_Patient " +
                "where Patient_ID='" + ID + "'  ";

            return clinic.ExecuteReader(query);

        }

        public DataTable search_ID(string fname, string lname,string phone)
        {

            string query = "select First_Name, Last_Name, PhoneNumber, ID from patient where First_Name=N'" + fname + "' and Last_Name=N'" + lname + "' and PhoneNumber='" + phone + "' ";
           
            return clinic.ExecuteReader(query);

        }

        public int update_paid(string ID,string tooth, string operation,int paid)
        {
            string query = "update Diagnosed_Patient set Paid=paid+" + paid + "," +
                "Remaining=Remaining-" + paid + "" +
                "where Patient_ID='" + ID + "' and Tooth='"+tooth+"' and Operation='"+operation+"' ";

            return clinic.ExecuteNonQuery(query);

        }

        public DataTable get_operations()
        {
            string query = "select OpName from operation";
            return clinic.ExecuteReader(query);
        }

        public int get_OPprice(string opname)
        {
            string query = "select Price from operation" +
                " where OpName = '"+opname+"'";
            object p=clinic.ExecuteScalar(query);
            if(p==null)
            {
                return 0;
            }
            else
            {
                return (int)p;
            }
        }

        public DataTable get_finance(string date)
        {
            string query = "select Patient_ID, Cost, Paid, Remaining from Diagnosed_Patient where Visit_Date='" + date + "'";
            return clinic.ExecuteReader(query);
        }

    }

   

}
