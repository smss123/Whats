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

namespace Xaina.Advertisement_Forms
{
    public partial class EditAdvertisementFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditAdvertisementFrm()
        {
            InitializeComponent();
        }
        XpremaFileManager cmd = new XpremaFileManager();
        AdvertisemetCommand AdvClss = new AdvertisemetCommand();
        Alerts.Alerts fr = new Alerts.Alerts();
        private void EditAdvertisementFrm_Load(object sender, EventArgs e)
        {
            FilladvertismentslookUpEdit();

            FillCustomerslookupEdit();
        }

        private void FillCustomerslookupEdit()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }

        private void FilladvertismentslookUpEdit()
        {
            cmd = new XpremaFileManager();
            advertismentsBindingSource.DataSource = cmd.DB.Advertisments;
            
        }

        private void SelectAdvrlookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var q = AdvClss.GetByID(int.Parse(SelectAdvrlookUpEdit.EditValue.ToString()));
            EditCustomerlookUpEdit.EditValue = q.CustomerID;
            EditMsgTextrichTextBox.Text = q.MessageText;
        }

        private void SaveAdvBtn_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to save changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AdvClss.EditAdvertismet(EditMsgTextrichTextBox.Text, int.Parse(EditCustomerlookUpEdit.EditValue.ToString()),int.Parse(SelectAdvrlookUpEdit.EditValue.ToString()));
                FilladvertismentslookUpEdit();
                fr.Show_Info_MSG(this, "Done");

            }
        }


    }
}