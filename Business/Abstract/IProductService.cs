using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int ıd); // GetALL (TÜMÜNÜ GETİR) NEYE GÖRE CategoryID ' SİNE GÖRE
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
