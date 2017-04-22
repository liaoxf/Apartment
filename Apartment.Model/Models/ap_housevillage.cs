	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_housevillage : EntityExt
    {

		public ap_housevillage() : base("ap_housevillage") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键
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
		      	
        private string _VillageArea = string.Empty;
		      	
	    /// <summary>
        /// 所在版块
        /// </summary>
        public string VillageArea
        {
            get { return _VillageArea; }
            set
            {
                this.OnPropertyValueChange(_.VillageArea, _VillageArea, value);
                this._VillageArea = value;
                
            }
        }
		
        private string _HouseType = string.Empty;
		      	
	    /// <summary>
        /// 住宅类型
        /// </summary>
        public string HouseType
        {
            get { return _HouseType; }
            set
            {
                this.OnPropertyValueChange(_.HouseType, _HouseType, value);
                this._HouseType = value;
                
            }
        }
		
        private string _BuildingAge = string.Empty;
		      	
	    /// <summary>
        /// 建造年代
        /// </summary>
        public string BuildingAge
        {
            get { return _BuildingAge; }
            set
            {
                this.OnPropertyValueChange(_.BuildingAge, _BuildingAge, value);
                this._BuildingAge = value;
                
            }
        }
		
        private string _AreaCover = string.Empty;
		      	
	    /// <summary>
        /// 占地面积
        /// </summary>
        public string AreaCover
        {
            get { return _AreaCover; }
            set
            {
                this.OnPropertyValueChange(_.AreaCover, _AreaCover, value);
                this._AreaCover = value;
                
            }
        }
		
        private int? _BuildingTotal = int.MinValue;
		      	
	    /// <summary>
        /// 楼栋数
        /// </summary>
        public int? BuildingTotal
        {
            get { return _BuildingTotal; }
            set
            {
                this.OnPropertyValueChange(_.BuildingTotal, _BuildingTotal, value);
                this._BuildingTotal = value;
                
            }
        }
		
        private int? _HouseTotal = int.MinValue;
		      	
	    /// <summary>
        /// 房屋总数
        /// </summary>
        public int? HouseTotal
        {
            get { return _HouseTotal; }
            set
            {
                this.OnPropertyValueChange(_.HouseTotal, _HouseTotal, value);
                this._HouseTotal = value;
                
            }
        }
		
        private int? _ParkingTotal = int.MinValue;
		      	
	    /// <summary>
        /// 停车位
        /// </summary>
        public int? ParkingTotal
        {
            get { return _ParkingTotal; }
            set
            {
                this.OnPropertyValueChange(_.ParkingTotal, _ParkingTotal, value);
                this._ParkingTotal = value;
                
            }
        }
		
        private string _PropertyFee = string.Empty;
		      	
	    /// <summary>
        /// 物业费
        /// </summary>
        public string PropertyFee
        {
            get { return _PropertyFee; }
            set
            {
                this.OnPropertyValueChange(_.PropertyFee, _PropertyFee, value);
                this._PropertyFee = value;
                
            }
        }
		
        private string _GreenCoverage = string.Empty;
		      	
	    /// <summary>
        /// 绿化率
        /// </summary>
        public string GreenCoverage
        {
            get { return _GreenCoverage; }
            set
            {
                this.OnPropertyValueChange(_.GreenCoverage, _GreenCoverage, value);
                this._GreenCoverage = value;
                
            }
        }
		
        private string _VolumeRatio = string.Empty;
		      	
	    /// <summary>
        /// 容积率
        /// </summary>
        public string VolumeRatio
        {
            get { return _VolumeRatio; }
            set
            {
                this.OnPropertyValueChange(_.VolumeRatio, _VolumeRatio, value);
                this._VolumeRatio = value;
                
            }
        }
		
        private string _PropertyCompany = string.Empty;
		      	
	    /// <summary>
        /// 物业公司
        /// </summary>
        public string PropertyCompany
        {
            get { return _PropertyCompany; }
            set
            {
                this.OnPropertyValueChange(_.PropertyCompany, _PropertyCompany, value);
                this._PropertyCompany = value;
                
            }
        }
		
        private string _Developer = string.Empty;
		      	
	    /// <summary>
        /// 开发商
        /// </summary>
        public string Developer
        {
            get { return _Developer; }
            set
            {
                this.OnPropertyValueChange(_.Developer, _Developer, value);
                this._Developer = value;
                
            }
        }
		
        private string _Description = string.Empty;
		      	
	    /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set
            {
                this.OnPropertyValueChange(_.Description, _Description, value);
                this._Description = value;
                
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
        /// 创建时间
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
        /// 更新时间
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
		
        private int? _Status = int.MinValue;
		      	
	    /// <summary>
        /// 小区状态,0:未审核，1已审核，2审核失败，-1已删除
        /// </summary>
        public int? Status
        {
            get { return _Status; }
            set
            {
                this.OnPropertyValueChange(_.Status, _Status, value);
                this._Status = value;
                
            }
        }
		
        private string _VillagName = string.Empty;
		      	
	    /// <summary>
        /// 小区名字
        /// </summary>
        public string VillagName
        {
            get { return _VillagName; }
            set
            {
                this.OnPropertyValueChange(_.VillagName, _VillagName, value);
                this._VillagName = value;
                
            }
        }
		
        private int? _HouseCount = int.MinValue;
		      	
	    /// <summary>
        /// 房源数
        /// </summary>
        public int? HouseCount
        {
            get { return _HouseCount; }
            set
            {
                this.OnPropertyValueChange(_.HouseCount, _HouseCount, value);
                this._HouseCount = value;
                
            }
        }
		
        private int? _SaledHouse = int.MinValue;
		      	
	    /// <summary>
        /// 成交记录
        /// </summary>
        public int? SaledHouse
        {
            get { return _SaledHouse; }
            set
            {
                this.OnPropertyValueChange(_.SaledHouse, _SaledHouse, value);
                this._SaledHouse = value;
                
            }
        }
		
        private string _Line = string.Empty;
		      	
	    /// <summary>
        /// 路线
        /// </summary>
        public string Line
        {
            get { return _Line; }
            set
            {
                this.OnPropertyValueChange(_.Line, _Line, value);
                this._Line = value;
                
            }
        }
		
        private string _Cover = string.Empty;
		      	
	    /// <summary>
        /// 封面图片
        /// </summary>
        public string Cover
        {
            get { return _Cover; }
            set
            {
                this.OnPropertyValueChange(_.Cover, _Cover, value);
                this._Cover = value;
                
            }
        }
		
        private string _Tags = string.Empty;
		      	
	    /// <summary>
        /// 标签，逗号分隔
        /// </summary>
        public string Tags
        {
            get { return _Tags; }
            set
            {
                this.OnPropertyValueChange(_.Tags, _Tags, value);
                this._Tags = value;
                
            }
        }
		
        private string _CommentsByAdmin = string.Empty;
		      	
	    /// <summary>
        /// 小区点评
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
		
        private long? _AddBy = int.MinValue;
		      	
	    /// <summary>
        /// 创建人
        /// </summary>
        public long? AddBy
        {
            get { return _AddBy; }
            set
            {
                this.OnPropertyValueChange(_.AddBy, _AddBy, value);
                this._AddBy = value;
                
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
		
        private string _DetailsAddress = string.Empty;
		      	
	    /// <summary>
        /// 详细地址
        /// </summary>
        public string DetailsAddress
        {
            get { return _DetailsAddress; }
            set
            {
                this.OnPropertyValueChange(_.DetailsAddress, _DetailsAddress, value);
                this._DetailsAddress = value;
                
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
            return new Field[] {_.Id,_.VillageArea,_.HouseType,_.BuildingAge,_.AreaCover,_.BuildingTotal,_.HouseTotal,_.ParkingTotal,_.PropertyFee,_.GreenCoverage,_.VolumeRatio,_.PropertyCompany,_.Developer,_.Description,_.XCoordinate,_.YCoordinate,_.IsDel,_.AddTime,_.LastUpdateTime,_.Status,_.VillagName,_.HouseCount,_.SaledHouse,_.Line,_.Cover,_.Tags,_.CommentsByAdmin,_.CollectionNumber,_.Remark,_.AddBy,_.Province,_.City,_.District,_.DetailsAddress,_.SubwayDistance,_.SubwayLines,_.SubwayStations,_.IsSync};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._VillageArea,this._HouseType,this._BuildingAge,this._AreaCover,this._BuildingTotal,this._HouseTotal,this._ParkingTotal,this._PropertyFee,this._GreenCoverage,this._VolumeRatio,this._PropertyCompany,this._Developer,this._Description,this._XCoordinate,this._YCoordinate,this._IsDel,this._AddTime,this._LastUpdateTime,this._Status,this._VillagName,this._HouseCount,this._SaledHouse,this._Line,this._Cover,this._Tags,this._CommentsByAdmin,this._CollectionNumber,this._Remark,this._AddBy,this._Province,this._City,this._District,this._DetailsAddress,this._SubwayDistance,this._SubwayLines,this._SubwayStations,this._IsSync };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._VillageArea = DataUtils.ConvertValue<string>(reader["VillageArea"]);
							this._HouseType = DataUtils.ConvertValue<string>(reader["HouseType"]);
							this._BuildingAge = DataUtils.ConvertValue<string>(reader["BuildingAge"]);
							this._AreaCover = DataUtils.ConvertValue<string>(reader["AreaCover"]);
							this._BuildingTotal = DataUtils.ConvertValue<int?>(reader["BuildingTotal"]);
							this._HouseTotal = DataUtils.ConvertValue<int?>(reader["HouseTotal"]);
							this._ParkingTotal = DataUtils.ConvertValue<int?>(reader["ParkingTotal"]);
							this._PropertyFee = DataUtils.ConvertValue<string>(reader["PropertyFee"]);
							this._GreenCoverage = DataUtils.ConvertValue<string>(reader["GreenCoverage"]);
							this._VolumeRatio = DataUtils.ConvertValue<string>(reader["VolumeRatio"]);
							this._PropertyCompany = DataUtils.ConvertValue<string>(reader["PropertyCompany"]);
							this._Developer = DataUtils.ConvertValue<string>(reader["Developer"]);
							this._Description = DataUtils.ConvertValue<string>(reader["Description"]);
							this._XCoordinate = DataUtils.ConvertValue<decimal>(reader["XCoordinate"]);
							this._YCoordinate = DataUtils.ConvertValue<decimal>(reader["YCoordinate"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._Status = DataUtils.ConvertValue<int?>(reader["Status"]);
							this._VillagName = DataUtils.ConvertValue<string>(reader["VillagName"]);
							this._HouseCount = DataUtils.ConvertValue<int?>(reader["HouseCount"]);
							this._SaledHouse = DataUtils.ConvertValue<int?>(reader["SaledHouse"]);
							this._Line = DataUtils.ConvertValue<string>(reader["Line"]);
							this._Cover = DataUtils.ConvertValue<string>(reader["Cover"]);
							this._Tags = DataUtils.ConvertValue<string>(reader["Tags"]);
							this._CommentsByAdmin = DataUtils.ConvertValue<string>(reader["CommentsByAdmin"]);
							this._CollectionNumber = DataUtils.ConvertValue<int?>(reader["CollectionNumber"]);
							this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
							this._AddBy = DataUtils.ConvertValue<long?>(reader["AddBy"]);
							this._Province = DataUtils.ConvertValue<string>(reader["Province"]);
							this._City = DataUtils.ConvertValue<string>(reader["City"]);
							this._District = DataUtils.ConvertValue<string>(reader["District"]);
							this._DetailsAddress = DataUtils.ConvertValue<string>(reader["DetailsAddress"]);
							this._SubwayDistance = DataUtils.ConvertValue<string>(reader["SubwayDistance"]);
							this._SubwayLines = DataUtils.ConvertValue<string>(reader["SubwayLines"]);
							this._SubwayStations = DataUtils.ConvertValue<string>(reader["SubwayStations"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._VillageArea =  DataUtils.ConvertValue<string>(row["VillageArea"]);
							this._HouseType =  DataUtils.ConvertValue<string>(row["HouseType"]);
							this._BuildingAge =  DataUtils.ConvertValue<string>(row["BuildingAge"]);
							this._AreaCover =  DataUtils.ConvertValue<string>(row["AreaCover"]);
							this._BuildingTotal =  DataUtils.ConvertValue<int?>(row["BuildingTotal"]);
							this._HouseTotal =  DataUtils.ConvertValue<int?>(row["HouseTotal"]);
							this._ParkingTotal =  DataUtils.ConvertValue<int?>(row["ParkingTotal"]);
							this._PropertyFee =  DataUtils.ConvertValue<string>(row["PropertyFee"]);
							this._GreenCoverage =  DataUtils.ConvertValue<string>(row["GreenCoverage"]);
							this._VolumeRatio =  DataUtils.ConvertValue<string>(row["VolumeRatio"]);
							this._PropertyCompany =  DataUtils.ConvertValue<string>(row["PropertyCompany"]);
							this._Developer =  DataUtils.ConvertValue<string>(row["Developer"]);
							this._Description =  DataUtils.ConvertValue<string>(row["Description"]);
							this._XCoordinate =  DataUtils.ConvertValue<decimal>(row["XCoordinate"]);
							this._YCoordinate =  DataUtils.ConvertValue<decimal>(row["YCoordinate"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._Status =  DataUtils.ConvertValue<int?>(row["Status"]);
							this._VillagName =  DataUtils.ConvertValue<string>(row["VillagName"]);
							this._HouseCount =  DataUtils.ConvertValue<int?>(row["HouseCount"]);
							this._SaledHouse =  DataUtils.ConvertValue<int?>(row["SaledHouse"]);
							this._Line =  DataUtils.ConvertValue<string>(row["Line"]);
							this._Cover =  DataUtils.ConvertValue<string>(row["Cover"]);
							this._Tags =  DataUtils.ConvertValue<string>(row["Tags"]);
							this._CommentsByAdmin =  DataUtils.ConvertValue<string>(row["CommentsByAdmin"]);
							this._CollectionNumber =  DataUtils.ConvertValue<int?>(row["CollectionNumber"]);
							this._Remark =  DataUtils.ConvertValue<string>(row["Remark"]);
							this._AddBy =  DataUtils.ConvertValue<long?>(row["AddBy"]);
							this._Province =  DataUtils.ConvertValue<string>(row["Province"]);
							this._City =  DataUtils.ConvertValue<string>(row["City"]);
							this._District =  DataUtils.ConvertValue<string>(row["District"]);
							this._DetailsAddress =  DataUtils.ConvertValue<string>(row["DetailsAddress"]);
							this._SubwayDistance =  DataUtils.ConvertValue<string>(row["SubwayDistance"]);
							this._SubwayLines =  DataUtils.ConvertValue<string>(row["SubwayLines"]);
							this._SubwayStations =  DataUtils.ConvertValue<string>(row["SubwayStations"]);
							this._IsSync =  DataUtils.ConvertValue<int?>(row["IsSync"]);
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
            public readonly static Field All = new Field("*", "ap_housevillage");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_housevillage", "主键");
						/// <summary>
            /// 所在版块
            /// </summary>
            public readonly static Field VillageArea = new Field("VillageArea", "ap_housevillage", "所在版块");
						/// <summary>
            /// 住宅类型
            /// </summary>
            public readonly static Field HouseType = new Field("HouseType", "ap_housevillage", "住宅类型");
						/// <summary>
            /// 建造年代
            /// </summary>
            public readonly static Field BuildingAge = new Field("BuildingAge", "ap_housevillage", "建造年代");
						/// <summary>
            /// 占地面积
            /// </summary>
            public readonly static Field AreaCover = new Field("AreaCover", "ap_housevillage", "占地面积");
						/// <summary>
            /// 楼栋数
            /// </summary>
            public readonly static Field BuildingTotal = new Field("BuildingTotal", "ap_housevillage", "楼栋数");
						/// <summary>
            /// 房屋总数
            /// </summary>
            public readonly static Field HouseTotal = new Field("HouseTotal", "ap_housevillage", "房屋总数");
						/// <summary>
            /// 停车位
            /// </summary>
            public readonly static Field ParkingTotal = new Field("ParkingTotal", "ap_housevillage", "停车位");
						/// <summary>
            /// 物业费
            /// </summary>
            public readonly static Field PropertyFee = new Field("PropertyFee", "ap_housevillage", "物业费");
						/// <summary>
            /// 绿化率
            /// </summary>
            public readonly static Field GreenCoverage = new Field("GreenCoverage", "ap_housevillage", "绿化率");
						/// <summary>
            /// 容积率
            /// </summary>
            public readonly static Field VolumeRatio = new Field("VolumeRatio", "ap_housevillage", "容积率");
						/// <summary>
            /// 物业公司
            /// </summary>
            public readonly static Field PropertyCompany = new Field("PropertyCompany", "ap_housevillage", "物业公司");
						/// <summary>
            /// 开发商
            /// </summary>
            public readonly static Field Developer = new Field("Developer", "ap_housevillage", "开发商");
						/// <summary>
            /// 描述
            /// </summary>
            public readonly static Field Description = new Field("Description", "ap_housevillage", "描述");
						/// <summary>
            /// 房源坐标（经度）
            /// </summary>
            public readonly static Field XCoordinate = new Field("XCoordinate", "ap_housevillage", "房源坐标（经度）");
						/// <summary>
            /// 房源坐标（纬度）
            /// </summary>
            public readonly static Field YCoordinate = new Field("YCoordinate", "ap_housevillage", "房源坐标（纬度）");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_housevillage", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_housevillage", "创建时间");
						/// <summary>
            /// 更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_housevillage", "更新时间");
						/// <summary>
            /// 小区状态,0:未审核，1已审核，2审核失败，-1已删除
            /// </summary>
            public readonly static Field Status = new Field("Status", "ap_housevillage", "小区状态,0:未审核，1已审核，2审核失败，-1已删除");
						/// <summary>
            /// 小区名字
            /// </summary>
            public readonly static Field VillagName = new Field("VillagName", "ap_housevillage", "小区名字");
						/// <summary>
            /// 房源数
            /// </summary>
            public readonly static Field HouseCount = new Field("HouseCount", "ap_housevillage", "房源数");
						/// <summary>
            /// 成交记录
            /// </summary>
            public readonly static Field SaledHouse = new Field("SaledHouse", "ap_housevillage", "成交记录");
						/// <summary>
            /// 路线
            /// </summary>
            public readonly static Field Line = new Field("Line", "ap_housevillage", "路线");
						/// <summary>
            /// 封面图片
            /// </summary>
            public readonly static Field Cover = new Field("Cover", "ap_housevillage", "封面图片");
						/// <summary>
            /// 标签，逗号分隔
            /// </summary>
            public readonly static Field Tags = new Field("Tags", "ap_housevillage", "标签，逗号分隔");
						/// <summary>
            /// 小区点评
            /// </summary>
            public readonly static Field CommentsByAdmin = new Field("CommentsByAdmin", "ap_housevillage", "小区点评");
						/// <summary>
            /// 收藏数
            /// </summary>
            public readonly static Field CollectionNumber = new Field("CollectionNumber", "ap_housevillage", "收藏数");
						/// <summary>
            /// 备注
            /// </summary>
            public readonly static Field Remark = new Field("Remark", "ap_housevillage", "备注");
						/// <summary>
            /// 创建人
            /// </summary>
            public readonly static Field AddBy = new Field("AddBy", "ap_housevillage", "创建人");
						/// <summary>
            /// 省
            /// </summary>
            public readonly static Field Province = new Field("Province", "ap_housevillage", "省");
						/// <summary>
            /// 市
            /// </summary>
            public readonly static Field City = new Field("City", "ap_housevillage", "市");
						/// <summary>
            /// 区
            /// </summary>
            public readonly static Field District = new Field("District", "ap_housevillage", "区");
						/// <summary>
            /// 详细地址
            /// </summary>
            public readonly static Field DetailsAddress = new Field("DetailsAddress", "ap_housevillage", "详细地址");
						/// <summary>
            /// 最近地铁距离
            /// </summary>
            public readonly static Field SubwayDistance = new Field("SubwayDistance", "ap_housevillage", "最近地铁距离");
						/// <summary>
            /// 地铁线路, 用逗号分隔
            /// </summary>
            public readonly static Field SubwayLines = new Field("SubwayLines", "ap_housevillage", "地铁线路, 用逗号分隔");
						/// <summary>
            /// 地铁站，用逗号隔开
            /// </summary>
            public readonly static Field SubwayStations = new Field("SubwayStations", "ap_housevillage", "地铁站，用逗号隔开");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_housevillage", "是否同步");
			
        }
		#endregion
        
    }

}
