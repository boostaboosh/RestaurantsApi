using Api;

namespace Tests;

public class ApiTests
{
    [Fact]
    public void Test1()
    {
        Restaurant restaurant = new Restaurant()
        {
            Address =  "123 Main Street",
            Cuisine = "English",
            Name =  "food place",
            PostCode = "FK1234"
        };

    }
}
