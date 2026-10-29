using System.Collections;
using Microsoft.AspNetCore.Mvc;
using RestaurantsApi.Models;
using RestaurantsApi.Services;

namespace RestaurantsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantsController
(
    IRestaurantRepository _restaurantRepository
) : ControllerBase
{
    // start with one endpoint.
    // start with everything int he controller class. thein break things upinot classes hwen it g ets to big an dyou feel forced to / need to.
    // that's how loic would start
    
    [HttpGet] // GET /restaurants
    public ActionResult GetRestaurants()
    {
        ArrayList<Restaurant> Restaurants = _restaurantRepository.GetAllRestaurants().ToList();
        // todo return 200 plus all restaurants
    }
    //
    // [HttpGet("{id:int}")] // GET /restaurants/id
    // public ActionResult GetRestaurant(int id)
    // {
    //     Restaurant restaurant = _restaurantRepository.GetRestaurantById(id);
    //     // todo return 200 + data for a specific restaurant
    // }
    //
    // [HttpPost] // POST /restaurants (restaurant post request)
    // [ProducesResponseType(StatusCodes.Status201Created)]
    // [ProducesResponseType(StatusCodes.Status400BadRequest)]
    // public ActionResult<Restaurant> PostRestaurant(Restaurant restaurant)
    // {
    //     _restaurantRepository.AddRestaurant(restaurant);
    //     // todo return 201
    //     return CreatedAtAction(nameof());
    // }
    //
    // [HttpPut] // PUT /restaurants (restaurant put request)
    // public ActionResult<> PutRestaurant(Restaurant restaurant)
    // {
    //     _restaurantRepository.UpdateRestaurant(restaurant);
    //     // todo return 200
    // }
    //
    // [HttpDelete("{id:int}")] // DELETE /restaurants/id
    // public ActionResult<> DeleteRestaurant(int id)
    // {
    //     _restaurantRepository.RemoveRestaurant(id);
    //     // todo return 200
    // }
}