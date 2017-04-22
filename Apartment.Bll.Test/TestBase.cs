using Apartment.Common.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Test
{
    public class TestBase : IRegister
    {
        //父类构造函数注入
        public TestBase()
        {
            Install();
        }
        public void Install()
        {
            AutofacService.Register("Apartment.Dal", "Apartment.BLL");
        }
    }
}
