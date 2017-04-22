using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class CaptchaResponse
    {

        private int _Id = int.MinValue;
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// 验证码
        /// </summary>
        public string Captcha { get; set; } = string.Empty;

        /// <summary>
        /// 是否已经使用：0表示未使用；1表示已使用；
        /// </summary>
        public int? IsUse { get; set; } = 0;
        /// <summary>
        /// 用户ID号（如果存在）
        /// </summary>
        public int? UserId { get; set; } = 0;
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; } = string.Empty;

        /// <summary>
        /// 验证码创建时间
        /// </summary>
        public DateTime? AddTime { get; set; }

        /// <summary>
        /// 验证码使用时间
        /// </summary>
        public DateTime? UseTime { get; set; }

        /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
        public int? IsDel { get; set; }

    }
}
