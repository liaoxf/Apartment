using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum.User
{
    /// <summary>
    /// 用户状态：0-租客；1-房东（房东也可以租房）
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// 待审核
        /// </summary>
        租客 = 0,
        /// <summary>
        /// 已审核
        /// </summary>
        房东 = 1
     
    }
}
