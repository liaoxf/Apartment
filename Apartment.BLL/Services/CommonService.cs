using System;
using Apartment.Model.Enum;
using Apartment.Model;
using Apartment.Dal.Base;
using Dos.ORM;
using System.Linq;

namespace Apartment.BLL.Services
{
    public class CommonService
    {
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dataId"></param>
        /// <param name="picUrl"></param>
        /// <param name="thumbUrl"></param>
        /// <param name="addTime"></param>
        /// <returns></returns>
        public int AddFile(FileType type, long dataId, string picUrl, string thumbUrl, DateTime addTime)
        {
            DbTrans trans = Db.MySqlContext_Apartment.BeginTransaction();
            var log = new ap_fileinfo()
            {
                Id = Common.IdentityGenerator.NewSequentialDomainId(),
                ResourceType = Convert.ToInt32(type),
                DataId = dataId,
                PicUrl = picUrl,
                ThumbUrl = thumbUrl,
                AddTime = DateTime.Now
            };
            var result = Db.MySqlContext_Apartment.Insert(trans, log);
            trans.Commit();
            return result;
        }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dataId"></param>
        /// <param name="datarNo"></param>
        /// <param name="dataStatus"></param>
        /// <param name="remark"></param>
        /// <param name="operatorId"></param>
        /// <param name="operatorName"></param>
        /// <param name="AddTime"></param>
        /// <returns></returns>

        public int AddLog(LogType type, long dataId, string datarNo, int dataStatus, string remark, long operatorId, string operatorName, DateTime AddTime)
        {
            DbTrans trans = Db.MySqlContext_Apartment.BeginTransaction();
            var log = new ap_loginfo()
            {
                Id = Common.IdentityGenerator.NewSequentialDomainId(),
                Type = Convert.ToInt32(type),
                DataId = dataId,
                DataStatus = dataStatus,
                LogRemark = remark,
                OperatorId = operatorId,
                OperatorName = operatorName,
                AddTime = DateTime.Now
            };
            var result = Db.MySqlContext_Apartment.Insert(trans, log);
            trans.Commit();
            return result;
        }

        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="type"></param>
        /// <param name="dataId"></param>
        /// <param name="updateTime"></param>
        /// <returns></returns>
        public int DelFile(FileType type, long dataId, DateTime updateTime)
        {
            var file = Db.MySqlContext_Apartment.From<ap_fileinfo>().Select(f => f.Id).Where(f => f.Id == dataId && f.ResourceType == Convert.ToInt32(type)).ToList();
            if (!file.Any()) return -1;

            DbTrans trans = Db.MySqlContext_Apartment.BeginTransaction();
            var result = Db.MySqlContext_Apartment.Update<ap_fileinfo>(file.FirstOrDefault());
            trans.Commit();
            return result;
        }
    }
}

