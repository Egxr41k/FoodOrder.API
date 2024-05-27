using FoodOrderWeb.Service.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController(IOrganizationService organizationService) : ControllerBase
    {
        //[GET] [Authorize(Roles = "User")] Organization() => ()

        //[GET] [] Organization() => ()

        //[GET] [Authorize(Roles = "Admin")] Organization() => ()

        //[POST] [Authorize(Roles = "Admin")] Organization/Create() => ()

        //[POST] [Authorize(Roles = "Admin")] Organization/Edit/id() => ()

        //[POST] [Authorize(Roles = "Admin")] Organization/Delete/id() => ()
    }
}