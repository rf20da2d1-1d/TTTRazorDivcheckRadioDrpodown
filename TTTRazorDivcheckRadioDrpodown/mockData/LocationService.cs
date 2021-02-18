using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTTRazorDivcheckRadioDrpodown.mockData
{
    public class LocationService
    {
        private static List<string> locations = new List<string>()
        {
            "Køge", "Roskilde", "Slagelse", "Næstved", "Nykøbing F", "Holbæk"
        };

        public static List<string> Locations => locations;
    }
}
