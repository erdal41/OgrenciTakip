using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class IndirimTuruBll : BaseGenelBll<IndirimTuru>, IBaseGenelBll, IBaseCommonBll
    {
        public IndirimTuruBll() : base(KartTuru.IndirimTuru) { }

        public IndirimTuruBll(Control ctrl) : base(ctrl, KartTuru.IndirimTuru) { }
    }
}