using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Xprema.Commands;
using Xprema.Data;
using Xprema.XdataType;

namespace Xaina.CustomersForms
{
    public partial class AddCustomerFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddCustomerFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private CustomerCommand CusClss = new CustomerCommand();
        Alerts.Alerts fr = new Alerts.Alerts();
        private void AddCustomerFrm_Load(object sender, EventArgs e)
        {
            cmd = new XpremaFileManager();
        }

        private void AddCoustmersBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNametextEdit.Text == "")
            {
                fr.Show_Error_MSG(this, "please enter customer name ");
                CustomerNametextEdit.Focus();
                return;

            }
           
            CusClss.AddNewCustomer(new Name( CustomerNametextEdit.Text,"",""), new PhoneNumber("","", CustomerPhonetextEdit.Text), new Email( CustomerEmailtextEdit.Text));
            fr.Show_Info_MSG(this, "Done");

        }

        private void CustomerNametextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}