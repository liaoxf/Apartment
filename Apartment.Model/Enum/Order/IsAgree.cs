using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum.Order
{
    /// <summary>
    /// 房东是否同意
    /// </summary>
    public enum IsAgree
    {
        /// <summary>
        /// 待确认
        /// </summary>
        待确认 = 0,
        /// <summary>
        /// 同意
        /// </summary>
        同意 = 1,
        /// <summary>
        /// 不同意
        /// </summary>
        不同意 = 2,
    }

}
