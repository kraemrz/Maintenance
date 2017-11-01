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
    public partial class createSpare : Form
    {
        public createSpare()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UpdateSpareDataBase updateSpare = new UpdateSpareDataBase();
            updateSpare.AddSpare(artTxt.Text, nameTxt.Text, locTxt.Text, quantityTxt.Text);

            artTxt.Text = "";
            nameTxt.Text = "";
            locTxt.Text = "";
            quantityTxt.ResetText();
        }
    }
}
