using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;

namespace OgrenciTakip.UI.Win.GenelForms
{
    public partial class Baslatiliyor : SplashScreen
    {
        public Baslatiliyor()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2018-" + DateTime.Now.Year.ToString() + " | Abc Yazılım";
            lblVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}