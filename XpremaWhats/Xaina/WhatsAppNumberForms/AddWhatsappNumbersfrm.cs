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
namespace Xaina.WhatsAppNumberForms
{
    public partial class AddWhatsappNumbersfrm : DevExpress.XtraEditors.XtraForm
    {
        public AddWhatsappNumbersfrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private WhatsAppNumberCommand WtsappClss = new WhatsAppNumberCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void WhatsAppNumberAddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}