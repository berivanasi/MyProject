using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {// iş kodları yetkisi varmı?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int ıd)
        {
            return _productDal.GetAll(p => p.CategoryId == ıd);// gönderdiğim ıd categoryıd eşitse onları gönder
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

    }
}
