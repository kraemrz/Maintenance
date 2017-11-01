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
    public partial class showSpares : Form
    {
        public showSpares()
        {
            InitializeComponent();
        }

        private void showSpares_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ezMaintdbDataSet.spares' table. You can move, or remove it, as needed.
            this.sparesTableAdapter.Fill(this.ezMaintdbDataSet.spares);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteSpare_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSpareDataBase updateSpare = new UpdateSpareDataBase();
                updateSpare.DeleteSpare(spareDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                spareDataGrid.Rows.RemoveAt(spareDataGrid.SelectedRows[0].Index);
                MessageBox.Show("Spare part successfully removed.");
            }
            catch (Exception)
            {

                MessageBox.Show("Mark the whole lane!");
            }
        }

        private void editQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateSpareDataBase updateQty = new UpdateSpareDataBase();
                updateQty.EditQuantity(newQty.Text, spareDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                this.sparesTableAdapter.Fill(this.ezMaintdbDataSet.spares);
            }
            catch (Exception)
            {
                MessageBox.Show("Mark the whole lane please");
            }
        }
    }
}
