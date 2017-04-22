	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_apartment : EntityExt
    {

		public ap_apartment() : base("ap_apartment") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 
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
		      	
        private long? _HouseId = int.MinValue;
		      	
	    /// <summary>
        /// 小区Id
        /// </summary>
        public long? HouseId
        {
            get { return _HouseId; }
            set
            {
                this.OnPropertyValueChange(_.HouseId, _HouseId, value);
                this._HouseId = value;
                
            }
        }
		
        private long? _UserId = int.MinValue;
		      	
	    /// <summary>
        /// 用户Id
        /// </summary>
        public long? UserId
        {
            get { return _UserId; }
            set
            {
                this.OnPropertyValueChange(_.UserId, _UserId, value);
                this._UserId = value;
                
            }
        }
		
        private string _ApartmentName = string.Empty;
		      	
	    /// <summary>
        /// 公寓名称
        /// </summary>
        public string ApartmentName
        {
            get { return _ApartmentName; }
            set
            {
                this.OnPropertyValueChange(_.ApartmentName, _ApartmentName, value);
                this._ApartmentName = value;
                
            }
        }
		
        private int? _State = int.MinValue;
		      	
	    /// <summary>
        /// 状态
        /// </summary>
        public int? State
        {
            get { return _State; }
            set
            {
                this.OnPropertyValueChange(_.State, _State, value);
                this._State = value;
                
            }
        }
		
        private int? _TotalFloorCount = int.MinValue;
		      	
	    /// <summary>
        /// 总楼层
        /// </summary>
        public int? TotalFloorCount
        {
            get { return _TotalFloorCount; }
            set
            {
                this.OnPropertyValueChange(_.TotalFloorCount, _TotalFloorCount, value);
                this._TotalFloorCount = value;
                
            }
        }
		
        private int? _RoomCount = int.MinValue;
		      	
	    /// <summary>
        /// 每层房间数
        /// </summary>
        public int? RoomCount
        {
            get { return _RoomCount; }
            set
            {
                this.OnPropertyValueChange(_.RoomCount, _RoomCount, value);
                this._RoomCount = value;
                
            }
        }
		
        private string _RoomAtt = string.Empty;
		      	
	    /// <summary>
        /// 房号前缀
        /// </summary>
        public string RoomAtt
        {
            get { return _RoomAtt; }
            set
            {
                this.OnPropertyValueChange(_.RoomAtt, _RoomAtt, value);
                this._RoomAtt = value;
                
            }
        }
		
        private string _OperatorId = string.Empty;
		      	
	    /// <summary>
        /// 操作人ID号
        /// </summary>
        public string OperatorId
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
            return new Field[] {_.Id,_.HouseId,_.UserId,_.ApartmentName,_.State,_.TotalFloorCount,_.RoomCount,_.RoomAtt,_.OperatorId,_.OperatorName,_.AddTime,_.LogRemark};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._HouseId,this._UserId,this._ApartmentName,this._State,this._TotalFloorCount,this._RoomCount,this._RoomAtt,this._OperatorId,this._OperatorName,this._AddTime,this._LogRemark };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._HouseId = DataUtils.ConvertValue<long?>(reader["HouseId"]);
							this._UserId = DataUtils.ConvertValue<long?>(reader["UserId"]);
							this._ApartmentName = DataUtils.ConvertValue<string>(reader["ApartmentName"]);
							this._State = DataUtils.ConvertValue<int?>(reader["State"]);
							this._TotalFloorCount = DataUtils.ConvertValue<int?>(reader["TotalFloorCount"]);
							this._RoomCount = DataUtils.ConvertValue<int?>(reader["RoomCount"]);
							this._RoomAtt = DataUtils.ConvertValue<string>(reader["RoomAtt"]);
							this._OperatorId = DataUtils.ConvertValue<string>(reader["OperatorId"]);
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
							this._HouseId =  DataUtils.ConvertValue<long?>(row["HouseId"]);
							this._UserId =  DataUtils.ConvertValue<long?>(row["UserId"]);
							this._ApartmentName =  DataUtils.ConvertValue<string>(row["ApartmentName"]);
							this._State =  DataUtils.ConvertValue<int?>(row["State"]);
							this._TotalFloorCount =  DataUtils.ConvertValue<int?>(row["TotalFloorCount"]);
							this._RoomCount =  DataUtils.ConvertValue<int?>(row["RoomCount"]);
							this._RoomAtt =  DataUtils.ConvertValue<string>(row["RoomAtt"]);
							this._OperatorId =  DataUtils.ConvertValue<string>(row["OperatorId"]);
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
            public readonly static Field All = new Field("*", "ap_apartment");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_apartment", "");
						/// <summary>
            /// 小区Id
            /// </summary>
            public readonly static Field HouseId = new Field("HouseId", "ap_apartment", "小区Id");
						/// <summary>
            /// 用户Id
            /// </summary>
            public readonly static Field UserId = new Field("UserId", "ap_apartment", "用户Id");
						/// <summary>
            /// 公寓名称
            /// </summary>
            public readonly static Field ApartmentName = new Field("ApartmentName", "ap_apartment", "公寓名称");
						/// <summary>
            /// 状态
            /// </summary>
            public readonly static Field State = new Field("State", "ap_apartment", "状态");
						/// <summary>
            /// 总楼层
            /// </summary>
            public readonly static Field TotalFloorCount = new Field("TotalFloorCount", "ap_apartment", "总楼层");
						/// <summary>
            /// 每层房间数
            /// </summary>
            public readonly static Field RoomCount = new Field("RoomCount", "ap_apartment", "每层房间数");
						/// <summary>
            /// 房号前缀
            /// </summary>
            public readonly static Field RoomAtt = new Field("RoomAtt", "ap_apartment", "房号前缀");
						/// <summary>
            /// 操作人ID号
            /// </summary>
            public readonly static Field OperatorId = new Field("OperatorId", "ap_apartment", "操作人ID号");
						/// <summary>
            /// 操作人姓名
            /// </summary>
            public readonly static Field OperatorName = new Field("OperatorName", "ap_apartment", "操作人姓名");
						/// <summary>
            /// 订单日志生成时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_apartment", "订单日志生成时间");
						/// <summary>
            /// 日志备注
            /// </summary>
            public readonly static Field LogRemark = new Field("LogRemark", "ap_apartment", "日志备注");
			
        }
		#endregion
        
    }

}
