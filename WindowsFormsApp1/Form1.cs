using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["myLb"].ConnectionString;
        //    using (SqlConnection sqlConnection = new SqlConnection(/*"Data Source=DESKTOPGGUI8EI; Initial Catalog=Libary; Integrated Security=true"*/connectionString))
        //    {
        //        sqlConnection.Open();
        //        using (SqlCommand sqlCommand = new SqlCommand("SELECT Id,Name FROM Libary", sqlConnection))
        //        {
        //            using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
        //            {
        //                while (sqlDataReader.Read())
        //                {
        //                    string data = sqlDataReader["Id"].ToString();
        //                }
        //            }


        //        }
                

        //    }
            

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["myLb"].ConnectionString;
        //    //string query= "INSERT INTO Books(Name, Price,ShelfId,Row) VALUES('"+textBox1.Text+"',"+textBox2.Text+ "," + textBox3.Text + "," + textBox4.Text + ")"
        //    //string query = String.Format("INSERT INTO Books(Name, Price,ShelfId,Row) VALUES('{0}',{1},{2},{3}",textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
        //    string query = $"INSERT INTO Books(Name, Price,ShelfId,Row) VALUES('{textBox1.Text}',{textBox2.Text},{textBox3.Text},{textBox4.Text})";
        //    using (SqlConnection sqlConnection = new SqlConnection(/*"Data Source=DESKTOPGGUI8EI; Initial Catalog=Libary; Integrated Security=true"*/connectionString))
        //    {
        //        sqlConnection.Open();
        //        using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
        //        {
        //            int affectedRows =sqlCommand.ExecuteNonQuery();

        //        }


        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            using(MyDatabase myDatabase=new MyDatabase("myLb"))
            {
                var resonse = myDatabase.GetAllSkills();
            }
        }
    }
}
