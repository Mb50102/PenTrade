using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;

namespace PenTrade.Repositories
{
    public class CRUDRepository<T> : ICRUDRepository<T> where T : class
    {
        protected ApplicationContext _context;

        public CRUDRepository(ApplicationContext context)
        {
            _context = context;
        }


        public T Add(T item)
        {
            _context.Add(item);
            _context.SaveChanges();

            return item;
        }

        public T Delete(int itemId)
        {
            var item = _context.Set<T>().Find(itemId);
            _context.Remove(item);

            return item;
        }

        public List<T> GetPaged(int pageNumber = 1, int pageSize = 10, bool loadProperties = false)
        {
            var query = _context.Set<T>().AsQueryable();
            if (loadProperties)
            {
                foreach (var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
                    query = query.Include(property.Name);
            }

            return query.GetPaged(pageNumber, pageSize).ToList();
        }

        public T GetSingleByPredicate(Func<T, bool> predicate)
        {
            var query = _context.Set<T>().AsQueryable();

            foreach(var property in _context.Model.FindEntityType(typeof(T)).GetNavigations())
            {
                query = query.Include(property.Name);
            }

            return query.FirstOrDefault(predicate);

        }

        public T Update(T item)
        {
            _context.Update(item);
            _context.SaveChanges();

            return item;
        }
    }
}
