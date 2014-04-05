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
using Xaina.Advertisement_Forms;
using Xaina.ServicesForms;

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

        private void EditCustomersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditCustomersFrm CusEdit = new EditCustomersFrm();
            CusEdit.ShowDialog();
        }

        private void addAdvertisementsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddAdvertisementFrm AdvaddFrm = new AddAdvertisementFrm();
            AdvaddFrm.ShowDialog();
        }

        private void EditAdvertisementsBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditAdvertisementFrm editAdvFrm = new EditAdvertisementFrm();
            editAdvFrm.ShowDialog();
        }

        private void DeleteCustomersBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteCustomersFrm CusDelFrm = new DeleteCustomersFrm();
            CusDelFrm.ShowDialog();
        }

        private void DeleteAdvertisementBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            deleteAdvertisementFrm delAdvFrm = new deleteAdvertisementFrm();
            delAdvFrm.ShowDialog();
        }

        private void GenaretNumberClick_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GeneratNumberFrm Gerfrm = new GeneratNumberFrm();
            Gerfrm.ShowDialog();
        }

        private void CheckSenderService_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCheckSenders sen = new frmCheckSenders();
            sen.ShowDialog();
        }
    }
}