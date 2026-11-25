using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantsController : ControllerBase
{
    private readonly HashSet<Restaurant> _restaurants = new HashSet<Restaurant>();

    public RestaurantsController()
    {
        _restaurants.Add(
            new Restaurant()
            {
                Id = "1",
                Name = "Burger King",
                PostCode = "FK81PD",
                Address = "18 Somewhere Nice Road, London, UK",
                Cuisine = "American"
            }
        );
        _restaurants.Add(
            new Restaurant()
            {
                Id = "2",
                Name = "Pasta!",
                PostCode = "DA82HD",
                Address = "100 Big Boulevard, Birmingham, UK",
                Cuisine = "Italian"
            }
        );
    }
    
    [HttpGet(Name = "GetRestaurants")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<HashSet<Restaurant>> Get()
    {
        return new OkObjectResult(_restaurants);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Restaurant> GetById(string id)
    {
        Restaurant? restaurant = _restaurants.FirstOrDefault(r => r.Id.Equals(id));
        return restaurant == null ? BadRequest() : restaurant;
    }
}
