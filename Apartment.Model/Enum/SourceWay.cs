using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum
{
    /// <summary>
    /// 来源：0表示系统；1表示微信端；2表示Ios；3表示安卓；4表示PC
    /// </summary>
    public enum SourceWay
    {
        /// <summary>
        /// 系统
        /// </summary>
        系统 = 0,
        /// <summary>
        /// 微信
        /// </summary>
        微信 = 1,
        /// <summary>
        /// IOS
        /// </summary>
        IOS = 2,
        /// <summary>
        /// Android
        /// </summary>
        Android = 3,
        /// <summary>
        /// PC
        /// </summary>
        PC = 4,
        /// <summary>
        /// 活动
        /// </summary>
        活动 = 5,
        /// <summary>
        /// 其他
        /// </summary>
        其他 = 6,
    }
}
