using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using StockUpdater.UtilityText;
using System.IO;

namespace StockUpdater
{
    public partial class StockUpdater : Form
    {
        TextManager file = new TextManager();
        public StockUpdater()
        {
            InitializeComponent();
            txtStockFileLocation.Text = file.GetStockFileLocation();
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                //if (xlApp == null)
                //{
                //    MessageBox.Show("Excel is not properly installed!!");
                //    return;
                //}
                //ExcelManager mgr = new ExcelManager();
                //mgr.UpdateStock(xlApp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Updation failed!!! " + ex.Message);
            }
        }

        private void btnChangeFileLocation_Click(object sender, EventArgs e)
        {
            try
            {
                file.UpdateStockFileLocation(txtStockFileLocation.Text);
                MessageBox.Show("Location updated.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Location update failed, "+ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtStockFileLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to exit the application?", "Exit", MessageBoxButtons.YesNo) ==
         System.Windows.Forms.DialogResult.Yes)
                this.Close();

        }
    }
}
