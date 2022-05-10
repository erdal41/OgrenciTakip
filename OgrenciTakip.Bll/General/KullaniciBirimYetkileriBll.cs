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
    public class KullaniciBirimYetkileriBll : BaseHareketBll<KullaniciBirimYetkileri, OgrenciTakipContext>, IBaseHareketSelectBll<KullaniciBirimYetkileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<KullaniciBirimYetkileri, bool>> filter)
        {
            return List(filter, x => new KullaniciBirimYetkileriList
            {
                Id = x.Id,
                Kod = x.KartTuru == KartTuru.Sube ? x.Sube.Kod : x.Donem.Kod,
                KartTuru = x.KartTuru,
                SubeId = x.SubeId,
                SubeAdi = x.Sube.SubeAdi,
                DonemId = x.DonemId,
                DonemAdi = x.Donem.DonemAdi,
            }).ToList();
        }
    }
}