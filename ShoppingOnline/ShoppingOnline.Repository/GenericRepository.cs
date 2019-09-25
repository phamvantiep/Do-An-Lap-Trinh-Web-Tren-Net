using ShoppingOnline.IRepository;
using ShoppingOnline.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnline.Repository
{
    public class GenericRepository<T>:IGenericRepository<T> where T:class
    {
        protected ShoppingOnlineDbContext db { get; set; }
        protected DbSet<T> table = null;

        //Phương thức khởi tạo
        public GenericRepository()
        {
            db = new ShoppingOnlineDbContext();
            table = db.Set<T>();
        }

        public GenericRepository(ShoppingOnlineDbContext db)
        {
            this.db = db;
            table = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(string id)
        {
            return table.Find(id);
        }

        public int Update(T item)
        {
            table.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Create(T item)
        {
            table.Add(item);
            return db.SaveChanges();
        }

        public int Delete(string id)
        {
            T t = table.Find(id);
            table.Remove(t);
            return db.SaveChanges();
        }
    }
}
