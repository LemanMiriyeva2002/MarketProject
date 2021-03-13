﻿using Core.DataAccess.Abstract;
using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
