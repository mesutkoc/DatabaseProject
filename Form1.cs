using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseBloodBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NBS215240163;Initial Catalog=BloodBank-Project;Integrated Security=true;");
        public static string user = "";
        public void Loginbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select EmployeeName, EmployeePassword from Employee where EmployeeName ='" + UsertextBox.Text + "'  and EmployeePassword = '" + PasswordtextBox.Text + "'", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            user = UsertextBox.Text;
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Welcome to Blood Center!");
                MainWindow form3 = new MainWindow();
                form3.Show();
            }

            else
            {
                MessageBox.Show("Username or Password Wrong!");
            }
            
        }
        
        
        
    }
}
