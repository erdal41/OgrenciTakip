using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class IptalNedeniBll : BaseGenelBll<IptalNedeni>, IBaseGenelBll, IBaseCommonBll
    {

        public IptalNedeniBll() : base(KartTuru.IptalNedeni) { }
        public IptalNedeniBll(Control ctrl) : base(ctrl, KartTuru.IptalNedeni) { }
    }
}