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
            cmd = new XpremaFileManager();
        }

        private void AddSenderNUmberBtn_Click(object sender, EventArgs e)
        {
            if (SenderNumbertextEdit.Text == "")
            {
                fr.Show_Error_MSG(this, "please enter customer name ");
                SenderNumbertextEdit.Focus();
                return;

            }
            bool status = Boolean.Parse(StatuscomboBoxEdit.Text);
            sendNumClass.AddSender(new PhoneNumber("", "", SenderNumbertextEdit.Text), PasswordtextEdit.Text, int.Parse(NumberOfmessagetextEdit.Text), status, int.Parse(CountertextEdit.Text));
            GC.SuppressFinalize(sendNumClass);
          // fr.Show_Info_MSG(this, "Done");
            
        }
    }
}