using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
  public  class HouseVillageRequest:BaseListRequest
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 所在版块
        /// </summary>
        public string VillageArea { get; set; }
        /// <summary>
        /// 住宅类型
        /// </summary>
        public string HouseType { get; set; }
        /// <summary>
        /// 建造年代
        /// </summary>
        public string BuildingAge { get; set; }
        /// <summary>
        /// 占地面积
        /// </summary>
        public string AreaCover { get; set; }
        /// <summary>
        /// 楼栋数
        /// </summary>
        public int? BuildingTotal { get; set; }
        /// <summary>
        /// 房屋总数
        /// </summary>
        public int? HouseTotal { get; set; }
        /// <summary>
        /// 停车位
        /// </summary>
        public int? ParkingTotal { get; set; }
        /// <summary>
        /// 物业费
        /// </summary>
        public string PropertyFee { get; set; }
        /// <summary>
        /// 绿化率
        /// </summary>
        public string GreenCoverage { get; set; }
        /// <summary>
        /// 容积率
        /// </summary>
        public string VolumeRatio { get; set; }
        /// <summary>
        /// 物业公司
        /// </summary>
        public string PropertyCompany { get; set; }
        /// <summary>
        /// 开发商
        /// </summary>
        public string Developer { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 房源坐标（经度）
        /// </summary>
        public decimal XCoordinate { get; set; }
        /// <summary>
        /// 房源坐标（纬度）
        /// </summary>
        public decimal YCoordinate { get; set; }
       
        #endregion
    }
}
