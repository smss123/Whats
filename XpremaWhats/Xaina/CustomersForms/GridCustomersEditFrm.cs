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

namespace Xaina.CustomersForms
{
    public partial class GridCustomersEditFrm : DevExpress.XtraEditors.XtraForm
    {
        public GridCustomersEditFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private CustomerCommand CusClss = new CustomerCommand();
        private Alerts.Alerts fr = new Alerts.Alerts();
        private void GridCustomersEditFrm_Load(object sender, EventArgs e)
        {
            FillGridView();
           
            gridView1.ViewCaption = "Customers Data";

        }

        private void FillGridView()
        {
            cmd = new XpremaFileManager();
            customersBindingSource.DataSource = cmd.DB.Customers;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            cmd.CommitData();

            FillGridView();


        }
    }
}