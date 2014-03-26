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

namespace Xaina.CustomersForms
{
    public partial class DeleteCustomersFrm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteCustomersFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private CustomerCommand CusClss = new CustomerCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void DeleteCustomersFrm_Load(object sender, EventArgs e)
        {
            FillGridView();
        }
        private void FillGridView()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }
        //private void FillCustmoersLookUpEdit()
        //{
        //    cmd = new XpremaFileManager();
        //    var q = cmd.DB.Customers;
        //    CustomerSearchlookUpEdit.Properties.DataSource = q;

        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButtonEdit1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.RemoveCurrent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void StartDeleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridColumn1.Visible = true;
        }

        private void SaveChangesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to save changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                customersBindingSource.EndEdit();
                cmd.CommitData();

                FillGridView();
                fr.Show_Info_MSG(this, "Save Changes Done");
                gridColumn1.Visible = false;
            }

        }
    }
}