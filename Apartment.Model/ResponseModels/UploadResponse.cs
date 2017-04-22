using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class UploadResponse
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 保存的路径
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 缩略图路径
        /// </summary>
        public string thumb { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public int size { get; set; }
        /// <summary>
        /// 后缀名
        /// </summary>
        public string ext { get; set; }
    }
}
