using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class TesvikBll : BaseGenelBll<Tesvik>, IBaseGenelBll, IBaseCommonBll
    {
        public TesvikBll(): base(KartTuru.Tesvik) { }

        public TesvikBll(Control ctrl) : base(ctrl, KartTuru.Tesvik) { }
    }
}