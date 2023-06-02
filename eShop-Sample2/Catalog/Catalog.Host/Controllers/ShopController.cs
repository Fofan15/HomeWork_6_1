using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private static readonly List<Shop> Items = new List<Shop>() 
        {
            new Shop { Id = 1, Item = "Glass" },
            new Shop { Id = 2, Item = "Mouse" },
            new Shop { Id = 3, Item = "Computer" },
            new Shop { Id = 4, Item = "Smartphone" },
            new Shop { Id = 5, Item = "TV" },
            new Shop { Id = 6, Item = "Frdge" },
            new Shop { Id = 7, Item = "Charging" },
            new Shop { Id = 8, Item = "Table" },
            new Shop { Id = 9, Item = "Backpack" },
            new Shop { Id = 10, Item = "Scissors" }
        };

        [HttpGet]
        public List<Shop> Get()
        {
            return Items;
        }
    }
}
