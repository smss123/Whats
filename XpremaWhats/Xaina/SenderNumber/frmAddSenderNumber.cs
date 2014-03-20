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
using Xprema.XdataType;
using Xprema.Commands;


namespace Xaina.SenderNumber
{
    public partial class frmAddSenderNumber : DevExpress.XtraEditors.XtraForm
    {
        public frmAddSenderNumber()
        {
            InitializeComponent();
        }

       private XpremaFileManager cmd = new XpremaFileManager();
       private SenderNumberCommand sendNumClass = new SenderNumberCommand();
       private Alerts.Alerts fr = new Alerts.Alerts();
        private void frmAddSenderNumber_Load(object sender, EventArgs e)
        {

        }

        private void AddSenderNUmberBtn_Click(object sender, EventArgs e)
        {
           
            sendNumClass.AddSender(new PhoneNumber("", "", SenderNumbertextEdit.Text), PasswordtextEdit.Text, int.Parse(NumberOfmessagetextEdit.Text),Convert.ToBoolean(StatuscomboBoxEdit.Text), int.Parse(CountertextEdit.Text));
             //CusClss.AddNewCustomer(new Name( CustomerNametextEdit.Text,"",""), new PhoneNumber("","", CustomerPhonetextEdit.Text), new Email( CustomerEmailtextEdit.Text));
        }
    }
}