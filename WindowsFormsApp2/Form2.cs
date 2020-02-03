﻿using System;
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
    public partial class Form2 : Form
    {
        SqlConnection sql1 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
            " DataBase=transportation;" +
            " Integrated Security=true");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql1.Open();
            SqlDataAdapter data = new SqlDataAdapter("sign_up_asuser", sql1);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@clientid", SqlDbType.VarChar, (11)).Value = textBox1.Text;
            data.SelectCommand.Parameters.Add("@idcode", SqlDbType.Char, (10)).Value = textBox6.Text;
            data.SelectCommand.Parameters.Add("@fullname", SqlDbType.VarChar, (20)).Value = textBox5.Text;
            data.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar, (70)).Value = textBox4.Text;
            data.SelectCommand.Parameters.Add("@clienttelephone", SqlDbType.VarChar, (11)).Value = textBox3.Text;
            data.SelectCommand.Parameters.Add("@gender", SqlDbType.VarChar, (6)).Value = textBox2.Text;
            data.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("welcome");
            new sign_in().Show();
            this.Close();
        }
    }
}
