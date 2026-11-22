using Api;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantsController : ControllerBase
{
    [HttpGet(Name = "GetRestaurants")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<HashSet<Restaurant>> Get()
    {
        HashSet<Restaurant> _restaurants = new HashSet<Restaurant>();
        _restaurants.Add(
            new Restaurant()
            {
                Name = "Burger King",
                PostCode = "FK81PD",
                Address = "18 Somewhere Nice Road, London, UK",
                Cuisine = "American"
            }
        );
        _restaurants.Add(
            new Restaurant()
            {
                Name = "Pasta!",
                PostCode = "DA82HD",
                Address = "100 Big Boulevard, Birmingham, UK",
                Cuisine = "Italian"
            }
        );
        return new OkObjectResult(_restaurants);
    }
}
