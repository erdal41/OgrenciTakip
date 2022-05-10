using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Dto;
using OgrenciTakip.Model.Entities;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Bll.General
{
    public class IletisimBilgileriBll : BaseHareketBll<IletisimBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<IletisimBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<IletisimBilgileri, bool>> filter)
        {
            return List(filter, x => new IletisimBilgileriList
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                IletisimId = x.IletisimId,
                TcKimlikNo = x.Iletisim.TcKimlikNo,
                Adi = x.Iletisim.Adi,
                Soyadi = x.Iletisim.Soyadi,
                EvTelefonu = x.Iletisim.EvTelefonu,
                CepTelefonu1 = x.Iletisim.CepTelefonu1,
                CepTelefonu2 = x.Iletisim.CepTelefonu2,
                IsTelefonu1 = x.Iletisim.IsTelefonu1,
                IsTelefonu2 = x.Iletisim.IsTelefonu2,
                EvAdresi = x.Iletisim.EvAdresi,
                EvAdresiIlAdi = x.Iletisim.EvAdresiIl.IlAdi,
                EvAdresiIlceAdi = x.Iletisim.EvAdresiIlce.IlceAdi,
                IsAdresi = x.Iletisim.IsAdresi,
                IsAdresiIlAdi = x.Iletisim.IsAdresiIl.IlAdi,
                IsAdresiIlceAdi = x.Iletisim.IsAdresiIlce.IlceAdi,
                YakinlikId = x.YakinlikId,
                YakinlikAdi = x.Yakinlik.YakinlikAdi,
                MeslekAdi = x.Iletisim.Meslek.MeslekAdi,
                IsyeriAdi = x.Iletisim.Isyeri.IsyeriAdi,
                GorevAdi = x.Iletisim.Gorev.GorevAdi,
                Veli = x.Veli,
                FaturaAdresi = x.FaturaAdresi,
            }).ToList();
        }
    }
}