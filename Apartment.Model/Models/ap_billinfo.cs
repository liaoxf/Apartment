	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_billinfo : EntityExt
    {

		public ap_billinfo() : base("ap_billinfo") { }
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
		      	
        private long? _RoomId = int.MinValue;
		      	
	    /// <summary>
        /// 房间Id
        /// </summary>
        public long? RoomId
        {
            get { return _RoomId; }
            set
            {
                this.OnPropertyValueChange(_.RoomId, _RoomId, value);
                this._RoomId = value;
                
            }
        }
		
        private string _HouseNo = string.Empty;
		      	
	    /// <summary>
        /// 房间号
        /// </summary>
        public string HouseNo
        {
            get { return _HouseNo; }
            set
            {
                this.OnPropertyValueChange(_.HouseNo, _HouseNo, value);
                this._HouseNo = value;
                
            }
        }
		
        private long? _TentantId = int.MinValue;
		      	
	    /// <summary>
        /// 租客Id
        /// </summary>
        public long? TentantId
        {
            get { return _TentantId; }
            set
            {
                this.OnPropertyValueChange(_.TentantId, _TentantId, value);
                this._TentantId = value;
                
            }
        }
		
        private string _UserRealName = string.Empty;
		      	
	    /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName
        {
            get { return _UserRealName; }
            set
            {
                this.OnPropertyValueChange(_.UserRealName, _UserRealName, value);
                this._UserRealName = value;
                
            }
        }
		
        private long? _ContractId = int.MinValue;
		      	
	    /// <summary>
        /// 合同Id
        /// </summary>
        public long? ContractId
        {
            get { return _ContractId; }
            set
            {
                this.OnPropertyValueChange(_.ContractId, _ContractId, value);
                this._ContractId = value;
                
            }
        }
		
        private int? _CostType = int.MinValue;
		      	
	    /// <summary>
        /// 电费/燃气费/水费/网费/有线电视费
        /// </summary>
        public int? CostType
        {
            get { return _CostType; }
            set
            {
                this.OnPropertyValueChange(_.CostType, _CostType, value);
                this._CostType = value;
                
            }
        }
		
        private int? _CostWay = int.MinValue;
		      	
	    /// <summary>
        /// 抄表计算/手动填写/固定收费
        /// </summary>
        public int? CostWay
        {
            get { return _CostWay; }
            set
            {
                this.OnPropertyValueChange(_.CostWay, _CostWay, value);
                this._CostWay = value;
                
            }
        }
		
        private string _CostWeek = string.Empty;
		      	
	    /// <summary>
        /// 一月一次/二月一次/季度一次/半年一次
        /// </summary>
        public string CostWeek
        {
            get { return _CostWeek; }
            set
            {
                this.OnPropertyValueChange(_.CostWeek, _CostWeek, value);
                this._CostWeek = value;
                
            }
        }
		
        private int? _BillType = int.MinValue;
		      	
	    /// <summary>
        /// 租金单/水费单/电费单
        /// </summary>
        public int? BillType
        {
            get { return _BillType; }
            set
            {
                this.OnPropertyValueChange(_.BillType, _BillType, value);
                this._BillType = value;
                
            }
        }
		
        private DateTime? _RentDate = DateTime.MinValue;
		      	
	    /// <summary>
        /// 起租时间
        /// </summary>
        public DateTime? RentDate
        {
            get { return _RentDate; }
            set
            {
                this.OnPropertyValueChange(_.RentDate, _RentDate, value);
                this._RentDate = value;
                
            }
        }
		
        private DateTime? _ToRentDate = DateTime.MinValue;
		      	
	    /// <summary>
        /// 到租时间
        /// </summary>
        public DateTime? ToRentDate
        {
            get { return _ToRentDate; }
            set
            {
                this.OnPropertyValueChange(_.ToRentDate, _ToRentDate, value);
                this._ToRentDate = value;
                
            }
        }
		
        private string _RentWeek = string.Empty;
		      	
	    /// <summary>
        /// 收租周期
        /// </summary>
        public string RentWeek
        {
            get { return _RentWeek; }
            set
            {
                this.OnPropertyValueChange(_.RentWeek, _RentWeek, value);
                this._RentWeek = value;
                
            }
        }
		
        private decimal _Rent = 0;
		      	
	    /// <summary>
        /// 租金
        /// </summary>
        public decimal Rent
        {
            get { return _Rent; }
            set
            {
                this.OnPropertyValueChange(_.Rent, _Rent, value);
                this._Rent = value;
                
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
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 合同生成时间
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
		
        private DateTime? _LastUpdateTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 合同更新时间
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.LastUpdateTime, _LastUpdateTime, value);
                this._LastUpdateTime = value;
                
            }
        }
		
        private int? _State = int.MinValue;
		      	
	    /// <summary>
        /// 状态(已付账/未付账)
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
		
        private string _Remark = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set
            {
                this.OnPropertyValueChange(_.Remark, _Remark, value);
                this._Remark = value;
                
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
            return new Field[] {_.Id,_.RoomId,_.HouseNo,_.TentantId,_.UserRealName,_.ContractId,_.CostType,_.CostWay,_.CostWeek,_.BillType,_.RentDate,_.ToRentDate,_.RentWeek,_.Rent,_.IsDel,_.AddTime,_.LastUpdateTime,_.State,_.Remark};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._RoomId,this._HouseNo,this._TentantId,this._UserRealName,this._ContractId,this._CostType,this._CostWay,this._CostWeek,this._BillType,this._RentDate,this._ToRentDate,this._RentWeek,this._Rent,this._IsDel,this._AddTime,this._LastUpdateTime,this._State,this._Remark };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._RoomId = DataUtils.ConvertValue<long?>(reader["RoomId"]);
							this._HouseNo = DataUtils.ConvertValue<string>(reader["HouseNo"]);
							this._TentantId = DataUtils.ConvertValue<long?>(reader["TentantId"]);
							this._UserRealName = DataUtils.ConvertValue<string>(reader["UserRealName"]);
							this._ContractId = DataUtils.ConvertValue<long?>(reader["ContractId"]);
							this._CostType = DataUtils.ConvertValue<int?>(reader["CostType"]);
							this._CostWay = DataUtils.ConvertValue<int?>(reader["CostWay"]);
							this._CostWeek = DataUtils.ConvertValue<string>(reader["CostWeek"]);
							this._BillType = DataUtils.ConvertValue<int?>(reader["BillType"]);
							this._RentDate = DataUtils.ConvertValue<DateTime?>(reader["RentDate"]);
							this._ToRentDate = DataUtils.ConvertValue<DateTime?>(reader["ToRentDate"]);
							this._RentWeek = DataUtils.ConvertValue<string>(reader["RentWeek"]);
							this._Rent = DataUtils.ConvertValue<decimal>(reader["Rent"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._State = DataUtils.ConvertValue<int?>(reader["State"]);
							this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._RoomId =  DataUtils.ConvertValue<long?>(row["RoomId"]);
							this._HouseNo =  DataUtils.ConvertValue<string>(row["HouseNo"]);
							this._TentantId =  DataUtils.ConvertValue<long?>(row["TentantId"]);
							this._UserRealName =  DataUtils.ConvertValue<string>(row["UserRealName"]);
							this._ContractId =  DataUtils.ConvertValue<long?>(row["ContractId"]);
							this._CostType =  DataUtils.ConvertValue<int?>(row["CostType"]);
							this._CostWay =  DataUtils.ConvertValue<int?>(row["CostWay"]);
							this._CostWeek =  DataUtils.ConvertValue<string>(row["CostWeek"]);
							this._BillType =  DataUtils.ConvertValue<int?>(row["BillType"]);
							this._RentDate =  DataUtils.ConvertValue<DateTime?>(row["RentDate"]);
							this._ToRentDate =  DataUtils.ConvertValue<DateTime?>(row["ToRentDate"]);
							this._RentWeek =  DataUtils.ConvertValue<string>(row["RentWeek"]);
							this._Rent =  DataUtils.ConvertValue<decimal>(row["Rent"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._State =  DataUtils.ConvertValue<int?>(row["State"]);
							this._Remark =  DataUtils.ConvertValue<string>(row["Remark"]);
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
            public readonly static Field All = new Field("*", "ap_billinfo");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_billinfo", "主键");
						/// <summary>
            /// 房间Id
            /// </summary>
            public readonly static Field RoomId = new Field("RoomId", "ap_billinfo", "房间Id");
						/// <summary>
            /// 房间号
            /// </summary>
            public readonly static Field HouseNo = new Field("HouseNo", "ap_billinfo", "房间号");
						/// <summary>
            /// 租客Id
            /// </summary>
            public readonly static Field TentantId = new Field("TentantId", "ap_billinfo", "租客Id");
						/// <summary>
            /// 用户真实姓名
            /// </summary>
            public readonly static Field UserRealName = new Field("UserRealName", "ap_billinfo", "用户真实姓名");
						/// <summary>
            /// 合同Id
            /// </summary>
            public readonly static Field ContractId = new Field("ContractId", "ap_billinfo", "合同Id");
						/// <summary>
            /// 电费/燃气费/水费/网费/有线电视费
            /// </summary>
            public readonly static Field CostType = new Field("CostType", "ap_billinfo", "电费/燃气费/水费/网费/有线电视费");
						/// <summary>
            /// 抄表计算/手动填写/固定收费
            /// </summary>
            public readonly static Field CostWay = new Field("CostWay", "ap_billinfo", "抄表计算/手动填写/固定收费");
						/// <summary>
            /// 一月一次/二月一次/季度一次/半年一次
            /// </summary>
            public readonly static Field CostWeek = new Field("CostWeek", "ap_billinfo", "一月一次/二月一次/季度一次/半年一次");
						/// <summary>
            /// 租金单/水费单/电费单
            /// </summary>
            public readonly static Field BillType = new Field("BillType", "ap_billinfo", "租金单/水费单/电费单");
						/// <summary>
            /// 起租时间
            /// </summary>
            public readonly static Field RentDate = new Field("RentDate", "ap_billinfo", "起租时间");
						/// <summary>
            /// 到租时间
            /// </summary>
            public readonly static Field ToRentDate = new Field("ToRentDate", "ap_billinfo", "到租时间");
						/// <summary>
            /// 收租周期
            /// </summary>
            public readonly static Field RentWeek = new Field("RentWeek", "ap_billinfo", "收租周期");
						/// <summary>
            /// 租金
            /// </summary>
            public readonly static Field Rent = new Field("Rent", "ap_billinfo", "租金");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_billinfo", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 合同生成时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_billinfo", "合同生成时间");
						/// <summary>
            /// 合同更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_billinfo", "合同更新时间");
						/// <summary>
            /// 状态(已付账/未付账)
            /// </summary>
            public readonly static Field State = new Field("State", "ap_billinfo", "状态(已付账/未付账)");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field Remark = new Field("Remark", "ap_billinfo", "");
			
        }
		#endregion
        
    }

}
