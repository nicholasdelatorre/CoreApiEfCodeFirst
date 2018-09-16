using CoreApiEfCodeFirst.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Services.Interfaces {

    interface IGenericRepository<T> where T : IdentifiedEntity {
        T GetSingle(int id);
        void Create(T toCreate);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate,params Expression<Func<T, object>>[] includes);
        void Update(T toUpdate);
        void Delete(int id);
        void Save();
    }
}
