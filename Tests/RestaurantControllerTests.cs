using Api;
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests;

public class RestaurantControllerTests
{
    [Fact]
    public void GetReturnsTwoRestaurants()
    {
        RestaurantsController controller = new RestaurantsController();
        ActionResult<HashSet<Restaurant>> result = controller.Get();
        Assert.Null(result.Value);
        Assert.NotNull(result.Result);
        OkObjectResult okResult = Assert.IsType<OkObjectResult>(result.Result);
        HashSet<Restaurant> restaurants = Assert.IsType<HashSet<Restaurant>>(okResult.Value);
        int expectedCount = 2;
        Assert.Equal(expectedCount, restaurants.Count);
    }
}
