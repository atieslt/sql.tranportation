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
    public partial class Form1 : Form
    {
        SqlConnection sql1 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
            " DataBase=transportation;" +
            " Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql1.Open();
            SqlDataAdapter data = new SqlDataAdapter("addNewTicket", sql1);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;

            data.SelectCommand.Parameters.Add("@origin", SqlDbType.VarChar, (50)).Value = txtorigin.Text;
            data.SelectCommand.Parameters.Add("@capacity", SqlDbType.Int).Value = txtcapacity.Text;//int
            data.SelectCommand.Parameters.Add("@price", SqlDbType.VarChar, (15)).Value = txtprice.Text;
            data.SelectCommand.Parameters.Add("@distination", SqlDbType.VarChar, (50)).Value = txtdistination.Text;
            data.SelectCommand.Parameters.Add("@ticketdate", SqlDbType.Date).Value = txtticketdate.Text;
            data.SelectCommand.Parameters.Add("@tickettime", SqlDbType.DateTime).Value = txttickettime.Text;
            data.SelectCommand.Parameters.Add("@ticketid", SqlDbType.Char, (10)).Value = txtticketid.Text;
            data.SelectCommand.Parameters.Add("@branchid", SqlDbType.Int).Value = txtbranchid.Text;
            data.SelectCommand.Parameters.Add("@idcode", SqlDbType.Char,(10)).Value = txtidcode.Text;
            //data.SelectCommand.Parameters.Add("@ssn", SqlDbType.Char, (10)).Value = this.label6.Text;

            
            
            
            
            
            data.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Your Ticket Has Been Added ...");

            //Home home = new Home(label6.Text);
            //home.Show();

            this.Close();
        }

        private void txtorigin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
