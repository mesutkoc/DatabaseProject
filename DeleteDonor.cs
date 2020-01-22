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
    public partial class DeleteDonor : Form
    {
        public DeleteDonor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NBS215240163;Initial Catalog=BloodBank-Project;Integrated Security=true;");

        private void findbutton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Donor where DonorID = '" + deleteıdtextBox1.Text + "' and DonorName = '" + deletenametextBox2.Text + "' and DonorPhone = '" + deletephonetextBox3.Text + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["DonorName"].ToString());
            }
            con.Close();
        }

        private void deletepatientbutton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from Donor where DonorName = '" + listBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            this.Close();
        }

    }
}
