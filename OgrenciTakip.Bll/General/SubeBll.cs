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
    public class SubeBll : BaseGenelBll<Sube>, IBaseGenelBll, IBaseCommonBll
    {
        public SubeBll() : base(KartTuru.Sube) { }

        public SubeBll(Control ctrl) : base(ctrl, KartTuru.Sube) { }

        public override BaseEntity Single(Expression<Func<Sube, bool>> filter)
        {
            return BaseSingle(filter, x => new SubeSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Adres = x.Adres,
                AdresIlId = x.AdresIlId,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceId = x.AdresIlceId,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
                Logo = x.Logo,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Sube, bool>> filter)
        {
            return BaseList(filter, x => new SubeList
            {
                Id = x.Id,
                Kod = x.Kod,
                SubeAdi = x.SubeAdi,
                Adres = x.Adres,
                AdresIlAdi = x.AdresIl.IlAdi,
                AdresIlceAdi = x.AdresIlce.IlceAdi,
                Telefon = x.Telefon,
                Fax = x.Fax,
                IbanNo = x.IbanNo,
                GrupAdi = x.GrupAdi,
                SiraNo = x.SiraNo,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}