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
    public class RaporBll : BaseGenelBll<Rapor>, IBaseGenelBll, IBaseCommonBll
    {
        public RaporBll() : base(KartTuru.Rapor) { }

        public RaporBll(Control ctrl) : base(ctrl, KartTuru.Rapor) { }

        public override IEnumerable<BaseEntity> List(Expression<Func<Rapor, bool>> filter)
        {
            return BaseList(filter, x => new RaporList
            {
                Id = x.Id,
                Kod = x.Kod,
                RaporAdi = x.RaporAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}