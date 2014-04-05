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
using System.Drawing;
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
        private void PopualteCountries() { 
      
        
        
        }
        Thread Thrd;



        private void AddWhatsappNumbersfrm_Load(object sender, EventArgs e)
        {
            PopulateCmb();

            Control.CheckForIllegalCrossThreadCalls = false;

          Thrd = new Thread(new ThreadStart(xxxxx));
            Thrd.IsBackground = true;
            Thrd.Start();
            // محمد  وينك ؟؟؟؟؟
    ////موج ود يس الصوت وينه 
            //      حط كمبوبكس مخفي عل الفورم
            //تمام هيك  تمام  سمية : CmbAllK
        /// البرنامج بطفي لحاله 
        /// عدل  شغل رن          طيب   بدنا نشغله في الثريد 

           /// Runnnnnnnnnnnnnnnnnnnnnnnnnnn
           
        }

        private void xxxxx()
        {
            CmbAllKeyes.DataSource = ContryCmd.AllKeys();
            CmbAllKeyes.Visible = false;
          // run 
        }

        private void CmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCountries .Text !="")
            {
                CmbAllKeyes.Text = null;
                KeyBox.Text = null;
                for (int i = 0; i < CmbAllKeyes.Items.Count - 1; i++)
                {
                    if (CmbCountries.SelectedIndex != 0)
                    {
                        CmbAllKeyes.Text = CmbAllKeyes.Items[CmbCountries.SelectedIndex].ToString();
                        KeyBox.Text = CmbAllKeyes.Text;
      
                    }
                }
            }
        }

      
    }
}