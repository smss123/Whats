using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using Xprema.Services;

namespace Xaina.ServicesForms
{
    public partial class GeneratNumberFrm : DevExpress.XtraEditors.XtraForm
    {
        public GeneratNumberFrm()
        {
            InitializeComponent();
        }
        GeneratNumbers Cntry = new GeneratNumbers();
        Thread Thrd;
        void PopulateCmbs()
        {
            CmbCountries.Properties.Items.Clear();
            CmbKeys.Properties.Items.Clear();
            Cntry = new GeneratNumbers();
            foreach (var Country in Cntry.PopulateCountries())
            {
                CmbCountries.Properties.Items.Add(Country);
            //    label1.Text = "Total Countries Is :   " + CmbCountries.Items.Count;
            }


            Cntry = new GeneratNumbers();
            var Kys = from k in Cntry.AllKeys() where k != null select k;
            foreach (var Ky in Kys)
            {
                CmbKeys.Properties.Items.Add(Ky);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void GNumbers()
        {
            Cntry = new GeneratNumbers();
            CmbPhones.Properties.Items.Clear();

            progressBarControl1.Visible = true;
            // var Keyss = from k in Cntry.AllKeys( ) select k;
            var Nmbrs = from N in Cntry.GeneratePhoneNumbers(int.Parse(XKeys.Text), NumbersBox.Text) select N;


            // foreach ( var j in Keyss ) { 
            foreach (var Nbr in Nmbrs)
            {
                CmbPhones.Properties.Items.Add(Nbr);
            }
            //   }
        //    progressBarControl1.Visible = false;
            
        }

        private void CmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        //private void button2_Click(object sender, EventArgs e) {




        //}
        #region
        public static void SyncWaContacts(string username, string password)
        {
            //Contact[] contacts = ContactStore.GetAllContacts();
            //List<string> input = new List<string>();
            //foreach (Contact c in contacts) {
            //    input.Add(c.jid.Split('@').First()); 
            //}
            //ContactSync s = new ContactSync(username, password);
            //try { ContactSyncResult[] res = s.Sync(input.ToArray());
            //    if (res != null) {
            //        foreach (ContactSyncResult r in res) {
            //            if (r.w == 1) {
            //                string jid = r.n + "@s.whatsapp.net";
            //                Contact con = ContactStore.GetContactByJid(jid);
            //                if (con != null && con.status != r.s) {
            //                    //update status 
            //                    if changed con.status = r.s;
            //                    ContactStore.UpdateStatus(con);
            //                    ContactStore.UpdateNickname(con);
            //                }
            //            } else 
            //            { //delete Contact
            //                con = ContactStore.GetContactByJid(r.n + "@s.whatsapp.net");
            //                if (con != null) {
            //                    ContactStore.DeleteContact(con); 
            //                }
            //            } 
            //        } 
            //    } 
            //} catch (Exception) 
            //{ 
            //} 
        }
        #endregion

        private void GeneratNumberFrm_Load(object sender, EventArgs e)
        {
           

            progressBarControl1.Visible = false;
            PopulateCmbs();
        }

        private void CmbCountries_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            CmbKeys.SelectedIndex = CmbCountries.SelectedIndex;

            for (int i = 0; i < (CmbKeys.Properties.Items.Count - 1); i++)
            {
                CmbKeys.Text = CmbKeys.Properties.Items[CmbCountries.SelectedIndex].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thrd = new Thread(new ThreadStart(GNumbers));
            Thrd.IsBackground = true;
            Thrd.Start();
            MessageBox.Show("xx");
        }

        private void CmbKeys_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CmbCountries.SelectedIndex = CmbKeys.SelectedIndex;
            for (int i = 0; i < (CmbCountries.Properties.Items.Count - 1); i++)
            {
                CmbCountries.Text = CmbCountries.Properties.Items[CmbKeys.SelectedIndex].ToString();
                XKeys.Text = CmbKeys.Text;
            }
        }
    }
}