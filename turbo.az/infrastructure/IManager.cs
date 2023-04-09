using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.infrastructure
{
    public interface IManager<T>
    {
        void Add(T item);
        void Edit(T item);
        void Remove(T item);       
        T GetbyId(int id);
        T[] FindbyName(string name);

    }
}
