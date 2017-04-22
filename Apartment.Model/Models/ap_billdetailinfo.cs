	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_billdetailinfo : EntityExt
    {

		public ap_billdetailinfo() : base("ap_billdetailinfo") { }
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
		      	
        private long? _BillId = int.MinValue;
		      	
	    /// <summary>
        /// 账单Id
        /// </summary>
        public long? BillId
        {
            get { return _BillId; }
            set
            {
                this.OnPropertyValueChange(_.BillId, _BillId, value);
                this._BillId = value;
                
            }
        }
		
        private string _BillName = string.Empty;
		      	
	    /// <summary>
        /// 费用名称
        /// </summary>
        public string BillName
        {
            get { return _BillName; }
            set
            {
                this.OnPropertyValueChange(_.BillName, _BillName, value);
                this._BillName = value;
                
            }
        }
		
        private decimal _Unit = 0;
		      	
	    /// <summary>
        /// 单价
        /// </summary>
        public decimal Unit
        {
            get { return _Unit; }
            set
            {
                this.OnPropertyValueChange(_.Unit, _Unit, value);
                this._Unit = value;
                
            }
        }
		
        private int? _SaleUnit = int.MinValue;
		      	
	    /// <summary>
        /// 计价单位
        /// </summary>
        public int? SaleUnit
        {
            get { return _SaleUnit; }
            set
            {
                this.OnPropertyValueChange(_.SaleUnit, _SaleUnit, value);
                this._SaleUnit = value;
                
            }
        }
		
        private int? _LastRead = int.MinValue;
		      	
	    /// <summary>
        /// 上期读数
        /// </summary>
        public int? LastRead
        {
            get { return _LastRead; }
            set
            {
                this.OnPropertyValueChange(_.LastRead, _LastRead, value);
                this._LastRead = value;
                
            }
        }
		
        private int? _CurrRead = int.MinValue;
		      	
	    /// <summary>
        /// 本期读数
        /// </summary>
        public int? CurrRead
        {
            get { return _CurrRead; }
            set
            {
                this.OnPropertyValueChange(_.CurrRead, _CurrRead, value);
                this._CurrRead = value;
                
            }
        }
		
        private decimal _Amount = 0;
		      	
	    /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                this.OnPropertyValueChange(_.Amount, _Amount, value);
                this._Amount = value;
                
            }
        }
		
        private int? _State = int.MinValue;
		      	
	    /// <summary>
        /// 生效/作废
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
            return new Field[] {_.Id,_.BillId,_.BillName,_.Unit,_.SaleUnit,_.LastRead,_.CurrRead,_.Amount,_.State};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._BillId,this._BillName,this._Unit,this._SaleUnit,this._LastRead,this._CurrRead,this._Amount,this._State };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._BillId = DataUtils.ConvertValue<long?>(reader["BillId"]);
							this._BillName = DataUtils.ConvertValue<string>(reader["BillName"]);
							this._Unit = DataUtils.ConvertValue<decimal>(reader["Unit"]);
							this._SaleUnit = DataUtils.ConvertValue<int?>(reader["SaleUnit"]);
							this._LastRead = DataUtils.ConvertValue<int?>(reader["LastRead"]);
							this._CurrRead = DataUtils.ConvertValue<int?>(reader["CurrRead"]);
							this._Amount = DataUtils.ConvertValue<decimal>(reader["Amount"]);
							this._State = DataUtils.ConvertValue<int?>(reader["State"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._BillId =  DataUtils.ConvertValue<long?>(row["BillId"]);
							this._BillName =  DataUtils.ConvertValue<string>(row["BillName"]);
							this._Unit =  DataUtils.ConvertValue<decimal>(row["Unit"]);
							this._SaleUnit =  DataUtils.ConvertValue<int?>(row["SaleUnit"]);
							this._LastRead =  DataUtils.ConvertValue<int?>(row["LastRead"]);
							this._CurrRead =  DataUtils.ConvertValue<int?>(row["CurrRead"]);
							this._Amount =  DataUtils.ConvertValue<decimal>(row["Amount"]);
							this._State =  DataUtils.ConvertValue<int?>(row["State"]);
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
            public readonly static Field All = new Field("*", "ap_billdetailinfo");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_billdetailinfo", "主键");
						/// <summary>
            /// 账单Id
            /// </summary>
            public readonly static Field BillId = new Field("BillId", "ap_billdetailinfo", "账单Id");
						/// <summary>
            /// 费用名称
            /// </summary>
            public readonly static Field BillName = new Field("BillName", "ap_billdetailinfo", "费用名称");
						/// <summary>
            /// 单价
            /// </summary>
            public readonly static Field Unit = new Field("Unit", "ap_billdetailinfo", "单价");
						/// <summary>
            /// 计价单位
            /// </summary>
            public readonly static Field SaleUnit = new Field("SaleUnit", "ap_billdetailinfo", "计价单位");
						/// <summary>
            /// 上期读数
            /// </summary>
            public readonly static Field LastRead = new Field("LastRead", "ap_billdetailinfo", "上期读数");
						/// <summary>
            /// 本期读数
            /// </summary>
            public readonly static Field CurrRead = new Field("CurrRead", "ap_billdetailinfo", "本期读数");
						/// <summary>
            /// 金额
            /// </summary>
            public readonly static Field Amount = new Field("Amount", "ap_billdetailinfo", "金额");
						/// <summary>
            /// 生效/作废
            /// </summary>
            public readonly static Field State = new Field("State", "ap_billdetailinfo", "生效/作废");
			
        }
		#endregion
        
    }

}
