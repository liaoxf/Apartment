	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_groups : EntityExt
    {

		public sys_groups() : base("sys_groups") { }
	    #region Field

        private int _Id = int.MinValue;
		      	
        private string _CreatedBy = string.Empty;
		      	
	    /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreatedBy
        {
            get { return _CreatedBy; }
            set
            {
                this.OnPropertyValueChange(_.CreatedBy, _CreatedBy, value);
                this._CreatedBy = value;
                
            }
        }
		
        private DateTime? _CreatedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return _CreatedTime; }
            set
            {
                this.OnPropertyValueChange(_.CreatedTime, _CreatedTime, value);
                this._CreatedTime = value;
                
            }
        }
		
        private DateTime? _UpdatedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdatedTime
        {
            get { return _UpdatedTime; }
            set
            {
                this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime, value);
                this._UpdatedTime = value;
                
            }
        }
		
        private string _UpdatedBy = string.Empty;
		      	
	    /// <summary>
        /// 更新人ID
        /// </summary>
        public string UpdatedBy
        {
            get { return _UpdatedBy; }
            set
            {
                this.OnPropertyValueChange(_.UpdatedBy, _UpdatedBy, value);
                this._UpdatedBy = value;
                
            }
        }
		
        private int? _IsDel = int.MinValue;
		      	
	    /// <summary>
        /// 是否删除
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
		
        private DateTime? _DeletedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletedTime
        {
            get { return _DeletedTime; }
            set
            {
                this.OnPropertyValueChange(_.DeletedTime, _DeletedTime, value);
                this._DeletedTime = value;
                
            }
        }
		
        private string _DeletedBy = string.Empty;
		      	
	    /// <summary>
        /// 删除人ID
        /// </summary>
        public string DeletedBy
        {
            get { return _DeletedBy; }
            set
            {
                this.OnPropertyValueChange(_.DeletedBy, _DeletedBy, value);
                this._DeletedBy = value;
                
            }
        }
		
        private string _Name = string.Empty;
		      	
	    /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
                
            }
        }
		
        private int? _Category = int.MinValue;
		      	
	    /// <summary>
        /// 类别
        /// </summary>
        public int? Category
        {
            get { return _Category; }
            set
            {
                this.OnPropertyValueChange(_.Category, _Category, value);
                this._Category = value;
                
            }
        }
		
        private string _Email = string.Empty;
		      	
	    /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set
            {
                this.OnPropertyValueChange(_.Email, _Email, value);
                this._Email = value;
                
            }
        }
		
        private string _Cellphone = string.Empty;
		      	
	    /// <summary>
        /// 负责人手机号
        /// </summary>
        public string Cellphone
        {
            get { return _Cellphone; }
            set
            {
                this.OnPropertyValueChange(_.Cellphone, _Cellphone, value);
                this._Cellphone = value;
                
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
            return new Field[] {_.Id,_.CreatedBy,_.CreatedTime,_.UpdatedTime,_.UpdatedBy,_.IsDel,_.DeletedTime,_.DeletedBy,_.Name,_.Category,_.Email,_.Cellphone};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._CreatedBy,this._CreatedTime,this._UpdatedTime,this._UpdatedBy,this._IsDel,this._DeletedTime,this._DeletedBy,this._Name,this._Category,this._Email,this._Cellphone };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<int>(reader["Id"]);
							this._CreatedBy = DataUtils.ConvertValue<string>(reader["CreatedBy"]);
							this._CreatedTime = DataUtils.ConvertValue<DateTime?>(reader["CreatedTime"]);
							this._UpdatedTime = DataUtils.ConvertValue<DateTime?>(reader["UpdatedTime"]);
							this._UpdatedBy = DataUtils.ConvertValue<string>(reader["UpdatedBy"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._DeletedTime = DataUtils.ConvertValue<DateTime?>(reader["DeletedTime"]);
							this._DeletedBy = DataUtils.ConvertValue<string>(reader["DeletedBy"]);
							this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
							this._Category = DataUtils.ConvertValue<int?>(reader["Category"]);
							this._Email = DataUtils.ConvertValue<string>(reader["Email"]);
							this._Cellphone = DataUtils.ConvertValue<string>(reader["Cellphone"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<int>(row["Id"]);
							this._CreatedBy =  DataUtils.ConvertValue<string>(row["CreatedBy"]);
							this._CreatedTime =  DataUtils.ConvertValue<DateTime?>(row["CreatedTime"]);
							this._UpdatedTime =  DataUtils.ConvertValue<DateTime?>(row["UpdatedTime"]);
							this._UpdatedBy =  DataUtils.ConvertValue<string>(row["UpdatedBy"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._DeletedTime =  DataUtils.ConvertValue<DateTime?>(row["DeletedTime"]);
							this._DeletedBy =  DataUtils.ConvertValue<string>(row["DeletedBy"]);
							this._Name =  DataUtils.ConvertValue<string>(row["Name"]);
							this._Category =  DataUtils.ConvertValue<int?>(row["Category"]);
							this._Email =  DataUtils.ConvertValue<string>(row["Email"]);
							this._Cellphone =  DataUtils.ConvertValue<string>(row["Cellphone"]);
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
            public readonly static Field All = new Field("*", "sys_groups");
						/// <summary>
            /// 主键自增ID号
            /// </summary>
            public readonly static Field Id = new Field("Id", "sys_groups", "主键自增ID号");
						/// <summary>
            /// 创建人ID
            /// </summary>
            public readonly static Field CreatedBy = new Field("CreatedBy", "sys_groups", "创建人ID");
						/// <summary>
            /// 创建时间
            /// </summary>
            public readonly static Field CreatedTime = new Field("CreatedTime", "sys_groups", "创建时间");
						/// <summary>
            /// 更新时间
            /// </summary>
            public readonly static Field UpdatedTime = new Field("UpdatedTime", "sys_groups", "更新时间");
						/// <summary>
            /// 更新人ID
            /// </summary>
            public readonly static Field UpdatedBy = new Field("UpdatedBy", "sys_groups", "更新人ID");
						/// <summary>
            /// 是否删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "sys_groups", "是否删除");
						/// <summary>
            /// 删除时间
            /// </summary>
            public readonly static Field DeletedTime = new Field("DeletedTime", "sys_groups", "删除时间");
						/// <summary>
            /// 删除人ID
            /// </summary>
            public readonly static Field DeletedBy = new Field("DeletedBy", "sys_groups", "删除人ID");
						/// <summary>
            /// 名称
            /// </summary>
            public readonly static Field Name = new Field("Name", "sys_groups", "名称");
						/// <summary>
            /// 类别
            /// </summary>
            public readonly static Field Category = new Field("Category", "sys_groups", "类别");
						/// <summary>
            /// 邮箱
            /// </summary>
            public readonly static Field Email = new Field("Email", "sys_groups", "邮箱");
						/// <summary>
            /// 负责人手机号
            /// </summary>
            public readonly static Field Cellphone = new Field("Cellphone", "sys_groups", "负责人手机号");
			
        }
		#endregion
        
    }

}
