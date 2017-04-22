using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zfx365.Com.Model.RequestModels;

namespace Zfx365.Com.WebAPI.Models
{
    public class HouseCollectLogsRequest: BaseListRequest
    {
        #region Field
        private int _Id = int.MinValue;
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set
            {
                this._Id = value;

            }
        }
        private int? _UserId = int.MinValue;
        /// <summary>
        /// 收藏人ID号
        /// </summary>
        public int? UserId
        {
            get { return _UserId; }
            set
            {
                this._UserId = value;

            }
        }
        private int? _HouseId = int.MinValue;
        /// <summary>
        /// 房源ID号
        /// </summary>
        public int? HouseId
        {
            get { return _HouseId; }
            set
            {
                this._HouseId = value;

            }
        }
        private string _HouseTitle = string.Empty;
        /// <summary>
        /// 房源标题
        /// </summary>
        public string HouseTitle
        {
            get { return _HouseTitle; }
            set
            {
                this._HouseTitle = value;

            }
        }
      
        #endregion
    }
}