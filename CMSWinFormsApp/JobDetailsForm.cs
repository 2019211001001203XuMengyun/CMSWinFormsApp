﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class btnDelete : Form
    {
        public btnDelete()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text=="")||(txtCarNo.Text== null))
            {
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please Specify a Valid Car Number");
                    txtCarNo.Focus();
                    return;
                }
                if (Convert.ToInt32(txtWorkerId.Text) < 1)
                {
                    MessageBox.Show("Please Specify a Valid Worker ID");
                    txtCarNo.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify a Valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            private void btnExit_Click(object sender,EventArgs e)
            {
                this.Close();
            }
    }
}
