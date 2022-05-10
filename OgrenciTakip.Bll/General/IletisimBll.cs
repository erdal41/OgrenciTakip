﻿using OgrenciTakip.Bll.Base;
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
    public class IletisimBll : BaseGenelBll<Iletisim>, IBaseGenelBll, IBaseCommonBll
    {
        public IletisimBll() : base(KartTuru.Iletisim) { }

        public IletisimBll(Control ctrl) : base(ctrl, KartTuru.Iletisim) { }

        public override BaseEntity Single(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseSingle(filter, x => new IletisimSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlId = x.KimlikIlId,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceId = x.KimlikIlceId,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTelefonu = x.EvTelefonu,
                IsTelefonu1 = x.IsTelefonu1,
                IsTelefonu2 = x.IsTelefonu2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTelefonu1 = x.CepTelefonu1,
                CepTelefonu2 = x.CepTelefonu2,
                Web = x.Web,
                Email = x.Email,
                EvAdresi = x.EvAdresi,
                EvAdresiIlId = x.EvAdresiIlId,
                EvAdresiIlAdi = x.EvAdresiIl.IlAdi,
                EvAdresiIlceId = x.EvAdresiIlceId,
                EvAdresiIlceAdi = x.EvAdresiIlce.IlceAdi,
                IsAdresi = x.IsAdresi,
                IsAdresiIlId = x.IsAdresiIlId,
                IsAdresiIlAdi = x.IsAdresiIl.IlAdi,
                IsAdresiIlceId = x.IsAdresiIlceId,
                IsAdresiIlceAdi = x.IsAdresiIlce.IlceAdi,
                MeslekId = x.MeslekId,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsyeriId = x.IsyeriId,
                IsyeriAdi = x.Isyeri.IsyeriAdi,
                GorevId = x.GorevId,
                GorevAdi = x.Gorev.GorevAdi,
                IbanNo = x.IbanNo,
                KartNo = x.KartNo,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Iletisim, bool>> filter)
        {
            return BaseList(filter, x => new IletisimList
            {
                Id = x.Id,
                Kod = x.Kod,
                TcKimlikNo = x.TcKimlikNo,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                BabaAdi = x.BabaAdi,
                AnaAdi = x.AnaAdi,
                DogumYeri = x.DogumYeri,
                DogumTarihi = x.DogumTarihi,
                KanGrubu = x.KanGrubu,
                KimlikSeri = x.KimlikSeri,
                KimlikSiraNo = x.KimlikSiraNo,
                KimlikIlAdi = x.KimlikIl.IlAdi,
                KimlikIlceAdi = x.KimlikIlce.IlceAdi,
                KimlikMahalleKoy = x.KimlikMahalleKoy,
                KimlikCiltNo = x.KimlikCiltNo,
                KimlikAileSiraNo = x.KimlikAileSiraNo,
                KimlikBireySiraNo = x.KimlikBireySiraNo,
                KimlikVerildigiYer = x.KimlikVerildigiYer,
                KimlikVerilisNedeni = x.KimlikVerilisNedeni,
                KimlikKayitNo = x.KimlikKayitNo,
                KimlikVerilisTarihi = x.KimlikVerilisTarihi,
                EvTelefonu = x.EvTelefonu,
                IsTelefonu1 = x.IsTelefonu1,
                IsTelefonu2 = x.IsTelefonu2,
                Dahili1 = x.Dahili1,
                Dahili2 = x.Dahili2,
                CepTelefonu1 = x.CepTelefonu1,
                CepTelefonu2 = x.CepTelefonu2,
                Web = x.Web,
                Email = x.Email,
                EvAdresi = x.EvAdresi,
                EvAdresiIlAdi = x.EvAdresiIl.IlAdi,
                EvAdresiIlceAdi = x.EvAdresiIlce.IlceAdi,
                IsAdresi = x.IsAdresi,
                IsAdresiIlAdi = x.IsAdresiIl.IlAdi,
                IsAdresiIlceAdi = x.IsAdresiIlce.IlceAdi,
                MeslekAdi = x.Meslek.MeslekAdi,
                IsyeriAdi = x.Isyeri.IsyeriAdi,
                GorevAdi = x.Gorev.GorevAdi,
                IbanNo = x.IbanNo,
                KartNo = x.KartNo,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}