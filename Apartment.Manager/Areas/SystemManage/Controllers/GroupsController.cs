using Dos.ORM;
using NFine.Application;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Apartment.Common;
using Apartment.Model;
using Apartment.Dal.Base;

namespace Apartment.Manager.Areas.SystemManage.Controllers
{
    public class GroupsController : ControllerBase
    {
        public override string tableName { get; set; } = "Sys_Groups";//表名
        public override string f_ModuleName { get; set; } = "用户组";//表名
        public async Task<ActionResult> GetGridJson(Pagination pagination, int? id)
        {
            OrderByClip lambdaOrderBy = null;
            if (!pagination.sord.IsEmpty() && !pagination.sidx.IsEmpty())
            {
                lambdaOrderBy = new OrderByClip(pagination.sidx, pagination.sord == "desc" ? OrderByOperater.DESC : OrderByOperater.ASC);
            }
            else
            {
                lambdaOrderBy = new OrderByClip(sys_groups._.CreatedTime, OrderByOperater.DESC);
            }

            WhereClipBuilder wherebuilder = new WhereClipBuilder();
            wherebuilder.And(sys_groups._.IsDel == 0);
            if (id.HasValue)
            {
                wherebuilder.And(sys_groups._.Id == id);
            }
            var Name = Request["Name"] ?? "";
            if (!string.IsNullOrEmpty(Name))
            {
                wherebuilder.And(sys_groups._.Name.Like(Name));
            }
            var Category = Request["Category"] ?? "";
            if (!string.IsNullOrEmpty(Category))
            {
                wherebuilder.And(sys_groups._.Category== Category);
            }
            var Email = Request["Email"] ?? "";
            if (!string.IsNullOrEmpty(Email))
            {
                wherebuilder.And(sys_groups._.Email == Email);
            }
            var Cellphone = Request["Cellphone"] ?? "";
            if (!string.IsNullOrEmpty(Cellphone))
            {
                wherebuilder.And(sys_groups._.Cellphone == Cellphone);
            }
            return getListByPaging<sys_groups, sys_groups>(Db.MySqlContext_Apartment.From<sys_groups>().Where(wherebuilder.ToWhereClip()), pagination, lambdaOrderBy);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            return DeleteFormBySql(Db.MySqlContext_Apartment, keyValue, tableName, true);
        }
        /// <summary>
        /// 提交表单
        /// </summary>
        /// <param name="model"></param>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(sys_groups model, string keyValue)
        {
            if (string.IsNullOrWhiteSpace(keyValue))
            {
                model.IsDel = 0;
                model.CreatedTime = DateTime.Now;
                model.CreatedBy = UserCode;
            }
            else
            {
                model.Id = keyValue.ToInt();
                model.UpdatedTime = DateTime.Now;
                model.CreatedBy = UserCode;
            }
            return SubmitForms(Db.MySqlContext_Apartment, model, keyValue);
        }

        /// <summary>
        /// 表单赋值
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            try
            {
                string sql = string.Format(@"SELECT  *
                            FROM    {0}
                            WHERE   IsDel = 0
                            AND Id= {1}", tableName, keyValue);
                return Content(Db.MySqlContext_Apartment.FromSql(sql).ToDataTable().ToJsonByColName());
            }
            catch (System.Exception ex)
            {
                LogApp(f_ModuleName, DbLogType.Exception, ex.Message);
                return Error(ex.Message);
            }
            
        }
        public ActionResult Create(string keyValue)
        {
            return View();
        }
    }
}