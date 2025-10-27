using System;
using System.Threading.Tasks;
using APIServiceLibrary.Services;

namespace APIServiceLibrary
{
    public class APITest
    {
        public static async Task Main()
        {
            var api = new APIService();
            var result = await api.GetOneDriver();

            if (result != null && result.Results.Count > 0)
            {
                var driver = result.Results[0];
                Console.WriteLine($"Driver: {driver.Name.First} {driver.Name.Last}");
                Console.WriteLine($"City: {driver.Location.City}");
                Console.WriteLine($"Country: {driver.Location.Country}");
            }
            else
            {
                Console.WriteLine("No driver data returned.");
            }
        }
    }
}
