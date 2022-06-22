using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IRepository<T> where T : class,new()
    {
        List<T> List();
        void Insert(T p);
        void Delete(T P);
        void Update(T P);
        T GetById(int id);
    }
}
