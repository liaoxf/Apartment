using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Apartment.Common;
using Apartment.Model.ModelsExp;

namespace Apartment.Dal.ServicesExp
{
    public class UpLoad
    {
        private siteconfig siteconfig;

        public UpLoad()
        {
            siteconfig = SiteConfig.loadConfig();
        }

        /// <summary>
        /// 文件上传方法
        /// </summary>
        /// <param name="postedFile">文件流</param>
        /// <param name="isThumbnail">是否生成缩略图</param>
        /// <param name="isWater">是否打水印</param>
        /// <returns>上传后文件信息</returns>
        public string fileSaveAs(HttpPostedFileBase postedFile, bool isThumbnail, bool isWater)
        {
            try
            {
                string fileExt = Utils.GetFileExt(postedFile.FileName); //文件扩展名，不含“.”
                int fileSize = postedFile.ContentLength; //获得文件大小，以字节为单位
                string fileName = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf(@"\") + 1); //取得原文件名
                string newFileName = Utils.GetRamCode() + "." + fileExt; //随机生成新的文件名
                string newThumbnailFileName = "thumb_" + newFileName; //随机生成缩略图文件名
                string upLoadPath = GetUpLoadPath(); //上传目录相对路径
                string fullUpLoadPath = Utils.GetMapPath(upLoadPath); //上传目录的物理路径
                string newFilePath = upLoadPath + newFileName; //上传后的路径
                string newThumbnailPath = upLoadPath + newThumbnailFileName; //上传后的缩略图路径

                //检查文件扩展名是否合法
                if (!CheckFileExt(fileExt))
                {
                    return "{\"status\": 0, \"msg\": \"不允许上传" + fileExt + "类型的文件！\"}";
                }
                //检查文件大小是否合法
                if (!CheckFileSize(fileExt, fileSize))
                {
                    return "{\"status\": 0, \"msg\": \"文件超过限制的大小！\"}";
                }
                //检查上传的物理路径是否存在，不存在则创建
                if (!Directory.Exists(fullUpLoadPath))
                {
                    Directory.CreateDirectory(fullUpLoadPath);
                }

                //保存文件
                postedFile.SaveAs(fullUpLoadPath + newFileName);
                //如果是图片，检查图片是否超出最大尺寸，是则裁剪
                if (IsImage(fileExt) && (this.siteconfig.imgmaxheight > 0 || this.siteconfig.imgmaxwidth > 0))
                {
                    Thumbnail.MakeThumbnailImage(fullUpLoadPath + newFileName, fullUpLoadPath + newFileName,
                        this.siteconfig.imgmaxwidth, this.siteconfig.imgmaxheight);
                }
                //如果是图片，检查是否需要生成缩略图，是则生成
                if (IsImage(fileExt) && isThumbnail && this.siteconfig.thumbnailwidth > 0 && this.siteconfig.thumbnailheight > 0)
                {
                    Thumbnail.MakeThumbnailImage(fullUpLoadPath + newFileName, fullUpLoadPath + newThumbnailFileName,
                        this.siteconfig.thumbnailwidth, this.siteconfig.thumbnailheight, this.siteconfig.thumbnailmode);
                }
                else
                {
                    newThumbnailPath = newFilePath; //不生成缩略图则返回原图
                }
                //如果是图片，检查是否需要打水印
                if (IsWaterMark(fileExt) && isWater)
                {
                    switch (this.siteconfig.watermarktype)
                    {
                        case 1:
                            WaterMark.AddImageSignText(newFilePath, newFilePath,
                                this.siteconfig.watermarktext, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarkfont, this.siteconfig.watermarkfontsize);
                            break;
                        case 2:
                            WaterMark.AddImageSignPic(newFilePath, newFilePath,
                                this.siteconfig.watermarkpic, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarktransparency);
                            break;
                    }
                }
                //处理完毕，返回JOSN格式的文件信息
                return "{\"status\": 1, \"msg\": \"上传文件成功！\", \"name\": \""
                    + fileName + "\", \"path\": \"" + newFilePath + "\", \"thumb\": \""
                    + newThumbnailPath + "\", \"size\": " + fileSize + ", \"ext\": \"" + fileExt + "\"}";
                //return "{\"status\": 1, \"msg\": \"上传文件成功！\", \"name\": \""
                //    + fileName + "\", \"path\": \""+ siteconfig.weburl + newFilePath + "\", \"thumb\": \""
                //    + siteconfig.weburl + newThumbnailPath + "\", \"size\": " + fileSize + ", \"ext\": \"" + fileExt + "\"}";
            }
            catch
            {
                return "{\"status\": 0, \"msg\": \"上传过程中发生意外错误！\"}";
            }
        }
        /// <summary>
        /// 文件上传方法
        /// </summary>
        /// <param name="postedFile">文件流</param>
        /// <param name="isThumbnail">是否生成缩略图</param>
        /// <param name="isWater">是否打水印</param>
        /// <returns>上传后文件信息</returns>
        public string fileSaveAs(HttpPostedFile postedFile, bool isThumbnail, bool isWater)
        {
            try
            {
                string fileExt = Utils.GetFileExt(postedFile.FileName); //文件扩展名，不含“.”
                int fileSize = postedFile.ContentLength; //获得文件大小，以字节为单位
                string fileName = postedFile.FileName.Substring(postedFile.FileName.LastIndexOf(@"\") + 1); //取得原文件名
                string newFileName = Utils.GetRamCode() + "." + fileExt; //随机生成新的文件名
                string newThumbnailFileName = "thumb_" + newFileName; //随机生成缩略图文件名
                string upLoadPath = GetUpLoadPath(); //上传目录相对路径
                string fullUpLoadPath = Utils.GetMapPath(upLoadPath); //上传目录的物理路径
                string newFilePath = upLoadPath + newFileName; //上传后的路径
                string newThumbnailPath = upLoadPath + newThumbnailFileName; //上传后的缩略图路径

                //检查文件扩展名是否合法
                if (!CheckFileExt(fileExt))
                {
                    return "{\"status\": 0, \"msg\": \"不允许上传" + fileExt + "类型的文件！\"}";
                }
                //检查文件大小是否合法
                if (!CheckFileSize(fileExt, fileSize))
                {
                    return "{\"status\": 0, \"msg\": \"文件超过限制的大小！\"}";
                }
                //检查上传的物理路径是否存在，不存在则创建
                if (!Directory.Exists(fullUpLoadPath))
                {
                    Directory.CreateDirectory(fullUpLoadPath);
                }

                //保存文件
                postedFile.SaveAs(fullUpLoadPath + newFileName);
                //如果是图片，检查图片是否超出最大尺寸，是则裁剪
                if (IsImage(fileExt) && (this.siteconfig.imgmaxheight > 0 || this.siteconfig.imgmaxwidth > 0))
                {
                    Thumbnail.MakeThumbnailImage(fullUpLoadPath + newFileName, fullUpLoadPath + newFileName,
                        this.siteconfig.imgmaxwidth, this.siteconfig.imgmaxheight);
                }
                //如果是图片，检查是否需要生成缩略图，是则生成
                if (IsImage(fileExt) && isThumbnail && this.siteconfig.thumbnailwidth > 0 && this.siteconfig.thumbnailheight > 0)
                {
                    Thumbnail.MakeThumbnailImage(fullUpLoadPath + newFileName, fullUpLoadPath + newThumbnailFileName,
                        this.siteconfig.thumbnailwidth, this.siteconfig.thumbnailheight, this.siteconfig.thumbnailmode);
                }
                else
                {
                    newThumbnailPath = newFilePath; //不生成缩略图则返回原图
                }
                //如果是图片，检查是否需要打水印
                if (IsWaterMark(fileExt) && isWater)
                {
                    switch (this.siteconfig.watermarktype)
                    {
                        case 1:
                            WaterMark.AddImageSignText(newFilePath, newFilePath,
                                this.siteconfig.watermarktext, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarkfont, this.siteconfig.watermarkfontsize);
                            break;
                        case 2:
                            WaterMark.AddImageSignPic(newFilePath, newFilePath,
                                this.siteconfig.watermarkpic, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarktransparency);
                            break;
                    }
                }
                //处理完毕，返回JOSN格式的文件信息
                return "{\"status\": 1, \"msg\": \"上传文件成功！\", \"data\":{\"name\": \""
                    + fileName + "\", \"path\": \"" + siteconfig.weburl + newFilePath + "\", \"thumb\": \""
                    + siteconfig.weburl + newThumbnailPath + "\", \"size\": " + fileSize + ", \"ext\": \"" + fileExt + "\"} }";
            }
            catch
            {
                return "{\"status\": 0, \"msg\": \"上传过程中发生意外错误！\"}";
            }
        }
        /// <summary>
        /// 保存远程文件到本地
        /// </summary>
        /// <param name="fileUri">URI地址</param>
        /// <returns>上传后的路径</returns>
        public string remoteSaveAs(string fileUri)
        {
            WebClient client = new WebClient();
            string fileExt = string.Empty; //文件扩展名，不含“.”
            if (fileUri.LastIndexOf(".") == -1)
            {
                fileExt = "gif";
            }
            else
            {
                fileExt = Utils.GetFileExt(fileUri);
            }
            string newFileName = Utils.GetRamCode() + "." + fileExt; //随机生成新的文件名
            string upLoadPath = GetUpLoadPath(); //上传目录相对路径
            string fullUpLoadPath = Utils.GetMapPath(upLoadPath); //上传目录的物理路径
            string newFilePath = upLoadPath + newFileName; //上传后的路径
            //检查上传的物理路径是否存在，不存在则创建
            if (!Directory.Exists(fullUpLoadPath))
            {
                Directory.CreateDirectory(fullUpLoadPath);
            }

            try
            {
                client.DownloadFile(fileUri, fullUpLoadPath + newFileName);
                //如果是图片，检查是否需要打水印
                if (IsWaterMark(fileExt))
                {
                    switch (this.siteconfig.watermarktype)
                    {
                        case 1:
                            WaterMark.AddImageSignText(newFilePath, newFilePath,
                                this.siteconfig.watermarktext, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarkfont, this.siteconfig.watermarkfontsize);
                            break;
                        case 2:
                            WaterMark.AddImageSignPic(newFilePath, newFilePath,
                                this.siteconfig.watermarkpic, this.siteconfig.watermarkposition,
                                this.siteconfig.watermarkimgquality, this.siteconfig.watermarktransparency);
                            break;
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
            client.Dispose();
            return newFilePath;
        }

        #region 私有方法
        /// <summary>
        /// 返回上传目录相对路径
        /// </summary>
        /// <param name="fileName">上传文件名</param>
        private string GetUpLoadPath()
        {
            string path = siteconfig.webpath + siteconfig.filepath + "/"; //站点目录+上传目录
            switch (this.siteconfig.filesave)
            {
                case 1: //按年月日每天一个文件夹
                    path += DateTime.Now.ToString("yyyyMMdd");
                    break;
                default: //按年月/日存入不同的文件夹
                    path += DateTime.Now.ToString("yyyyMM") + "/" + DateTime.Now.ToString("dd");
                    break;
            }
            return path + "/";
        }

        /// <summary>
        /// 是否需要打水印
        /// </summary>
        /// <param name="_fileExt">文件扩展名，不含“.”</param>
        private bool IsWaterMark(string _fileExt)
        {
            //判断是否开启水印
            if (this.siteconfig.watermarktype > 0)
            {
                //判断是否可以打水印的图片类型
                ArrayList al = new ArrayList();
                al.Add("bmp");
                al.Add("jpeg");
                al.Add("jpg");
                al.Add("png");
                if (al.Contains(_fileExt.ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 是否为图片文件
        /// </summary>
        /// <param name="_fileExt">文件扩展名，不含“.”</param>
        private bool IsImage(string _fileExt)
        {
            ArrayList al = new ArrayList();
            al.Add("bmp");
            al.Add("jpeg");
            al.Add("jpg");
            al.Add("gif");
            al.Add("png");
            if (al.Contains(_fileExt.ToLower()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 检查是否为合法的上传文件
        /// </summary>
        private bool CheckFileExt(string _fileExt)
        {
            //检查危险文件
            string[] excExt = { "asp", "aspx", "ashx", "asa", "asmx", "asax", "php", "jsp", "htm", "html" };
            for (int i = 0; i < excExt.Length; i++)
            {
                if (excExt[i].ToLower() == _fileExt.ToLower())
                {
                    return false;
                }
            }
            //检查合法文件
            string[] allowExt = (this.siteconfig.fileextension + "," + this.siteconfig.videoextension + "," + this.siteconfig.courseextension).Split(',');
            for (int i = 0; i < allowExt.Length; i++)
            {
                if (allowExt[i].ToLower() == _fileExt.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 检查文件大小是否合法
        /// </summary>
        /// <param name="_fileExt">文件扩展名，不含“.”</param>
        /// <param name="_fileSize">文件大小(B)</param>
        private bool CheckFileSize(string _fileExt, int _fileSize)
        {
            //将视频扩展名转换成ArrayList
            ArrayList lsVideoExt = new ArrayList(this.siteconfig.videoextension.ToLower().Split(','));
            //判断是否为图片文件
            if (IsImage(_fileExt))
            {
                if (this.siteconfig.imgsize > 0 && _fileSize > this.siteconfig.imgsize * 1024)
                {
                    return false;
                }
            }
            else if (lsVideoExt.Contains(_fileExt.ToLower()))
            {
                if (this.siteconfig.videosize > 0 && _fileSize > this.siteconfig.videosize * 1024)
                {
                    return false;
                }
            }
            else
            {
                if (this.siteconfig.attachsize > 0 && _fileSize > this.siteconfig.attachsize * 1024)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 私有类
        /// <summary>
        /// Thumbnail 的摘要说明。
        /// </summary>
        public class Thumbnail
        {
            private Image srcImage;
            private string srcFileName;

            /// <summary>
            /// 创建
            /// </summary>
            /// <param name="FileName">原始图片路径</param>
            public bool SetImage(string FileName)
            {
                srcFileName = Utils.GetMapPath(FileName);
                try
                {
                    srcImage = Image.FromFile(srcFileName);
                }
                catch
                {
                    return false;
                }
                return true;

            }

            /// <summary>
            /// 回调
            /// </summary>
            /// <returns></returns>
            public bool ThumbnailCallback()
            {
                return false;
            }

            /// <summary>
            /// 生成缩略图,返回缩略图的Image对象
            /// </summary>
            /// <param name="Width">缩略图宽度</param>
            /// <param name="Height">缩略图高度</param>
            /// <returns>缩略图的Image对象</returns>
            public Image GetImage(int Width, int Height)
            {
                Image img;
                Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                img = srcImage.GetThumbnailImage(Width, Height, callb, IntPtr.Zero);
                return img;
            }

            /// <summary>
            /// 保存缩略图
            /// </summary>
            /// <param name="Width"></param>
            /// <param name="Height"></param>
            public void SaveThumbnailImage(int Width, int Height)
            {
                switch (Path.GetExtension(srcFileName).ToLower())
                {
                    case ".png":
                        SaveImage(Width, Height, ImageFormat.Png);
                        break;
                    case ".gif":
                        SaveImage(Width, Height, ImageFormat.Gif);
                        break;
                    default:
                        SaveImage(Width, Height, ImageFormat.Jpeg);
                        break;
                }
            }

            /// <summary>
            /// 生成缩略图并保存
            /// </summary>
            /// <param name="Width">缩略图的宽度</param>
            /// <param name="Height">缩略图的高度</param>
            /// <param name="imgformat">保存的图像格式</param>
            /// <returns>缩略图的Image对象</returns>
            public void SaveImage(int Width, int Height, ImageFormat imgformat)
            {
                if (imgformat != ImageFormat.Gif && (srcImage.Width > Width) || (srcImage.Height > Height))
                {
                    Image img;
                    Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                    img = srcImage.GetThumbnailImage(Width, Height, callb, IntPtr.Zero);
                    srcImage.Dispose();
                    img.Save(srcFileName, imgformat);
                    img.Dispose();
                }
            }

            #region Helper

            /// <summary>
            /// 保存图片
            /// </summary>
            /// <param name="image">Image 对象</param>
            /// <param name="savePath">保存路径</param>
            /// <param name="ici">指定格式的编解码参数</param>
            private static void SaveImage(Image image, string savePath, ImageCodecInfo ici)
            {
                //设置 原图片 对象的 EncoderParameters 对象
                EncoderParameters parameters = new EncoderParameters(1);
                parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, ((long)100));
                image.Save(savePath, ici, parameters);
                parameters.Dispose();
            }

            /// <summary>
            /// 获取图像编码解码器的所有相关信息
            /// </summary>
            /// <param name="mimeType">包含编码解码器的多用途网际邮件扩充协议 (MIME) 类型的字符串</param>
            /// <returns>返回图像编码解码器的所有相关信息</returns>
            private static ImageCodecInfo GetCodecInfo(string mimeType)
            {
                ImageCodecInfo[] CodecInfo = ImageCodecInfo.GetImageEncoders();
                foreach (ImageCodecInfo ici in CodecInfo)
                {
                    if (ici.MimeType == mimeType)
                        return ici;
                }
                return null;
            }

            /// <summary>
            /// 计算新尺寸
            /// </summary>
            /// <param name="width">原始宽度</param>
            /// <param name="height">原始高度</param>
            /// <param name="maxWidth">最大新宽度</param>
            /// <param name="maxHeight">最大新高度</param>
            /// <returns></returns>
            private static Size ResizeImage(int width, int height, int maxWidth, int maxHeight)
            {
                //此次2012-02-05修改过=================
                if (maxWidth <= 0)
                    maxWidth = width;
                if (maxHeight <= 0)
                    maxHeight = height;
                //以上2012-02-05修改过=================
                decimal MAX_WIDTH = (decimal)maxWidth;
                decimal MAX_HEIGHT = (decimal)maxHeight;
                decimal ASPECT_RATIO = MAX_WIDTH / MAX_HEIGHT;

                int newWidth, newHeight;
                decimal originalWidth = (decimal)width;
                decimal originalHeight = (decimal)height;

                if (originalWidth > MAX_WIDTH || originalHeight > MAX_HEIGHT)
                {
                    decimal factor;
                    // determine the largest factor 
                    if (originalWidth / originalHeight > ASPECT_RATIO)
                    {
                        factor = originalWidth / MAX_WIDTH;
                        newWidth = Convert.ToInt32(originalWidth / factor);
                        newHeight = Convert.ToInt32(originalHeight / factor);
                    }
                    else
                    {
                        factor = originalHeight / MAX_HEIGHT;
                        newWidth = Convert.ToInt32(originalWidth / factor);
                        newHeight = Convert.ToInt32(originalHeight / factor);
                    }
                }
                else
                {
                    newWidth = width;
                    newHeight = height;
                }
                return new Size(newWidth, newHeight);
            }

            /// <summary>
            /// 得到图片格式
            /// </summary>
            /// <param name="name">文件名称</param>
            /// <returns></returns>
            public static ImageFormat GetFormat(string name)
            {
                string ext = name.Substring(name.LastIndexOf(".") + 1);
                switch (ext.ToLower())
                {
                    case "jpg":
                    case "jpeg":
                        return ImageFormat.Jpeg;
                    case "bmp":
                        return ImageFormat.Bmp;
                    case "png":
                        return ImageFormat.Png;
                    case "gif":
                        return ImageFormat.Gif;
                    default:
                        return ImageFormat.Jpeg;
                }
            }
            #endregion

            /// <summary>
            /// 制作小正方形
            /// </summary>
            /// <param name="image">图片对象</param>
            /// <param name="newFileName">新地址</param>
            /// <param name="newSize">长度或宽度</param>
            public static void MakeSquareImage(Image image, string newFileName, int newSize)
            {
                int i = 0;
                int width = image.Width;
                int height = image.Height;
                if (width > height)
                    i = height;
                else
                    i = width;

                Bitmap b = new Bitmap(newSize, newSize);

                try
                {
                    Graphics g = Graphics.FromImage(b);
                    //设置高质量插值法
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //设置高质量,低速度呈现平滑程度
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    //清除整个绘图面并以透明背景色填充
                    g.Clear(Color.Transparent);
                    if (width < height)
                        g.DrawImage(image, new Rectangle(0, 0, newSize, newSize), new Rectangle(0, (height - width) / 2, width, width), GraphicsUnit.Pixel);
                    else
                        g.DrawImage(image, new Rectangle(0, 0, newSize, newSize), new Rectangle((width - height) / 2, 0, height, height), GraphicsUnit.Pixel);

                    SaveImage(b, newFileName, GetCodecInfo("image/" + GetFormat(newFileName).ToString().ToLower()));
                }
                finally
                {
                    image.Dispose();
                    b.Dispose();
                }
            }

            /// <summary>
            /// 制作小正方形
            /// </summary>
            /// <param name="fileName">图片文件名</param>
            /// <param name="newFileName">新地址</param>
            /// <param name="newSize">长度或宽度</param>
            public static void MakeSquareImage(string fileName, string newFileName, int newSize)
            {
                MakeSquareImage(Image.FromFile(fileName), newFileName, newSize);
            }

            /// <summary>
            /// 制作远程小正方形
            /// </summary>
            /// <param name="url">图片url</param>
            /// <param name="newFileName">新地址</param>
            /// <param name="newSize">长度或宽度</param>
            public static void MakeRemoteSquareImage(string url, string newFileName, int newSize)
            {
                Stream stream = GetRemoteImage(url);
                if (stream == null)
                    return;
                Image original = Image.FromStream(stream);
                stream.Close();
                MakeSquareImage(original, newFileName, newSize);
            }

            /// <summary>
            /// 制作缩略图
            /// </summary>
            /// <param name="original">图片对象</param>
            /// <param name="newFileName">新图路径</param>
            /// <param name="maxWidth">最大宽度</param>
            /// <param name="maxHeight">最大高度</param>
            public static void MakeThumbnailImage(Image original, string newFileName, int maxWidth, int maxHeight)
            {
                Size _newSize = ResizeImage(original.Width, original.Height, maxWidth, maxHeight);

                using (Image displayImage = new Bitmap(original, _newSize))
                {
                    try
                    {
                        displayImage.Save(newFileName, original.RawFormat);
                    }
                    finally
                    {
                        original.Dispose();
                    }
                }
            }

            /// <summary>
            /// 制作缩略图
            /// </summary>
            /// <param name="fileName">文件名</param>
            /// <param name="newFileName">新图路径</param>
            /// <param name="maxWidth">最大宽度</param>
            /// <param name="maxHeight">最大高度</param>
            public static void MakeThumbnailImage(string fileName, string newFileName, int maxWidth, int maxHeight)
            {
                //2012-02-05修改过，支持替换
                byte[] imageBytes = File.ReadAllBytes(fileName);
                Image img = Image.FromStream(new System.IO.MemoryStream(imageBytes));
                MakeThumbnailImage(img, newFileName, maxWidth, maxHeight);
                //原文
                //MakeThumbnailImage(Image.FromFile(fileName), newFileName, maxWidth, maxHeight);
            }

            #region 2012-2-19 新增生成图片缩略图方法
            /// <summary>
            /// 生成缩略图
            /// </summary>
            /// <param name="fileName">源图路径（绝对路径）</param>
            /// <param name="newFileName">缩略图路径（绝对路径）</param>
            /// <param name="width">缩略图宽度</param>
            /// <param name="height">缩略图高度</param>
            /// <param name="mode">生成缩略图的方式</param>    
            public static void MakeThumbnailImage(string fileName, string newFileName, int width, int height, string mode)
            {
                Image originalImage = Image.FromFile(fileName);
                int towidth = width;
                int toheight = height;

                int x = 0;
                int y = 0;
                int ow = originalImage.Width;
                int oh = originalImage.Height;

                switch (mode)
                {
                    case "HW"://指定高宽缩放（补白）
                        if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                        {
                            ow = originalImage.Width;
                            oh = originalImage.Width * height / towidth;
                            x = 0;
                            y = (originalImage.Height - oh) / 2;
                        }
                        else
                        {
                            oh = originalImage.Height;
                            ow = originalImage.Height * towidth / toheight;
                            y = 0;
                            x = (originalImage.Width - ow) / 2;
                        }
                        break;
                    case "W"://指定宽，高按比例                    
                        toheight = originalImage.Height * width / originalImage.Width;
                        break;
                    case "H"://指定高，宽按比例
                        towidth = originalImage.Width * height / originalImage.Height;
                        break;
                    case "Cut"://指定高宽裁减（不变形）                
                        if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                        {
                            oh = originalImage.Height;
                            ow = originalImage.Height * towidth / toheight;
                            y = 0;
                            x = (originalImage.Width - ow) / 2;
                        }
                        else
                        {
                            ow = originalImage.Width;
                            oh = originalImage.Width * height / towidth;
                            x = 0;
                            y = (originalImage.Height - oh) / 2;
                        }
                        break;
                    default:
                        break;
                }

                //新建一个bmp图片
                Bitmap b = new Bitmap(towidth, toheight);
                try
                {
                    //新建一个画板
                    Graphics g = Graphics.FromImage(b);
                    //设置高质量插值法
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    //设置高质量,低速度呈现平滑程度
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    //清空画布并以透明背景色填充
                    g.Clear(Color.White);
                    //g.Clear(Color.Transparent);
                    //在指定位置并且按指定大小绘制原图片的指定部分
                    g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);

                    SaveImage(b, newFileName, GetCodecInfo("image/" + GetFormat(newFileName).ToString().ToLower()));
                }
                catch (System.Exception e)
                {
                    throw e;
                }
                finally
                {
                    originalImage.Dispose();
                    b.Dispose();
                }
            }
            #endregion

            #region 2012-10-30 新增图片裁剪方法
            /// <summary>
            /// 裁剪图片并保存
            /// </summary>
            /// <param name="fileName">源图路径（绝对路径）</param>
            /// <param name="newFileName">缩略图路径（绝对路径）</param>
            /// <param name="maxWidth">缩略图宽度</param>
            /// <param name="maxHeight">缩略图高度</param>
            /// <param name="cropWidth">裁剪宽度</param>
            /// <param name="cropHeight">裁剪高度</param>
            /// <param name="X">X轴</param>
            /// <param name="Y">Y轴</param>
            public static bool MakeThumbnailImage(string fileName, string newFileName, int maxWidth, int maxHeight, int cropWidth, int cropHeight, int X, int Y)
            {
                byte[] imageBytes = File.ReadAllBytes(fileName);
                Image originalImage = Image.FromStream(new System.IO.MemoryStream(imageBytes));
                Bitmap b = new Bitmap(cropWidth, cropHeight);
                try
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        //设置高质量插值法
                        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        //设置高质量,低速度呈现平滑程度
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        //清空画布并以透明背景色填充
                        g.Clear(Color.Transparent);
                        //在指定位置并且按指定大小绘制原图片的指定部分
                        g.DrawImage(originalImage, new Rectangle(0, 0, cropWidth, cropHeight), X, Y, cropWidth, cropHeight, GraphicsUnit.Pixel);
                        Image displayImage = new Bitmap(b, maxWidth, maxHeight);
                        SaveImage(displayImage, newFileName, GetCodecInfo("image/" + GetFormat(newFileName).ToString().ToLower()));
                        return true;
                    }
                }
                catch (System.Exception e)
                {
                    throw e;
                }
                finally
                {
                    originalImage.Dispose();
                    b.Dispose();
                }
            }
            #endregion

            /// <summary>
            /// 制作远程缩略图
            /// </summary>
            /// <param name="url">图片URL</param>
            /// <param name="newFileName">新图路径</param>
            /// <param name="maxWidth">最大宽度</param>
            /// <param name="maxHeight">最大高度</param>
            public static void MakeRemoteThumbnailImage(string url, string newFileName, int maxWidth, int maxHeight)
            {
                Stream stream = GetRemoteImage(url);
                if (stream == null)
                    return;
                Image original = Image.FromStream(stream);
                stream.Close();
                MakeThumbnailImage(original, newFileName, maxWidth, maxHeight);
            }

            /// <summary>
            /// 获取图片流
            /// </summary>
            /// <param name="url">图片URL</param>
            /// <returns></returns>
            private static Stream GetRemoteImage(string url)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "GET";
                request.ContentLength = 0;
                request.Timeout = 20000;
                HttpWebResponse response = null;

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    return response.GetResponseStream();
                }
                catch
                {
                    return null;
                }
            }
        }
        public class WaterMark
        {
            /// <summary>
            /// 图片水印
            /// </summary>
            /// <param name="imgPath">服务器图片相对路径</param>
            /// <param name="filename">保存文件名</param>
            /// <param name="watermarkFilename">水印文件相对路径</param>
            /// <param name="watermarkStatus">图片水印位置 0=不使用 1=左上 2=中上 3=右上 4=左中  9=右下</param>
            /// <param name="quality">附加水印图片质量,0-100</param>
            /// <param name="watermarkTransparency">水印的透明度 1--10 10为不透明</param>
            public static void AddImageSignPic(string imgPath, string filename, string watermarkFilename, int watermarkStatus, int quality, int watermarkTransparency)
            {
                if (!File.Exists(Utils.GetMapPath(imgPath)))
                    return;
                byte[] _ImageBytes = File.ReadAllBytes(Utils.GetMapPath(imgPath));
                Image img = Image.FromStream(new System.IO.MemoryStream(_ImageBytes));
                filename = Utils.GetMapPath(filename);

                if (watermarkFilename.StartsWith("/") == false)
                    watermarkFilename = "/" + watermarkFilename;
                watermarkFilename = Utils.GetMapPath(watermarkFilename);
                if (!File.Exists(watermarkFilename))
                    return;
                Graphics g = Graphics.FromImage(img);
                //设置高质量插值法
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //设置高质量,低速度呈现平滑程度
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                Image watermark = new Bitmap(watermarkFilename);

                if (watermark.Height >= img.Height || watermark.Width >= img.Width)
                    return;

                ImageAttributes imageAttributes = new ImageAttributes();
                ColorMap colorMap = new ColorMap();

                colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                ColorMap[] remapTable = { colorMap };

                imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

                float transparency = 0.5F;
                if (watermarkTransparency >= 1 && watermarkTransparency <= 10)
                    transparency = (watermarkTransparency / 10.0F);


                float[][] colorMatrixElements = {
                                                new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                                                new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                                                new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                                                new float[] {0.0f,  0.0f,  0.0f,  transparency, 0.0f},
                                                new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
                                            };

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

                imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                int xpos = 0;
                int ypos = 0;

                switch (watermarkStatus)
                {
                    case 1:
                        xpos = (int)(img.Width * (float).01);
                        ypos = (int)(img.Height * (float).01);
                        break;
                    case 2:
                        xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                        ypos = (int)(img.Height * (float).01);
                        break;
                    case 3:
                        xpos = (int)((img.Width * (float).99) - (watermark.Width));
                        ypos = (int)(img.Height * (float).01);
                        break;
                    case 4:
                        xpos = (int)(img.Width * (float).01);
                        ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                        break;
                    case 5:
                        xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                        ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                        break;
                    case 6:
                        xpos = (int)((img.Width * (float).99) - (watermark.Width));
                        ypos = (int)((img.Height * (float).50) - (watermark.Height / 2));
                        break;
                    case 7:
                        xpos = (int)(img.Width * (float).01);
                        ypos = (int)((img.Height * (float).99) - watermark.Height);
                        break;
                    case 8:
                        xpos = (int)((img.Width * (float).50) - (watermark.Width / 2));
                        ypos = (int)((img.Height * (float).99) - watermark.Height);
                        break;
                    case 9:
                        xpos = (int)((img.Width * (float).99) - (watermark.Width));
                        ypos = (int)((img.Height * (float).99) - watermark.Height);
                        break;
                }

                g.DrawImage(watermark, new Rectangle(xpos, ypos, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel, imageAttributes);

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo ici = null;
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType.IndexOf("jpeg") > -1)
                        ici = codec;
                }
                EncoderParameters encoderParams = new EncoderParameters();
                long[] qualityParam = new long[1];
                if (quality < 0 || quality > 100)
                    quality = 80;

                qualityParam[0] = quality;

                EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityParam);
                encoderParams.Param[0] = encoderParam;

                if (ici != null)
                    img.Save(filename, ici, encoderParams);
                else
                    img.Save(filename);

                g.Dispose();
                img.Dispose();
                watermark.Dispose();
                imageAttributes.Dispose();
            }

            /// <summary>
            /// 文字水印
            /// </summary>
            /// <param name="imgPath">服务器图片相对路径</param>
            /// <param name="filename">保存文件名</param>
            /// <param name="watermarkText">水印文字</param>
            /// <param name="watermarkStatus">图片水印位置 0=不使用 1=左上 2=中上 3=右上 4=左中  9=右下</param>
            /// <param name="quality">附加水印图片质量,0-100</param>
            /// <param name="fontname">字体</param>
            /// <param name="fontsize">字体大小</param>
            public static void AddImageSignText(string imgPath, string filename, string watermarkText, int watermarkStatus, int quality, string fontname, int fontsize)
            {
                byte[] _ImageBytes = File.ReadAllBytes(Utils.GetMapPath(imgPath));
                Image img = Image.FromStream(new System.IO.MemoryStream(_ImageBytes));
                filename = Utils.GetMapPath(filename);

                Graphics g = Graphics.FromImage(img);
                //设置高质量插值法
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //设置高质量,低速度呈现平滑程度
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                Font drawFont = new Font(fontname, fontsize, FontStyle.Regular, GraphicsUnit.Pixel);
                SizeF crSize;
                crSize = g.MeasureString(watermarkText, drawFont);

                float xpos = 0;
                float ypos = 0;

                switch (watermarkStatus)
                {
                    case 1:
                        xpos = (float)img.Width * (float).01;
                        ypos = (float)img.Height * (float).01;
                        break;
                    case 2:
                        xpos = ((float)img.Width * (float).50) - (crSize.Width / 2);
                        ypos = (float)img.Height * (float).01;
                        break;
                    case 3:
                        xpos = ((float)img.Width * (float).99) - crSize.Width;
                        ypos = (float)img.Height * (float).01;
                        break;
                    case 4:
                        xpos = (float)img.Width * (float).01;
                        ypos = ((float)img.Height * (float).50) - (crSize.Height / 2);
                        break;
                    case 5:
                        xpos = ((float)img.Width * (float).50) - (crSize.Width / 2);
                        ypos = ((float)img.Height * (float).50) - (crSize.Height / 2);
                        break;
                    case 6:
                        xpos = ((float)img.Width * (float).99) - crSize.Width;
                        ypos = ((float)img.Height * (float).50) - (crSize.Height / 2);
                        break;
                    case 7:
                        xpos = (float)img.Width * (float).01;
                        ypos = ((float)img.Height * (float).99) - crSize.Height;
                        break;
                    case 8:
                        xpos = ((float)img.Width * (float).50) - (crSize.Width / 2);
                        ypos = ((float)img.Height * (float).99) - crSize.Height;
                        break;
                    case 9:
                        xpos = ((float)img.Width * (float).99) - crSize.Width;
                        ypos = ((float)img.Height * (float).99) - crSize.Height;
                        break;
                }

                g.DrawString(watermarkText, drawFont, new SolidBrush(Color.White), xpos + 1, ypos + 1);
                g.DrawString(watermarkText, drawFont, new SolidBrush(Color.Black), xpos, ypos);

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo ici = null;
                foreach (ImageCodecInfo codec in codecs)
                {
                    if (codec.MimeType.IndexOf("jpeg") > -1)
                        ici = codec;
                }
                EncoderParameters encoderParams = new EncoderParameters();
                long[] qualityParam = new long[1];
                if (quality < 0 || quality > 100)
                    quality = 80;

                qualityParam[0] = quality;

                EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualityParam);
                encoderParams.Param[0] = encoderParam;

                if (ici != null)
                    img.Save(filename, ici, encoderParams);
                else
                    img.Save(filename);

                g.Dispose();
                img.Dispose();
            }
        }
        #endregion
    }
}
