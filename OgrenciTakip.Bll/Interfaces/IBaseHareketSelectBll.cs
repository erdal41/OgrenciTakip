﻿using OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OgrenciTakip.Bll.Interfaces
{
    public interface IBaseHareketSelectBll<T>
    {
        IEnumerable<BaseHareketEntity> List(Expression<Func<T, bool>> filter);
    }
}