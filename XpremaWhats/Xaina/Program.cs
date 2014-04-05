using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Xaina
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new MainFrm());
        }
    }
}
