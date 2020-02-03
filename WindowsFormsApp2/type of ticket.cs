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
    public partial class type_of_ticket : Form
    {
        SqlConnection sql1 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
              " DataBase=transportation;" +
                 " Integrated Security=true");
        public type_of_ticket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
