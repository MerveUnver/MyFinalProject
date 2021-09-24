using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete.DTOs;

namespace DataAccess.Abstract
{
    //Interface methodları default public tir.
    //Bu interface data access uzeninde yapilacak islemleri tutar.

    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
