using Apartment.Model.Base;
using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Base
{
    public interface IRepository<T> where T : EntityExt
    {
        List<T> GetAll();
        /// <summary>
        /// 通用查询
        /// </summary>
        List<T> GetFilter(Expression<Func<T, bool>> where);

        bool Any(Expression<Func<T, bool>> where);

        /// <summary>
        /// 取总数
        /// </summary>
        int Count(Expression<Func<T, bool>> where);

        #region 插入
        /// <summary>
        /// 插入单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Insert(T entity);
        /// <summary>
        /// 插入单个实体
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Insert(DbTrans context, T entity);
        /// <summary>
        /// 插入多个实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Insert(IEnumerable<T> entities);
        void Insert(DbTrans context, IEnumerable<T> entities);
        #endregion
        #region 更新
        /// <summary>
        /// 更新单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(T entity);

        /// <summary>
        /// 更新多个实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Update(IEnumerable<T> entities);
        void Update(DbTrans context, IEnumerable<T> entities);
        #endregion

        /// <summary>
        /// 删除多个实体
        /// </summary>
        int Delete(List<long> ids);
        /// <summary>
        /// 删除单个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(long id);
        /// <summary>
        /// 删除单个实体
        /// </summary>
        int Delete(Expression<Func<T, bool>> where);
    }
}
