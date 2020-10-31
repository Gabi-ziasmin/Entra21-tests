using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<GameResponse> Get()
        {
            var game = new GameResponse
            {
                Name = "Dark Souls",
                Plataform = "MultiPlataforma",
                Price = 150
            };

            return new List<GameResponse>{game};
        }
    }
}
