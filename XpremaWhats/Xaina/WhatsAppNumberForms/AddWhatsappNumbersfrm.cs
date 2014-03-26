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
using Xprema.Services;
using System.Threading;
namespace Xaina.WhatsAppNumberForms
{
    public partial class AddWhatsappNumbersfrm : DevExpress.XtraEditors.XtraForm
    {
        public AddWhatsappNumbersfrm()
        {
            InitializeComponent();
        }
        private XpremaFileManager cmd = new XpremaFileManager();
     
        private Alerts.Alerts fr = new Alerts.Alerts();
       

      // ^^^   { Abu Ehab } Class Object ....   
        GeneratNumbers ContryCmd = new GeneratNumbers();
        CheckNumbers ChkCmd = new CheckNumbers();
        WhatsAppNumberCommand WCmd = new WhatsAppNumberCommand();


        #region " { Abu Ehab } Populate ComboBox By 203 Countreis Until Now    "
        void PopulateCmb() {
           ContryCmd = new GeneratNumbers();
                CmbCountries.Properties.Items.Clear();
                foreach (var Cntry in ContryCmd .PopulateCountries ())
                {
                    CmbCountries.Properties.Items.Add(Cntry);
                }         
        }

        #endregion 

        private void WhatsAppNumberAddBtn_Click(object sender, EventArgs e)
        {
            WCmd = new WhatsAppNumberCommand();
          
           


        }
        //=============================================================================

        private void AddWhatsappNumbersfrm_Load(object sender, EventArgs e)
        {
            PopulateCmb();

            //Control.CheckForIllegalCrossThreadCalls = false;

            //Thread Thrd = new Thread(new ThreadStart(ChkCmd.SaveAllWhatsAppNoAtXMLFile));
            //Thrd.IsBackground = true;
            //Thrd.Start();


        }

      
    }
}