using Dos.Common;
using Dos.ORM;

namespace Apartment.Dal.Base
{
    public class Db
    {
        //public static readonly DbSession MsContext = new DbSession("SqlServerConn");
        //public static readonly DbSession MySqlContext_User = new DbSession("MySqlConn_User");//用户
        //public static readonly DbSession MySqlContext_House = new DbSession("MySqlConn_House");//房屋
        //public static readonly DbSession MySqlContext_Order = new DbSession("MySqlConn_Order");//订单
        public static readonly DbSession MySqlContext_Apartment = new DbSession("MySqlConn_Manager");//后台管理系统
        //public static readonly DbSession Context = new DbSession("SqliteConn");
        //public static readonly DbSession Context = new DbSession("AccessConn");
        //public static readonly DbSession Context = new DbSession("OracleConn");
        //public static readonly DbSession Context = new DbSession("PostgreSqlConn");
        static Db()
        {
            #region mssql
            //MsContext.RegisterSqlLogger(delegate (string sql)
            //{
            //    //在此可以记录sql日志
            //    //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
            //    LogHelper.Debug(sql, "MsSQL日志");
            //});
            //#endregion
            //#region mysql
            //MySqlContext_User.RegisterSqlLogger(delegate (string sql)
            //{
            //    //在此可以记录sql日志
            //    //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
            //    //LogHelper.Debug(sql, "MySQL日志");
            //});
            //MySqlContext_House.RegisterSqlLogger(delegate (string sql)
            //{
            //    //在此可以记录sql日志
            //    //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
            //    //LogHelper.Debug(sql, "MySQL日志");
            //});
            //MySqlContext_Order.RegisterSqlLogger(delegate (string sql)
            //{
            //    //在此可以记录sql日志
            //    //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
            //    //LogHelper.Debug(sql, "MySQL日志");
            //});
            MySqlContext_Apartment.RegisterSqlLogger(delegate (string sql)
            {
                //在此可以记录sql日志
                //写日志会影响性能，建议开发版本记录sql以便调试，发布正式版本不要记录
                //LogHelper.Debug(sql, "MySQL日志");
            });
            #endregion
        }
    }
}
