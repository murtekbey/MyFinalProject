using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Product product);      //C
        List<Product> GetAll();         //R
        void Update(Product product);   //U
        void Delete(Product product);   //D
        List<Product> GetAllByCategory(int categoryId);
    }
}
