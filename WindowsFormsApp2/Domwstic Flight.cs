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
    public partial class Domwstic_Flight : Form
    {
        SqlConnection sql11 = new SqlConnection("server=DESKTOP-CKGL1BN\\SQL2019 ;" +
        " DataBase=transportation;" +
         " Integrated Security=true");
        public Domwstic_Flight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql11.Open();
            SqlDataAdapter data = new SqlDataAdapter("Domwstic_Flight", sql11);
            data.SelectCommand.CommandType = CommandType.StoredProcedure;
            data.SelectCommand.Parameters.Add("@ticketid", SqlDbType.Char, (13)).Value = textBox3.Text;
            data.SelectCommand.Parameters.Add("@origin", SqlDbType.VarChar, (25)).Value = textBox1.Text;
            data.SelectCommand.Parameters.Add("@distination", SqlDbType.VarChar, (25)).Value = textBox4.Text;
            data.SelectCommand.Parameters.Add("@date", SqlDbType.Date).Value = textBox5.Text;
            data.SelectCommand.Parameters.Add("@time", SqlDbType.Time).Value = textBox6.Text;
            data.SelectCommand.Parameters.Add("@capacity", SqlDbType.Int).Value = textBox7.Text;
            data.SelectCommand.Parameters.Add("@price", SqlDbType.VarChar, (9)).Value = textBox8.Text;
            data.SelectCommand.Parameters.Add("@branchid", SqlDbType.Int).Value = textBox9.Text;
            data.SelectCommand.ExecuteNonQuery();
        }
    }
}
