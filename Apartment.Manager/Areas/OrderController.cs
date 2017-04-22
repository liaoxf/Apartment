using Apartment.BLL.Services.Order;
using System.Web.Mvc;

namespace Apartment.Manager.Areas
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
    }
}