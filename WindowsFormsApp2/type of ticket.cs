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
            new bus().Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new taxi().Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new International_Fight().Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Freight_Train().Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Passenger_Train().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Domwstic_Flight().Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Freight_Ship().Show();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Passenger_Ship().Show();
          
        }

        private void type_of_ticket_Load(object sender, EventArgs e)
        {

        }
    }
}
