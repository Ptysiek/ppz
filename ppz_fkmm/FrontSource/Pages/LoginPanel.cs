using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.BackSource.EndPoints;
using ppz_fkmm.BackSource.DataModels;
using System.Net.Http;
using ppz_fkmm.BackSource.Controls;
using ppz_fkmm.FrontSource.Structures;

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
        => _program._pagesControler.PushPage("RegisterPage");
        
        private async void loginBtnLogin_Click(object sender, EventArgs e)
        {
            if (loginUser.Checked)
            {
                if (await Login(true))
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedUserLayout");
                    //ThreeWingedLayout tmp = (ThreeWingedLayout)_program._pagesControler.GetLayout();
                    //tmp.GetHorizontalSplitContainer();
                    _program._pagesControler.PushPage("MainPage");
                }
                return;
            }
            if (loginShop.Checked)
            {
                if (await Login(false))
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedShopLayout");
                    _program._pagesControler.PushPage("MainPage");
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
    }
}

