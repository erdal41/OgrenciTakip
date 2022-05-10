using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class PromosyonBll : BaseGenelBll<Promosyon>, IBaseCommonBll
    {
        public PromosyonBll() : base(KartTuru.Promosyon) { }

        public PromosyonBll(Control ctrl) : base(ctrl, KartTuru.Promosyon) { }
    }
}