using System;
using System.Collections.Generic;

namespace GoogleInterviewAirport
{
    class Program
    {
        static void Main()
        {
            string[] airports = {"BGI", "CDG", "DEL", "DOH", "DSM", "EWR", "EYW", "HND", "ICN",
                "JFK", "LGA", "LHR", "ORD", "SAN", "SFO", "SIN", "TLV", "BUD", };
            string[,] routes = {
                { "DSM", "ORD" },
                { "ORD", "BGI"},
                {"BGI", "LGA" },
                {"SIN", "CDG" },
                {"CDG", "SIN" },
                {"CDG", "BUD" },
                {"DEL", "DOH" },
                {"DEL", "CDG" },
                {"TLV", "DEL" },
                {"EWR", "HND" },
                {"HND", "ICN" },
                {"HND", "JFK" },
                {"ICN", "JFK" },
                {"JFK", "LGA" },
                {"EYW", "LHR" },
                {"LHR", "SFO" },
                {"SFO", "SAN" },
                {"SFO", "DSM" },
                {"SAN", "EYW" }
                };
            string startingAirport = "LGA";
            int answer = 3;
            // write a method that gives me the minimum connexion from startingAirport to any airports
            foreach (string airport in airports)
            {
                Console.WriteLine($"From LGA to {airport}, you have to go through {GetMinimumRoute(airport)}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static string GetMinimumRoute(string toAirport)
        {
            string result = string.Empty;
            string[] airports = {"BGI", "CDG", "DEL", "DOH", "DSM", "EWR", "EYW", "HND", "ICN",
                "JFK", "LGA", "LHR", "ORD", "SAN", "SFO", "SIN", "TLV", "BUD", };
            string[,] routes = {
                { "DSM", "ORD" },
                { "ORD", "BGI"},
                {"BGI", "LGA" },
                {"SIN", "CDG" },
                {"CDG", "SIN" },
                {"CDG", "BUD" },
                {"DEL", "DOH" },
                {"DEL", "CDG" },
                {"TLV", "DEL" },
                {"EWR", "HND" },
                {"HND", "ICN" },
                {"HND", "JFK" },
                {"ICN", "JFK" },
                {"JFK", "LGA" },
                {"EYW", "LHR" },
                {"LHR", "SFO" },
                {"SFO", "SAN" },
                {"SFO", "DSM" },
                {"SAN", "EYW" }
                };
            string startingAirport = "LGA";
            int answer = 3;
            string[,] tempoRoute = new string[99, 99];

            foreach (var item in routes)
            {

            };


            Dictionary<string, int> map = new Dictionary<string, int>();
            map.Add("BGI", 1);
            map.Add("CDG", 2);
            map.Add("DEL", 3);
            map.Add("DOH", 4);
            map.Add("DSM", 5);
            map.Add("EWR", 6);
            map.Add("EYW", 7);
            map.Add("HND", 8);
            map.Add("ICN", 9);
            map.Add("JFK", 10);
            map.Add("LGA", 11);
            map.Add("LHR", 12);
            map.Add("ORD", 13);
            map.Add("SAN", 14);
            map.Add("SFO", 15);
            map.Add("SIN", 16);
            map.Add("TLV", 17);
            map.Add("BUD", 18);

            List<int> adjacent = new List<int>();//[n]
            // go through routes
            //Korasaju's algo
            string[] who = new string[99];

            return result;

        }

        enum AirportsId
        {
            BGI = 1,
            CDG,
            DEL,
            DOH,
            DSM,
            EWR,
            EYW,
            HND,
            ICN,
            JFK,
            LGA,
            LHR,
            ORD,
            SAN,
            SFO,
            SIN,
            TLV,
            BUD
        };
    }
}
