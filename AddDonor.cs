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
    public partial class AddDonor : Form
    {
        public AddDonor()
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
                DonorCentercomboBox1.Items.Add(dr["CenterName"].ToString());
            }
        }
        private void DonorADDbutton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"Insert into Donor(DonorID,DonorName,DonorPhone,DonorBloodGroup,CenterID) Values(@ID,@Name,@Phone,@BloodGroup,@CenterID)", con);
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Select CenterID from BloodCenter where CenterName= '" + DonorCentercomboBox1.SelectedItem.ToString() + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);

            cmd.Parameters.AddWithValue("@ID", DonorIDtextBox1.Text);
            cmd.Parameters.AddWithValue("@Name", DonorNametextBox1.Text);
            cmd.Parameters.AddWithValue("@Phone", DonorPhonetextBox2.Text);
            cmd.Parameters.AddWithValue("@BloodGroup", DonorBloodtextBox3.Text);

            foreach (DataRow dr in dt.Rows)
            {
                cmd.Parameters.AddWithValue("@CenterID", dr["CenterID"].ToString());
            }
            cmd.ExecuteNonQuery();

            con.Close();
            this.Close();
        }
    }
}
