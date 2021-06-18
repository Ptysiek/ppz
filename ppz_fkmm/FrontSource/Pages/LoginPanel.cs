using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.BackSource.Controls;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class LoginPanel : UserControl
    {
        Program _program;

        public LoginPanel(Program program)
        {
            _program = program;
            InitializeComponent();
        }

        private void loginBtnRegister_Click(object sender, EventArgs e)
        {
            _program._pagesControler.PushPage("RegisterPage");
            Cleanup();
        }

        private async void loginBtnLogin_Click(object sender, EventArgs e)
        {
            if (loginUser.Checked)
            {
                if (await Login(true))
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedUserLayout");
                    _program._pagesControler.PushPage("UserSearchPage");
                    Cleanup();
                }
                return;
            }
            if (loginShop.Checked)
            {
                if (await Login(false))
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedShopLayout");
                    _program._pagesControler.PushPage("UserSearchPage");
                    Cleanup();
                }
                return;
            }
            ErrorText.Text = "Choose User/Shop Login";         
        }

        private async Task<bool> Login(bool user)
        {
            if (loginName.Text.Length == 0 || loginPass.Text.Length == 0)
            {
                var error = "Credentials not given ";
                ErrorText.Text = error;
                return false;
            }
            AuthenticationControler authenticationControler = new AuthenticationControler();
            string result = await authenticationControler.Login(_program._httpControler, loginName.Text, loginPass.Text, user);

            if (result.Length == 0) {
                return true;
            }            
            ErrorText.Text = result;
            return false;
        }

        private void Cleanup()
        {
            ErrorText.Text = "";
            loginName.Text = "";
            loginPass.Text = "";
            loginUser.Checked = false;
            loginShop.Checked = false;
        }
    }
}

