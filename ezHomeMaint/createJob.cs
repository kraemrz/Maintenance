using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezHomeMaint
{
    public partial class createJob : Form
    {
        public createJob()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addJobBtn_Click(object sender, EventArgs e)
        {
            UpdateJobDataBase updateJob = new UpdateJobDataBase();
            
            updateJob.AddWork(roomTxt.Text, dateTxt.Text, descriptionTxt.Text, jobStatusTxt.Text);

            roomTxt.Text = "";
            dateTxt.ResetText();
            descriptionTxt.Text = "";
            jobStatusTxt.Text = "Open";

        }
    }
}
