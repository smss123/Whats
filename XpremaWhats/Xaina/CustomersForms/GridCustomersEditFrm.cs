using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Xprema.Data;
using Xprema.Commands;
using DevExpress.XtraGrid.Columns;

namespace Xaina.CustomersForms
{
    public partial class GridCustomersEditFrm : DevExpress.XtraEditors.XtraForm
    {
        public GridCustomersEditFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private CustomerCommand CusClss = new CustomerCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void GridCustomersEditFrm_Load(object sender, EventArgs e)
        {
            FillGridView();
           
           

        }

        private void FillGridView()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            


        }

        private void StartEditBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            this.gridView1.OptionsBehavior.ReadOnly = false;
            fr.Show_Info_MSG(this, "Start To Edit");
        
        }

        private void SaveChangesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to save changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customersBindingSource.EndEdit();
                cmd.CommitData();

                FillGridView();
                fr.Show_Info_MSG(this, "Save Changes Done");
                this.gridView1.OptionsBehavior.ReadOnly = true;
            }
        }
    }
}