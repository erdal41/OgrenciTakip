using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class KurumBll : BaseGenelYonetimBll<Kurum>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumBll() : base(KartTuru.Kurum) { }

        public KurumBll(Control ctrl) : base(ctrl, KartTuru.Kurum) { }
    }
}