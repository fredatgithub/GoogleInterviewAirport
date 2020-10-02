namespace GoogleInterviewAirport.Models
{
  public class Route
  {
    public Airport FromAirport { get; set; }
    public Airport ToAirport { get; set; }

    public Route(Airport from, Airport to)
    {
      FromAirport = from;
      ToAirport = to;
    }

    public override string ToString()
    {
      return $"{FromAirport}-{ToAirport}";
    }

    public bool IsRouteValid()
    {
      bool result = false;
      if (FromAirport == ToAirport)
      {
        return false;
      }

      var allRoutes = AirportHelper.RouteList();
      result = allRoutes.Contains($"{FromAirport.Name}-{ToAirport.Name}") || allRoutes.Contains($"{ToAirport.Name}-{FromAirport.Name}");
      return result;
    }
  }
}
