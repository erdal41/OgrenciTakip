using OgrenciTakip.Bll.Base;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
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
    public class GeriOdemeBilgileriBll : BaseHareketBll<GeriOdemeBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<GeriOdemeBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<GeriOdemeBilgileri, bool>> filter)
        {
            return List(filter, x => new GeriOdemeBilgileriList
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                HesapTuru = x.HesapTuru,
                HesapId = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.KasaId : x.BankaHesapId,
                HesapAdi = x.HesapTuru == GeriOdemeHesapTuru.Kasa ? x.Kasa.KasaAdi : x.BankaHesap.HesapAdi,
                BankaHesapId = x.BankaHesapId,
                KasaId = x.KasaId,
                Tutar = x.Tutar,
                Aciklama = x.Aciklama,
            }).ToList();
        }
    }
}