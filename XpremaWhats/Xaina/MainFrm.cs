using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Xaina.WhatsAppNumberForms;
using Xaina.SenderNumber;
using Xaina.CustomersForms;

namespace Xaina
{
    public partial class MainFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void AddWhatsUpNumberBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddWhatsappNumbersfrm addWhapp = new AddWhatsappNumbersfrm();
            addWhapp.ShowDialog();
        }

        private void EditWhatsUpNumberBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditWhatsAppNumbersFrm EdtWhaap = new EditWhatsAppNumbersFrm();
            EdtWhaap.ShowDialog();

        }

        private void AddSenderNumberBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAddSenderNumber addSendNumb = new frmAddSenderNumber();
            addSendNumb.ShowDialog();
        }

        private void EditSenderNumberBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditSenderNumberFrm editsend = new EditSenderNumberFrm();
            editsend.ShowDialog();

        }

        private void AddCustomersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddCustomerFrm CusAddFrm = new AddCustomerFrm();
            CusAddFrm.ShowDialog();
        }
    }
}