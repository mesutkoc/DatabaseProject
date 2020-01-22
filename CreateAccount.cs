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
using System.Configuration;

namespace DatabaseBloodBank
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            Fillcombo();
        }
        SqlConnection con = new SqlConnection("Data Source=NBS215240163;Initial Catalog=BloodBank-Project;Integrated Security=true;");


        void Fillcombo()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select CenterName from BloodCenter";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                centernamecomboBox.Items.Add(dr["CenterName"].ToString());
            }
        }
        private void addinfobutton_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand(@"Insert into Employee(EmployeeID,EmployeeName,EmployeePassword,EmployeePhone,CenterID) Values(@ID,@Name,@Password,@Phone,@CenterID)", con);
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText ="Select CenterID from BloodCenter where CenterName= '" + centernamecomboBox.SelectedItem.ToString() + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            
            cmd.Parameters.AddWithValue("@ID", IDtextBox.Text);
            cmd.Parameters.AddWithValue("@Name", usernametextBox.Text);
            cmd.Parameters.AddWithValue("@Password", passwordtextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", phonetextBox.Text);
            
            foreach (DataRow dr in dt.Rows)
            {
                cmd.Parameters.AddWithValue("@CenterID",dr["CenterID"].ToString()); 
            }
            cmd.ExecuteNonQuery();

            con.Close();
            this.Close();
           
            
        }


    }
}
