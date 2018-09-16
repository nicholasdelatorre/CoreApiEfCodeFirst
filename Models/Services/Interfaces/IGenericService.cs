using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiEfCodeFirst.Models.Services.Interfaces
{
    public interface IGenericService<T> {

        T Create(T toCreate);
        T Get(int id);
        IEnumerable<T> FindBy(T filter);
        T Update(T toUpdate);
        bool Delete(int id);

    }
}
