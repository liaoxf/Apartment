	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_house : EntityExt
    {

		public ap_house() : base("ap_house") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键自增ID号
        /// </summary>
        public new long Id
        {
            get { return _Id ==0 ? base.Id :_Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
                
            }
        }
		      	
        private string _HouseTitle = string.Empty;
		      	
	    /// <summary>
        /// 房源标题(房间号)
        /// </summary>
        public string HouseTitle
        {
            get { return _HouseTitle; }
            set
            {
                this.OnPropertyValueChange(_.HouseTitle, _HouseTitle, value);
                this._HouseTitle = value;
                
            }
        }
		
        private long? _UserId = int.MinValue;
		      	
	    /// <summary>
        /// 用户ID号
        /// </summary>
        public long? UserId
        {
            get { return _UserId; }
            set
            {
                this.OnPropertyValueChange(_.UserId, _UserId, value);
                this._UserId = value;
                
            }
        }
		
        private string _UserRealName = string.Empty;
		      	
	    /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName
        {
            get { return _UserRealName; }
            set
            {
                this.OnPropertyValueChange(_.UserRealName, _UserRealName, value);
                this._UserRealName = value;
                
            }
        }
		
        private int? _AuditStatus = int.MinValue;
		      	
	    /// <summary>
        /// 房源总状态状态：0代表待审核；1代表审核通过；2代表审核被驳回
        /// </summary>
        public int? AuditStatus
        {
            get { return _AuditStatus; }
            set
            {
                this.OnPropertyValueChange(_.AuditStatus, _AuditStatus, value);
                this._AuditStatus = value;
                
            }
        }
		
        private int? _HStatus = int.MinValue;
		      	
	    /// <summary>
        /// 房源状态：0表示未出租；1表示已出租；
        /// </summary>
        public int? HStatus
        {
            get { return _HStatus; }
            set
            {
                this.OnPropertyValueChange(_.HStatus, _HStatus, value);
                this._HStatus = value;
                
            }
        }
		
        private DateTime? _AuditedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 审核通过时间
        /// </summary>
        public DateTime? AuditedTime
        {
            get { return _AuditedTime; }
            set
            {
                this.OnPropertyValueChange(_.AuditedTime, _AuditedTime, value);
                this._AuditedTime = value;
                
            }
        }
		
        private string _HTags = string.Empty;
		      	
	    /// <summary>
        /// 房源标签（多个标签以逗号隔开）
        /// </summary>
        public string HTags
        {
            get { return _HTags; }
            set
            {
                this.OnPropertyValueChange(_.HTags, _HTags, value);
                this._HTags = value;
                
            }
        }
		
        private string _RentMode = string.Empty;
		      	
	    /// <summary>
        /// 出租方式
        /// </summary>
        public string RentMode
        {
            get { return _RentMode; }
            set
            {
                this.OnPropertyValueChange(_.RentMode, _RentMode, value);
                this._RentMode = value;
                
            }
        }
		
        private long? _HouseVillageId = int.MinValue;
		      	
	    /// <summary>
        /// 房源小区ID
        /// </summary>
        public long? HouseVillageId
        {
            get { return _HouseVillageId; }
            set
            {
                this.OnPropertyValueChange(_.HouseVillageId, _HouseVillageId, value);
                this._HouseVillageId = value;
                
            }
        }
		
        private string _AreasName = string.Empty;
		      	
	    /// <summary>
        /// 小区名称
        /// </summary>
        public string AreasName
        {
            get { return _AreasName; }
            set
            {
                this.OnPropertyValueChange(_.AreasName, _AreasName, value);
                this._AreasName = value;
                
            }
        }
		
        private string _Province = string.Empty;
		      	
	    /// <summary>
        /// 省
        /// </summary>
        public string Province
        {
            get { return _Province; }
            set
            {
                this.OnPropertyValueChange(_.Province, _Province, value);
                this._Province = value;
                
            }
        }
		
        private string _City = string.Empty;
		      	
	    /// <summary>
        /// 市
        /// </summary>
        public string City
        {
            get { return _City; }
            set
            {
                this.OnPropertyValueChange(_.City, _City, value);
                this._City = value;
                
            }
        }
		
        private string _District = string.Empty;
		      	
	    /// <summary>
        /// 区
        /// </summary>
        public string District
        {
            get { return _District; }
            set
            {
                this.OnPropertyValueChange(_.District, _District, value);
                this._District = value;
                
            }
        }
		
        private string _TradingArea = string.Empty;
		      	
	    /// <summary>
        /// 商圈
        /// </summary>
        public string TradingArea
        {
            get { return _TradingArea; }
            set
            {
                this.OnPropertyValueChange(_.TradingArea, _TradingArea, value);
                this._TradingArea = value;
                
            }
        }
		
        private int? _HRoom = int.MinValue;
		      	
	    /// <summary>
        /// 户型（室）
        /// </summary>
        public int? HRoom
        {
            get { return _HRoom; }
            set
            {
                this.OnPropertyValueChange(_.HRoom, _HRoom, value);
                this._HRoom = value;
                
            }
        }
		
        private int? _HOffice = int.MinValue;
		      	
	    /// <summary>
        /// 户型（厅）
        /// </summary>
        public int? HOffice
        {
            get { return _HOffice; }
            set
            {
                this.OnPropertyValueChange(_.HOffice, _HOffice, value);
                this._HOffice = value;
                
            }
        }
		
        private int? _HWashroom = int.MinValue;
		      	
	    /// <summary>
        /// 户型（卫）
        /// </summary>
        public int? HWashroom
        {
            get { return _HWashroom; }
            set
            {
                this.OnPropertyValueChange(_.HWashroom, _HWashroom, value);
                this._HWashroom = value;
                
            }
        }
		
        private int? _HFloor = int.MinValue;
		      	
	    /// <summary>
        /// 楼层（层级）
        /// </summary>
        public int? HFloor
        {
            get { return _HFloor; }
            set
            {
                this.OnPropertyValueChange(_.HFloor, _HFloor, value);
                this._HFloor = value;
                
            }
        }
		
        private int? _HFloorTotal = int.MinValue;
		      	
	    /// <summary>
        /// 楼层（共计）
        /// </summary>
        public int? HFloorTotal
        {
            get { return _HFloorTotal; }
            set
            {
                this.OnPropertyValueChange(_.HFloorTotal, _HFloorTotal, value);
                this._HFloorTotal = value;
                
            }
        }
		
        private decimal _RentalArea = 0;
		      	
	    /// <summary>
        /// 出租面积
        /// </summary>
        public decimal RentalArea
        {
            get { return _RentalArea; }
            set
            {
                this.OnPropertyValueChange(_.RentalArea, _RentalArea, value);
                this._RentalArea = value;
                
            }
        }
		
        private string _Bedroom = string.Empty;
		      	
	    /// <summary>
        /// 卧室
        /// </summary>
        public string Bedroom
        {
            get { return _Bedroom; }
            set
            {
                this.OnPropertyValueChange(_.Bedroom, _Bedroom, value);
                this._Bedroom = value;
                
            }
        }
		
        private string _HDirection = string.Empty;
		      	
	    /// <summary>
        /// 房源朝向
        /// </summary>
        public string HDirection
        {
            get { return _HDirection; }
            set
            {
                this.OnPropertyValueChange(_.HDirection, _HDirection, value);
                this._HDirection = value;
                
            }
        }
		
        private string _HDecoration = string.Empty;
		      	
	    /// <summary>
        /// 房屋装修情况
        /// </summary>
        public string HDecoration
        {
            get { return _HDecoration; }
            set
            {
                this.OnPropertyValueChange(_.HDecoration, _HDecoration, value);
                this._HDecoration = value;
                
            }
        }
		
        private decimal _HRent = 0;
		      	
	    /// <summary>
        /// 房源租金
        /// </summary>
        public decimal HRent
        {
            get { return _HRent; }
            set
            {
                this.OnPropertyValueChange(_.HRent, _HRent, value);
                this._HRent = value;
                
            }
        }
		
        private decimal _XCoordinate = 0;
		      	
	    /// <summary>
        /// 房源坐标（经度）
        /// </summary>
        public decimal XCoordinate
        {
            get { return _XCoordinate; }
            set
            {
                this.OnPropertyValueChange(_.XCoordinate, _XCoordinate, value);
                this._XCoordinate = value;
                
            }
        }
		
        private decimal _YCoordinate = 0;
		      	
	    /// <summary>
        /// 房源坐标（纬度）
        /// </summary>
        public decimal YCoordinate
        {
            get { return _YCoordinate; }
            set
            {
                this.OnPropertyValueChange(_.YCoordinate, _YCoordinate, value);
                this._YCoordinate = value;
                
            }
        }
		
        private string _DetailAddress = string.Empty;
		      	
	    /// <summary>
        /// 房源具体地址
        /// </summary>
        public string DetailAddress
        {
            get { return _DetailAddress; }
            set
            {
                this.OnPropertyValueChange(_.DetailAddress, _DetailAddress, value);
                this._DetailAddress = value;
                
            }
        }
		
        private int? _IsDel = 0;
		      	
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
        public int? IsDel
        {
            get { return _IsDel; }
            set
            {
                this.OnPropertyValueChange(_.IsDel, _IsDel, value);
                this._IsDel = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 房源创建时间
        /// </summary>
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange(_.AddTime, _AddTime, value);
                this._AddTime = value;
                
            }
        }
		
        private DateTime? _LastUpdateTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 房源更新时间
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.LastUpdateTime, _LastUpdateTime, value);
                this._LastUpdateTime = value;
                
            }
        }
		
        private string _HouseCorver = string.Empty;
		      	
	    /// <summary>
        /// 房源封面
        /// </summary>
        public string HouseCorver
        {
            get { return _HouseCorver; }
            set
            {
                this.OnPropertyValueChange(_.HouseCorver, _HouseCorver, value);
                this._HouseCorver = value;
                
            }
        }
		
        private string _CommentsByAdmin = string.Empty;
		      	
	    /// <summary>
        /// 点评
        /// </summary>
        public string CommentsByAdmin
        {
            get { return _CommentsByAdmin; }
            set
            {
                this.OnPropertyValueChange(_.CommentsByAdmin, _CommentsByAdmin, value);
                this._CommentsByAdmin = value;
                
            }
        }
		
        private int? _PicsCount = int.MinValue;
		      	
	    /// <summary>
        /// 图片数
        /// </summary>
        public int? PicsCount
        {
            get { return _PicsCount; }
            set
            {
                this.OnPropertyValueChange(_.PicsCount, _PicsCount, value);
                this._PicsCount = value;
                
            }
        }
		
        private int? _VideoCount = int.MinValue;
		      	
	    /// <summary>
        /// 视频数
        /// </summary>
        public int? VideoCount
        {
            get { return _VideoCount; }
            set
            {
                this.OnPropertyValueChange(_.VideoCount, _VideoCount, value);
                this._VideoCount = value;
                
            }
        }
		
        private int? _CollectionNumber = int.MinValue;
		      	
	    /// <summary>
        /// 收藏数
        /// </summary>
        public int? CollectionNumber
        {
            get { return _CollectionNumber; }
            set
            {
                this.OnPropertyValueChange(_.CollectionNumber, _CollectionNumber, value);
                this._CollectionNumber = value;
                
            }
        }
		
        private string _Remark = string.Empty;
		      	
	    /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set
            {
                this.OnPropertyValueChange(_.Remark, _Remark, value);
                this._Remark = value;
                
            }
        }
		
        private string _LinkTel = string.Empty;
		      	
	    /// <summary>
        /// 联系电话
        /// </summary>
        public string LinkTel
        {
            get { return _LinkTel; }
            set
            {
                this.OnPropertyValueChange(_.LinkTel, _LinkTel, value);
                this._LinkTel = value;
                
            }
        }
		
        private int? _InterestNumber = int.MinValue;
		      	
	    /// <summary>
        /// 意向房源数
        /// </summary>
        public int? InterestNumber
        {
            get { return _InterestNumber; }
            set
            {
                this.OnPropertyValueChange(_.InterestNumber, _InterestNumber, value);
                this._InterestNumber = value;
                
            }
        }
		
        private int? _CallNumber = int.MinValue;
		      	
	    /// <summary>
        /// 通话量
        /// </summary>
        public int? CallNumber
        {
            get { return _CallNumber; }
            set
            {
                this.OnPropertyValueChange(_.CallNumber, _CallNumber, value);
                this._CallNumber = value;
                
            }
        }
		
        private int? _Source = int.MinValue;
		      	
	    /// <summary>
        /// 来源,0 默认 用户上传,1 后台上传,2其他
        /// </summary>
        public int? Source
        {
            get { return _Source; }
            set
            {
                this.OnPropertyValueChange(_.Source, _Source, value);
                this._Source = value;
                
            }
        }
		
        private string _AuditId = string.Empty;
		      	
	    /// <summary>
        /// 审核人Id
        /// </summary>
        public string AuditId
        {
            get { return _AuditId; }
            set
            {
                this.OnPropertyValueChange(_.AuditId, _AuditId, value);
                this._AuditId = value;
                
            }
        }
		
        private string _AuditName = string.Empty;
		      	
	    /// <summary>
        /// 审核人名称
        /// </summary>
        public string AuditName
        {
            get { return _AuditName; }
            set
            {
                this.OnPropertyValueChange(_.AuditName, _AuditName, value);
                this._AuditName = value;
                
            }
        }
		
        private string _SubwayDistance = string.Empty;
		      	
	    /// <summary>
        /// 最近地铁距离
        /// </summary>
        public string SubwayDistance
        {
            get { return _SubwayDistance; }
            set
            {
                this.OnPropertyValueChange(_.SubwayDistance, _SubwayDistance, value);
                this._SubwayDistance = value;
                
            }
        }
		
        private string _SubwayLines = string.Empty;
		      	
	    /// <summary>
        /// 地铁线路, 用逗号分隔
        /// </summary>
        public string SubwayLines
        {
            get { return _SubwayLines; }
            set
            {
                this.OnPropertyValueChange(_.SubwayLines, _SubwayLines, value);
                this._SubwayLines = value;
                
            }
        }
		
        private string _SubwayStations = string.Empty;
		      	
	    /// <summary>
        /// 地铁站，用逗号隔开
        /// </summary>
        public string SubwayStations
        {
            get { return _SubwayStations; }
            set
            {
                this.OnPropertyValueChange(_.SubwayStations, _SubwayStations, value);
                this._SubwayStations = value;
                
            }
        }
		
        private string _BuildingNO = string.Empty;
		      	
	    /// <summary>
        /// 栋号
        /// </summary>
        public string BuildingNO
        {
            get { return _BuildingNO; }
            set
            {
                this.OnPropertyValueChange(_.BuildingNO, _BuildingNO, value);
                this._BuildingNO = value;
                
            }
        }
		
        private string _RoomNO = string.Empty;
		      	
	    /// <summary>
        /// 室号
        /// </summary>
        public string RoomNO
        {
            get { return _RoomNO; }
            set
            {
                this.OnPropertyValueChange(_.RoomNO, _RoomNO, value);
                this._RoomNO = value;
                
            }
        }
		
        private int? _IsOn = int.MinValue;
		      	
	    /// <summary>
        /// 上下架，0：未上架，1已上架
        /// </summary>
        public int? IsOn
        {
            get { return _IsOn; }
            set
            {
                this.OnPropertyValueChange(_.IsOn, _IsOn, value);
                this._IsOn = value;
                
            }
        }
		
        private DateTime? _IsOnTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 上架时间
        /// </summary>
        public DateTime? IsOnTime
        {
            get { return _IsOnTime; }
            set
            {
                this.OnPropertyValueChange(_.IsOnTime, _IsOnTime, value);
                this._IsOnTime = value;
                
            }
        }
		
        private int? _RefreshStatus = int.MinValue;
		      	
	    /// <summary>
        /// 刷新状态：-1 刷新失败，0已刷新，1 待刷新，
        /// </summary>
        public int? RefreshStatus
        {
            get { return _RefreshStatus; }
            set
            {
                this.OnPropertyValueChange(_.RefreshStatus, _RefreshStatus, value);
                this._RefreshStatus = value;
                
            }
        }
		
        private string _RentMoneyWay = string.Empty;
		      	
	    /// <summary>
        /// 租金方式
        /// </summary>
        public string RentMoneyWay
        {
            get { return _RentMoneyWay; }
            set
            {
                this.OnPropertyValueChange(_.RentMoneyWay, _RentMoneyWay, value);
                this._RentMoneyWay = value;
                
            }
        }
		
        private bool? _IsAppartment = false;
		      	
	    /// <summary>
        /// 是否公寓，默认false，不是；true是公寓
        /// </summary>
        public bool? IsAppartment
        {
            get { return _IsAppartment; }
            set
            {
                this.OnPropertyValueChange(_.IsAppartment, _IsAppartment, value);
                this._IsAppartment = value;
                
            }
        }
		
        private string _HouseConfig = string.Empty;
		      	
	    /// <summary>
        /// 房屋配置（多个房屋配置以逗号隔开）
        /// </summary>
        public string HouseConfig
        {
            get { return _HouseConfig; }
            set
            {
                this.OnPropertyValueChange(_.HouseConfig, _HouseConfig, value);
                this._HouseConfig = value;
                
            }
        }
		
        private int? _VisitCount = int.MinValue;
		      	
	    /// <summary>
        /// VisitCount
        /// </summary>
        public int? VisitCount
        {
            get { return _VisitCount; }
            set
            {
                this.OnPropertyValueChange(_.VisitCount, _VisitCount, value);
                this._VisitCount = value;
                
            }
        }
		
        private int? _IsUp = int.MinValue;
		      	
	    /// <summary>
        /// 是否置顶，0表示否，1表示置顶
        /// </summary>
        public int? IsUp
        {
            get { return _IsUp; }
            set
            {
                this.OnPropertyValueChange(_.IsUp, _IsUp, value);
                this._IsUp = value;
                
            }
        }
		
        private string _SelfSort = string.Empty;
		      	
	    /// <summary>
        /// 自定义顺序，采用字母数字混合排序。如a_b_
        /// </summary>
        public string SelfSort
        {
            get { return _SelfSort; }
            set
            {
                this.OnPropertyValueChange(_.SelfSort, _SelfSort, value);
                this._SelfSort = value;
                
            }
        }
		
        private int? _IsLock = int.MinValue;
		      	
	    /// <summary>
        /// 是否锁定，0表示默认不锁定，1表示锁定
        /// </summary>
        public int? IsLock
        {
            get { return _IsLock; }
            set
            {
                this.OnPropertyValueChange(_.IsLock, _IsLock, value);
                this._IsLock = value;
                
            }
        }
		
        private DateTime? _DeletedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletedTime
        {
            get { return _DeletedTime; }
            set
            {
                this.OnPropertyValueChange(_.DeletedTime, _DeletedTime, value);
                this._DeletedTime = value;
                
            }
        }
		
        private DateTime? _RentTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 出租时间
        /// </summary>
        public DateTime? RentTime
        {
            get { return _RentTime; }
            set
            {
                this.OnPropertyValueChange(_.RentTime, _RentTime, value);
                this._RentTime = value;
                
            }
        }
		
        private DateTime? _LockedTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? LockedTime
        {
            get { return _LockedTime; }
            set
            {
                this.OnPropertyValueChange(_.LockedTime, _LockedTime, value);
                this._LockedTime = value;
                
            }
        }
		
        private string _HouseNo = string.Empty;
		      	
	    /// <summary>
        /// 房间号
        /// </summary>
        public string HouseNo
        {
            get { return _HouseNo; }
            set
            {
                this.OnPropertyValueChange(_.HouseNo, _HouseNo, value);
                this._HouseNo = value;
                
            }
        }
		
        private int? _IsSync = int.MinValue;
		      	
	    /// <summary>
        /// 是否同步
        /// </summary>
        public int? IsSync
        {
            get { return _IsSync; }
            set
            {
                this.OnPropertyValueChange(_.IsSync, _IsSync, value);
                this._IsSync = value;
                
            }
        }
		
        private long _ApartmentId = int.MinValue;
		      	
	    /// <summary>
        /// 房源小区ID
        /// </summary>
        public long ApartmentId
        {
            get { return _ApartmentId; }
            set
            {
                this.OnPropertyValueChange(_.ApartmentId, _ApartmentId, value);
                this._ApartmentId = value;
                
            }
        }
				#endregion

		#region Method

		        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {_.Id };
        }
				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.Id,_.HouseTitle,_.UserId,_.UserRealName,_.AuditStatus,_.HStatus,_.AuditedTime,_.HTags,_.RentMode,_.HouseVillageId,_.AreasName,_.Province,_.City,_.District,_.TradingArea,_.HRoom,_.HOffice,_.HWashroom,_.HFloor,_.HFloorTotal,_.RentalArea,_.Bedroom,_.HDirection,_.HDecoration,_.HRent,_.XCoordinate,_.YCoordinate,_.DetailAddress,_.IsDel,_.AddTime,_.LastUpdateTime,_.HouseCorver,_.CommentsByAdmin,_.PicsCount,_.VideoCount,_.CollectionNumber,_.Remark,_.LinkTel,_.InterestNumber,_.CallNumber,_.Source,_.AuditId,_.AuditName,_.SubwayDistance,_.SubwayLines,_.SubwayStations,_.BuildingNO,_.RoomNO,_.IsOn,_.IsOnTime,_.RefreshStatus,_.RentMoneyWay,_.IsAppartment,_.HouseConfig,_.VisitCount,_.IsUp,_.SelfSort,_.IsLock,_.DeletedTime,_.RentTime,_.LockedTime,_.HouseNo,_.IsSync,_.ApartmentId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._HouseTitle,this._UserId,this._UserRealName,this._AuditStatus,this._HStatus,this._AuditedTime,this._HTags,this._RentMode,this._HouseVillageId,this._AreasName,this._Province,this._City,this._District,this._TradingArea,this._HRoom,this._HOffice,this._HWashroom,this._HFloor,this._HFloorTotal,this._RentalArea,this._Bedroom,this._HDirection,this._HDecoration,this._HRent,this._XCoordinate,this._YCoordinate,this._DetailAddress,this._IsDel,this._AddTime,this._LastUpdateTime,this._HouseCorver,this._CommentsByAdmin,this._PicsCount,this._VideoCount,this._CollectionNumber,this._Remark,this._LinkTel,this._InterestNumber,this._CallNumber,this._Source,this._AuditId,this._AuditName,this._SubwayDistance,this._SubwayLines,this._SubwayStations,this._BuildingNO,this._RoomNO,this._IsOn,this._IsOnTime,this._RefreshStatus,this._RentMoneyWay,this._IsAppartment,this._HouseConfig,this._VisitCount,this._IsUp,this._SelfSort,this._IsLock,this._DeletedTime,this._RentTime,this._LockedTime,this._HouseNo,this._IsSync,this._ApartmentId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._HouseTitle = DataUtils.ConvertValue<string>(reader["HouseTitle"]);
							this._UserId = DataUtils.ConvertValue<long?>(reader["UserId"]);
							this._UserRealName = DataUtils.ConvertValue<string>(reader["UserRealName"]);
							this._AuditStatus = DataUtils.ConvertValue<int?>(reader["AuditStatus"]);
							this._HStatus = DataUtils.ConvertValue<int?>(reader["HStatus"]);
							this._AuditedTime = DataUtils.ConvertValue<DateTime?>(reader["AuditedTime"]);
							this._HTags = DataUtils.ConvertValue<string>(reader["HTags"]);
							this._RentMode = DataUtils.ConvertValue<string>(reader["RentMode"]);
							this._HouseVillageId = DataUtils.ConvertValue<long?>(reader["HouseVillageId"]);
							this._AreasName = DataUtils.ConvertValue<string>(reader["AreasName"]);
							this._Province = DataUtils.ConvertValue<string>(reader["Province"]);
							this._City = DataUtils.ConvertValue<string>(reader["City"]);
							this._District = DataUtils.ConvertValue<string>(reader["District"]);
							this._TradingArea = DataUtils.ConvertValue<string>(reader["TradingArea"]);
							this._HRoom = DataUtils.ConvertValue<int?>(reader["HRoom"]);
							this._HOffice = DataUtils.ConvertValue<int?>(reader["HOffice"]);
							this._HWashroom = DataUtils.ConvertValue<int?>(reader["HWashroom"]);
							this._HFloor = DataUtils.ConvertValue<int?>(reader["HFloor"]);
							this._HFloorTotal = DataUtils.ConvertValue<int?>(reader["HFloorTotal"]);
							this._RentalArea = DataUtils.ConvertValue<decimal>(reader["RentalArea"]);
							this._Bedroom = DataUtils.ConvertValue<string>(reader["Bedroom"]);
							this._HDirection = DataUtils.ConvertValue<string>(reader["HDirection"]);
							this._HDecoration = DataUtils.ConvertValue<string>(reader["HDecoration"]);
							this._HRent = DataUtils.ConvertValue<decimal>(reader["HRent"]);
							this._XCoordinate = DataUtils.ConvertValue<decimal>(reader["XCoordinate"]);
							this._YCoordinate = DataUtils.ConvertValue<decimal>(reader["YCoordinate"]);
							this._DetailAddress = DataUtils.ConvertValue<string>(reader["DetailAddress"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._HouseCorver = DataUtils.ConvertValue<string>(reader["HouseCorver"]);
							this._CommentsByAdmin = DataUtils.ConvertValue<string>(reader["CommentsByAdmin"]);
							this._PicsCount = DataUtils.ConvertValue<int?>(reader["PicsCount"]);
							this._VideoCount = DataUtils.ConvertValue<int?>(reader["VideoCount"]);
							this._CollectionNumber = DataUtils.ConvertValue<int?>(reader["CollectionNumber"]);
							this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
							this._LinkTel = DataUtils.ConvertValue<string>(reader["LinkTel"]);
							this._InterestNumber = DataUtils.ConvertValue<int?>(reader["InterestNumber"]);
							this._CallNumber = DataUtils.ConvertValue<int?>(reader["CallNumber"]);
							this._Source = DataUtils.ConvertValue<int?>(reader["Source"]);
							this._AuditId = DataUtils.ConvertValue<string>(reader["AuditId"]);
							this._AuditName = DataUtils.ConvertValue<string>(reader["AuditName"]);
							this._SubwayDistance = DataUtils.ConvertValue<string>(reader["SubwayDistance"]);
							this._SubwayLines = DataUtils.ConvertValue<string>(reader["SubwayLines"]);
							this._SubwayStations = DataUtils.ConvertValue<string>(reader["SubwayStations"]);
							this._BuildingNO = DataUtils.ConvertValue<string>(reader["BuildingNO"]);
							this._RoomNO = DataUtils.ConvertValue<string>(reader["RoomNO"]);
							this._IsOn = DataUtils.ConvertValue<int?>(reader["IsOn"]);
							this._IsOnTime = DataUtils.ConvertValue<DateTime?>(reader["IsOnTime"]);
							this._RefreshStatus = DataUtils.ConvertValue<int?>(reader["RefreshStatus"]);
							this._RentMoneyWay = DataUtils.ConvertValue<string>(reader["RentMoneyWay"]);
							this._IsAppartment = DataUtils.ConvertValue<bool?>(reader["IsAppartment"]);
							this._HouseConfig = DataUtils.ConvertValue<string>(reader["HouseConfig"]);
							this._VisitCount = DataUtils.ConvertValue<int?>(reader["VisitCount"]);
							this._IsUp = DataUtils.ConvertValue<int?>(reader["IsUp"]);
							this._SelfSort = DataUtils.ConvertValue<string>(reader["SelfSort"]);
							this._IsLock = DataUtils.ConvertValue<int?>(reader["IsLock"]);
							this._DeletedTime = DataUtils.ConvertValue<DateTime?>(reader["DeletedTime"]);
							this._RentTime = DataUtils.ConvertValue<DateTime?>(reader["RentTime"]);
							this._LockedTime = DataUtils.ConvertValue<DateTime?>(reader["LockedTime"]);
							this._HouseNo = DataUtils.ConvertValue<string>(reader["HouseNo"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
							this._ApartmentId = DataUtils.ConvertValue<long>(reader["ApartmentId"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._HouseTitle =  DataUtils.ConvertValue<string>(row["HouseTitle"]);
							this._UserId =  DataUtils.ConvertValue<long?>(row["UserId"]);
							this._UserRealName =  DataUtils.ConvertValue<string>(row["UserRealName"]);
							this._AuditStatus =  DataUtils.ConvertValue<int?>(row["AuditStatus"]);
							this._HStatus =  DataUtils.ConvertValue<int?>(row["HStatus"]);
							this._AuditedTime =  DataUtils.ConvertValue<DateTime?>(row["AuditedTime"]);
							this._HTags =  DataUtils.ConvertValue<string>(row["HTags"]);
							this._RentMode =  DataUtils.ConvertValue<string>(row["RentMode"]);
							this._HouseVillageId =  DataUtils.ConvertValue<long?>(row["HouseVillageId"]);
							this._AreasName =  DataUtils.ConvertValue<string>(row["AreasName"]);
							this._Province =  DataUtils.ConvertValue<string>(row["Province"]);
							this._City =  DataUtils.ConvertValue<string>(row["City"]);
							this._District =  DataUtils.ConvertValue<string>(row["District"]);
							this._TradingArea =  DataUtils.ConvertValue<string>(row["TradingArea"]);
							this._HRoom =  DataUtils.ConvertValue<int?>(row["HRoom"]);
							this._HOffice =  DataUtils.ConvertValue<int?>(row["HOffice"]);
							this._HWashroom =  DataUtils.ConvertValue<int?>(row["HWashroom"]);
							this._HFloor =  DataUtils.ConvertValue<int?>(row["HFloor"]);
							this._HFloorTotal =  DataUtils.ConvertValue<int?>(row["HFloorTotal"]);
							this._RentalArea =  DataUtils.ConvertValue<decimal>(row["RentalArea"]);
							this._Bedroom =  DataUtils.ConvertValue<string>(row["Bedroom"]);
							this._HDirection =  DataUtils.ConvertValue<string>(row["HDirection"]);
							this._HDecoration =  DataUtils.ConvertValue<string>(row["HDecoration"]);
							this._HRent =  DataUtils.ConvertValue<decimal>(row["HRent"]);
							this._XCoordinate =  DataUtils.ConvertValue<decimal>(row["XCoordinate"]);
							this._YCoordinate =  DataUtils.ConvertValue<decimal>(row["YCoordinate"]);
							this._DetailAddress =  DataUtils.ConvertValue<string>(row["DetailAddress"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._HouseCorver =  DataUtils.ConvertValue<string>(row["HouseCorver"]);
							this._CommentsByAdmin =  DataUtils.ConvertValue<string>(row["CommentsByAdmin"]);
							this._PicsCount =  DataUtils.ConvertValue<int?>(row["PicsCount"]);
							this._VideoCount =  DataUtils.ConvertValue<int?>(row["VideoCount"]);
							this._CollectionNumber =  DataUtils.ConvertValue<int?>(row["CollectionNumber"]);
							this._Remark =  DataUtils.ConvertValue<string>(row["Remark"]);
							this._LinkTel =  DataUtils.ConvertValue<string>(row["LinkTel"]);
							this._InterestNumber =  DataUtils.ConvertValue<int?>(row["InterestNumber"]);
							this._CallNumber =  DataUtils.ConvertValue<int?>(row["CallNumber"]);
							this._Source =  DataUtils.ConvertValue<int?>(row["Source"]);
							this._AuditId =  DataUtils.ConvertValue<string>(row["AuditId"]);
							this._AuditName =  DataUtils.ConvertValue<string>(row["AuditName"]);
							this._SubwayDistance =  DataUtils.ConvertValue<string>(row["SubwayDistance"]);
							this._SubwayLines =  DataUtils.ConvertValue<string>(row["SubwayLines"]);
							this._SubwayStations =  DataUtils.ConvertValue<string>(row["SubwayStations"]);
							this._BuildingNO =  DataUtils.ConvertValue<string>(row["BuildingNO"]);
							this._RoomNO =  DataUtils.ConvertValue<string>(row["RoomNO"]);
							this._IsOn =  DataUtils.ConvertValue<int?>(row["IsOn"]);
							this._IsOnTime =  DataUtils.ConvertValue<DateTime?>(row["IsOnTime"]);
							this._RefreshStatus =  DataUtils.ConvertValue<int?>(row["RefreshStatus"]);
							this._RentMoneyWay =  DataUtils.ConvertValue<string>(row["RentMoneyWay"]);
							this._IsAppartment =  DataUtils.ConvertValue<bool?>(row["IsAppartment"]);
							this._HouseConfig =  DataUtils.ConvertValue<string>(row["HouseConfig"]);
							this._VisitCount =  DataUtils.ConvertValue<int?>(row["VisitCount"]);
							this._IsUp =  DataUtils.ConvertValue<int?>(row["IsUp"]);
							this._SelfSort =  DataUtils.ConvertValue<string>(row["SelfSort"]);
							this._IsLock =  DataUtils.ConvertValue<int?>(row["IsLock"]);
							this._DeletedTime =  DataUtils.ConvertValue<DateTime?>(row["DeletedTime"]);
							this._RentTime =  DataUtils.ConvertValue<DateTime?>(row["RentTime"]);
							this._LockedTime =  DataUtils.ConvertValue<DateTime?>(row["LockedTime"]);
							this._HouseNo =  DataUtils.ConvertValue<string>(row["HouseNo"]);
							this._IsSync =  DataUtils.ConvertValue<int?>(row["IsSync"]);
							this._ApartmentId =  DataUtils.ConvertValue<long>(row["ApartmentId"]);
			        }
		#endregion
		
		#region _
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// *
            /// </summary>
            public readonly static Field All = new Field("*", "ap_house");
						/// <summary>
            /// 主键自增ID号
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_house", "主键自增ID号");
						/// <summary>
            /// 房源标题(房间号)
            /// </summary>
            public readonly static Field HouseTitle = new Field("HouseTitle", "ap_house", "房源标题(房间号)");
						/// <summary>
            /// 用户ID号
            /// </summary>
            public readonly static Field UserId = new Field("UserId", "ap_house", "用户ID号");
						/// <summary>
            /// 用户真实姓名
            /// </summary>
            public readonly static Field UserRealName = new Field("UserRealName", "ap_house", "用户真实姓名");
						/// <summary>
            /// 房源总状态状态：0代表待审核；1代表审核通过；2代表审核被驳回
            /// </summary>
            public readonly static Field AuditStatus = new Field("AuditStatus", "ap_house", "房源总状态状态：0代表待审核；1代表审核通过；2代表审核被驳回");
						/// <summary>
            /// 房源状态：0表示未出租；1表示已出租；
            /// </summary>
            public readonly static Field HStatus = new Field("HStatus", "ap_house", "房源状态：0表示未出租；1表示已出租；");
						/// <summary>
            /// 审核通过时间
            /// </summary>
            public readonly static Field AuditedTime = new Field("AuditedTime", "ap_house", "审核通过时间");
						/// <summary>
            /// 房源标签（多个标签以逗号隔开）
            /// </summary>
            public readonly static Field HTags = new Field("HTags", "ap_house", "房源标签（多个标签以逗号隔开）");
						/// <summary>
            /// 出租方式
            /// </summary>
            public readonly static Field RentMode = new Field("RentMode", "ap_house", "出租方式");
						/// <summary>
            /// 房源小区ID
            /// </summary>
            public readonly static Field HouseVillageId = new Field("HouseVillageId", "ap_house", "房源小区ID");
						/// <summary>
            /// 小区名称
            /// </summary>
            public readonly static Field AreasName = new Field("AreasName", "ap_house", "小区名称");
						/// <summary>
            /// 省
            /// </summary>
            public readonly static Field Province = new Field("Province", "ap_house", "省");
						/// <summary>
            /// 市
            /// </summary>
            public readonly static Field City = new Field("City", "ap_house", "市");
						/// <summary>
            /// 区
            /// </summary>
            public readonly static Field District = new Field("District", "ap_house", "区");
						/// <summary>
            /// 商圈
            /// </summary>
            public readonly static Field TradingArea = new Field("TradingArea", "ap_house", "商圈");
						/// <summary>
            /// 户型（室）
            /// </summary>
            public readonly static Field HRoom = new Field("HRoom", "ap_house", "户型（室）");
						/// <summary>
            /// 户型（厅）
            /// </summary>
            public readonly static Field HOffice = new Field("HOffice", "ap_house", "户型（厅）");
						/// <summary>
            /// 户型（卫）
            /// </summary>
            public readonly static Field HWashroom = new Field("HWashroom", "ap_house", "户型（卫）");
						/// <summary>
            /// 楼层（层级）
            /// </summary>
            public readonly static Field HFloor = new Field("HFloor", "ap_house", "楼层（层级）");
						/// <summary>
            /// 楼层（共计）
            /// </summary>
            public readonly static Field HFloorTotal = new Field("HFloorTotal", "ap_house", "楼层（共计）");
						/// <summary>
            /// 出租面积
            /// </summary>
            public readonly static Field RentalArea = new Field("RentalArea", "ap_house", "出租面积");
						/// <summary>
            /// 卧室
            /// </summary>
            public readonly static Field Bedroom = new Field("Bedroom", "ap_house", "卧室");
						/// <summary>
            /// 房源朝向
            /// </summary>
            public readonly static Field HDirection = new Field("HDirection", "ap_house", "房源朝向");
						/// <summary>
            /// 房屋装修情况
            /// </summary>
            public readonly static Field HDecoration = new Field("HDecoration", "ap_house", "房屋装修情况");
						/// <summary>
            /// 房源租金
            /// </summary>
            public readonly static Field HRent = new Field("HRent", "ap_house", "房源租金");
						/// <summary>
            /// 房源坐标（经度）
            /// </summary>
            public readonly static Field XCoordinate = new Field("XCoordinate", "ap_house", "房源坐标（经度）");
						/// <summary>
            /// 房源坐标（纬度）
            /// </summary>
            public readonly static Field YCoordinate = new Field("YCoordinate", "ap_house", "房源坐标（纬度）");
						/// <summary>
            /// 房源具体地址
            /// </summary>
            public readonly static Field DetailAddress = new Field("DetailAddress", "ap_house", "房源具体地址");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_house", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 房源创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_house", "房源创建时间");
						/// <summary>
            /// 房源更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_house", "房源更新时间");
						/// <summary>
            /// 房源封面
            /// </summary>
            public readonly static Field HouseCorver = new Field("HouseCorver", "ap_house", "房源封面");
						/// <summary>
            /// 点评
            /// </summary>
            public readonly static Field CommentsByAdmin = new Field("CommentsByAdmin", "ap_house", "点评");
						/// <summary>
            /// 图片数
            /// </summary>
            public readonly static Field PicsCount = new Field("PicsCount", "ap_house", "图片数");
						/// <summary>
            /// 视频数
            /// </summary>
            public readonly static Field VideoCount = new Field("VideoCount", "ap_house", "视频数");
						/// <summary>
            /// 收藏数
            /// </summary>
            public readonly static Field CollectionNumber = new Field("CollectionNumber", "ap_house", "收藏数");
						/// <summary>
            /// 备注
            /// </summary>
            public readonly static Field Remark = new Field("Remark", "ap_house", "备注");
						/// <summary>
            /// 联系电话
            /// </summary>
            public readonly static Field LinkTel = new Field("LinkTel", "ap_house", "联系电话");
						/// <summary>
            /// 意向房源数
            /// </summary>
            public readonly static Field InterestNumber = new Field("InterestNumber", "ap_house", "意向房源数");
						/// <summary>
            /// 通话量
            /// </summary>
            public readonly static Field CallNumber = new Field("CallNumber", "ap_house", "通话量");
						/// <summary>
            /// 来源,0 默认 用户上传,1 后台上传,2其他
            /// </summary>
            public readonly static Field Source = new Field("Source", "ap_house", "来源,0 默认 用户上传,1 后台上传,2其他");
						/// <summary>
            /// 审核人Id
            /// </summary>
            public readonly static Field AuditId = new Field("AuditId", "ap_house", "审核人Id");
						/// <summary>
            /// 审核人名称
            /// </summary>
            public readonly static Field AuditName = new Field("AuditName", "ap_house", "审核人名称");
						/// <summary>
            /// 最近地铁距离
            /// </summary>
            public readonly static Field SubwayDistance = new Field("SubwayDistance", "ap_house", "最近地铁距离");
						/// <summary>
            /// 地铁线路, 用逗号分隔
            /// </summary>
            public readonly static Field SubwayLines = new Field("SubwayLines", "ap_house", "地铁线路, 用逗号分隔");
						/// <summary>
            /// 地铁站，用逗号隔开
            /// </summary>
            public readonly static Field SubwayStations = new Field("SubwayStations", "ap_house", "地铁站，用逗号隔开");
						/// <summary>
            /// 栋号
            /// </summary>
            public readonly static Field BuildingNO = new Field("BuildingNO", "ap_house", "栋号");
						/// <summary>
            /// 室号
            /// </summary>
            public readonly static Field RoomNO = new Field("RoomNO", "ap_house", "室号");
						/// <summary>
            /// 上下架，0：未上架，1已上架
            /// </summary>
            public readonly static Field IsOn = new Field("IsOn", "ap_house", "上下架，0：未上架，1已上架");
						/// <summary>
            /// 上架时间
            /// </summary>
            public readonly static Field IsOnTime = new Field("IsOnTime", "ap_house", "上架时间");
						/// <summary>
            /// 刷新状态：-1 刷新失败，0已刷新，1 待刷新，
            /// </summary>
            public readonly static Field RefreshStatus = new Field("RefreshStatus", "ap_house", "刷新状态：-1 刷新失败，0已刷新，1 待刷新，");
						/// <summary>
            /// 租金方式
            /// </summary>
            public readonly static Field RentMoneyWay = new Field("RentMoneyWay", "ap_house", "租金方式");
						/// <summary>
            /// 是否公寓，默认false，不是；true是公寓
            /// </summary>
            public readonly static Field IsAppartment = new Field("IsAppartment", "ap_house", "是否公寓，默认false，不是；true是公寓");
						/// <summary>
            /// 房屋配置（多个房屋配置以逗号隔开）
            /// </summary>
            public readonly static Field HouseConfig = new Field("HouseConfig", "ap_house", "房屋配置（多个房屋配置以逗号隔开）");
						/// <summary>
            /// VisitCount
            /// </summary>
            public readonly static Field VisitCount = new Field("VisitCount", "ap_house", "VisitCount");
						/// <summary>
            /// 是否置顶，0表示否，1表示置顶
            /// </summary>
            public readonly static Field IsUp = new Field("IsUp", "ap_house", "是否置顶，0表示否，1表示置顶");
						/// <summary>
            /// 自定义顺序，采用字母数字混合排序。如a_b_
            /// </summary>
            public readonly static Field SelfSort = new Field("SelfSort", "ap_house", "自定义顺序，采用字母数字混合排序。如a_b_");
						/// <summary>
            /// 是否锁定，0表示默认不锁定，1表示锁定
            /// </summary>
            public readonly static Field IsLock = new Field("IsLock", "ap_house", "是否锁定，0表示默认不锁定，1表示锁定");
						/// <summary>
            /// 删除时间
            /// </summary>
            public readonly static Field DeletedTime = new Field("DeletedTime", "ap_house", "删除时间");
						/// <summary>
            /// 出租时间
            /// </summary>
            public readonly static Field RentTime = new Field("RentTime", "ap_house", "出租时间");
						/// <summary>
            /// 删除时间
            /// </summary>
            public readonly static Field LockedTime = new Field("LockedTime", "ap_house", "删除时间");
						/// <summary>
            /// 房间号
            /// </summary>
            public readonly static Field HouseNo = new Field("HouseNo", "ap_house", "房间号");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_house", "是否同步");
						/// <summary>
            /// 房源小区ID
            /// </summary>
            public readonly static Field ApartmentId = new Field("ApartmentId", "ap_house", "房源小区ID");
			
        }
		#endregion
        
    }

}
