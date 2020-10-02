using System.Collections.Generic;

namespace GoogleInterviewAirport.Models
{
  public class Routes
  {
    public Airport FromAirport { get; set; }
    public Airport ToAirport { get; set; }

    public List<Route> AllRoutes { get; set; }

    public Routes()
    {
      AllRoutes = new List<Route>();
    }
  }
}
