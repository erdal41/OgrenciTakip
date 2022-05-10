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
    public class BilgiNotlariBll : BaseHareketBll<BilgiNotlari, OgrenciTakipContext>, IBaseHareketSelectBll<BilgiNotlari>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<BilgiNotlari, bool>> filter)
        {
            return List(filter, x => new BilgiNotlariList
            {
                Id = x.Id,
                TahakkukId = x.TahakkukId,
                Tarih = x.Tarih,
                BilgiNotu = x.BilgiNotu,
            }).ToList();
        }
    }
}