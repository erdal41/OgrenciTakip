using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class HizmetTuruBll : BaseGenelBll<HizmetTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public HizmetTuruBll() : base(KartTuru.HizmetTuru) { }

        public HizmetTuruBll(Control ctrl) : base(ctrl, KartTuru.HizmetTuru) { }
    }
}