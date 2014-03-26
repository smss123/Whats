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
    public partial class AddAdvertisementFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddAdvertisementFrm()
        {
            InitializeComponent();
        }
        XpremaFileManager cmd = new XpremaFileManager();
        AdvertisemetCommand AdvClss = new AdvertisemetCommand();
        Alerts.Alerts fr = new Alerts.Alerts();
        private void AddAdvertisementFrm_Load(object sender, EventArgs e)
        {
            CustmorsLookupEdit();

            
        }

        private void CustmorsLookupEdit()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }

        private void AddAdvertisementBtn_Click(object sender, EventArgs e)
        {
            AdvClss.AddAdvertisement(MessgTextrichTextBox.Text,int.Parse(CustomersLookUpEdit.EditValue.ToString()));
            fr.Show_Info_MSG(this, "Done");

        }
    }
}