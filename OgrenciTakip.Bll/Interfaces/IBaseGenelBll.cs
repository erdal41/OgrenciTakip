using OgrenciTakip.Model.Entities.Base;

namespace OgrenciTakip.Bll.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity newEntity);
        string YeniKodVer();
    }
}