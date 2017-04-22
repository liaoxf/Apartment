using System.ComponentModel;

namespace Apartment.Model.Enum
{
    /// <summary>
    /// 文件记录
    /// </summary>
    public enum FileType
    {
        [Description("图片")]
        Pic = 1,
        [Description("视频")]
        Vedio = 2,
        [Description("文件")]
        File = 3
    }

    /// <summary>
    /// 日志记录
    /// </summary>
    public enum LogType
    {
        [Description("用户")]
        User = 1,
        [Description("房源")]
        House = 2,
        [Description("订单")]
        Order = 3,
        [Description("合同")]
        Contract = 4,
        [Description("账单")]
        Bill = 5,
    }
}
