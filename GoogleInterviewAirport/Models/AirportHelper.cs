using System.Collections.Generic;

namespace GoogleInterviewAirport.Models
{
  public static class AirportHelper
  {
    public static string[] AirportList()
    {
      return new string[] { "BGI", "CDG", "DEL", "DOH", "DSM", "EWR", "EYW", "HND", "ICN", "JFK", "LGA", "LHR", "ORD", "SAN", "SFO", "SIN", "TLV", "BUD", };
    }

    public static string[,] RoutesList()
    {
      return new string[,] {
                { "DSM", "ORD" },
                { "ORD", "BGI"},
                { "BGI", "LGA" },
                { "SIN", "CDG" },
                { "CDG", "SIN" },
                { "CDG", "BUD" },
                { "DEL", "DOH" },
                { "DEL", "CDG" },
                { "TLV", "DEL" },
                { "EWR", "HND" },
                { "HND", "ICN" },
                { "HND", "JFK" },
                { "ICN", "JFK" },
                { "JFK", "LGA" },
                { "EYW", "LHR" },
                { "LHR", "SFO" },
                { "SFO", "SAN" },
                { "SFO", "DSM" },
                { "SAN", "EYW" }
      };
    }

    public static List<string> RouteList()
    {
      var result = new List<string> {
      {"DSM-ORD" },
      {"ORD-BGI"},
      {"BGI-LGA"},
      {"SIN-CDG"},
      {"CDG-SIN"},
      {"CDG-BUD"},
      {"DEL-DOH"},
      {"DEL-CDG"},
      {"TLV-DEL"},
      {"EWR-HND"},
      {"HND-ICN"},
      {"HND-JFK"},
      {"ICN-JFK"},
      {"JFK-LGA"},
      {"EYW-LHR"},
      {"LHR-SFO"},
      {"SFO-SAN"},
      {"SFO-DSM"},
      {"SAN-EYW"}
      };

      return result;
    }

    public static bool DoesRouteExist(string fromAirport)
    {
      bool result = false;
      string[,] routes = RoutesList();

      for (int i = 0; i < 18; i++)
      {
        for (int j = 0; j < 2; j++)
        {
          if (routes[i, j] == fromAirport)
          {
            return true;
          }
        }
      }

      return result;
    }

    public static List<string> ListAllRoutes(string fromAirport)
    {
      var result = new List<string>();
      if (fromAirport == string.Empty)
      {
        return result;
      }

      string[,] routes = RoutesList();

      for (int i = 0; i < 18; i++)
      {
        for (int j = 0; j < 2; j++)
        {
          if (routes[i, j] == fromAirport)
          {
            if (j == 0)
            {
              result.Add($"{routes[i, j]}-{routes[i, j + 1]}");
            }
            else
            {
              result.Add($"{routes[i, j]}-{routes[i, j - 1]}");
            }
          }
        }
      }

      return result;
    }

    public static Dictionary<string, int> MapAirportID()
    {
      Dictionary<string, int> map = new Dictionary<string, int>
      {
        { "BGI", 1 },
        { "CDG", 2 },
        { "DEL", 3 },
        { "DOH", 4 },
        { "DSM", 5 },
        { "EWR", 6 },
        { "EYW", 7 },
        { "HND", 8 },
        { "ICN", 9 },
        { "JFK", 10 },
        { "LGA", 11 },
        { "LHR", 12 },
        { "ORD", 13 },
        { "SAN", 14 },
        { "SFO", 15 },
        { "SIN", 16 },
        { "TLV", 17 },
        { "BUD", 18 }
      };

      return map;
    }

    public static SortedDictionary<string, int> MapAirportIDSortedByKey()
    {
      SortedDictionary<string, int> map = new SortedDictionary<string, int>
      {
        { "BGI", 1 },
        { "BUD", 18 },
        { "CDG", 2 },
        { "DEL", 3 },
        { "DOH", 4 },
        { "DSM", 5 },
        { "EWR", 6 },
        { "EYW", 7 },
        { "HND", 8 },
        { "ICN", 9 },
        { "JFK", 10 },
        { "LHR", 12 },
        { "LGA", 11 },
        { "ORD", 13 },
        { "SAN", 14 },
        { "SFO", 15 },
        { "SIN", 16 },
        { "TLV", 17 }
      };

      return map;
    }

    public static Dictionary<string, int> MapAirportIDOrderedByKey()
    {
      Dictionary<string, int> map = new Dictionary<string, int>
      {
        { "BGI", 1 },
        { "BUD", 18 },
        { "CDG", 2 },
        { "DEL", 3 },
        { "DOH", 4 },
        { "DSM", 5 },
        { "EWR", 6 },
        { "EYW", 7 },
        { "HND", 8 },
        { "ICN", 9 },
        { "JFK", 10 },
        { "LHR", 12 },
        { "LGA", 11 },
        { "ORD", 13 },
        { "SAN", 14 },
        { "SFO", 15 },
        { "SIN", 16 },
        { "TLV", 17 }
      };

      return map;
    }
  }
}
