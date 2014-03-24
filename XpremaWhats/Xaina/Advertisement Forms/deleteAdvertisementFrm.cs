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
    public partial class deleteAdvertisementFrm : DevExpress.XtraEditors.XtraForm
    {
        public deleteAdvertisementFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private AdvertisemetCommand AdvClss = new AdvertisemetCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void deleteAdvertisementFrm_Load(object sender, EventArgs e)
        {
            FillAdvertisementData();

        }

        private void FillAdvertisementData()
        {
            cmd = new XpremaFileManager();
            advertismentsBindingSource.DataSource = cmd.DB.Advertisments;
            customersBindingSource.DataSource = cmd.DB.Customers;
            //repositoryItemLookUpEdit1.DataSource = cmd.DB.Customers;
            //repositoryItemLookUpEdit1.DisplayMember = "CustomerName";

            //repositoryItemLookUpEdit1.ValueMember = "ID";

        } 
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            this.advertismentsBindingSource.RemoveCurrent();

            

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void SearchDateBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void SaveChangesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Would you like to Save Changes", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                advertismentsBindingSource.EndEdit();
                cmd.CommitData();
                fr.Show_Info_MSG(this, "Done");
                FillAdvertisementData();
            }
        }
    }
}