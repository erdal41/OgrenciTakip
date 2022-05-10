using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.General
{
    public class GecikmeAciklamalariBll : BaseGenelBll<GecikmeAciklamalari>, IBaseCommonBll
    {
        public GecikmeAciklamalariBll() : base(KartTuru.GecikmeAciklamalari) { }

        public GecikmeAciklamalariBll(Control ctrl) : base(ctrl, KartTuru.GecikmeAciklamalari) { }

        public override BaseEntity Single(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseSingle(filter, x => new GecikmeAciklamalariSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                OdemeBilgileriId = x.OdemeBilgileriId,
                KullaniciAdi = x.Kullanici.Adi,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<GecikmeAciklamalari, bool>> filter)
        {
            return BaseList(filter, x => new GecikmeAciklamalariList
            {
                Id = x.Id,
                Kod = x.Kod,
                KullaniciAdi = x.Kullanici.Adi,
                TarihSaat = x.TarihSaat,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}