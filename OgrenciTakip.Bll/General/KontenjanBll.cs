using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class KontenjanBll : BaseGenelBll<Kontenjan>, IBaseGenelBll, IBaseCommonBll
    {
        public KontenjanBll() : base(KartTuru.Kontenjan) { }

        public KontenjanBll(Control ctrl) : base(ctrl, KartTuru.Kontenjan) { }
    }
}