using OgrenciTakip.UI.Win.Functions;
using OgrenciTakip.UI.Yonetim.Forms.GenelForms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Yonetim
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GeneralFunctions.EncryptConfigFile(AppDomain.CurrentDomain.SetupInformation.ApplicationName, "connectionStrings", "appSettings");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            Application.Run(new GirisForm());
        }
    }
}
