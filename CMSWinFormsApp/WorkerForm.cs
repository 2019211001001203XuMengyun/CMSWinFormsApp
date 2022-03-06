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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDatabaseDataSet.tblWorker.Clear();
            sqlDataAdapterl.Fill(this.cMSDatabaseDataSet.tblWorker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapterl.Updata(this.cMSDatabaseDataSet.tblWorker);
            MessageBox.Show("The Worker Table is Updated");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSDatabaseDataSet.tblWorker.Clear();
            sqlDataAdapterl.Fill(this.cMSDatabaseDataSet.tblWorker);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this Close();
        }
    }
}
