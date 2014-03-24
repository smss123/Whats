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
    public partial class GridEditAdvertisementFrm : DevExpress.XtraEditors.XtraForm
    {
        public GridEditAdvertisementFrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
        private AdvertisemetCommand AdvClss = new AdvertisemetCommand();
        
        private void GridEditAdvertisementFrm_Load(object sender, EventArgs e)
        {
            cmd = new XpremaFileManager();
            advertismentsBindingSource.DataSource = cmd.DB.Advertisments;
            customersBindingSource.DataSource = cmd.DB.Customers;
             


        }


    }
}