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
    public class CariBll : BaseGenelBll<Cari>, IBaseGenelBll, IBaseCommonBll
    {
        public CariBll() : base(KartTuru.Cari) { }

        public CariBll(Control ctrl) : base(ctrl, KartTuru.Cari) { }

        public override BaseEntity Single(Expression<Func<Cari, bool>> filter)
        {
            return BaseSingle(filter, x => new CariSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Telefon4 = x.Telefon4,
                Fax = x.Fax,
                Web = x.Web,
                Email = x.Email,
                Adres = x.Adres,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Cari, bool>> filter)
        {
            return BaseList(filter, x => new CariList
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Telefon4 = x.Telefon4,
                Fax = x.Fax,
                Web = x.Web,
                Email = x.Email,
                Adres = x.Adres,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}