using GoogleInterviewAirport.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestAirPort
{
  [TestClass]
  public class UnitTestListAllRoutes
  {
    [TestMethod]
    public void TestMethod_emptyString()
    {
      string source = string.Empty;
      List<string> expected = new List<string>();
      List<string> result = AirportHelper.ListAllRoutes(source);
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_LGA()
    {
      string source = "LGA";
      List<string> expected = new List<string> { "LGA-BGI", "LGA-JFK" };
      List<string> result = AirportHelper.ListAllRoutes(source);
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_IsRouteValid_BGI_LGA()
    {
      Route source = new Route(new Airport("BGI"), new Airport("LGA"));
      bool expected = true;
      bool result = source.IsRouteValid();
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IsRouteValid_LGA_BGI()
    {
      Route source = new Route(new Airport("LGA"), new Airport("BGI"));
      bool expected = true;
      bool result = source.IsRouteValid();
      Assert.AreEqual(result, expected);
    }

    private static bool AssertListAreEqual(List<string> listSource, List<string> listTarget)
    {
      bool result = true;
      if (listSource.Count != listTarget.Count)
      {
        return false;
      }

      for (int i = 0; i < listSource.Count; i++)
      {
        if (listSource[i] != listTarget[i])
        {
          return false;
        }
      }

      return result;
    }
  }
}
