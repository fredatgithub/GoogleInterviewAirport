using GoogleInterviewAirport.Models;
using System;
using System.Collections.Generic;


namespace GoogleInterviewAirport
{
  class Program
  {
    static void Main()
    {
      string[] airports = AirportHelper.AirportList();
      string[,] routes = AirportHelper.RoutesList();
      string startingAirport = "LGA";
      int answer = 3;
      // write a method that gives the minimum connexion from startingAirport to any airports
      foreach (string airport in airports)
      {
        Console.WriteLine($"From LGA to {airport}, you have to go through {GetMinimumRoute(airport)}");
      }

      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    private static string GetMinimumRoute(string toAirport)
    {
      if (toAirport == "LGA")
      {
        return string.Empty;
      }

      string result = string.Empty;
      string[] airports = AirportHelper.AirportList();
      string[,] routes = AirportHelper.RoutesList();
      string startingAirport = "LGA";
      int answer = 3;
      string[,] tempoRoute = new string[99, 99];

      foreach (var item in routes)
      {

      };




      List<int> adjacent = new List<int>();//[n]
                                           // go through routes
                                           //Korasaju's algo
      string[] who = new string[99];

      return result;

    }

  }
}
