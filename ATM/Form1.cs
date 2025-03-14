﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {


        mysqlQ myquies = new mysqlQ();
        public Form1()
        {
            InitializeComponent();
        }

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = myquies.IdentifierUser(UserNameBox.Text, PasswordBox.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    //this.Hide();
                    //MainForm startMain = new MainForm(dt.Rows[0][0].ToString(), dt.Rows[0][3].ToString());
                    //startMain.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
