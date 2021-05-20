using System;
using System.Collections.Generic;

namespace PenTrade.Repositories.Interfaces
{
    public interface ICRUDRepository<T> where T : class
    {
        T Add(T item);

        T Delete(int itemId);

        T GetSingleByPredicate(Func<T, bool> predicate);

        List<T> GetPaged(int pageNumber = 1, int pageSize = 10, bool loadProperties = false);

        T Update(T item);
    }
}
