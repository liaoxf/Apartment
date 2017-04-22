using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Dos.ORM;
using Apartment.Model.Base;
using Apartment.Common;
using System.Threading;

namespace Apartment.Dal.Base
{
    public abstract class Repository<T> : IRepository<T> where T : EntityExt
    {

        public Repository() {
             
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
           return Db.MySqlContext_Apartment.From<T>().Where(where).ToList().Any();
        }

        public int Count(Expression<Func<T, bool>> where)
        {
          return  Db.MySqlContext_Apartment.From<T>().Where(where).Count();
        }

        public int Delete(long id)
        {
            return Db.MySqlContext_Apartment.Delete<T>(id);
        }

        public int Delete(Expression<Func<T, bool>> where)
        {
            return Db.MySqlContext_Apartment.Delete<T>(where);
        }

        public int Delete(List<long> ids)
        {
            int _result = 0;

            var entities = Db.MySqlContext_Apartment.From<T>().Where(f => ids.Contains(f.Id));

            entities.ToList().ForEach(f =>
            {
                Delete(f.Id);
                _result++;
                Interlocked.Decrement(ref _result);
            });
            return _result;
        }


        public List<T> GetAll()
        {
            return Db.MySqlContext_Apartment.From<T>().ToList();
        }

        public List<T> GetFilter(Expression<Func<T, bool>> where)
        {
            return Db.MySqlContext_Apartment.From<T>().Where(where).ToList();
        }

        public int Insert(IEnumerable<T> entities)
        {
            return Db.MySqlContext_Apartment.Insert<T>(entities);
        }

        public int Insert(T entity)
        {
            if (entity.Id == 0)
                entity.Id = IdentityGenerator.NewSequentialDomainId();
            return Db.MySqlContext_Apartment.Insert<T>(entity);
        }

        public void Insert(DbTrans context, IEnumerable<T> entities)
        {
            Db.MySqlContext_Apartment.Insert<T>(context, entities.ToArray());
        }

        public void Insert(DbTrans context, T entity)
        {
            Db.MySqlContext_Apartment.Insert<T>(context, entity);
        }

        public int Update(IEnumerable<T> entities)
        {
            return Db.MySqlContext_Apartment.Update<T>(entities);
        }

        public int Update(T entity)
        {
            return Db.MySqlContext_Apartment.Update<T>(entity);
        }

        public void Update(DbTrans context, IEnumerable<T> entities)
        {
            Db.MySqlContext_Apartment.Update<T>(context, entities.ToArray());
        }
    }
}
