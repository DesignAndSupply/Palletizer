using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Palletizer.Class;

namespace Palletizer.Forms
{
    public partial class frmAllocationType : Form
    {
        public frmAllocationType()
        {
            InitializeComponent();
        }

        private void frmAllocationType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet.c_view_palletizer_visual' table. You can move, or remove it, as needed.
            this.c_view_palletizer_visualTableAdapter.Fill(this.order_databaseDataSet.c_view_palletizer_visual);

        }


        private void hideSelector()
        {
            if (rdoAuto.Checked == true)
            {
                lblPalletID.Visible = false;
                cmbPalletID.Visible = false;

            }
            else
            {
                lblPalletID.Visible = true;
                cmbPalletID.Visible = true;
            }


        }

        private void rdoManual_CheckedChanged(object sender, EventArgs e)
        {
            hideSelector();
        }

        private void rdoAuto_CheckedChanged(object sender, EventArgs e)
        {
            hideSelector();
        }

        private void frmAllocationType_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            if (rdoAuto.Checked == true)
            {
                Allocation._getAllocationType = "Auto";

            }
            else
            {
                Allocation._getAllocationType = "Manual";
                Allocation._getManualPallet = cmbPalletID.Text;
            }
            this.Close();
        }

        private void frmAllocationType_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
