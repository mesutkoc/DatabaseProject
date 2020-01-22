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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        SqlConnection con = new SqlConnection("Data Source=NBS215240163;Initial Catalog=BloodBank-Project;Integrated Security=true;");

        private void findDonorbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            donorlistBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Donor where DonorBloodGroup = '" + BloodtextBox.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {               
                 donorlistBox1.Items.Add(dr["DonorName"].ToString());        
            }
            con.Close();
        }

        private void donorlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Donor where DonorName ='" + donorlistBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach(DataRow dr in dt.Rows)
            {
                donorNametext.Text = dr["DonorID"].ToString();
                donorphonetext.Text = dr["DonorPhone"].ToString();
                donorbloodgrouptext.Text = dr["DonorBloodGroup"].ToString();

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select CenterName from BloodCenter where CenterID = '" + dr["CenterID"] + "'";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    donorcenternametext.Text = dr1["CenterName"].ToString();
                }
            }

            con.Close();
        }
        
        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDonor form4 = new AddDonor();
            form4.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAccount form2 = new CreateAccount();
            form2.Show();
        }

        private void donorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDonor form5 = new DeleteDonor();
            form5.Show();
        }

        private void selectDonorbutton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into Patient(PatientID,PatientName,PatientPhone,PatientBloodGroup) Values(@ID,@Name,@Phone,@Blood)", con);
            cmd.Parameters.AddWithValue("@ID", IDtextBox1.Text);
            cmd.Parameters.AddWithValue("@Name", nametextBox.Text);
            cmd.Parameters.AddWithValue("@Phone", phonetextBox.Text);
            cmd.Parameters.AddWithValue("@Blood", BloodtextBox.Text);
            cmd.ExecuteNonQuery();



            SqlCommand cmd2 = new SqlCommand(@"Insert into Exchange (PatientID, DonorID,EmployeeID, CenterID) Values(@Pati,@Donor,@Employee,@Center)", con);
            cmd2.Parameters.AddWithValue("@Pati", IDtextBox1.Text);
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select DonorId from Donor where DonorName= '" + donorlistBox1.SelectedItem.ToString() + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
              cmd2.Parameters.AddWithValue("@Donor", dr["DonorId"].ToString());
            }
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "Select EmployeeID,CenterID from Employee where EmployeeName= '" + Form1.user+ "'";
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                cmd2.Parameters.AddWithValue("@Employee", dr3["EmployeeID"].ToString());
                cmd2.Parameters.AddWithValue("@Center", dr3["CenterID"].ToString());
            }

            SqlCommand cmd4 = new SqlCommand(@"Insert into OldDonor(DonorID,DonorName,DonorPhone,DonorBloodGroup,CenterID) Values (@ID,@Name,@Phone,@Blood,@Center)",con);
            SqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "Select DonorID,DonorName,DonorPhone,DonorBloodGroup,CenterID from Donor where DonorName ='" + donorlistBox1.SelectedItem.ToString() + "'";
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            foreach (DataRow dr5 in dt5.Rows)
            {
                cmd4.Parameters.AddWithValue("@ID", dr5["DonorID"].ToString());
                cmd4.Parameters.AddWithValue("@Name", dr5["DonorName"].ToString());
                cmd4.Parameters.AddWithValue("@Phone", dr5["DonorPhone"].ToString());
                cmd4.Parameters.AddWithValue("@Blood", dr5["DonorBloodGroup"].ToString());
                cmd4.Parameters.AddWithValue("@Center", dr5["CenterID"].ToString());
            }

            SqlCommand cmd6 = new SqlCommand(@"Delete from Donor where DonorName='" + donorlistBox1.SelectedItem.ToString() + "'", con);


            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            con.Close();
            
        }

        private void addanalysisbutton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Insert into Analysis(ExchangeID,WBC,RBC,HGB,MCV,PLT) Values(@ex,@wbc,@rbc,@hgb,@mcv,@plt)", con);
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "Select ExchangeID from Exchange where PatientID='" + IDtextBox1.Text+"'";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                cmd.Parameters.AddWithValue("@ex", dr2["ExchangeID"].ToString());
            }
            cmd.Parameters.AddWithValue("@wbc", rnd.Next(4, 10));
            cmd.Parameters.AddWithValue("@rbc", rnd.Next(4, 6));
            cmd.Parameters.AddWithValue("@hgb", rnd.Next(14, 17));
            cmd.Parameters.AddWithValue("@mcv", rnd.Next(81, 96));
            cmd.Parameters.AddWithValue("@plt", rnd.Next(155, 375));
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void oldDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OldDonorResult form6 = new OldDonorResult();
            form6.Show();
        }
    }
}
