using System;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.BackSource.Controls;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class LoginPage : UserControl
    {
        PagesControler _pagesControler;
        LayoutControler _layoutControler;
        AuthenticationControler _authenticationControler;

        public LoginPage(PagesControler pagesControler, LayoutControler layoutControler, AuthenticationControler authenticationControler)
        {
            _pagesControler = pagesControler;
            _layoutControler = layoutControler;
            _authenticationControler = authenticationControler;
            InitializeComponent();
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (_authenticationControler.Login(UsernameTxt.Text, PasswordTxt.Text))
            {
                _layoutControler.ChangeLayout("ThreeWingedLayout");
                _pagesControler.PushPage("MainPage");
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            _pagesControler.PushPage("RegisterPage");
        }
    }
}
