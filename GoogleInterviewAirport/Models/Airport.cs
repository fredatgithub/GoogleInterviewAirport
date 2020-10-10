using System.Collections.Generic;

namespace GoogleInterviewAirport.Models
{
  public class Airport
  {
    public string Name { get; set; }

    public Airport(string name)
    {
      Name = name;
    }

    public List<string> ListOfAirportServed()
    {
      List<string> result = new List<string>();
      var routes = AirportHelper.RouteList();
      foreach (var item in routes)
      {
        if (item.Contains(Name))
        {
          string airportFrom = AirportHelper.GetAirportFrom(item);
          string airportTo = AirportHelper.GetAirportTo(item);
          if (airportFrom == Name)
          {
            if (!result.Contains(airportTo))
            {
              result.Add(airportTo);
            }
          }
          else
          {
            if (!result.Contains(airportFrom))
            {
              result.Add(airportFrom);
            }
          }
        }
      }

      return result;
    }
  }
}
