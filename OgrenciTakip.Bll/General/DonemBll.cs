using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class DonemBll : BaseGenelBll<Donem>, IBaseGenelBll, IBaseCommonBll
    {
        public DonemBll() : base(KartTuru.Donem) { }

        public DonemBll(Control ctrl) : base(ctrl, KartTuru.Donem) { }
    }
}