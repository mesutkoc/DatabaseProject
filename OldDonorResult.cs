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
    public partial class OldDonorResult : Form
    {
        public OldDonorResult()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NBS215240163;Initial Catalog=BloodBank-Project;Integrated Security=true;");

        private void FindOldDonorbutton1_Click(object sender, EventArgs e)
        {
            con.Open();
            OldDonorlistBox1.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from OldDonor where DonorID = '" + OldDonorIDtextBox1.Text + "'";         
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                OldDonorlistBox1.Items.Add(dr["DonorName"].ToString());
            }
            con.Close();
        }

        private void OldDonorlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select DonorID from OldDonor where DonorName='" + OldDonorlistBox1.SelectedItem.ToString() + "'";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "Select Exchange.ExchangeID from Exchange Inner Join OldDonor On Exchange.DonorID='"+dr["DonorID"].ToString()+"'";
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "Select Analysis.WBC,Analysis.RBC,Analysis.HGB,Analysis.MCV,Analysis.PLT from Analysis Inner Join Exchange On Analysis.ExchangeID='" + dr2["ExchangeID"].ToString() + "'";
                    DataTable dt3 = new DataTable();
                    SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                    da3.Fill(dt3);
                    foreach(DataRow dr3 in dt3.Rows)
                    {
                        label2.Text = dr3["WBC"].ToString();
                        label3.Text = dr3["RBC"].ToString();
                        label4.Text = dr3["HGB"].ToString();
                        label5.Text = dr3["MCV"].ToString();
                        label6.Text = dr3["PLT"].ToString();
                        

                    }

                }

            }
            con.Close();
        }

        private void OldDonorResult_Load(object sender, EventArgs e)
        {

        }
    }
}
