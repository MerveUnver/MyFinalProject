using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
               new Product{ProductId=1,CategoryId=1,ProductName="bardak",UnitPrice=15,UnitsInStock=15},
               new Product{ProductId=2,CategoryId=1,ProductName="kamera",UnitPrice=500,UnitsInStock=3},
               new Product{ProductId=3,CategoryId=2,ProductName="telefon",UnitPrice=1500,UnitsInStock=2},
               new Product{ProductId=4,CategoryId=2,ProductName="klavye",UnitPrice=150,UnitsInStock=65}
            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ
            Product productDelete =_products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //public List<Product> GetAll()
        //{
        //    return _products;
        //}
        public bool a(Product product)
        {
            return true;
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        { 
            return this._products.Where(
                filter == null 
                    ? product => true 
                    : filter.Compile()
            ).ToList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderilen ürün ıd sine ait ürünü listeden bulur.

            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
