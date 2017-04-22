using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum.User
{
    /// <summary>
    /// 消息类型：0-系统消息；1-看房预约消息；2-金额变动消息
    /// </summary>
    public enum MsgType
    {
        /// <summary>
        /// 系统消息
        /// </summary>
        系统消息 = 0,
        /// <summary>
        /// 出价消息
        /// </summary>
        出价消息 = 1,
        /// <summary>
        /// 金额变动消息
        /// </summary>
        金额变动消息 = 2,
        /// <summary>
        /// 合同消息
        /// </summary>
        合同消息 = 3
    }
}
