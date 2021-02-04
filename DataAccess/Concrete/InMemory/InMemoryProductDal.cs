using DataAccess.Abstract;
using Entities.Concrete;
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
			_products = new List<Product> { 
			new Product{CategoryId=1, ProductId=1,ProductName="Bardak", UnitInStock=15, UnitPrice=15},
			new Product{CategoryId=1, ProductId=2,ProductName="Kamera", UnitInStock=3, UnitPrice=500},
			new Product{CategoryId=2, ProductId=3,ProductName="Telefon", UnitInStock=2, UnitPrice=1500 },
			new Product{CategoryId=2, ProductId=4,ProductName="Klavye", UnitInStock=65, UnitPrice=150},
			new Product{CategoryId=2, ProductId=5,ProductName="Fare", UnitInStock=1, UnitPrice=85},
			};
		}
		public void Add(Product product)
		{
			_products.Add(product);
		}

		public void Delete(Product product)
		{
			Product productToDelete=  _products.SingleOrDefault(p => p.ProductId == product.ProductId);
			//foreach (var p in _products)
			//{
			//	if (product.ProductId==p.ProductId)
			//	{
			//		productToDelete = p;
			//	}
			//}


			_products.Remove(productToDelete);
		}

		public Product Get(Expression<Func<Product, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAll()
		{
			return _products;
		}

		public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAllByCategory(int categoryId)
		{
			return _products.Where(p => p.CategoryId == categoryId).ToList();
		}

		public void Update(Product product)
		{
			//gönderdiğim ürün Id'sine sahip listedeki ürünü bul demek
			Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
			productToUpdate.ProductId = product.ProductId;
			productToUpdate.ProductName = product.ProductName;
			productToUpdate.CategoryId = product.CategoryId;
			productToUpdate.UnitPrice = product.UnitPrice;
			productToUpdate.UnitInStock = product.UnitInStock;


		}
		//	public List<Product> GetAllByCategory(int categoryId)
		//{
		//	return _products.Where(p => p.CategoryId == categoryId).ToList();
		//}
	}
}

