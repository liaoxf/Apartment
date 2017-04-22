using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apartment.Model.ModelsExp;

namespace Zfx365.Com.Model.ResponseModels
{
    public class UsersResponse
    {
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; } = 0;

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

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }

    public class UserLoginResponse : UsersResponse
    {
        /// <summary>
        /// 返回代码
        /// </summary>
        public int ResponseCode { get; set; }

        /// <summary>
        /// 返回提示
        /// </summary>
        public string ResponseMsg { get; set; } = string.Empty;
    }

    public class GenerateQRResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        public string QRUrl { get; set; }
    }
}
