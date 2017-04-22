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
    public enum UserTrackLogType
    {
        /// <summary>
        /// 新增
        /// </summary>
        新增 = 0,
        /// <summary>
        /// 修改
        /// </summary>
        修改 = 1,
        /// <summary>
        /// 删除
        /// </summary>
        删除 = 2,
        /// <summary>
        /// 加入黑名单
        /// </summary>
        加入黑名单 = 3,
        /// <summary>
        /// 移除黑名单
        /// </summary>
        移除黑名单 = 4,
        /// <summary>
        /// 禁用
        /// </summary>
        禁用 = 5,
        /// <summary>
        /// 启用
        /// </summary>
        启用 = 6,
        /// <summary>
        /// 用户跟踪
        /// </summary>
        用户跟踪 = 7,
        /// <summary>
        /// 扣除押金
        /// </summary>
        扣除押金 = 8,
    }
}
