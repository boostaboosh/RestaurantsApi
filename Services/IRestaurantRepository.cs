using RestaurantsApi.Models;

namespace RestaurantsApi.Services;

public interface IRestaurantRepository
{
    ISet<Restaurant> GetAllRestaurants();
    Restaurant GetRestaurantById(int id);
    void AddRestaurant(Restaurant restaurant);
    void UpdateRestaurant(Restaurant restaurant);
    void RemoveRestaurant(int id);
}

public class RestaurantRepository : IRestaurantRepository
{
    private HashSet<Restaurant> _restaurants;

    public RestaurantRepository()
    {
        _restaurants = new HashSet<Restaurant>();
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
    }
    
    public ISet<Restaurant> GetAllRestaurants()
    {
        return _restaurants.ToHashSet();
    }

    public Restaurant GetRestaurantById(int id)
    {
        // todo
        // return _restaurants.TryGetValue(, out var restaurant) ? restaurant : null;
        return null;
    }

    public void AddRestaurant(Restaurant restaurant)
    {
        _restaurants.Add(restaurant);
    }

    public void UpdateRestaurant(Restaurant restaurant)
    {
        RemoveRestaurant(restaurant.Id);
        _restaurants.Add(restaurant);
    }

    public void RemoveRestaurant(int id)
    {
        _restaurants.RemoveWhere(restaurant => restaurant.Id == id);
    }
}
