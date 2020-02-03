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
    public partial class buyticket : Form
    {
        SqlConnection sql4 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
                      " DataBase=transportation;" +
                       " Integrated Security=true");
        public buyticket()
        {
            InitializeComponent();
        }

        private void buyticket_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter("checkticket_taxi", sql4);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@idcode", SqlDbType.Char, (10)).Value = textBox1.Text;
            data.SelectCommand.Parameters.AddWithValue("@Orgin", txtorigin.Text.Trim());
            data.SelectCommand.Parameters.AddWithValue("@Distination", txtdistination.Text.Trim());
            data.SelectCommand.Parameters.AddWithValue("@Date", txtticketdate.Text.Trim());
            DataTable da = new DataTable();
            data.Fill(da);

            if (da.Rows.Count == 0)
            {
                MessageBox.Show(".نام کاربری یا رمز عبور خود را اشتباه وارد کرده اید", "!توجه");
                txtorigin.ResetText();
                txtdistination.ResetText();
                txtticketdate.Focus();
            }
            else
            {

            }
        }
    }
}
