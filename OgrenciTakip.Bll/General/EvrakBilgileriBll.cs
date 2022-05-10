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
    public class EvrakBilgileriBll : BaseHareketBll<EvrakBilgileri, OgrenciTakipContext>, IBaseHareketSelectBll<EvrakBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<EvrakBilgileri, bool>> filter)
        {
            return List(filter, x => new EvrakBilgileriList
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                EvrakId = x.EvrakId,
                Kod = x.Evrak.Kod,
                EvrakAdi = x.Evrak.EvrakAdi,
            }).ToList();
        }
    }
}