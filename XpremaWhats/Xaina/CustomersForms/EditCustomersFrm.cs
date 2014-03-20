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
using Xprema.XdataType;

namespace Xaina.CustomersForms
{
    public partial class EditCustomersFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditCustomersFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private CustomerCommand CusClss = new CustomerCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void EditCustomersFrm_Load(object sender, EventArgs e)
        {
            FillLookUpEditCustomer();
        }

        private void FillLookUpEditCustomer()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }

        private void SelectCostumerlookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var q =  CusClss.GetCustomerByID(int.Parse(SelectCostumerlookUpEdit.EditValue.ToString()));
            EditCustomertextEdit.Text = q.CustomerName;
            EditCustomerPhonetextEdit.Text = q.CustomerPhone;
            EditCoustmerEmailtextEdit.Text = q.CustomerEmail;

        }

        private void SaveCustomersimpleButton1_Click(object sender, EventArgs e)
        {
            if (EditCustomertextEdit.Text == "")
            {
                fr.Show_Error_MSG(this, "please enter customer name ");
                EditCustomertextEdit.Focus();
                return;

            }
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to save changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CusClss.EditCustomer(new Name(EditCustomertextEdit.Text, "", ""), new PhoneNumber("", "", EditCustomerPhonetextEdit.Text), new Email(EditCoustmerEmailtextEdit.Text), int.Parse(SelectCostumerlookUpEdit.EditValue.ToString()));
                fr.Show_Info_MSG(this, "Done");
                FillLookUpEditCustomer();

            }

        }

        private void GridEditBtn_Click(object sender, EventArgs e)
        {
            GridCustomersEditFrm GrCusEdit = new GridCustomersEditFrm();
            GrCusEdit.ShowDialog();
        }


    }
}