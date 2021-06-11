using System;
using System.Collections.Generic;
using System.Linq;
using WeightTracker.DomainModels.Framework;

namespace WeightTracker.DataAccess.Framework
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Guid id);
        IQueryable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}