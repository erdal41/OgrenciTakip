using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class OdemeTuruBll : BaseGenelBll<OdemeTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public OdemeTuruBll() : base(KartTuru.OdemeTuru) { }

        public OdemeTuruBll(Control ctrl) : base(ctrl, KartTuru.OdemeTuru) { }
    }
}