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
        }

        private async Task LoadData()
        {
            string url = "https://api.openbrewerydb.org/breweries";

            using (HttpResponseMessage response = await httpHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                }
            }
        }
    
    }
    

}
