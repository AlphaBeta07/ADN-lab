using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
using System.Collections.Generic;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        public static List<FoodItem> items = new List<FoodItem>
        {
            new FoodItem { Id = 1, Name = "Pizza", Price = 200 },
            new FoodItem { Id = 2, Name = "Burger", Price = 100 }
        };

        [HttpGet]
        public IActionResult Get() => Ok(items);

        [HttpPost]
        public IActionResult Add(FoodItem item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
            return Ok(item);
        }
    }
}
