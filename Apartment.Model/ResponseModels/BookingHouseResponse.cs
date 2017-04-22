using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
   
    public class GetByOrderNoResponse
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int bookingHouseId { get; set; }
        /// <summary>
        /// 房屋ID号
        /// </summary>
        public int? HouseID { get; set; }
        /// <summary>
        /// 预约看房时间
        /// </summary>
        public DateTime? BookingTime { get; set; }
        /// <summary>
        /// 房屋名称
        /// </summary>
        public string HouseTitle { get; set; } = string.Empty;
        /// <summary>
        /// 房屋封面
        /// </summary>
        public string HouseCorver { get; set; } = string.Empty;
        /// <summary>
        /// 出租方式
        /// </summary>
        public string RentMode { get; set; } = string.Empty;
        /// <summary>
        /// 小区名称
        /// </summary>
        public string AreasName { get; set; } = string.Empty;
        #endregion
    }

}
