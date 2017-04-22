	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_loginfo : EntityExt
    {

		public ap_loginfo() : base("ap_loginfo") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键
        /// </summary>
        public new long Id
        {
            get { return _Id ==0 ? base.Id :_Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
                
            }
        }
		      	
        private int? _Type = int.MinValue;
		      	
	    /// <summary>
        /// 日志类型:1系统日志;2业务日志
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
		
        private long? _DataId = int.MinValue;
		      	
	    /// <summary>
        /// 数据Id
        /// </summary>
        public long? DataId
        {
            get { return _DataId; }
            set
            {
                this.OnPropertyValueChange(_.DataId, _DataId, value);
                this._DataId = value;
                
            }
        }
		
        private string _DatarNo = string.Empty;
		      	
	    /// <summary>
        /// 单据号等
        /// </summary>
        public string DatarNo
        {
            get { return _DatarNo; }
            set
            {
                this.OnPropertyValueChange(_.DatarNo, _DatarNo, value);
                this._DatarNo = value;
                
            }
        }
		
        private int? _DataStatus = int.MinValue;
		      	
	    /// <summary>
        /// 订单状态：0代表创建意向单；1代表释放订单；2代表正式订单；3代表确认成交；4代表合同生成；5代表成功签约；
        /// </summary>
        public int? DataStatus
        {
            get { return _DataStatus; }
            set
            {
                this.OnPropertyValueChange(_.DataStatus, _DataStatus, value);
                this._DataStatus = value;
                
            }
        }
		
        private long? _OperatorId = int.MinValue;
		      	
	    /// <summary>
        /// 操作人ID号
        /// </summary>
        public long? OperatorId
        {
            get { return _OperatorId; }
            set
            {
                this.OnPropertyValueChange(_.OperatorId, _OperatorId, value);
                this._OperatorId = value;
                
            }
        }
		
        private string _OperatorName = string.Empty;
		      	
	    /// <summary>
        /// 操作人姓名
        /// </summary>
        public string OperatorName
        {
            get { return _OperatorName; }
            set
            {
                this.OnPropertyValueChange(_.OperatorName, _OperatorName, value);
                this._OperatorName = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 订单日志生成时间
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
		
        private string _LogRemark = string.Empty;
		      	
	    /// <summary>
        /// 日志备注
        /// </summary>
        public string LogRemark
        {
            get { return _LogRemark; }
            set
            {
                this.OnPropertyValueChange(_.LogRemark, _LogRemark, value);
                this._LogRemark = value;
                
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
            return new Field[] {_.Id,_.Type,_.DataId,_.DatarNo,_.DataStatus,_.OperatorId,_.OperatorName,_.AddTime,_.LogRemark};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._Type,this._DataId,this._DatarNo,this._DataStatus,this._OperatorId,this._OperatorName,this._AddTime,this._LogRemark };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._Type = DataUtils.ConvertValue<int?>(reader["Type"]);
							this._DataId = DataUtils.ConvertValue<long?>(reader["DataId"]);
							this._DatarNo = DataUtils.ConvertValue<string>(reader["DatarNo"]);
							this._DataStatus = DataUtils.ConvertValue<int?>(reader["DataStatus"]);
							this._OperatorId = DataUtils.ConvertValue<long?>(reader["OperatorId"]);
							this._OperatorName = DataUtils.ConvertValue<string>(reader["OperatorName"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LogRemark = DataUtils.ConvertValue<string>(reader["LogRemark"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._Type =  DataUtils.ConvertValue<int?>(row["Type"]);
							this._DataId =  DataUtils.ConvertValue<long?>(row["DataId"]);
							this._DatarNo =  DataUtils.ConvertValue<string>(row["DatarNo"]);
							this._DataStatus =  DataUtils.ConvertValue<int?>(row["DataStatus"]);
							this._OperatorId =  DataUtils.ConvertValue<long?>(row["OperatorId"]);
							this._OperatorName =  DataUtils.ConvertValue<string>(row["OperatorName"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LogRemark =  DataUtils.ConvertValue<string>(row["LogRemark"]);
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
            public readonly static Field All = new Field("*", "ap_loginfo");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_loginfo", "主键");
						/// <summary>
            /// 日志类型:1系统日志;2业务日志
            /// </summary>
            public readonly static Field Type = new Field("Type", "ap_loginfo", "日志类型:1系统日志;2业务日志");
						/// <summary>
            /// 数据Id
            /// </summary>
            public readonly static Field DataId = new Field("DataId", "ap_loginfo", "数据Id");
						/// <summary>
            /// 单据号等
            /// </summary>
            public readonly static Field DatarNo = new Field("DatarNo", "ap_loginfo", "单据号等");
						/// <summary>
            /// 订单状态：0代表创建意向单；1代表释放订单；2代表正式订单；3代表确认成交；4代表合同生成；5代表成功签约；
            /// </summary>
            public readonly static Field DataStatus = new Field("DataStatus", "ap_loginfo", "订单状态：0代表创建意向单；1代表释放订单；2代表正式订单；3代表确认成交；4代表合同生成；5代表成功签约；");
						/// <summary>
            /// 操作人ID号
            /// </summary>
            public readonly static Field OperatorId = new Field("OperatorId", "ap_loginfo", "操作人ID号");
						/// <summary>
            /// 操作人姓名
            /// </summary>
            public readonly static Field OperatorName = new Field("OperatorName", "ap_loginfo", "操作人姓名");
						/// <summary>
            /// 订单日志生成时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_loginfo", "订单日志生成时间");
						/// <summary>
            /// 日志备注
            /// </summary>
            public readonly static Field LogRemark = new Field("LogRemark", "ap_loginfo", "日志备注");
			
        }
		#endregion
        
    }

}
