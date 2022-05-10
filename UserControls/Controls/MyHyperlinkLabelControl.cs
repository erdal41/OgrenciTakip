using DevExpress.XtraEditors;
using OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyHyperlinkLabelControl : HyperlinkLabelControl, IStatusBarAciklama
    {
        public MyHyperlinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;
        }

        public string StatusBarAciklama { get; set; }
    }
}