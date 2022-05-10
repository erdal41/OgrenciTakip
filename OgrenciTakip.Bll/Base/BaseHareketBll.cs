using OgrenciTakip.Bll.Functions;
using OgrenciTakip.Bll.Interfaces;
using OgrenciTakip.Common.Enums;
using OgrenciTakip.Dal.Interfaces;
using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace OgrenciTakip.Bll.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        #region  Variables

        private IUnitOfWork<T> _unitOfWork;

        #endregion

        protected TResult Single<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        public virtual bool InsertSingle(BaseHareketEntity entity)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Insert(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Update(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Delete(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        #region Dispose

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        #endregion
    }
}