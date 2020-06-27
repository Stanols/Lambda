﻿using System;
using System.Collections.Generic;
using Lambda.DAL.Entities;

namespace Lambda.DAL.Interfaces
{
	public interface IBaseRepository<T> where T : BaseEntity
	{
		T Get(int id);
		T GetBy(Func<T, bool> predicate);
		IEnumerable<T> GetAll();
		IEnumerable<T> GetAllBy(Func<T, bool> predicate);
		int Create(T entity);
		void Update(T entity);
		void Remove(T entity);
		void Remove(int id);
	}
}
