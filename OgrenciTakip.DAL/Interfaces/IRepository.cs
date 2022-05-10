using OgrenciTakip.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OgrenciTakip.Dal.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        //Tek veri ekleme koşulu
        void Insert(T entity);

        //Aynı anda birden fazla veri ekleme koşulu
        void Insert(IEnumerable<T> entities);
        
        //Tek veri güncelleme koşulu
        void Update(T entity);
        
        //Bir tablodaki verilerin bazı alanlarını güncelleme koşulu
        void Update(T entity, IEnumerable<string> fields);
        
        //Bir tablodaki verilerin tüm alanlarını güncelleme koşulu
        void Update(IEnumerable<T> entities);
        
        //Tek veri silme koşulu
        void Delete(T entity);
        
        //Aynı anda birden fazla veri silme koşulu
        void Delete(IEnumerable<T> entities);
        
        //T tipinde aranacak veri duruma göre bool döner ve sonuc olarak aranan veriyi getirir
        TResult Find<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);
        
        //T tipinde aranacak veri duruma göre bool döner ve sonuc olarak sorguyu çağırır
        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        int Count(Expression<Func<T, bool>> filter = null);
        
        //Her kayıt için otomatik kod oluşturma
        string YeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null);
    }
}