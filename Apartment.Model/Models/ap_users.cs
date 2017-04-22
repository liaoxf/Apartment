	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_users : EntityExt
    {

		public ap_users() : base("ap_users") { }
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
		      	
        private string _LogAccount = string.Empty;
		      	
	    /// <summary>
        /// 登录账号
        /// </summary>
        public string LogAccount
        {
            get { return _LogAccount; }
            set
            {
                this.OnPropertyValueChange(_.LogAccount, _LogAccount, value);
                this._LogAccount = value;
                
            }
        }
		
        private string _OpenId = string.Empty;
		      	
	    /// <summary>
        /// 微信ID号
        /// </summary>
        public string OpenId
        {
            get { return _OpenId; }
            set
            {
                this.OnPropertyValueChange(_.OpenId, _OpenId, value);
                this._OpenId = value;
                
            }
        }
		
        private string _Avatar = string.Empty;
		      	
	    /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar
        {
            get { return _Avatar; }
            set
            {
                this.OnPropertyValueChange(_.Avatar, _Avatar, value);
                this._Avatar = value;
                
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
		
        private string _UserGender = string.Empty;
		      	
	    /// <summary>
        /// 用户性别
        /// </summary>
        public string UserGender
        {
            get { return _UserGender; }
            set
            {
                this.OnPropertyValueChange(_.UserGender, _UserGender, value);
                this._UserGender = value;
                
            }
        }
		
        private decimal _UserDeposit = 0;
		      	
	    /// <summary>
        /// 用户押金
        /// </summary>
        public decimal UserDeposit
        {
            get { return _UserDeposit; }
            set
            {
                this.OnPropertyValueChange(_.UserDeposit, _UserDeposit, value);
                this._UserDeposit = value;
                
            }
        }
		
        private int? _IsLockDeposit = int.MinValue;
		      	
	    /// <summary>
        /// 是否锁定押金：0表示未锁定；1表示已锁定；
        /// </summary>
        public int? IsLockDeposit
        {
            get { return _IsLockDeposit; }
            set
            {
                this.OnPropertyValueChange(_.IsLockDeposit, _IsLockDeposit, value);
                this._IsLockDeposit = value;
                
            }
        }
		
        private decimal _AccountBalance = 0;
		      	
	    /// <summary>
        /// 账户余额
        /// </summary>
        public decimal AccountBalance
        {
            get { return _AccountBalance; }
            set
            {
                this.OnPropertyValueChange(_.AccountBalance, _AccountBalance, value);
                this._AccountBalance = value;
                
            }
        }
		
        private int? _UserType = int.MinValue;
		      	
	    /// <summary>
        /// 用户类型：0-租客用户 ；1-房东
        /// </summary>
        public int? UserType
        {
            get { return _UserType; }
            set
            {
                this.OnPropertyValueChange(_.UserType, _UserType, value);
                this._UserType = value;
                
            }
        }
		
        private int? _UserStatus = int.MinValue;
		      	
	    /// <summary>
        /// 用户状态：0-待审核；1-已审核；2-审核失败；3-黑名单/已禁用
        /// </summary>
        public int? UserStatus
        {
            get { return _UserStatus; }
            set
            {
                this.OnPropertyValueChange(_.UserStatus, _UserStatus, value);
                this._UserStatus = value;
                
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
        /// 用户创建时间
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
        /// 用户更新时间
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
		
        private DateTime? _ContractSignTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? ContractSignTime
        {
            get { return _ContractSignTime; }
            set
            {
                this.OnPropertyValueChange(_.ContractSignTime, _ContractSignTime, value);
                this._ContractSignTime = value;
                
            }
        }
		
        private DateTime? _ContractDueTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? ContractDueTime
        {
            get { return _ContractDueTime; }
            set
            {
                this.OnPropertyValueChange(_.ContractDueTime, _ContractDueTime, value);
                this._ContractDueTime = value;
                
            }
        }
		
        private string _BContractAmount = string.Empty;
		      	
	    /// <summary>
        /// 房子租金（大写）
        /// </summary>
        public string BContractAmount
        {
            get { return _BContractAmount; }
            set
            {
                this.OnPropertyValueChange(_.BContractAmount, _BContractAmount, value);
                this._BContractAmount = value;
                
            }
        }
		
        private decimal _ContractAmount = 0;
		      	
	    /// <summary>
        /// 房子租金
        /// </summary>
        public decimal ContractAmount
        {
            get { return _ContractAmount; }
            set
            {
                this.OnPropertyValueChange(_.ContractAmount, _ContractAmount, value);
                this._ContractAmount = value;
                
            }
        }
		
        private int? _PersonCount = int.MinValue;
		      	
	    /// <summary>
        /// 人数
        /// </summary>
        public int? PersonCount
        {
            get { return _PersonCount; }
            set
            {
                this.OnPropertyValueChange(_.PersonCount, _PersonCount, value);
                this._PersonCount = value;
                
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
            return new Field[] {_.Id,_.LogAccount,_.OpenId,_.Avatar,_.UserRealName,_.UserGender,_.UserDeposit,_.IsLockDeposit,_.AccountBalance,_.UserType,_.UserStatus,_.IsDel,_.AddTime,_.LastUpdateTime,_.ContractSignTime,_.ContractDueTime,_.BContractAmount,_.ContractAmount,_.PersonCount,_.HouseNo,_.IsSync};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._LogAccount,this._OpenId,this._Avatar,this._UserRealName,this._UserGender,this._UserDeposit,this._IsLockDeposit,this._AccountBalance,this._UserType,this._UserStatus,this._IsDel,this._AddTime,this._LastUpdateTime,this._ContractSignTime,this._ContractDueTime,this._BContractAmount,this._ContractAmount,this._PersonCount,this._HouseNo,this._IsSync };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._LogAccount = DataUtils.ConvertValue<string>(reader["LogAccount"]);
							this._OpenId = DataUtils.ConvertValue<string>(reader["OpenId"]);
							this._Avatar = DataUtils.ConvertValue<string>(reader["Avatar"]);
							this._UserRealName = DataUtils.ConvertValue<string>(reader["UserRealName"]);
							this._UserGender = DataUtils.ConvertValue<string>(reader["UserGender"]);
							this._UserDeposit = DataUtils.ConvertValue<decimal>(reader["UserDeposit"]);
							this._IsLockDeposit = DataUtils.ConvertValue<int?>(reader["IsLockDeposit"]);
							this._AccountBalance = DataUtils.ConvertValue<decimal>(reader["AccountBalance"]);
							this._UserType = DataUtils.ConvertValue<int?>(reader["UserType"]);
							this._UserStatus = DataUtils.ConvertValue<int?>(reader["UserStatus"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._ContractSignTime = DataUtils.ConvertValue<DateTime?>(reader["ContractSignTime"]);
							this._ContractDueTime = DataUtils.ConvertValue<DateTime?>(reader["ContractDueTime"]);
							this._BContractAmount = DataUtils.ConvertValue<string>(reader["BContractAmount"]);
							this._ContractAmount = DataUtils.ConvertValue<decimal>(reader["ContractAmount"]);
							this._PersonCount = DataUtils.ConvertValue<int?>(reader["PersonCount"]);
							this._HouseNo = DataUtils.ConvertValue<string>(reader["HouseNo"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._LogAccount =  DataUtils.ConvertValue<string>(row["LogAccount"]);
							this._OpenId =  DataUtils.ConvertValue<string>(row["OpenId"]);
							this._Avatar =  DataUtils.ConvertValue<string>(row["Avatar"]);
							this._UserRealName =  DataUtils.ConvertValue<string>(row["UserRealName"]);
							this._UserGender =  DataUtils.ConvertValue<string>(row["UserGender"]);
							this._UserDeposit =  DataUtils.ConvertValue<decimal>(row["UserDeposit"]);
							this._IsLockDeposit =  DataUtils.ConvertValue<int?>(row["IsLockDeposit"]);
							this._AccountBalance =  DataUtils.ConvertValue<decimal>(row["AccountBalance"]);
							this._UserType =  DataUtils.ConvertValue<int?>(row["UserType"]);
							this._UserStatus =  DataUtils.ConvertValue<int?>(row["UserStatus"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._ContractSignTime =  DataUtils.ConvertValue<DateTime?>(row["ContractSignTime"]);
							this._ContractDueTime =  DataUtils.ConvertValue<DateTime?>(row["ContractDueTime"]);
							this._BContractAmount =  DataUtils.ConvertValue<string>(row["BContractAmount"]);
							this._ContractAmount =  DataUtils.ConvertValue<decimal>(row["ContractAmount"]);
							this._PersonCount =  DataUtils.ConvertValue<int?>(row["PersonCount"]);
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
            public readonly static Field All = new Field("*", "ap_users");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_users", "主键");
						/// <summary>
            /// 登录账号
            /// </summary>
            public readonly static Field LogAccount = new Field("LogAccount", "ap_users", "登录账号");
						/// <summary>
            /// 微信ID号
            /// </summary>
            public readonly static Field OpenId = new Field("OpenId", "ap_users", "微信ID号");
						/// <summary>
            /// 用户头像
            /// </summary>
            public readonly static Field Avatar = new Field("Avatar", "ap_users", "用户头像");
						/// <summary>
            /// 用户真实姓名
            /// </summary>
            public readonly static Field UserRealName = new Field("UserRealName", "ap_users", "用户真实姓名");
						/// <summary>
            /// 用户性别
            /// </summary>
            public readonly static Field UserGender = new Field("UserGender", "ap_users", "用户性别");
						/// <summary>
            /// 用户押金
            /// </summary>
            public readonly static Field UserDeposit = new Field("UserDeposit", "ap_users", "用户押金");
						/// <summary>
            /// 是否锁定押金：0表示未锁定；1表示已锁定；
            /// </summary>
            public readonly static Field IsLockDeposit = new Field("IsLockDeposit", "ap_users", "是否锁定押金：0表示未锁定；1表示已锁定；");
						/// <summary>
            /// 账户余额
            /// </summary>
            public readonly static Field AccountBalance = new Field("AccountBalance", "ap_users", "账户余额");
						/// <summary>
            /// 用户类型：0-租客用户 ；1-房东
            /// </summary>
            public readonly static Field UserType = new Field("UserType", "ap_users", "用户类型：0-租客用户 ；1-房东");
						/// <summary>
            /// 用户状态：0-待审核；1-已审核；2-审核失败；3-黑名单/已禁用
            /// </summary>
            public readonly static Field UserStatus = new Field("UserStatus", "ap_users", "用户状态：0-待审核；1-已审核；2-审核失败；3-黑名单/已禁用");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_users", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 用户创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_users", "用户创建时间");
						/// <summary>
            /// 用户更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_users", "用户更新时间");
						/// <summary>
            /// 开始时间
            /// </summary>
            public readonly static Field ContractSignTime = new Field("ContractSignTime", "ap_users", "开始时间");
						/// <summary>
            /// 结束时间
            /// </summary>
            public readonly static Field ContractDueTime = new Field("ContractDueTime", "ap_users", "结束时间");
						/// <summary>
            /// 房子租金（大写）
            /// </summary>
            public readonly static Field BContractAmount = new Field("BContractAmount", "ap_users", "房子租金（大写）");
						/// <summary>
            /// 房子租金
            /// </summary>
            public readonly static Field ContractAmount = new Field("ContractAmount", "ap_users", "房子租金");
						/// <summary>
            /// 人数
            /// </summary>
            public readonly static Field PersonCount = new Field("PersonCount", "ap_users", "人数");
						/// <summary>
            /// 房间号
            /// </summary>
            public readonly static Field HouseNo = new Field("HouseNo", "ap_users", "房间号");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_users", "是否同步");
			
        }
		#endregion
        
    }

}
