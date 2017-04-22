	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_userlogon : EntityExt
    {

		public sys_userlogon() : base("sys_userlogon") { }
	    #region Field

        private string _F_Id = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Id
        {
            get { return _F_Id; }
            set
            {
                this.OnPropertyValueChange(_.F_Id, _F_Id, value);
                this._F_Id = value;
                
            }
        }
		
        private string _F_UserId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_UserId
        {
            get { return _F_UserId; }
            set
            {
                this.OnPropertyValueChange(_.F_UserId, _F_UserId, value);
                this._F_UserId = value;
                
            }
        }
		
        private string _F_UserPassword = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_UserPassword
        {
            get { return _F_UserPassword; }
            set
            {
                this.OnPropertyValueChange(_.F_UserPassword, _F_UserPassword, value);
                this._F_UserPassword = value;
                
            }
        }
		
        private string _F_UserSecretkey = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_UserSecretkey
        {
            get { return _F_UserSecretkey; }
            set
            {
                this.OnPropertyValueChange(_.F_UserSecretkey, _F_UserSecretkey, value);
                this._F_UserSecretkey = value;
                
            }
        }
		
        private byte[] _F_AllowStartTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_AllowStartTime
        {
            get { return _F_AllowStartTime; }
            set
            {
                this.OnPropertyValueChange(_.F_AllowStartTime, _F_AllowStartTime, value);
                this._F_AllowStartTime = value;
                
            }
        }
		
        private byte[] _F_AllowEndTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_AllowEndTime
        {
            get { return _F_AllowEndTime; }
            set
            {
                this.OnPropertyValueChange(_.F_AllowEndTime, _F_AllowEndTime, value);
                this._F_AllowEndTime = value;
                
            }
        }
		
        private byte[] _F_LockStartDate = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_LockStartDate
        {
            get { return _F_LockStartDate; }
            set
            {
                this.OnPropertyValueChange(_.F_LockStartDate, _F_LockStartDate, value);
                this._F_LockStartDate = value;
                
            }
        }
		
        private byte[] _F_LockEndDate = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_LockEndDate
        {
            get { return _F_LockEndDate; }
            set
            {
                this.OnPropertyValueChange(_.F_LockEndDate, _F_LockEndDate, value);
                this._F_LockEndDate = value;
                
            }
        }
		
        private byte[] _F_FirstVisitTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_FirstVisitTime
        {
            get { return _F_FirstVisitTime; }
            set
            {
                this.OnPropertyValueChange(_.F_FirstVisitTime, _F_FirstVisitTime, value);
                this._F_FirstVisitTime = value;
                
            }
        }
		
        private byte[] _F_PreviousVisitTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_PreviousVisitTime
        {
            get { return _F_PreviousVisitTime; }
            set
            {
                this.OnPropertyValueChange(_.F_PreviousVisitTime, _F_PreviousVisitTime, value);
                this._F_PreviousVisitTime = value;
                
            }
        }
		
        private byte[] _F_LastVisitTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_LastVisitTime
        {
            get { return _F_LastVisitTime; }
            set
            {
                this.OnPropertyValueChange(_.F_LastVisitTime, _F_LastVisitTime, value);
                this._F_LastVisitTime = value;
                
            }
        }
		
        private byte[] _F_ChangePasswordDate = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_ChangePasswordDate
        {
            get { return _F_ChangePasswordDate; }
            set
            {
                this.OnPropertyValueChange(_.F_ChangePasswordDate, _F_ChangePasswordDate, value);
                this._F_ChangePasswordDate = value;
                
            }
        }
		
        private bool _F_MultiUserLogin = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_MultiUserLogin
        {
            get { return _F_MultiUserLogin; }
            set
            {
                this.OnPropertyValueChange(_.F_MultiUserLogin, _F_MultiUserLogin, value);
                this._F_MultiUserLogin = value;
                
            }
        }
		
        private int? _F_LogOnCount = int.MinValue;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public int? F_LogOnCount
        {
            get { return _F_LogOnCount; }
            set
            {
                this.OnPropertyValueChange(_.F_LogOnCount, _F_LogOnCount, value);
                this._F_LogOnCount = value;
                
            }
        }
		
        private bool _F_UserOnLine = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_UserOnLine
        {
            get { return _F_UserOnLine; }
            set
            {
                this.OnPropertyValueChange(_.F_UserOnLine, _F_UserOnLine, value);
                this._F_UserOnLine = value;
                
            }
        }
		
        private string _F_Question = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Question
        {
            get { return _F_Question; }
            set
            {
                this.OnPropertyValueChange(_.F_Question, _F_Question, value);
                this._F_Question = value;
                
            }
        }
		
        private string _F_AnswerQuestion = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_AnswerQuestion
        {
            get { return _F_AnswerQuestion; }
            set
            {
                this.OnPropertyValueChange(_.F_AnswerQuestion, _F_AnswerQuestion, value);
                this._F_AnswerQuestion = value;
                
            }
        }
		
        private bool _F_CheckIPAddress = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_CheckIPAddress
        {
            get { return _F_CheckIPAddress; }
            set
            {
                this.OnPropertyValueChange(_.F_CheckIPAddress, _F_CheckIPAddress, value);
                this._F_CheckIPAddress = value;
                
            }
        }
		
        private string _F_Language = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Language
        {
            get { return _F_Language; }
            set
            {
                this.OnPropertyValueChange(_.F_Language, _F_Language, value);
                this._F_Language = value;
                
            }
        }
		
        private string _F_Theme = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Theme
        {
            get { return _F_Theme; }
            set
            {
                this.OnPropertyValueChange(_.F_Theme, _F_Theme, value);
                this._F_Theme = value;
                
            }
        }
				#endregion

		#region Method

				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.F_Id,_.F_UserId,_.F_UserPassword,_.F_UserSecretkey,_.F_AllowStartTime,_.F_AllowEndTime,_.F_LockStartDate,_.F_LockEndDate,_.F_FirstVisitTime,_.F_PreviousVisitTime,_.F_LastVisitTime,_.F_ChangePasswordDate,_.F_MultiUserLogin,_.F_LogOnCount,_.F_UserOnLine,_.F_Question,_.F_AnswerQuestion,_.F_CheckIPAddress,_.F_Language,_.F_Theme};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_UserId,this._F_UserPassword,this._F_UserSecretkey,this._F_AllowStartTime,this._F_AllowEndTime,this._F_LockStartDate,this._F_LockEndDate,this._F_FirstVisitTime,this._F_PreviousVisitTime,this._F_LastVisitTime,this._F_ChangePasswordDate,this._F_MultiUserLogin,this._F_LogOnCount,this._F_UserOnLine,this._F_Question,this._F_AnswerQuestion,this._F_CheckIPAddress,this._F_Language,this._F_Theme };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_UserId = DataUtils.ConvertValue<string>(reader["F_UserId"]);
							this._F_UserPassword = DataUtils.ConvertValue<string>(reader["F_UserPassword"]);
							this._F_UserSecretkey = DataUtils.ConvertValue<string>(reader["F_UserSecretkey"]);
							this._F_AllowStartTime = DataUtils.ConvertValue<byte[]>(reader["F_AllowStartTime"]);
							this._F_AllowEndTime = DataUtils.ConvertValue<byte[]>(reader["F_AllowEndTime"]);
							this._F_LockStartDate = DataUtils.ConvertValue<byte[]>(reader["F_LockStartDate"]);
							this._F_LockEndDate = DataUtils.ConvertValue<byte[]>(reader["F_LockEndDate"]);
							this._F_FirstVisitTime = DataUtils.ConvertValue<byte[]>(reader["F_FirstVisitTime"]);
							this._F_PreviousVisitTime = DataUtils.ConvertValue<byte[]>(reader["F_PreviousVisitTime"]);
							this._F_LastVisitTime = DataUtils.ConvertValue<byte[]>(reader["F_LastVisitTime"]);
							this._F_ChangePasswordDate = DataUtils.ConvertValue<byte[]>(reader["F_ChangePasswordDate"]);
							this._F_MultiUserLogin = DataUtils.ConvertValue<bool>(reader["F_MultiUserLogin"]);
							this._F_LogOnCount = DataUtils.ConvertValue<int?>(reader["F_LogOnCount"]);
							this._F_UserOnLine = DataUtils.ConvertValue<bool>(reader["F_UserOnLine"]);
							this._F_Question = DataUtils.ConvertValue<string>(reader["F_Question"]);
							this._F_AnswerQuestion = DataUtils.ConvertValue<string>(reader["F_AnswerQuestion"]);
							this._F_CheckIPAddress = DataUtils.ConvertValue<bool>(reader["F_CheckIPAddress"]);
							this._F_Language = DataUtils.ConvertValue<string>(reader["F_Language"]);
							this._F_Theme = DataUtils.ConvertValue<string>(reader["F_Theme"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._F_Id =  DataUtils.ConvertValue<string>(row["F_Id"]);
							this._F_UserId =  DataUtils.ConvertValue<string>(row["F_UserId"]);
							this._F_UserPassword =  DataUtils.ConvertValue<string>(row["F_UserPassword"]);
							this._F_UserSecretkey =  DataUtils.ConvertValue<string>(row["F_UserSecretkey"]);
							this._F_AllowStartTime =  DataUtils.ConvertValue<byte[]>(row["F_AllowStartTime"]);
							this._F_AllowEndTime =  DataUtils.ConvertValue<byte[]>(row["F_AllowEndTime"]);
							this._F_LockStartDate =  DataUtils.ConvertValue<byte[]>(row["F_LockStartDate"]);
							this._F_LockEndDate =  DataUtils.ConvertValue<byte[]>(row["F_LockEndDate"]);
							this._F_FirstVisitTime =  DataUtils.ConvertValue<byte[]>(row["F_FirstVisitTime"]);
							this._F_PreviousVisitTime =  DataUtils.ConvertValue<byte[]>(row["F_PreviousVisitTime"]);
							this._F_LastVisitTime =  DataUtils.ConvertValue<byte[]>(row["F_LastVisitTime"]);
							this._F_ChangePasswordDate =  DataUtils.ConvertValue<byte[]>(row["F_ChangePasswordDate"]);
							this._F_MultiUserLogin =  DataUtils.ConvertValue<bool>(row["F_MultiUserLogin"]);
							this._F_LogOnCount =  DataUtils.ConvertValue<int?>(row["F_LogOnCount"]);
							this._F_UserOnLine =  DataUtils.ConvertValue<bool>(row["F_UserOnLine"]);
							this._F_Question =  DataUtils.ConvertValue<string>(row["F_Question"]);
							this._F_AnswerQuestion =  DataUtils.ConvertValue<string>(row["F_AnswerQuestion"]);
							this._F_CheckIPAddress =  DataUtils.ConvertValue<bool>(row["F_CheckIPAddress"]);
							this._F_Language =  DataUtils.ConvertValue<string>(row["F_Language"]);
							this._F_Theme =  DataUtils.ConvertValue<string>(row["F_Theme"]);
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
            public readonly static Field All = new Field("*", "sys_userlogon");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_UserId = new Field("F_UserId", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_UserPassword = new Field("F_UserPassword", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_UserSecretkey = new Field("F_UserSecretkey", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AllowStartTime = new Field("F_AllowStartTime", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AllowEndTime = new Field("F_AllowEndTime", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LockStartDate = new Field("F_LockStartDate", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LockEndDate = new Field("F_LockEndDate", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FirstVisitTime = new Field("F_FirstVisitTime", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_PreviousVisitTime = new Field("F_PreviousVisitTime", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LastVisitTime = new Field("F_LastVisitTime", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ChangePasswordDate = new Field("F_ChangePasswordDate", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_MultiUserLogin = new Field("F_MultiUserLogin", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LogOnCount = new Field("F_LogOnCount", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_UserOnLine = new Field("F_UserOnLine", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Question = new Field("F_Question", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AnswerQuestion = new Field("F_AnswerQuestion", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CheckIPAddress = new Field("F_CheckIPAddress", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Language = new Field("F_Language", "sys_userlogon", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Theme = new Field("F_Theme", "sys_userlogon", "");
			
        }
		#endregion
        
    }

}
