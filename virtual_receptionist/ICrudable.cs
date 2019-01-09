using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_receptionist
{
    /// <summary>
    /// CRUD interfész
    /// </summary>
    /// <typeparam name="T">Típus</typeparam>
    public interface ICrudable<T> where T : class
    {
        void Create(T entity);
        T GetEntities();
        void Update(T entity);
        void Delete(T entity);
    }
}
