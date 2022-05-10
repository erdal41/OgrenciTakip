using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class IsyeriBll : BaseGenelBll<Isyeri>, IBaseGenelBll, IBaseCommonBll
    {
        public IsyeriBll() : base(KartTuru.Isyeri) { }

        public IsyeriBll(Control ctrl) : base(ctrl, KartTuru.Isyeri) { }
    }
}