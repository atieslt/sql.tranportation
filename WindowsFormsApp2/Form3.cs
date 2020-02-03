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
        SqlConnection sql2 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
            " DataBase=transportation;" +
            " Integrated Security=true");
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
            SqlDataAdapter data = new SqlDataAdapter("sign_up_asmanager", sql2);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@branchname", SqlDbType.VarChar, (11)).Value = textBox1.Text;
            data.SelectCommand.Parameters.Add("@branchid", SqlDbType.Char, (10)).Value = textBox4.Text;
            data.SelectCommand.Parameters.Add("@companyaddress", SqlDbType.VarChar, (20)).Value = textBox3.Text;
            data.SelectCommand.Parameters.Add("@companytelephone ", SqlDbType.VarChar, (70)).Value = textBox2.Text;
            data.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("welcome");
            new sign_in().Show();
            this.Close();
        }
    }
}
