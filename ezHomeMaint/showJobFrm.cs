using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezHomeMaint
{
    public partial class showJobFrm : Form
    {
        public showJobFrm()
        {
            InitializeComponent();
        }

        private void showJobFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ezMaintdbDataSet.work' table. You can move, or remove it, as needed.
            this.workTableAdapter.Fill(this.ezMaintdbDataSet.work);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteJobBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateJobDataBase jobDataBase = new UpdateJobDataBase();
                jobDataBase.DeleteJob(jobDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                
                jobDataGrid.Rows.RemoveAt(jobDataGrid.SelectedRows[0].Index);
                MessageBox.Show("Work successfully removed.");
            }
            catch (Exception)
            {

                MessageBox.Show("Mark the whole lane!");
            }

        }

        private void updateJobBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string rdcheck = "";

                if (closedRdBtn.Checked)
                    rdcheck = "Closed";
                else if (openRdBtn.Checked)
                    rdcheck = "Open";
                else if (waitRdBtn.Checked)
                    rdcheck = "Waiting on spares";

                UpdateJobDataBase statusUpdate = new UpdateJobDataBase();
                statusUpdate.StatusWork(rdcheck, jobDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                this.workTableAdapter.Fill(this.ezMaintdbDataSet.work);
            }
            catch (Exception)
            {
                MessageBox.Show("Mark the whole lane please");
            }
        }
    }
}
