using System;
using System.Collections.Generic;
using Apartment.Model;
using Apartment.Dal.Base;
using Apartment.BLL.Services.House;

namespace Apartment.BLL.Services.House.Impl
{
    public class HouseService : IHouseService
    {
        public int Create(ap_house entity)
        {
            entity.IsLock = 0;
            entity.IsUp = 0;
            entity.IsDel = 0;
            entity.AuditStatus = 0;
            entity.AddTime = DateTime.Now;
            entity.LastUpdateTime = DateTime.Now;
            var id = Db.MySqlContext_Apartment.Insert<ap_house>(entity);
            // pics save 
            //

            if (entity.IsSync==1)
            {
                // send to main databse; call add back
            }
            return id;
        }

        public int Delete(ap_house entity)
        {
            entity.IsDel = 1;
            entity.DeletedTime = DateTime.Now;
            entity.LastUpdateTime = DateTime.Now;
            var id = Db.MySqlContext_Apartment.Update<ap_house>(entity);
            return id;
        }

      
        public int Update(ap_house entity)
        {
            entity.LastUpdateTime = DateTime.Now;
            var id = Db.MySqlContext_Apartment.Update<ap_house>(entity);
            return id;
        }
    }
}
