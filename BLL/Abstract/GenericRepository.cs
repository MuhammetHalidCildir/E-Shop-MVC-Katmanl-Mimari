using DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        DataContext db = new DataContext();
        DbSet<T> data;
        public GenericRepository()
        {
            data=db.Set<T>();
        }
        public void Delete(T P)
        {
            data.Remove(P);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return data.Find(id);

        }

        public void Insert(T p)
        {
            data.Add(p);
            db.SaveChanges();
        }

        public List<T> List()
        {
            return data.ToList();
        }

        public void Update(T P)
        {
            
            db.SaveChanges();

        }
    }
}
