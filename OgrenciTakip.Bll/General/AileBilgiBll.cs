using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class AileBilgiBll : BaseGenelBll<AileBilgi>, IBaseGenelBll, IBaseCommonBll
    {
        //buradaki kartturu yetki kontrolü için
        public AileBilgiBll() : base(KartTuru.AileBilgi) { }

        //Buradaki Control tabloda bulunan text vb. araçların boş geçilme durumunu kontrol etmek için kullandık
        public AileBilgiBll(Control ctrl) : base(ctrl, KartTuru.AileBilgi) { }
    }
}