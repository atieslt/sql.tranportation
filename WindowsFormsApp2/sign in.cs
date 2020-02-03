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
    public partial class sign_in : Form
    {
        SqlConnection sql3 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
                 " DataBase=transportation;" +
                 " Integrated Security=true");
        public sign_in()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           SqlDataAdapter data = new SqlDataAdapter("checkuser", sql3);
           data.SelectCommand.CommandType = CommandType.StoredProcedure;
           data.SelectCommand.Parameters.AddWithValue("@Clinentid", textBox3.Text.Trim());
           data.SelectCommand.Parameters.AddWithValue("@Idcode", textBox1.Text.Trim());
           DataTable da = new DataTable();
           data.Fill(da);

            if (da.Rows.Count == 0)
            {
                MessageBox.Show(".نام کاربری یا رمز عبور خود را اشتباه وارد کرده اید", "!توجه");
                textBox3.ResetText();
                textBox1.ResetText();
                textBox3.Focus();
            }
            else
            {
                new userpage().Show();
                //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Close();
        }
    }
}
