using Microsoft.AspNetCore.Mvc;

namespace RestaurantsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantsController : ControllerBase
{
    [HttpGet(Name = "GetRestaurants")]
    public ISet<Restaurant> Get()
    {
        HashSet<Restaurant>_restaurants = new HashSet<Restaurant>();
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

        return _restaurants;
    }
}
