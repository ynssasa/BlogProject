﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
			_blogDal = blogDal;
        }
        public void Add(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetAll()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetBlogsById(int id)
		{
			return _blogDal.GetAll(x=>x.BlogId==id);
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

        public List<Blog> GetListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public void Remove(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void Update(Blog blog)
		{
			throw new NotImplementedException();
		}
	}
}
