using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apartment.Common.Autofac;
using Apartment.BLL.Services.Order;
using Apartment.Common;
using Apartment.Dal.IRepository;
using Apartment.Model;

namespace Apartment.Bll.Test
{
    [TestClass]
    public class AutofacTest : TestBase
    {
        [TestMethod]
        public void RepostoryTest()
        {
            IOrderRepository orderRepostory = AutofacService.Resolve<IOrderRepository>();
            var result = orderRepostory.Insert(new ap_order { OrderNo = "orderRepostory" });
            Assert.IsTrue(result == 1);
        }


        [TestMethod]
        public void ServiceTest()
        {

            IOrderService orderService = AutofacService.Resolve<IOrderService>();
            var result = orderService.Insert(new ap_order { Id = IdentityGenerator.NewSequentialDomainId(), OrderNo = "orderService" });
            Assert.IsTrue(result == 1);
        }
    }
}
