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

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        SqlConnection sql2 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019;DataBase=transportation;Integrated Security=true");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql2.Open();
            SqlCommand data = new SqlCommand("sign_up_asmanager", sql2);
            data.CommandType = CommandType.StoredProcedure;

            data.CommandType = CommandType.StoredProcedure;
            data.Parameters.Add("@branchname", SqlDbType.VarChar, (30)).Value = textBox1.Text;
            data.Parameters.Add("@branchid", SqlDbType.Int).Value = textBox4.Text;
            data.Parameters.Add("@companyaddress", SqlDbType.VarChar, (200)).Value = textBox3.Text;
            data.Parameters.Add("@companytelephone ", SqlDbType.VarChar, (50)).Value = textBox2.Text;
            
            data.ExecuteNonQuery();
            sql2.Close();
            MessageBox.Show("welcome");
            new Form1().Show();
            
        }
    }
}
