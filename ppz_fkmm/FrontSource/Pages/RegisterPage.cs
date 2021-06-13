using System;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.BackSource.Controls;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class RegisterPage : UserControl
    {
        readonly PagesControler _pagesControler;
        readonly LayoutControler _layoutControler;
        readonly AuthenticationControler _authenticationControler;

        public RegisterPage(PagesControler pagesControler, LayoutControler layoutControler, AuthenticationControler authenticationControler)
        {
            _pagesControler = pagesControler;
            _layoutControler = layoutControler;
            _authenticationControler = authenticationControler;
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (_authenticationControler.Login(UsernameTxt.Text, PasswordTxt.Text))
            {
                _pagesControler.PopPage();
                _layoutControler.ChangeLayout("ThreeWingedLayout");
                _pagesControler.PushPage("MainPage");
            }
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            _pagesControler.PopPage();
        }
    }
}