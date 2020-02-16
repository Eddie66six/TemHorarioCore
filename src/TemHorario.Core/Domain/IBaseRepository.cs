using System;
using System.Collections.Generic;
using System.Text;

namespace TemHorario.Core.Domain
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}