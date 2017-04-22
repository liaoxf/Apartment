	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sendlistlog : EntityExt
    {

		public sendlistlog() : base("sendlistlog") { }
	    #region Field

        private int _Id = int.MinValue;
		      	
        private string _RecievorId = string.Empty;
		      	
	    /// <summary>
        /// 接收人Id
        /// </summary>
        public string RecievorId
        {
            get { return _RecievorId; }
            set
            {
                this.OnPropertyValueChange(_.RecievorId, _RecievorId, value);
                this._RecievorId = value;
                
            }
        }
		
        private string _OperateID = string.Empty;
		      	
	    /// <summary>
        /// 用户ID号
        /// </summary>
        public string OperateID
        {
            get { return _OperateID; }
            set
            {
                this.OnPropertyValueChange(_.OperateID, _OperateID, value);
                this._OperateID = value;
                
            }
        }
		
        private string _OperateAccount = string.Empty;
		      	
	    /// <summary>
        /// 操作账号
        /// </summary>
        public string OperateAccount
        {
            get { return _OperateAccount; }
            set
            {
                this.OnPropertyValueChange(_.OperateAccount, _OperateAccount, value);
                this._OperateAccount = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 派单时间
        /// </summary>
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange(_.AddTime, _AddTime, value);
                this._AddTime = value;
                
            }
        }
		
        private int? _IsDel = 0;
		      	
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
        public int? IsDel
        {
            get { return _IsDel; }
            set
            {
                this.OnPropertyValueChange(_.IsDel, _IsDel, value);
                this._IsDel = value;
                
            }
        }
		
        private int? _DemandId = int.MinValue;
		      	
	    /// <summary>
        /// 需求单ID
        /// </summary>
        public int? DemandId
        {
            get { return _DemandId; }
            set
            {
                this.OnPropertyValueChange(_.DemandId, _DemandId, value);
                this._DemandId = value;
                
            }
        }
		
        private int? _Type = int.MinValue;
		      	
	    /// <summary>
        /// 类型：0表示派单；1表示退单；
        /// </summary>
        public int? Type
        {
            get { return _Type; }
            set
            {
                this.OnPropertyValueChange(_.Type, _Type, value);
                this._Type = value;
                
            }
        }
				#endregion

		#region Method

		        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {_.Id };
        }
				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.Id,_.RecievorId,_.OperateID,_.OperateAccount,_.AddTime,_.IsDel,_.DemandId,_.Type};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._RecievorId,this._OperateID,this._OperateAccount,this._AddTime,this._IsDel,this._DemandId,this._Type };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<int>(reader["Id"]);
							this._RecievorId = DataUtils.ConvertValue<string>(reader["RecievorId"]);
							this._OperateID = DataUtils.ConvertValue<string>(reader["OperateID"]);
							this._OperateAccount = DataUtils.ConvertValue<string>(reader["OperateAccount"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._DemandId = DataUtils.ConvertValue<int?>(reader["DemandId"]);
							this._Type = DataUtils.ConvertValue<int?>(reader["Type"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<int>(row["Id"]);
							this._RecievorId =  DataUtils.ConvertValue<string>(row["RecievorId"]);
							this._OperateID =  DataUtils.ConvertValue<string>(row["OperateID"]);
							this._OperateAccount =  DataUtils.ConvertValue<string>(row["OperateAccount"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._DemandId =  DataUtils.ConvertValue<int?>(row["DemandId"]);
							this._Type =  DataUtils.ConvertValue<int?>(row["Type"]);
			        }
		#endregion
		
		#region _
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// *
            /// </summary>
            public readonly static Field All = new Field("*", "sendlistlog");
						/// <summary>
            /// 主键自增ID号
            /// </summary>
            public readonly static Field Id = new Field("Id", "sendlistlog", "主键自增ID号");
						/// <summary>
            /// 接收人Id
            /// </summary>
            public readonly static Field RecievorId = new Field("RecievorId", "sendlistlog", "接收人Id");
						/// <summary>
            /// 用户ID号
            /// </summary>
            public readonly static Field OperateID = new Field("OperateID", "sendlistlog", "用户ID号");
						/// <summary>
            /// 操作账号
            /// </summary>
            public readonly static Field OperateAccount = new Field("OperateAccount", "sendlistlog", "操作账号");
						/// <summary>
            /// 派单时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "sendlistlog", "派单时间");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "sendlistlog", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 需求单ID
            /// </summary>
            public readonly static Field DemandId = new Field("DemandId", "sendlistlog", "需求单ID");
						/// <summary>
            /// 类型：0表示派单；1表示退单；
            /// </summary>
            public readonly static Field Type = new Field("Type", "sendlistlog", "类型：0表示派单；1表示退单；");
			
        }
		#endregion
        
    }

}
