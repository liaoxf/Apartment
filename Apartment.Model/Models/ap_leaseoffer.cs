	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_leaseoffer : EntityExt
    {

		public ap_leaseoffer() : base("ap_leaseoffer") { }
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
		      	
        private string _OrderNo = string.Empty;
		      	
	    /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo
        {
            get { return _OrderNo; }
            set
            {
                this.OnPropertyValueChange(_.OrderNo, _OrderNo, value);
                this._OrderNo = value;
                
            }
        }
		
        private long? _HouseId = int.MinValue;
		      	
	    /// <summary>
        /// 房源Id号
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
		
        private string _HouseName = string.Empty;
		      	
	    /// <summary>
        /// 房源名称
        /// </summary>
        public string HouseName
        {
            get { return _HouseName; }
            set
            {
                this.OnPropertyValueChange(_.HouseName, _HouseName, value);
                this._HouseName = value;
                
            }
        }
		
        private long? _LandlordId = int.MinValue;
		      	
	    /// <summary>
        /// 房东ID
        /// </summary>
        public long? LandlordId
        {
            get { return _LandlordId; }
            set
            {
                this.OnPropertyValueChange(_.LandlordId, _LandlordId, value);
                this._LandlordId = value;
                
            }
        }
		
        private string _LandlordAccount = string.Empty;
		      	
	    /// <summary>
        /// 房东账号（即为房东登录手机号）
        /// </summary>
        public string LandlordAccount
        {
            get { return _LandlordAccount; }
            set
            {
                this.OnPropertyValueChange(_.LandlordAccount, _LandlordAccount, value);
                this._LandlordAccount = value;
                
            }
        }
		
        private string _LandlordName = string.Empty;
		      	
	    /// <summary>
        /// 房东姓名
        /// </summary>
        public string LandlordName
        {
            get { return _LandlordName; }
            set
            {
                this.OnPropertyValueChange(_.LandlordName, _LandlordName, value);
                this._LandlordName = value;
                
            }
        }
		
        private long? _UserId = int.MinValue;
		      	
	    /// <summary>
        /// 用户ID号
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
		
        private string _UserAccount = string.Empty;
		      	
	    /// <summary>
        /// 用户账号
        /// </summary>
        public string UserAccount
        {
            get { return _UserAccount; }
            set
            {
                this.OnPropertyValueChange(_.UserAccount, _UserAccount, value);
                this._UserAccount = value;
                
            }
        }
		
        private string _UserName = string.Empty;
		      	
	    /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set
            {
                this.OnPropertyValueChange(_.UserName, _UserName, value);
                this._UserName = value;
                
            }
        }
		
        private decimal _OfferPrice = 0;
		      	
	    /// <summary>
        /// 出价金额
        /// </summary>
        public decimal OfferPrice
        {
            get { return _OfferPrice; }
            set
            {
                this.OnPropertyValueChange(_.OfferPrice, _OfferPrice, value);
                this._OfferPrice = value;
                
            }
        }
		
        private string _ToLandlordContent = string.Empty;
		      	
	    /// <summary>
        /// 对房东说的话
        /// </summary>
        public string ToLandlordContent
        {
            get { return _ToLandlordContent; }
            set
            {
                this.OnPropertyValueChange(_.ToLandlordContent, _ToLandlordContent, value);
                this._ToLandlordContent = value;
                
            }
        }
		
        private string _NoPassReason = string.Empty;
		      	
	    /// <summary>
        /// 房东不同意的原因
        /// </summary>
        public string NoPassReason
        {
            get { return _NoPassReason; }
            set
            {
                this.OnPropertyValueChange(_.NoPassReason, _NoPassReason, value);
                this._NoPassReason = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 出价创建时间
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
        /// 出价更新时间
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
		
        private int? _IsAgree = int.MinValue;
		      	
	    /// <summary>
        /// 房东是否同意：0表示待确认；1表示同意；2表示不同意；
        /// </summary>
        public int? IsAgree
        {
            get { return _IsAgree; }
            set
            {
                this.OnPropertyValueChange(_.IsAgree, _IsAgree, value);
                this._IsAgree = value;
                
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
		
        private int? _Type = int.MinValue;
		      	
	    /// <summary>
        /// 0代表普通出价；1表示当面签约出价；
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
		
        private int? _IsSync = int.MinValue;
		      	
	    /// <summary>
        /// 是否同步
        /// </summary>
        public int? IsSync
        {
            get { return _IsSync; }
            set
            {
                this.OnPropertyValueChange(_.IsSync, _IsSync, value);
                this._IsSync = value;
                
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
            return new Field[] {_.Id,_.OrderNo,_.HouseId,_.HouseName,_.LandlordId,_.LandlordAccount,_.LandlordName,_.UserId,_.UserAccount,_.UserName,_.OfferPrice,_.ToLandlordContent,_.NoPassReason,_.AddTime,_.LastUpdateTime,_.IsAgree,_.IsDel,_.Type,_.HouseNo,_.IsSync};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._OrderNo,this._HouseId,this._HouseName,this._LandlordId,this._LandlordAccount,this._LandlordName,this._UserId,this._UserAccount,this._UserName,this._OfferPrice,this._ToLandlordContent,this._NoPassReason,this._AddTime,this._LastUpdateTime,this._IsAgree,this._IsDel,this._Type,this._HouseNo,this._IsSync };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._OrderNo = DataUtils.ConvertValue<string>(reader["OrderNo"]);
							this._HouseId = DataUtils.ConvertValue<long?>(reader["HouseId"]);
							this._HouseName = DataUtils.ConvertValue<string>(reader["HouseName"]);
							this._LandlordId = DataUtils.ConvertValue<long?>(reader["LandlordId"]);
							this._LandlordAccount = DataUtils.ConvertValue<string>(reader["LandlordAccount"]);
							this._LandlordName = DataUtils.ConvertValue<string>(reader["LandlordName"]);
							this._UserId = DataUtils.ConvertValue<long?>(reader["UserId"]);
							this._UserAccount = DataUtils.ConvertValue<string>(reader["UserAccount"]);
							this._UserName = DataUtils.ConvertValue<string>(reader["UserName"]);
							this._OfferPrice = DataUtils.ConvertValue<decimal>(reader["OfferPrice"]);
							this._ToLandlordContent = DataUtils.ConvertValue<string>(reader["ToLandlordContent"]);
							this._NoPassReason = DataUtils.ConvertValue<string>(reader["NoPassReason"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._IsAgree = DataUtils.ConvertValue<int?>(reader["IsAgree"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._Type = DataUtils.ConvertValue<int?>(reader["Type"]);
							this._HouseNo = DataUtils.ConvertValue<string>(reader["HouseNo"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._OrderNo =  DataUtils.ConvertValue<string>(row["OrderNo"]);
							this._HouseId =  DataUtils.ConvertValue<long?>(row["HouseId"]);
							this._HouseName =  DataUtils.ConvertValue<string>(row["HouseName"]);
							this._LandlordId =  DataUtils.ConvertValue<long?>(row["LandlordId"]);
							this._LandlordAccount =  DataUtils.ConvertValue<string>(row["LandlordAccount"]);
							this._LandlordName =  DataUtils.ConvertValue<string>(row["LandlordName"]);
							this._UserId =  DataUtils.ConvertValue<long?>(row["UserId"]);
							this._UserAccount =  DataUtils.ConvertValue<string>(row["UserAccount"]);
							this._UserName =  DataUtils.ConvertValue<string>(row["UserName"]);
							this._OfferPrice =  DataUtils.ConvertValue<decimal>(row["OfferPrice"]);
							this._ToLandlordContent =  DataUtils.ConvertValue<string>(row["ToLandlordContent"]);
							this._NoPassReason =  DataUtils.ConvertValue<string>(row["NoPassReason"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._IsAgree =  DataUtils.ConvertValue<int?>(row["IsAgree"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._Type =  DataUtils.ConvertValue<int?>(row["Type"]);
							this._HouseNo =  DataUtils.ConvertValue<string>(row["HouseNo"]);
							this._IsSync =  DataUtils.ConvertValue<int?>(row["IsSync"]);
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
            public readonly static Field All = new Field("*", "ap_leaseoffer");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_leaseoffer", "主键");
						/// <summary>
            /// 订单号
            /// </summary>
            public readonly static Field OrderNo = new Field("OrderNo", "ap_leaseoffer", "订单号");
						/// <summary>
            /// 房源Id号
            /// </summary>
            public readonly static Field HouseId = new Field("HouseId", "ap_leaseoffer", "房源Id号");
						/// <summary>
            /// 房源名称
            /// </summary>
            public readonly static Field HouseName = new Field("HouseName", "ap_leaseoffer", "房源名称");
						/// <summary>
            /// 房东ID
            /// </summary>
            public readonly static Field LandlordId = new Field("LandlordId", "ap_leaseoffer", "房东ID");
						/// <summary>
            /// 房东账号（即为房东登录手机号）
            /// </summary>
            public readonly static Field LandlordAccount = new Field("LandlordAccount", "ap_leaseoffer", "房东账号（即为房东登录手机号）");
						/// <summary>
            /// 房东姓名
            /// </summary>
            public readonly static Field LandlordName = new Field("LandlordName", "ap_leaseoffer", "房东姓名");
						/// <summary>
            /// 用户ID号
            /// </summary>
            public readonly static Field UserId = new Field("UserId", "ap_leaseoffer", "用户ID号");
						/// <summary>
            /// 用户账号
            /// </summary>
            public readonly static Field UserAccount = new Field("UserAccount", "ap_leaseoffer", "用户账号");
						/// <summary>
            /// 用户姓名
            /// </summary>
            public readonly static Field UserName = new Field("UserName", "ap_leaseoffer", "用户姓名");
						/// <summary>
            /// 出价金额
            /// </summary>
            public readonly static Field OfferPrice = new Field("OfferPrice", "ap_leaseoffer", "出价金额");
						/// <summary>
            /// 对房东说的话
            /// </summary>
            public readonly static Field ToLandlordContent = new Field("ToLandlordContent", "ap_leaseoffer", "对房东说的话");
						/// <summary>
            /// 房东不同意的原因
            /// </summary>
            public readonly static Field NoPassReason = new Field("NoPassReason", "ap_leaseoffer", "房东不同意的原因");
						/// <summary>
            /// 出价创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_leaseoffer", "出价创建时间");
						/// <summary>
            /// 出价更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_leaseoffer", "出价更新时间");
						/// <summary>
            /// 房东是否同意：0表示待确认；1表示同意；2表示不同意；
            /// </summary>
            public readonly static Field IsAgree = new Field("IsAgree", "ap_leaseoffer", "房东是否同意：0表示待确认；1表示同意；2表示不同意；");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_leaseoffer", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 0代表普通出价；1表示当面签约出价；
            /// </summary>
            public readonly static Field Type = new Field("Type", "ap_leaseoffer", "0代表普通出价；1表示当面签约出价；");
						/// <summary>
            /// 房间号
            /// </summary>
            public readonly static Field HouseNo = new Field("HouseNo", "ap_leaseoffer", "房间号");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_leaseoffer", "是否同步");
			
        }
		#endregion
        
    }

}
