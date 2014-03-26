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
using System.Collections;

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
            customersBindingSource.DataSource = null;
           
         
           
             
            }
            
        }
    }
}