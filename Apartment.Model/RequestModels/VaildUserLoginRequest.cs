using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zfx365.Com.Model.RequestModels
{
    /// <summary>
    /// 登录验证
    /// </summary>
    public class VaildUserLoginRequest : BaseRequest
    {
        /// <summary>
        /// 登录手机号
        /// </summary>
        public string mobileNo { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string verificationCode { get; set; }

    }
}