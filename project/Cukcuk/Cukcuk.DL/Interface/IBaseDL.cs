using System;
using System.Collections.Generic;
using System.Text;

namespace Cukcuk.DL.Interface
{
    public interface IBaseDL<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        T GetbyId(Guid id);
        int Insert(T employee);
        int Update(T employee);
        int Delete(Guid id);
    }
}
