using Dos.Common;
using Apartment.Common;
using Apartment.Model.ModelsExp;

namespace Apartment.Dal.ServicesExp
{
    public class SiteConfig
    {
        private static object lockHelper = new object();
        /// <summary>
        ///  读取配置文件
        /// </summary>
        public static siteconfig loadConfig()
        {
            siteconfig model = CacheHelper.Get(ZFX365ManagerKey.CACHE_SITE_CONFIG) as siteconfig;
            if (model == null)
            {
                CacheHelper.Set(
                    ZFX365ManagerKey.CACHE_SITE_CONFIG, 
                    loadConfig(Utils.GetXmlMapPath(ZFX365ManagerKey.FILE_SITE_XML_CONFING)
                    ));
                model = CacheHelper.Get(ZFX365ManagerKey.CACHE_SITE_CONFIG) as siteconfig;
            }
            return model;
        }
        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public static siteconfig loadConfig(string configFilePath)
        {
            return (siteconfig)SerializationHelper.Load(typeof(siteconfig), configFilePath);
        }

        /// <summary>
        ///  保存配置文件
        /// </summary>
        public static siteconfig saveConifg(siteconfig model, string configFilePath = ZFX365ManagerKey.FILE_SITE_XML_CONFING )
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, Utils.GetXmlMapPath(configFilePath));
            }
            return model;
        }
    }
}
