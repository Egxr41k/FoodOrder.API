using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService basketService;

        public BasketController(IBasketService basketService)
        {
            this.basketService = basketService;
        }

        [HttpGet("GetForGuest")]
        public IActionResult GetBasket()
        {
            return Ok();
        }

        [HttpGet("GetForUser")]
        [Authorize(Roles = "User")]
        public IActionResult GetBasketForUser()
        {
            return Ok();
        }

        [HttpPost("CreateOrEdit/{id}")]
        [Authorize(Roles = "User")]
        public IActionResult CreateOrEditBasket(int id)
        {
            return Ok();
        }

        [HttpPost("Pay/{id}")]
        [Authorize(Roles = "User")]
        public IActionResult PayForBasket(int id)
        {
            return Ok();
        }

        [HttpPost("RatingAndComment/{id}")]
        [Authorize(Roles = "User")]
        public IActionResult RateAndCommentBasket(int id)
        {
            return Ok();
        }

        [HttpPost("Delete/{id}")]
        [Authorize(Roles = "User")]
        public IActionResult DeleteBasket(int id)
        {
            return Ok();
        }
    }
}