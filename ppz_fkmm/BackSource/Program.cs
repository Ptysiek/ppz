using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ppz_fkmm.BackSource
{
    class Program
    {
        private readonly ApiHttpHelper httpHelper;

        public Program()
        {
            httpHelper = new ApiHttpHelper();
            httpHelper.InitializeClient();

            Execute();
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
    }  
}
