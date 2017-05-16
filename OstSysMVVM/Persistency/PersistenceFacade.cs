using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;
using OstSysMVVM.Model;

namespace OstSysMVVM.Persistency
{
    class PersistenceFacade
    {
        const string ServerUrl = "http://localhost:61359";
        HttpClientHandler handler;

        public PersistenceFacade()
        {
            handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
        }

        public List<Apartment> GetApartments()
        {
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
                        var apartmentlist = response.Content.ReadAsAsync<IEnumerable<Apartment>>().Result;
                        return apartmentlist.ToList();
                    }
                }
                catch (Exception ex)
                {
                    new MessageDialog(ex.Message).ShowAsync();
                }
                return null;
            }
        }

        public void SaveApartment(Apartment aApartment)
        {
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    string postBody = JsonConvert.SerializeObject(aApartment);
                    //var response = 
                    var response =
                        client.PostAsync("api/apartments", new StringContent(postBody, Encoding.UTF8, "application/json"))
                            .Result;
                }
                catch (Exception ex)
                {
                    new MessageDialog(ex.Message).ShowAsync();

                }
            }


        }
    }
}
