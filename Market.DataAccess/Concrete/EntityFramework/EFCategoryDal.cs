﻿using Core.DataAccess.Concrete.EntityFramework;
using Market.DataAccess.Abstract;
using Market.DataAccess.Concrete.EntityFramework.Contexts;
using Market.Entity.Concrete;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
