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


namespace Xaina.SenderNumber
{
    public partial class GridEditSenderNumbersFrm : DevExpress.XtraEditors.XtraForm
    {
        public GridEditSenderNumbersFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private SenderNumberCommand SendrCluss = new SenderNumberCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private   void GridEditSenderNumbersFrm_Load(object sender, EventArgs e)
        {
            // cmd = new XpremaFileManager();

            senderNumberBindingSource.DataSource = cmd.DB.SenderNumber;
            gridControl1.RefreshDataSource();
            

        }

        private void FillSenderNumberGridView()
        {
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("would you like to Save Changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                senderNumberBindingSource.EndEdit();
                cmd.CommitData();
                fr.Show_Info_MSG(this, "Save Changes Done");

            }
           
        }

    }
}