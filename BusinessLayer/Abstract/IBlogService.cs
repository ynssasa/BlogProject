﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void Add(Blog blog);
		void Remove(Blog blog);
		void Update(Blog blog);
		List<Blog> GetAll();
		Blog GetById(int id);
		List<Blog> GetListWithCategory();
	}
}
