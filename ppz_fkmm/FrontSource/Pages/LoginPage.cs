using System;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.BackSource.EndPoints;
using ppz_fkmm.BackSource.DataModels;

namespace ppz_fkmm.FrontSource.Pages
{
    public partial class LoginPage : UserControl
    {
        Program _program;

         public LoginPage(Program program)
        {
            _program = program;
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (_program._authenticationControler.Login(UsernameTxt.Text, PasswordTxt.Text))
            {
                _program._layoutControler.ChangeLayout("ThreeWingedLayout");
                _program._pagesControler.PushPage("MainPage");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            GetDataExample();
            _program._pagesControler.PushPage("RegisterPage");
        }

        private async void GetDataExample()
        {
            EndPointControler<BeerModel> beerEndPoint = new EndPointControler<BeerModel>();
            var models = await beerEndPoint.LoadData("https://bhtjsvntyg.execute-api.eu-central-1.amazonaws.com/dev/beer", _program._httpControler);

            foreach (BeerModel model in models)
            {
                Console.WriteLine(model.Id + "  " + model.Name);
            }
        }
    }
}
