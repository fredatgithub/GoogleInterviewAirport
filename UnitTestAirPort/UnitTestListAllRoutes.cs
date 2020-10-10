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

    [TestMethod]
    public void TestMethod_GetAllPossibleAirport()
    {
      string source = "LGA";
      List<string> expected = new List<string> { "BGI" };
      List<string> result = AirportHelper.GetAllPossibleAirport(source);
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_LGA()
    {
      string source = "LGA";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "BGI", "JFK" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_DSM()
    {
      string source = "DSM";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "ORD", "SFO" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_ORD()
    {
      string source = "ORD";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "DSM", "BGI" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_BGI()
    {
      string source = "BGI";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "ORD", "LGA" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_SIN()
    {
      string source = "SIN";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "CDG" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_CDG()
    {
      string source = "CDG";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "SIN", "BUD", "DEL" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_BUD()
    {
      string source = "BUD";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "CDG" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_DEL()
    {
      string source = "DEL";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "DOH", "CDG", "TLV" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_DOH()
    {
      string source = "DOH";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "DEL" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_TLV()
    {
      string source = "TLV";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "DEL" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_EWR()
    {
      string source = "EWR";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "HND" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_HND()
    {
      string source = "HND";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "EWR", "ICN", "JFK" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_ICN()
    {
      string source = "ICN";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "HND", "JFK" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_JFK()
    {
      string source = "JFK";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "HND", "ICN", "LGA" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_EYW()
    {
      string source = "EYW";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "LHR", "SAN" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_LHR()
    {
      string source = "LHR";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "EYW", "SFO" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_SFO()
    {
      string source = "SFO";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "LHR", "SAN", "DSM" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
    }

    [TestMethod]
    public void TestMethod_What_Airport_From_SAN()
    {
      string source = "SAN";
      Airport source2 = new Airport(source);
      List<string> expected = new List<string> { "SFO", "EYW" };
      List<string> result = source2.ListOfAirportServed();
      Assert.IsTrue(AssertListAreEqual(result, expected));
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
