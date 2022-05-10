using OgrenciTakip.Common.Enums;
using OgrenciTakip.Data.Contexts;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.Base
{
    public class BaseGenelYonetimBll<T> : BaseBll<T, OgrenciTakipYonetimContext> where T : BaseEntity
    {
        #region Variables

        private KartTuru kartTuru;

        #endregion

        public BaseGenelYonetimBll(KartTuru kt)
        {
            kartTuru = kt;
        }

        public BaseGenelYonetimBll(Control ctrl, KartTuru kt) : base(ctrl)
        {
            kartTuru = kt;
        }

        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Insert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity newEntity)
        {
            return BaseUpdate(oldEntity, newEntity, x => x.Kod == newEntity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity newEntity, Expression<Func<T, bool>> filter)
        {
            return BaseUpdate(oldEntity, newEntity, filter);
        }

        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, kartTuru, false);
        }

        public string YeniKodVer()
        {
            //Tabloya git kod bölümünü çek
            return BaseYeniKodVer(kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<T, bool>> filter)
        {
            //Tabloya git kod bölümünü çek
            return BaseYeniKodVer(kartTuru, x => x.Kod, filter);
        }
    }
}