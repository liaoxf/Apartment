	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_contract : EntityExt
    {

		public ap_contract() : base("ap_contract") { }
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
		
        private long? _SignatoryId = int.MinValue;
		      	
	    /// <summary>
        /// 出租方ID号
        /// </summary>
        public long? SignatoryId
        {
            get { return _SignatoryId; }
            set
            {
                this.OnPropertyValueChange(_.SignatoryId, _SignatoryId, value);
                this._SignatoryId = value;
                
            }
        }
		
        private string _SignatoryName = string.Empty;
		      	
	    /// <summary>
        /// 出租方姓名
        /// </summary>
        public string SignatoryName
        {
            get { return _SignatoryName; }
            set
            {
                this.OnPropertyValueChange(_.SignatoryName, _SignatoryName, value);
                this._SignatoryName = value;
                
            }
        }
		
        private string _SignatoryPhone = string.Empty;
		      	
	    /// <summary>
        /// 出租方联系电话
        /// </summary>
        public string SignatoryPhone
        {
            get { return _SignatoryPhone; }
            set
            {
                this.OnPropertyValueChange(_.SignatoryPhone, _SignatoryPhone, value);
                this._SignatoryPhone = value;
                
            }
        }
		
        private string _SignatoryIDCard = string.Empty;
		      	
	    /// <summary>
        /// 出租方身份证号
        /// </summary>
        public string SignatoryIDCard
        {
            get { return _SignatoryIDCard; }
            set
            {
                this.OnPropertyValueChange(_.SignatoryIDCard, _SignatoryIDCard, value);
                this._SignatoryIDCard = value;
                
            }
        }
		
        private long? _LessorId = int.MinValue;
		      	
	    /// <summary>
        /// 承租方ID号
        /// </summary>
        public long? LessorId
        {
            get { return _LessorId; }
            set
            {
                this.OnPropertyValueChange(_.LessorId, _LessorId, value);
                this._LessorId = value;
                
            }
        }
		
        private string _LessorName = string.Empty;
		      	
	    /// <summary>
        /// 承租方姓名
        /// </summary>
        public string LessorName
        {
            get { return _LessorName; }
            set
            {
                this.OnPropertyValueChange(_.LessorName, _LessorName, value);
                this._LessorName = value;
                
            }
        }
		
        private string _LessorPhone = string.Empty;
		      	
	    /// <summary>
        /// 承租方联系电话
        /// </summary>
        public string LessorPhone
        {
            get { return _LessorPhone; }
            set
            {
                this.OnPropertyValueChange(_.LessorPhone, _LessorPhone, value);
                this._LessorPhone = value;
                
            }
        }
		
        private string _LessorIDCard = string.Empty;
		      	
	    /// <summary>
        /// 承租方身份证号
        /// </summary>
        public string LessorIDCard
        {
            get { return _LessorIDCard; }
            set
            {
                this.OnPropertyValueChange(_.LessorIDCard, _LessorIDCard, value);
                this._LessorIDCard = value;
                
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
		
        private decimal _FirstPayment = 0;
		      	
	    /// <summary>
        /// 首次付款
        /// </summary>
        public decimal FirstPayment
        {
            get { return _FirstPayment; }
            set
            {
                this.OnPropertyValueChange(_.FirstPayment, _FirstPayment, value);
                this._FirstPayment = value;
                
            }
        }
		
        private decimal _HouseDeposit = 0;
		      	
	    /// <summary>
        /// 房屋押金
        /// </summary>
        public decimal HouseDeposit
        {
            get { return _HouseDeposit; }
            set
            {
                this.OnPropertyValueChange(_.HouseDeposit, _HouseDeposit, value);
                this._HouseDeposit = value;
                
            }
        }
		
        private int? _TotalMonth = int.MinValue;
		      	
	    /// <summary>
        /// 房租总月数
        /// </summary>
        public int? TotalMonth
        {
            get { return _TotalMonth; }
            set
            {
                this.OnPropertyValueChange(_.TotalMonth, _TotalMonth, value);
                this._TotalMonth = value;
                
            }
        }
		
        private int? _FTotalMonth = int.MinValue;
		      	
	    /// <summary>
        /// 房租总月数（首次）
        /// </summary>
        public int? FTotalMonth
        {
            get { return _FTotalMonth; }
            set
            {
                this.OnPropertyValueChange(_.FTotalMonth, _FTotalMonth, value);
                this._FTotalMonth = value;
                
            }
        }
		
        private decimal _FTotalMoney = 0;
		      	
	    /// <summary>
        /// 房租总金额（首次）
        /// </summary>
        public decimal FTotalMoney
        {
            get { return _FTotalMoney; }
            set
            {
                this.OnPropertyValueChange(_.FTotalMoney, _FTotalMoney, value);
                this._FTotalMoney = value;
                
            }
        }
		
        private int? _AuditStatus = int.MinValue;
		      	
	    /// <summary>
        /// 审核状态：0表示待审核；1表示审核成功；2表示审核失败；
        /// </summary>
        public int? AuditStatus
        {
            get { return _AuditStatus; }
            set
            {
                this.OnPropertyValueChange(_.AuditStatus, _AuditStatus, value);
                this._AuditStatus = value;
                
            }
        }
		
        private int? _HouseId = int.MinValue;
		      	
	    /// <summary>
        /// 房屋的ID号
        /// </summary>
        public int? HouseId
        {
            get { return _HouseId; }
            set
            {
                this.OnPropertyValueChange(_.HouseId, _HouseId, value);
                this._HouseId = value;
                
            }
        }
		
        private string _ContractHtml = string.Empty;
		      	
	    /// <summary>
        /// 合同html
        /// </summary>
        public string ContractHtml
        {
            get { return _ContractHtml; }
            set
            {
                this.OnPropertyValueChange(_.ContractHtml, _ContractHtml, value);
                this._ContractHtml = value;
                
            }
        }
		
        private string _ContractRemark = string.Empty;
		      	
	    /// <summary>
        /// 合同备注
        /// </summary>
        public string ContractRemark
        {
            get { return _ContractRemark; }
            set
            {
                this.OnPropertyValueChange(_.ContractRemark, _ContractRemark, value);
                this._ContractRemark = value;
                
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
		
        private int? _GenerateWay = int.MinValue;
		      	
	    /// <summary>
        /// 合同生成方式：0表示线上；1表示线下；
        /// </summary>
        public int? GenerateWay
        {
            get { return _GenerateWay; }
            set
            {
                this.OnPropertyValueChange(_.GenerateWay, _GenerateWay, value);
                this._GenerateWay = value;
                
            }
        }
		
        private string _City = string.Empty;
		      	
	    /// <summary>
        /// 市
        /// </summary>
        public string City
        {
            get { return _City; }
            set
            {
                this.OnPropertyValueChange(_.City, _City, value);
                this._City = value;
                
            }
        }
		
        private string _District = string.Empty;
		      	
	    /// <summary>
        /// 区
        /// </summary>
        public string District
        {
            get { return _District; }
            set
            {
                this.OnPropertyValueChange(_.District, _District, value);
                this._District = value;
                
            }
        }
		
        private string _DetailAddress = string.Empty;
		      	
	    /// <summary>
        /// 房源具体地址
        /// </summary>
        public string DetailAddress
        {
            get { return _DetailAddress; }
            set
            {
                this.OnPropertyValueChange(_.DetailAddress, _DetailAddress, value);
                this._DetailAddress = value;
                
            }
        }
		
        private string _AreasName = string.Empty;
		      	
	    /// <summary>
        /// 小区名称
        /// </summary>
        public string AreasName
        {
            get { return _AreasName; }
            set
            {
                this.OnPropertyValueChange(_.AreasName, _AreasName, value);
                this._AreasName = value;
                
            }
        }
		
        private string _BuildingNO = string.Empty;
		      	
	    /// <summary>
        /// （栋号）弄
        /// </summary>
        public string BuildingNO
        {
            get { return _BuildingNO; }
            set
            {
                this.OnPropertyValueChange(_.BuildingNO, _BuildingNO, value);
                this._BuildingNO = value;
                
            }
        }
		
        private string _RoomNO = string.Empty;
		      	
	    /// <summary>
        /// 室号
        /// </summary>
        public string RoomNO
        {
            get { return _RoomNO; }
            set
            {
                this.OnPropertyValueChange(_.RoomNO, _RoomNO, value);
                this._RoomNO = value;
                
            }
        }
		
        private string _HSpec = string.Empty;
		      	
	    /// <summary>
        /// 房型规格
        /// </summary>
        public string HSpec
        {
            get { return _HSpec; }
            set
            {
                this.OnPropertyValueChange(_.HSpec, _HSpec, value);
                this._HSpec = value;
                
            }
        }
		
        private decimal _RentalArea = 0;
		      	
	    /// <summary>
        /// 出租面积
        /// </summary>
        public decimal RentalArea
        {
            get { return _RentalArea; }
            set
            {
                this.OnPropertyValueChange(_.RentalArea, _RentalArea, value);
                this._RentalArea = value;
                
            }
        }
		
        private string _RentMoneyWay = string.Empty;
		      	
	    /// <summary>
        /// 租金方式
        /// </summary>
        public string RentMoneyWay
        {
            get { return _RentMoneyWay; }
            set
            {
                this.OnPropertyValueChange(_.RentMoneyWay, _RentMoneyWay, value);
                this._RentMoneyWay = value;
                
            }
        }
		
        private DateTime? _SignTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 签约日期
        /// </summary>
        public DateTime? SignTime
        {
            get { return _SignTime; }
            set
            {
                this.OnPropertyValueChange(_.SignTime, _SignTime, value);
                this._SignTime = value;
                
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
            return new Field[] {_.Id,_.OrderNo,_.SignatoryId,_.SignatoryName,_.SignatoryPhone,_.SignatoryIDCard,_.LessorId,_.LessorName,_.LessorPhone,_.LessorIDCard,_.ContractSignTime,_.ContractDueTime,_.BContractAmount,_.ContractAmount,_.FirstPayment,_.HouseDeposit,_.TotalMonth,_.FTotalMonth,_.FTotalMoney,_.AuditStatus,_.HouseId,_.ContractHtml,_.ContractRemark,_.IsDel,_.AddTime,_.LastUpdateTime,_.GenerateWay,_.City,_.District,_.DetailAddress,_.AreasName,_.BuildingNO,_.RoomNO,_.HSpec,_.RentalArea,_.RentMoneyWay,_.SignTime,_.IsSync};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._OrderNo,this._SignatoryId,this._SignatoryName,this._SignatoryPhone,this._SignatoryIDCard,this._LessorId,this._LessorName,this._LessorPhone,this._LessorIDCard,this._ContractSignTime,this._ContractDueTime,this._BContractAmount,this._ContractAmount,this._FirstPayment,this._HouseDeposit,this._TotalMonth,this._FTotalMonth,this._FTotalMoney,this._AuditStatus,this._HouseId,this._ContractHtml,this._ContractRemark,this._IsDel,this._AddTime,this._LastUpdateTime,this._GenerateWay,this._City,this._District,this._DetailAddress,this._AreasName,this._BuildingNO,this._RoomNO,this._HSpec,this._RentalArea,this._RentMoneyWay,this._SignTime,this._IsSync };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._OrderNo = DataUtils.ConvertValue<string>(reader["OrderNo"]);
							this._SignatoryId = DataUtils.ConvertValue<long?>(reader["SignatoryId"]);
							this._SignatoryName = DataUtils.ConvertValue<string>(reader["SignatoryName"]);
							this._SignatoryPhone = DataUtils.ConvertValue<string>(reader["SignatoryPhone"]);
							this._SignatoryIDCard = DataUtils.ConvertValue<string>(reader["SignatoryIDCard"]);
							this._LessorId = DataUtils.ConvertValue<long?>(reader["LessorId"]);
							this._LessorName = DataUtils.ConvertValue<string>(reader["LessorName"]);
							this._LessorPhone = DataUtils.ConvertValue<string>(reader["LessorPhone"]);
							this._LessorIDCard = DataUtils.ConvertValue<string>(reader["LessorIDCard"]);
							this._ContractSignTime = DataUtils.ConvertValue<DateTime?>(reader["ContractSignTime"]);
							this._ContractDueTime = DataUtils.ConvertValue<DateTime?>(reader["ContractDueTime"]);
							this._BContractAmount = DataUtils.ConvertValue<string>(reader["BContractAmount"]);
							this._ContractAmount = DataUtils.ConvertValue<decimal>(reader["ContractAmount"]);
							this._FirstPayment = DataUtils.ConvertValue<decimal>(reader["FirstPayment"]);
							this._HouseDeposit = DataUtils.ConvertValue<decimal>(reader["HouseDeposit"]);
							this._TotalMonth = DataUtils.ConvertValue<int?>(reader["TotalMonth"]);
							this._FTotalMonth = DataUtils.ConvertValue<int?>(reader["FTotalMonth"]);
							this._FTotalMoney = DataUtils.ConvertValue<decimal>(reader["FTotalMoney"]);
							this._AuditStatus = DataUtils.ConvertValue<int?>(reader["AuditStatus"]);
							this._HouseId = DataUtils.ConvertValue<int?>(reader["HouseId"]);
							this._ContractHtml = DataUtils.ConvertValue<string>(reader["ContractHtml"]);
							this._ContractRemark = DataUtils.ConvertValue<string>(reader["ContractRemark"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._GenerateWay = DataUtils.ConvertValue<int?>(reader["GenerateWay"]);
							this._City = DataUtils.ConvertValue<string>(reader["City"]);
							this._District = DataUtils.ConvertValue<string>(reader["District"]);
							this._DetailAddress = DataUtils.ConvertValue<string>(reader["DetailAddress"]);
							this._AreasName = DataUtils.ConvertValue<string>(reader["AreasName"]);
							this._BuildingNO = DataUtils.ConvertValue<string>(reader["BuildingNO"]);
							this._RoomNO = DataUtils.ConvertValue<string>(reader["RoomNO"]);
							this._HSpec = DataUtils.ConvertValue<string>(reader["HSpec"]);
							this._RentalArea = DataUtils.ConvertValue<decimal>(reader["RentalArea"]);
							this._RentMoneyWay = DataUtils.ConvertValue<string>(reader["RentMoneyWay"]);
							this._SignTime = DataUtils.ConvertValue<DateTime?>(reader["SignTime"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._OrderNo =  DataUtils.ConvertValue<string>(row["OrderNo"]);
							this._SignatoryId =  DataUtils.ConvertValue<long?>(row["SignatoryId"]);
							this._SignatoryName =  DataUtils.ConvertValue<string>(row["SignatoryName"]);
							this._SignatoryPhone =  DataUtils.ConvertValue<string>(row["SignatoryPhone"]);
							this._SignatoryIDCard =  DataUtils.ConvertValue<string>(row["SignatoryIDCard"]);
							this._LessorId =  DataUtils.ConvertValue<long?>(row["LessorId"]);
							this._LessorName =  DataUtils.ConvertValue<string>(row["LessorName"]);
							this._LessorPhone =  DataUtils.ConvertValue<string>(row["LessorPhone"]);
							this._LessorIDCard =  DataUtils.ConvertValue<string>(row["LessorIDCard"]);
							this._ContractSignTime =  DataUtils.ConvertValue<DateTime?>(row["ContractSignTime"]);
							this._ContractDueTime =  DataUtils.ConvertValue<DateTime?>(row["ContractDueTime"]);
							this._BContractAmount =  DataUtils.ConvertValue<string>(row["BContractAmount"]);
							this._ContractAmount =  DataUtils.ConvertValue<decimal>(row["ContractAmount"]);
							this._FirstPayment =  DataUtils.ConvertValue<decimal>(row["FirstPayment"]);
							this._HouseDeposit =  DataUtils.ConvertValue<decimal>(row["HouseDeposit"]);
							this._TotalMonth =  DataUtils.ConvertValue<int?>(row["TotalMonth"]);
							this._FTotalMonth =  DataUtils.ConvertValue<int?>(row["FTotalMonth"]);
							this._FTotalMoney =  DataUtils.ConvertValue<decimal>(row["FTotalMoney"]);
							this._AuditStatus =  DataUtils.ConvertValue<int?>(row["AuditStatus"]);
							this._HouseId =  DataUtils.ConvertValue<int?>(row["HouseId"]);
							this._ContractHtml =  DataUtils.ConvertValue<string>(row["ContractHtml"]);
							this._ContractRemark =  DataUtils.ConvertValue<string>(row["ContractRemark"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._GenerateWay =  DataUtils.ConvertValue<int?>(row["GenerateWay"]);
							this._City =  DataUtils.ConvertValue<string>(row["City"]);
							this._District =  DataUtils.ConvertValue<string>(row["District"]);
							this._DetailAddress =  DataUtils.ConvertValue<string>(row["DetailAddress"]);
							this._AreasName =  DataUtils.ConvertValue<string>(row["AreasName"]);
							this._BuildingNO =  DataUtils.ConvertValue<string>(row["BuildingNO"]);
							this._RoomNO =  DataUtils.ConvertValue<string>(row["RoomNO"]);
							this._HSpec =  DataUtils.ConvertValue<string>(row["HSpec"]);
							this._RentalArea =  DataUtils.ConvertValue<decimal>(row["RentalArea"]);
							this._RentMoneyWay =  DataUtils.ConvertValue<string>(row["RentMoneyWay"]);
							this._SignTime =  DataUtils.ConvertValue<DateTime?>(row["SignTime"]);
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
            public readonly static Field All = new Field("*", "ap_contract");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_contract", "主键");
						/// <summary>
            /// 订单号
            /// </summary>
            public readonly static Field OrderNo = new Field("OrderNo", "ap_contract", "订单号");
						/// <summary>
            /// 出租方ID号
            /// </summary>
            public readonly static Field SignatoryId = new Field("SignatoryId", "ap_contract", "出租方ID号");
						/// <summary>
            /// 出租方姓名
            /// </summary>
            public readonly static Field SignatoryName = new Field("SignatoryName", "ap_contract", "出租方姓名");
						/// <summary>
            /// 出租方联系电话
            /// </summary>
            public readonly static Field SignatoryPhone = new Field("SignatoryPhone", "ap_contract", "出租方联系电话");
						/// <summary>
            /// 出租方身份证号
            /// </summary>
            public readonly static Field SignatoryIDCard = new Field("SignatoryIDCard", "ap_contract", "出租方身份证号");
						/// <summary>
            /// 承租方ID号
            /// </summary>
            public readonly static Field LessorId = new Field("LessorId", "ap_contract", "承租方ID号");
						/// <summary>
            /// 承租方姓名
            /// </summary>
            public readonly static Field LessorName = new Field("LessorName", "ap_contract", "承租方姓名");
						/// <summary>
            /// 承租方联系电话
            /// </summary>
            public readonly static Field LessorPhone = new Field("LessorPhone", "ap_contract", "承租方联系电话");
						/// <summary>
            /// 承租方身份证号
            /// </summary>
            public readonly static Field LessorIDCard = new Field("LessorIDCard", "ap_contract", "承租方身份证号");
						/// <summary>
            /// 开始时间
            /// </summary>
            public readonly static Field ContractSignTime = new Field("ContractSignTime", "ap_contract", "开始时间");
						/// <summary>
            /// 结束时间
            /// </summary>
            public readonly static Field ContractDueTime = new Field("ContractDueTime", "ap_contract", "结束时间");
						/// <summary>
            /// 房子租金（大写）
            /// </summary>
            public readonly static Field BContractAmount = new Field("BContractAmount", "ap_contract", "房子租金（大写）");
						/// <summary>
            /// 房子租金
            /// </summary>
            public readonly static Field ContractAmount = new Field("ContractAmount", "ap_contract", "房子租金");
						/// <summary>
            /// 首次付款
            /// </summary>
            public readonly static Field FirstPayment = new Field("FirstPayment", "ap_contract", "首次付款");
						/// <summary>
            /// 房屋押金
            /// </summary>
            public readonly static Field HouseDeposit = new Field("HouseDeposit", "ap_contract", "房屋押金");
						/// <summary>
            /// 房租总月数
            /// </summary>
            public readonly static Field TotalMonth = new Field("TotalMonth", "ap_contract", "房租总月数");
						/// <summary>
            /// 房租总月数（首次）
            /// </summary>
            public readonly static Field FTotalMonth = new Field("FTotalMonth", "ap_contract", "房租总月数（首次）");
						/// <summary>
            /// 房租总金额（首次）
            /// </summary>
            public readonly static Field FTotalMoney = new Field("FTotalMoney", "ap_contract", "房租总金额（首次）");
						/// <summary>
            /// 审核状态：0表示待审核；1表示审核成功；2表示审核失败；
            /// </summary>
            public readonly static Field AuditStatus = new Field("AuditStatus", "ap_contract", "审核状态：0表示待审核；1表示审核成功；2表示审核失败；");
						/// <summary>
            /// 房屋的ID号
            /// </summary>
            public readonly static Field HouseId = new Field("HouseId", "ap_contract", "房屋的ID号");
						/// <summary>
            /// 合同html
            /// </summary>
            public readonly static Field ContractHtml = new Field("ContractHtml", "ap_contract", "合同html");
						/// <summary>
            /// 合同备注
            /// </summary>
            public readonly static Field ContractRemark = new Field("ContractRemark", "ap_contract", "合同备注");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_contract", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 合同生成时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_contract", "合同生成时间");
						/// <summary>
            /// 合同更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_contract", "合同更新时间");
						/// <summary>
            /// 合同生成方式：0表示线上；1表示线下；
            /// </summary>
            public readonly static Field GenerateWay = new Field("GenerateWay", "ap_contract", "合同生成方式：0表示线上；1表示线下；");
						/// <summary>
            /// 市
            /// </summary>
            public readonly static Field City = new Field("City", "ap_contract", "市");
						/// <summary>
            /// 区
            /// </summary>
            public readonly static Field District = new Field("District", "ap_contract", "区");
						/// <summary>
            /// 房源具体地址
            /// </summary>
            public readonly static Field DetailAddress = new Field("DetailAddress", "ap_contract", "房源具体地址");
						/// <summary>
            /// 小区名称
            /// </summary>
            public readonly static Field AreasName = new Field("AreasName", "ap_contract", "小区名称");
						/// <summary>
            /// （栋号）弄
            /// </summary>
            public readonly static Field BuildingNO = new Field("BuildingNO", "ap_contract", "（栋号）弄");
						/// <summary>
            /// 室号
            /// </summary>
            public readonly static Field RoomNO = new Field("RoomNO", "ap_contract", "室号");
						/// <summary>
            /// 房型规格
            /// </summary>
            public readonly static Field HSpec = new Field("HSpec", "ap_contract", "房型规格");
						/// <summary>
            /// 出租面积
            /// </summary>
            public readonly static Field RentalArea = new Field("RentalArea", "ap_contract", "出租面积");
						/// <summary>
            /// 租金方式
            /// </summary>
            public readonly static Field RentMoneyWay = new Field("RentMoneyWay", "ap_contract", "租金方式");
						/// <summary>
            /// 签约日期
            /// </summary>
            public readonly static Field SignTime = new Field("SignTime", "ap_contract", "签约日期");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_contract", "是否同步");
			
        }
		#endregion
        
    }

}
