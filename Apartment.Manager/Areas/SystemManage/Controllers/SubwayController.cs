using NFine.Application.SystemManage;
using Apartment.Common;
using NFine.Domain.Entity.SystemManage;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web.Mvc;
using LitJson2;
using System.Text;
using System.Xml;

namespace Apartment.Manager.Areas.SystemManage.Controllers
{
    public class SubwayController : ControllerBase
    {
        private SubwayApp subwayApp = new SubwayApp();
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeGridJson(string keyword)
        {
            var data = subwayApp.GetList();
            var treeList = new List<TreeGridModel>();
            foreach (SubwayEntity item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Count(t => t.F_ParentId == item.F_Id) == 0 ? false : true;
                treeModel.id = item.F_Id;
                treeModel.text = item.F_FullName;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.F_ParentId;
                treeModel.expanded = item.F_ParentId == "0";
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                treeList = treeList.TreeWhere(t => t.text.Contains(keyword), "id", "parentId");
            }
            return Content(treeList.TreeGridJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson()
        {
            var data = subwayApp.GetList();
            var treeList = new List<TreeSelectModel>();
            foreach (SubwayEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.F_Id;
                treeModel.text = item.F_FullName;
                treeModel.parentId = item.F_ParentId;
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson());
        }
        /// <summary>
        /// 根据区域获取商圈
        /// </summary>
        /// <param name="district"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJsonByDistrict(string district)
        {
            //Newtonsoft.Json.JsonConvert.DeserializeObject(FileHelper.Read(@"/File/Subway.json"));
            var data = subwayApp.GetList();
            var rootData = data.Where(d => d.F_FullName == district.Replace("区", "")).First();
            var treeList = new List<TreeSelectModel>();
            var childData = data.Where(d => d.F_ParentId == rootData.F_Id);
            foreach (SubwayEntity item in childData)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.F_FullName;
                treeModel.text = item.F_FullName;
                treeModel.parentId = item.F_ParentId;
                treeList.Add(treeModel);
            }
            return Content(treeList.ToJson());
        }
        /// <summary>
        /// 根据城市获取地铁站
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJsonByCity(string city)
        {
            JsonData r = new JsonData();
            r.Add(null);
            r.Clear();
            var data = subwayApp.GetList();
            var treeList = new List<TreeSelectModel>();

            var rootData = data.Where(t => t.F_ParentId == "0" && t.F_FullName == city).First();
            var subWayRoot = data.Where(d => d.F_FullName == "地铁" && d.F_ParentId == rootData.F_Id).First();
            var subwayData = data.Where(d => d.F_ParentId == subWayRoot.F_Id);
            foreach (SubwayEntity item in subwayData)
            {
                if (item.F_FullName != "全部")
                {
                    JsonData boot = new JsonData();
                    boot["id"] = item.F_FullName;
                    boot["text"] = item.F_FullName;
                    boot["elment"] = item.F_FullName;

                    var childData = data.Where(t => t.F_ParentId == item.F_Id);
                    JsonData arrChild = new JsonData();
                    arrChild.Add(null);
                    arrChild.Clear();
                    foreach (var citem in childData)
                    {
                        if (citem.F_FullName != "全部")
                        {
                            JsonData Child = new JsonData();
                            Child["id"] = item.F_FullName + "-" + citem.F_FullName;
                            Child["text"] = item.F_FullName + "-" + citem.F_FullName;
                            Child["elment"] = item.F_FullName + "-" + citem.F_FullName;
                            arrChild.Add(Child);
                        }
                    }
                    boot["children"] = arrChild;
                    r.Add(boot);
                }
            }

            return Content(JsonMapper.ToJson(r));
        }
        [HttpGet]
        public ActionResult GetTreeSelectJson1()
        {
            JsonData r = new JsonData();
            r.Add(null);
            r.Clear();
            var data = subwayApp.GetList();
            var treeList = new List<TreeSelectModel>();

            var BootData = data.Where(t => t.F_ParentId == "0");
            foreach (SubwayEntity item in BootData)
            {
                JsonData boot = new JsonData();
                boot["id"] = item.F_FullName;
                boot["text"] = item.F_FullName;
                boot["elment"] = item.F_FullName;

                var childData = data.Where(t => t.F_ParentId == item.F_Id);
                JsonData arrChild = new JsonData();
                arrChild.Add(null);
                arrChild.Clear();
                foreach (var citem in childData)
                {
                    JsonData Child = new JsonData();
                    Child["id"] = citem.F_FullName;
                    Child["text"] = citem.F_FullName;
                    Child["elment"] = citem.F_FullName;
                    arrChild.Add(Child);
                }
                boot["children"] = arrChild;
                r.Add(boot);
            }

            return Content(JsonMapper.ToJson(r));
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson2()
        {
            var data = subwayApp.GetList();
            var treeList = new List<TreeSelectModel>();
            foreach (SubwayEntity item in data)
            {
                TreeSelectModel treeModel = new TreeSelectModel();
                treeModel.id = item.F_Id;
                treeModel.text = item.F_FullName;
                treeModel.parentId = item.F_ParentId;
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeSelectJson2());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeSelectJson3()
        {
            OperatorModel op = OperatorProvider.Provider.GetCurrent();
            List<SubwayEntity> data = subwayApp.GetList();
            var treeList = new List<TreeSelectModel>();
            if (op.F_Area.Contains("上海市"))
            {
                foreach (SubwayEntity item in data)
                {
                    TreeSelectModel treeModel = new TreeSelectModel();
                    treeModel.id = item.F_Id;
                    treeModel.text = item.F_FullName;
                    treeModel.parentId = item.F_ParentId;
                    treeList.Add(treeModel);
                }
                return Content(treeList.TreeSelectJson2());
            }
            else
            {
                JsonData r = new JsonData();
                r.Add(null);
                r.Clear();
                foreach (SubwayEntity item in data)
                {
                    if (op.F_Area.Contains(item.F_FullName))
                    {
                        JsonData boot = new JsonData();
                        boot["id"] = item.F_FullName;
                        boot["text"] = item.F_FullName;
                        boot["elment"] = item.F_FullName;
                        r.Add(boot);
                    }
                }
                return Content(JsonMapper.ToJson(r));
            }
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = subwayApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(SubwayEntity subwayEntity, string keyValue)
        {
            SubwayEntity parentEntity = subwayApp.GetForm(subwayEntity.F_ParentId);
            if (parentEntity != null)
            {
                subwayEntity.F_Layers = parentEntity.F_Layers + 1;
            }
            else
            {
                subwayEntity.F_Layers = 0;
            }
            subwayApp.SubmitForm(subwayEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            subwayApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        #region 递归获取树状结构图
        /// <summary>
        /// 递归获取树形json
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetTreeSelectJsonByRecursion()
        {
            JsonData r = new JsonData();
            JsonData subway = new JsonData();
            subway["root"] = GetChild(subwayApp.GetList(), "0");
            r["SubwayJsonV1"] = subway;
            return JsonMapper.ToJson(r);
        }
        private JsonData GetChild(List<SubwayEntity> data, string F_Id)
        {
            var childData = data.Where(t => t.F_ParentId == F_Id);
            JsonData arrChild = new JsonData();
            arrChild.Add(null);
            arrChild.Clear();
            foreach (var citem in childData)
            {
                JsonData Child = new JsonData();
                Child["id"] = citem.F_Id;
                Child["text"] = citem.F_FullName;
                Child["layer"] = citem.F_Layers;
                Child["children"] = GetChild(data, citem.F_Id);
                arrChild.Add(Child);
            }
            return arrChild;
        }
        [HttpPost]
        [HandlerAuthorize]
        public ActionResult GenerateFile(string ext = "json")
        {
            string jsonStr = GetTreeSelectJsonByRecursion();//使用递归获取，利用litjson生成json字符串
            FileHelper.CreateDir("File");//判断文件是否存在，如果不存在则创建文件夹
            string VirtualPath = @"/File/Subway." + ext;//虚拟路径
            string PhysicalPath = Server.MapPath(VirtualPath);//实际的物理路径
            if (ext == "json")//如果是要生成json格式
            {
                FileHelper.WriteText(PhysicalPath, jsonStr, UTF8Encoding.UTF8);//将文件存入服务器
            }
            else//如果是要生成xml格式
            {
                XmlDocument xdoc = Newtonsoft.Json.JsonConvert.DeserializeXmlNode(jsonStr, "SubwayJsonV1");//首先将json装xml
                xdoc.Save(PhysicalPath);//将文件存入服务器
            }
            FileDownHelper.DownLoad(VirtualPath);//从服务器下载文件至本地
            return Success("下载成功！");//下载成功
        }
        #endregion

        #region 导入
        [HttpPost]
        [HandlerAjaxOnly]
        [HandlerAuthorize]
        public ActionResult Import(int type)
        {
            string fileUrl = "";
            #region 区域
            if (type == 0)
            {
                fileUrl = "/xmlconfig/distict.json";
                string jsonStr = System.IO.File.ReadAllText(Server.MapPath(fileUrl), Encoding.UTF8);
                List<CityList> list = jsonStr.ToObject<List<CityList>>();

                List<SubwayEntity> SubwayEntityList = new List<SubwayEntity>();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                int sort = 1000;
                foreach (var item in list)
                {
                    string guid = Guid.NewGuid().ToString();
                    SubwayEntityList.Add(new SubwayEntity
                    {
                        F_Id = guid,
                        F_ParentId = "2",
                        F_Layers = 1,
                        F_FullName = item.name,
                        F_SortCode = sort,
                        F_EnabledMark = true,
                        F_CreatorTime = DateTime.Now,
                        F_CreatorUserId = LoginInfo.UserId,
                        F_LastModifyTime = DateTime.Now,
                        F_LastModifyUserId = LoginInfo.UserId
                    });
                    sort++;

                    foreach (SubList SubListItem in item.subList)
                    {
                        foreach (Towns TownsItem in SubListItem.towns)
                        {
                            SubwayEntityList.Add(new SubwayEntity
                            {
                                F_Id = Guid.NewGuid().ToString(),
                                F_ParentId = guid,
                                F_Layers = 2,
                                F_FullName = TownsItem.name,
                                F_SortCode = sort,
                                F_EnabledMark = true,
                                F_CreatorTime = DateTime.Now,
                                F_CreatorUserId = LoginInfo.UserId,
                                F_LastModifyTime = DateTime.Now,
                                F_LastModifyUserId = LoginInfo.UserId
                            });
                            sort++;
                        }
                    }
                }
                subwayApp.SubwayInsert(SubwayEntityList);
                return Success("导入成功。");
            }
            #endregion
            #region 地铁
            if (type ==1)
            {
                fileUrl = "/xmlconfig/subway.json";
                string jsonStr = System.IO.File.ReadAllText(Server.MapPath(fileUrl), Encoding.UTF8);
                List<SubWayList> list = jsonStr.ToObject<List<SubWayList>>();

                List<SubwayEntity> SubwayEntityList = new List<SubwayEntity>();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                int sort = 1000;
                foreach (var item in list)
                {
                    string guid = Guid.NewGuid().ToString();
                    SubwayEntityList.Add(new SubwayEntity
                    {
                        F_Id = guid,
                        F_ParentId = "3",
                        F_Layers = 1,
                        F_FullName = item.name,
                        F_SortCode = sort,
                        F_EnabledMark = true,
                        F_CreatorTime = DateTime.Now,
                        F_CreatorUserId = LoginInfo.UserId,
                        F_LastModifyTime = DateTime.Now,
                        F_LastModifyUserId = LoginInfo.UserId
                    });
                    sort++;

                    foreach (SubWaySubList SubWaySubListItem in item.subList)
                    {
                        SubwayEntityList.Add(new SubwayEntity
                        {
                            F_Id = Guid.NewGuid().ToString(),
                            F_ParentId = guid,
                            F_Layers = 2,
                            F_FullName = SubWaySubListItem.name,
                            F_SortCode = sort,
                            F_EnabledMark = true,
                            F_CreatorTime = DateTime.Now,
                            F_CreatorUserId = LoginInfo.UserId,
                            F_LastModifyTime = DateTime.Now,
                            F_LastModifyUserId = LoginInfo.UserId
                        });
                        sort++;
                    }
                }
                subwayApp.SubwayInsert(SubwayEntityList);
                return Success("导入成功。");
            }
            #endregion
            return Error("类型不正确");
        }

        #region 区域类
        public class CityList
        {
            public string id { get; set; }
            public string name { get; set; }
            public List<SubList> subList { get; set; }

        }
        public class SubList
        {
            public string letter { get; set; }
            public List<Towns> towns { get; set; }
        }
        public class Towns
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        #endregion
        #region 地铁类
        public class SubWayList
        {
            public string id { get; set; }
            public string name { get; set; }
            public List<SubWaySubList> subList { get; set; }

        }
        public class SubWaySubList
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        #endregion
        #endregion
    }
}