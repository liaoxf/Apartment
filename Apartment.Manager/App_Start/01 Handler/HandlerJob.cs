using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZFX365.Com.Manager.BLL;

namespace ZFX365.Com.Manager.Web.App_Start._01_Handler
{
    public class HandlerJob : IJob
    {
       
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                //执行房源更新
                new HouseJobBLL().UpdateHouse();
            }
            catch (Exception e)
            {
                //
                Console.WriteLine(e.Message);
            }
            try
            {
                // 执行小区更新
                new VillageJobBLL().UpdateVillage(); 
                //执行订单更新
                //new OrderJobBLL().UpdateOrder();
            }
            catch (Exception e)
            {
                //nonthign to do
                Console.WriteLine(e.Message);
            }
          
        }

        public static void startFrash()
        {
            //工厂
            ISchedulerFactory factory = new StdSchedulerFactory();
            //启动
            IScheduler scheduler = factory.GetScheduler();
            scheduler.Start();
            //描述工作
            IJobDetail jobDetail = new JobDetailImpl("villageupdate", "pushGroup_villageupdate", typeof(HandlerJob));
            //触发器/每10分钟执行一次
            ITrigger trigger = TriggerBuilder.Create()
               .WithIdentity("triggerfrash", "pushGroup_villageupdate")
               .WithSchedule(SimpleScheduleBuilder.RepeatMinutelyForever(10))
               .ForJob("villageupdate", "pushGroup_villageupdate")
               .Build();
            //执行
            scheduler.ScheduleJob(jobDetail, trigger);
        }
    }
}