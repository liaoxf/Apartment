using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zfx365.Com.Model.RequestModels
{
    /// <summary>
    /// 发送验证码参数
    /// </summary>
    public class SendCaptchaRequest : BaseRequest
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobileNo { get; set; }
    }
}