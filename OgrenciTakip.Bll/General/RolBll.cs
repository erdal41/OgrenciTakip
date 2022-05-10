using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Entities;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class RolBll : BaseGenelBll<Rol>, IBaseGenelBll, IBaseCommonBll
    {
        //kartturu listformdan silmek için
        public RolBll() : base(KartTuru.Rol) { }

        //karturu ve control editform için
        //Buradaki Control tabloda bulunan text vb. araçların boş geçilme durumunu kontrol etmek için kullandık
        //Kartturu ise o kart ismi ile yeni kod vermesi için
        public RolBll(Control ctrl) : base(ctrl, KartTuru.Rol) { }
    }
}