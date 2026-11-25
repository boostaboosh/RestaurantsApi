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

    [Fact]
    public void GetByIdReturnsRestaurantById()
    {
        // setup controller
        RestaurantsController controller = new RestaurantsController();
        // call get by id
        controller.GetById("1");
        // get expected restaurant
        Restaurant expectedRestaurant = new Restaurant()
        {
            Id = "1",
            Name = "Burger King",
            PostCode = "FK81PD",
            Address = "18 Somewhere Nice Road, London, UK",
            Cuisine = "American"
        };
        // get actual restaurant
        ActionResult<Restaurant> result = controller.GetById("1");
        // check result in ActionResult is null and value is not null
        Assert.Null(result.Result);
        Assert.NotNull(result.Value);
        Restaurant actualRestaurant = Assert.IsType<Restaurant>(result.Value);
        
        // check if expected restaurant matches actual restaurant
        Assert.Equal(expectedRestaurant, actualRestaurant);
    }
    
    [Fact]
    public void GetByIdReturnsNotFoundForRestaurantThatIsNotPresent()
    {
        // setup controller
        RestaurantsController controller = new RestaurantsController();
        
        // declare expected result
        NotFoundResult expectedResult = new NotFoundResult();
        
        // get actual result
        ActionResult<Restaurant> actualResult = controller.GetById("3");
        
        // check if expected result matches actual result
        NotFoundResult actualNotFoundResult = Assert.IsType<NotFoundResult>(actualResult.Result);
        Assert.Equal(expectedResult.StatusCode, actualNotFoundResult.StatusCode);
    }
}
