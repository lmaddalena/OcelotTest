using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : ControllerBase
    {
        private readonly ILogger<OrderingController> _logger;
        public OrderingController(ILogger<OrderingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetOrders")]
        public IEnumerable<string> Get()
        {
            string[] orders = new string[] { "ord_001", "ord_002", "ord_003", "ord_004", "ord_005" };

            return orders;
        }

    }
}
