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
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createJobBtn_Click(object sender, EventArgs e)
        {
            Form createJob = new createJob();
            createJob.Show();
            
        }

        private void viewJobBtn_Click(object sender, EventArgs e)
        {
            Form showJob = new showJobFrm();
            showJob.Show();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createSpareBtn_Click(object sender, EventArgs e)
        {
            Form addSpare = new createSpare();
            addSpare.Show();
        }

        private void viewSparesBtn_Click(object sender, EventArgs e)
        {
            Form showSpares = new showSpares();
            showSpares.Show();
        }
    }
}
