using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfCategoryDal : ICategoryDal
	{
		public void Add(Catagory entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Catagory entity)
		{
			throw new NotImplementedException();
		}

		public Catagory Get(Expression<Func<Catagory, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Catagory> GetAll(Expression<Func<Catagory, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Catagory entity)
		{
			throw new NotImplementedException();
		}
	}
}
