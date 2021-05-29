using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using ppz_fkmm.FrontSource.Pages;
using ppz_fkmm.BackSource.Controls;

namespace ppz_fkmm.BackSource
{
    public class Program
    {
<<<<<<< HEAD
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
=======
        public MainWindow _mainWindow;

        public AuthenticationControler _authenticationControler;
        public LayoutControler _layoutControler;
        public PagesControler _pagesControler;


        public Program()
        {
            _mainWindow = new MainWindow();

            _authenticationControler = new AuthenticationControler();
            _layoutControler = new LayoutControler(_mainWindow);
            _pagesControler = new PagesControler(this);

            _layoutControler.ChangeLayout("PlainLayout");
            _pagesControler.PushPage("LoginPage");

            Application.Run(_mainWindow._form);
        }
    }
>>>>>>> master
}
