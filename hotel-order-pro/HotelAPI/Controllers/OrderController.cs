using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
using System.Collections.Generic;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        public static List<Order> orders = new List<Order>();

        [HttpGet]
        public IActionResult Get() => Ok(orders);

        [HttpPost]
        public IActionResult Place(Order order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
            return Ok(order);
        }
    }
}
