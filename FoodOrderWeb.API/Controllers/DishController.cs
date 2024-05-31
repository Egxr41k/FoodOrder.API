using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService dishService;

        public DishController(IDishService dishService)
        {
            this.dishService = dishService;
        }

        [HttpGet("Get")]
        public IActionResult GetDishes(int organizationId)
        {
            return Ok();
        }

        [HttpGet("GetForAdmin")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetDishesForAdmin(int organizationId)
        {
            return Ok();
        }

        [HttpGet("IndexAll")]
        public IActionResult GetAllDishes(int organizationId)
        {
            return Ok();
        }

        [HttpPost("Create")]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateDish(int organizationId)
        {
            return Ok();
        }

        [HttpPost("Edit/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult EditDish(int id)
        {
            return Ok();
        }

        [HttpPost("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteDish(int id)
        {
            return Ok();
        }
    }
}
