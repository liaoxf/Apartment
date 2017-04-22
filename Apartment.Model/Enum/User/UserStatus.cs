using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum.User
{
    /// <summary>
    /// 用户状态：0-待审核；1-已审核；2-审核失败；3-已禁用/黑名单
    /// </summary>
    public enum UserStatus
    {
        /// <summary>
        /// 待审核
        /// </summary>
        待审核 = 0,
        /// <summary>
        /// 已审核
        /// </summary>
        已审核 = 1,
        /// <summary>
        /// 审核失败
        /// </summary>
        审核失败 = 2,
        /// <summary>
        /// 已禁用
        /// </summary>
        已禁用 = 3,
        /// <summary>
        /// 黑名单
        /// </summary>
        黑名单 = 4
    }
}
