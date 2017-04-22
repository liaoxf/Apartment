using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class PageResponse<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public long CurrentPage { get; set; }
        /// <summary>
        /// 每页的个数
        /// </summary>
        public long ItemsPerPage { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public long TotalPages { get; set; }
        /// <summary>
        /// 总个数
        /// </summary>
        public long TotalItems { get; set; }
        
        /// <summary>
        /// 列表数据
        /// </summary>
        public List<T> Items { get; set; }
    }
}
