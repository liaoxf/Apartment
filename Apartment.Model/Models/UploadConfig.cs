using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.Models
{
    public class UploadConfig
    {
        #region 文件上传设置==================================
        /// <summary>
        /// 域名
        /// </summary>
        public string weburl { get; set; } = string.Empty;
        
        /// <summary>
        /// 附件上传目录
        /// </summary>
        public string filepath { get; set; } = string.Empty;
        /// <summary>
        /// 附件保存方式
        /// </summary>
        public int filesave { get; set; } = 1;
        /// <summary>
        /// 编辑器远程图片上传
        /// </summary>
        public int fileremote { get; set; } = 0;
        /// <summary>
        /// 附件上传类型
        /// </summary>
        public string fileextension { get; set; } = string.Empty;
        /// <summary>
        /// 视频上传类型 
        /// </summary>
        public string videoextension { get; set; } = string.Empty;
        /// <summary>
        /// 文件上传大小
        /// </summary>
        public int attachsize { get; set; } = 0;
        /// <summary>
        /// 视频上传大小
        /// </summary>
        public int videosize { get; set; } = 0;
        /// <summary>
        /// 图片上传大小
        /// </summary>
        public int imgsize { get; set; } = 0;
        /// <summary>
        /// 图片最大高度(像素)
        /// </summary>
        public int imgmaxheight { get; set; } = 0;
        /// <summary>
        /// 图片最大宽度(像素)
        /// </summary>
        public int imgmaxwidth { get; set; } = 0;

        /// <summary>
        /// 生成缩略图高度(像素)
        /// </summary>
        public int thumbnailheight { get; set; } = 0;

        /// <summary>
        /// 生成缩略图宽度(像素)
        /// </summary>
        public int thumbnailwidth { get; set; } = 0;

        /// <summary>
        /// 缩略图生成方式
        /// </summary>
        public string thumbnailmode { get; set; } = "Cut";

        /// <summary>
        /// 图片水印类型
        /// </summary>
        public int watermarktype { get; set; } = 0;

        /// <summary>
        /// 图片水印位置
        /// </summary>
        public int watermarkposition { get; set; } = 9;

        /// <summary>
        /// 图片生成质量
        /// </summary>
        public int watermarkimgquality { get; set; } = 80;
        /// <summary>
        /// 图片水印文件
        /// </summary>
        public string watermarkpic { get; set; } = string.Empty;

        /// <summary>
        /// 水印透明度
        /// </summary>
        public int watermarktransparency { get; set; } = 10;
        
        /// <summary>
        /// 水印文字
        /// </summary>
        public string watermarktext { get; set; } = string.Empty;
       
        /// <summary>
        /// 文字字体
        /// </summary>
        public string watermarkfont { get; set; } = string.Empty;
        /// <summary>
        /// 文字大小(像素)
        /// </summary>
        public int watermarkfontsize { get; set; } = 12;
        #endregion
    }
}
