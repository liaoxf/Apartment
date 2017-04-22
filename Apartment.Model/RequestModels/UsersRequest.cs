using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class UsersRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
    }
    public class GetUsersByOpenIdRequest : BaseRequest
    {
        /// <summary>
        /// 用户OpenId号
        /// </summary>
        public string openId { get; set; }
    }
    public class GetUsersByLogAccountRequest : BaseRequest
    {
        /// <summary>
        /// 用户登录号
        /// </summary>
        public string logAccount { get; set; }
    }
    public class GetUsersListRequest : BaseListRequest
    {
        /// <summary>
        /// 用户登录号
        /// </summary>
        public string logAccount { get; set; }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string userRealName { get; set; }
        /// <summary>
        /// 用户昵称姓名
        /// </summary>
        public string userNickName { get; set; }

    }
    
    public class InsertUserRequest : BaseRequest
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public string LogAccount { get; set; } = string.Empty;

        /// <summary>
        /// 微信ID号
        /// </summary>
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal AccountBalance { get; set; } = 0;

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNickName { get; set; } = string.Empty;

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName { get; set; } = string.Empty;

        /// <summary>
        /// 用户押金
        /// </summary>
        public decimal UserDeposit { get; set; } = 0;

        /// <summary>
        /// 联系手机号
        /// </summary>
        public string LinkMobile { get; set; } = string.Empty;

        /// <summary>
        /// 联系邮箱
        /// </summary>
        public string LinkMail { get; set; } = string.Empty;

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; } = string.Empty;

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// 区
        /// </summary>
        public string District { get; set; } = string.Empty;
    }
}
