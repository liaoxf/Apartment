	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class apimanager : EntityExt
    {

		public apimanager() : base("apimanager") { }
	    #region Field

        private string _APIId = string.Empty;
		      	
	    /// <summary>
        /// 接口编号
        /// </summary>
        public string APIId
        {
            get { return _APIId; }
            set
            {
                this.OnPropertyValueChange(_.APIId, _APIId, value);
                this._APIId = value;
                
            }
        }
		
        private string _APIMethodName = string.Empty;
		      	
	    /// <summary>
        /// 接口方法名称
        /// </summary>
        public string APIMethodName
        {
            get { return _APIMethodName; }
            set
            {
                this.OnPropertyValueChange(_.APIMethodName, _APIMethodName, value);
                this._APIMethodName = value;
                
            }
        }
		
        private string _APIRequestParams = string.Empty;
		      	
	    /// <summary>
        /// 接口请求参数格式
        /// </summary>
        public string APIRequestParams
        {
            get { return _APIRequestParams; }
            set
            {
                this.OnPropertyValueChange(_.APIRequestParams, _APIRequestParams, value);
                this._APIRequestParams = value;
                
            }
        }
		
        private string _APIResponseData = string.Empty;
		      	
	    /// <summary>
        /// 接口返回数据格式
        /// </summary>
        public string APIResponseData
        {
            get { return _APIResponseData; }
            set
            {
                this.OnPropertyValueChange(_.APIResponseData, _APIResponseData, value);
                this._APIResponseData = value;
                
            }
        }
		
        private string _APIRequestType = string.Empty;
		      	
	    /// <summary>
        /// 接口请求方式
        /// </summary>
        public string APIRequestType
        {
            get { return _APIRequestType; }
            set
            {
                this.OnPropertyValueChange(_.APIRequestType, _APIRequestType, value);
                this._APIRequestType = value;
                
            }
        }
		
        private string _APIPath = string.Empty;
		      	
	    /// <summary>
        /// 接口请求路径
        /// </summary>
        public string APIPath
        {
            get { return _APIPath; }
            set
            {
                this.OnPropertyValueChange(_.APIPath, _APIPath, value);
                this._APIPath = value;
                
            }
        }
		
        private string _APIRemark = string.Empty;
		      	
	    /// <summary>
        /// 接口备注
        /// </summary>
        public string APIRemark
        {
            get { return _APIRemark; }
            set
            {
                this.OnPropertyValueChange(_.APIRemark, _APIRemark, value);
                this._APIRemark = value;
                
            }
        }
		
        private int? _IsDel = int.MinValue;
		      	
	    /// <summary>
        /// 软删除
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
		
        private string _APIOperator = string.Empty;
		      	
	    /// <summary>
        /// 接口添加人
        /// </summary>
        public string APIOperator
        {
            get { return _APIOperator; }
            set
            {
                this.OnPropertyValueChange(_.APIOperator, _APIOperator, value);
                this._APIOperator = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 添加时间
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
				#endregion

		#region Method

		        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {_.APIId };
        }
				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.APIId,_.APIMethodName,_.APIRequestParams,_.APIResponseData,_.APIRequestType,_.APIPath,_.APIRemark,_.IsDel,_.APIOperator,_.AddTime};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._APIId,this._APIMethodName,this._APIRequestParams,this._APIResponseData,this._APIRequestType,this._APIPath,this._APIRemark,this._IsDel,this._APIOperator,this._AddTime };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._APIId = DataUtils.ConvertValue<string>(reader["APIId"]);
							this._APIMethodName = DataUtils.ConvertValue<string>(reader["APIMethodName"]);
							this._APIRequestParams = DataUtils.ConvertValue<string>(reader["APIRequestParams"]);
							this._APIResponseData = DataUtils.ConvertValue<string>(reader["APIResponseData"]);
							this._APIRequestType = DataUtils.ConvertValue<string>(reader["APIRequestType"]);
							this._APIPath = DataUtils.ConvertValue<string>(reader["APIPath"]);
							this._APIRemark = DataUtils.ConvertValue<string>(reader["APIRemark"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._APIOperator = DataUtils.ConvertValue<string>(reader["APIOperator"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._APIId =  DataUtils.ConvertValue<string>(row["APIId"]);
							this._APIMethodName =  DataUtils.ConvertValue<string>(row["APIMethodName"]);
							this._APIRequestParams =  DataUtils.ConvertValue<string>(row["APIRequestParams"]);
							this._APIResponseData =  DataUtils.ConvertValue<string>(row["APIResponseData"]);
							this._APIRequestType =  DataUtils.ConvertValue<string>(row["APIRequestType"]);
							this._APIPath =  DataUtils.ConvertValue<string>(row["APIPath"]);
							this._APIRemark =  DataUtils.ConvertValue<string>(row["APIRemark"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._APIOperator =  DataUtils.ConvertValue<string>(row["APIOperator"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
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
            public readonly static Field All = new Field("*", "apimanager");
						/// <summary>
            /// 接口编号
            /// </summary>
            public readonly static Field APIId = new Field("APIId", "apimanager", "接口编号");
						/// <summary>
            /// 接口方法名称
            /// </summary>
            public readonly static Field APIMethodName = new Field("APIMethodName", "apimanager", "接口方法名称");
						/// <summary>
            /// 接口请求参数格式
            /// </summary>
            public readonly static Field APIRequestParams = new Field("APIRequestParams", "apimanager", "接口请求参数格式");
						/// <summary>
            /// 接口返回数据格式
            /// </summary>
            public readonly static Field APIResponseData = new Field("APIResponseData", "apimanager", "接口返回数据格式");
						/// <summary>
            /// 接口请求方式
            /// </summary>
            public readonly static Field APIRequestType = new Field("APIRequestType", "apimanager", "接口请求方式");
						/// <summary>
            /// 接口请求路径
            /// </summary>
            public readonly static Field APIPath = new Field("APIPath", "apimanager", "接口请求路径");
						/// <summary>
            /// 接口备注
            /// </summary>
            public readonly static Field APIRemark = new Field("APIRemark", "apimanager", "接口备注");
						/// <summary>
            /// 软删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "apimanager", "软删除");
						/// <summary>
            /// 接口添加人
            /// </summary>
            public readonly static Field APIOperator = new Field("APIOperator", "apimanager", "接口添加人");
						/// <summary>
            /// 添加时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "apimanager", "添加时间");
			
        }
		#endregion
        
    }

}
