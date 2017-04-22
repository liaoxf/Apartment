using System;
using System.Collections.Generic;
using Apartment.Model;
using Apartment.Dal.Base;
using Apartment.BLL.Services.House;

namespace Apartment.BLL.Services.Village.Impl
{
    public class VillageService : IVillageService
    {
        public int Create(ap_apartment entity)
        {
            entity.AddTime = DateTime.Now;
            entity.State = 0;
            var id = Db.MySqlContext_Apartment.Insert<ap_apartment>(entity);
            return id;
        }

      
        public int Delete(ap_apartment entity)
        {
          
            entity.State = 1;
            var id = Db.MySqlContext_Apartment.Update<ap_apartment>(entity);
            return id;
        }

        public int Update(ap_apartment entity)
        {
            entity.State = 1;
            var id = Db.MySqlContext_Apartment.Update<ap_apartment>(entity);
            return id;
        }
    }
}
