using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController(IBasketService basketService) : ControllerBase
    {
        //[GET] [Authorize(Roles = "User")] Busket() => ()

        //[POST] [Authorize(Roles = "User")] Busket/CreateOrEdit/id() => ()

        //[POST] [Authorize(Roles = "User")] Busket/Pay/id() => ()

        //[POST] [Authorize(Roles = "User")] Busket/RatingAndComment/id() => ()

        //[POST] [Authorize(Roles = "User")] Busket/Delete/id() => ()
    }
}