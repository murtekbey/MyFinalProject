using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID
    // Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product);
            //}

            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine("{0} - {1}",item.ProductName, item.CategoryId);
            }


        }
    }
}
