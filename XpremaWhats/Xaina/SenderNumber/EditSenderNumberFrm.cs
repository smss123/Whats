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

namespace Xaina.SenderNumber
{
    public partial class EditSenderNumberFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditSenderNumberFrm()
        {
            InitializeComponent();
        }
        XpremaFileManager cmd = new XpremaFileManager();
        private SenderNumberCommand sendNumClass = new SenderNumberCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void EditSenderNumberFrm_Load(object sender, EventArgs e)
        {
            senderNumberBindingSource.DataSource = cmd.DB.SenderNumber;

        }

        private void SelectNumberlookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var q = sendNumClass.GetById(int.Parse(SelectNumberlookUpEdit.EditValue.ToString()));
            EditNumbertextEdit.Text = q.SenderNumber;
            EditpasswordtextEdit.Text = q.Password;
            EditNumberMessagetextEdit.Text = q.NumberOfMessageInDay;
            EditCountertextEdit.Text = q.Counter.ToString();
            EditStatuscomboBoxEdit.Text = q.Status.ToString();
        }

        private void EditSenderNumberBtn_Click(object sender, EventArgs e)
        {
            if (EditNumbertextEdit.Text == "")
            {
                fr.Show_Error_MSG(this, "please enter The phone Number ");
                EditNumbertextEdit.Focus();
                return;

            }
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to save changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sendNumClass.EditSender(new PhoneNumber("", "", EditNumbertextEdit.Text), EditpasswordtextEdit.Text, int.Parse(EditNumberMessagetextEdit.Text),bool.Parse(EditStatuscomboBoxEdit.Text), int.Parse(SelectNumberlookUpEdit.EditValue.ToString()), int.Parse(EditCountertextEdit.Text));
                fr.Show_Info_MSG(this, "Done");
            }
        }
    }
}