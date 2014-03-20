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


namespace Xaina.NumberGroupsFroms
{
    public partial class AddGroupsFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddGroupsFrm()
        {
            InitializeComponent();
        }
        XpremaFileManager cmd = new XpremaFileManager();
        
        private void AddGroupsFrm_Load(object sender, EventArgs e)
        {

        }
    }
}