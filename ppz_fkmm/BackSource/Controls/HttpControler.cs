using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ppz_fkmm.BackSource.Controls
{
    class HttpControler
    {
        public HttpClient ApiClient { get; set; }

        public void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /*
        
        class BreweriesModel
         {
        public int Id { get; set; }
        public string Name { get; set; }
         }

        public Program()
        {
            //Execute();
        }
        public async void Execute()
        {
            var models = await LoadData();
            foreach (BreweriesModel model in models)
            {
                Console.WriteLine(model.Id + "  " + model.Name);
            }
        }
        
        private async Task<List<BreweriesModel>> LoadData()
        {
            string url = "https://api.openbrewerydb.org/breweries";

            using (HttpResponseMessage response = await httpHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<BreweriesModel> models = await response.Content.ReadAsAsync<List<BreweriesModel>>();
                    return models;
                }
                throw new Exception(response.ReasonPhrase);
            }
        }
        */
    }
}
