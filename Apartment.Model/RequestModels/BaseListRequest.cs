using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class BaseListRequest
    {
        /// <summary>
        /// 应用的ID号
        /// </summary>
        public string AppID { get; set; }
        /// <summary>
        /// 每页个数（默认10个）
        /// </summary>
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// 第几页（默认第一页）
        /// </summary>
        public int PageIndex { get; set; } = 1;
    }
}
