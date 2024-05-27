using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishController(IDishService dishService) : ControllerBase
    {
        //[GET] [Authorize(Roles = "Admin")] Dish? OrganizationId = id () => ()

        //[GET] [] Dish/IndexAll? OrganizationId = id () => ()

        //[POST] [Authorize(Roles = "Admin")] Dish/Create? organizationId = id () => ()

        //[POST] [Authorize(Roles = "Admin")] Dishes/Edit/id() => ()

        //[POST] [Authorize(Roles = "Admin")] Dishes/Delete/id() => ()
    }
}
