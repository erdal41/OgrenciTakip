using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class KurumBilgileriBll : BaseGenelBll<KurumBilgileri>, IBaseGenelBll, IBaseCommonBll
    {
        public KurumBilgileriBll(Control ctrl) : base(ctrl) { }
        public override BaseEntity Single(Expression<Func<KurumBilgileri, bool>> filter)
        {
            return BaseSingle(filter, x => new KurumBilgileriSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                KurumAdi = x.KurumAdi,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                IlId = x.Il.Id,
                IlAdi = x.Il.IlAdi,
                IlceId = x.Ilce.Id,
                IlceAdi = x.Ilce.IlceAdi,
            });
        }
    }
}