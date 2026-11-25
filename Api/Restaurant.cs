namespace Api;

public record class Restaurant
{
    public required String Id { get; set; }
    public required String Name { get; set; }
    public required String PostCode { get; set; }
    public required String Address { get; set; }
    public required String Cuisine { get; set; }
}
