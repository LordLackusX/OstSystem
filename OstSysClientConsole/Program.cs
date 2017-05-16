using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OstSysWeb;

namespace OstSysClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ServerUrl = "http://localhost:61359";

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;

            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    var response = client.GetAsync("api/Apartments").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        IEnumerable<Apartment> apartmentData =
                            response.Content.ReadAsAsync<IEnumerable<Apartment>>().Result;
                        foreach (var apartment in apartmentData)
                        {
                            Console.WriteLine(apartment);
                        }
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                }

            }
        }
    }
}
