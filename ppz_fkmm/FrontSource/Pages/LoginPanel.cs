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
            if (await Login())
            {
                _program._layoutControler.ChangeLayout("ThreeWingedLayout");
                _program._pagesControler.PushPage("MainPage");
            }
        }

        private async Task<bool> Login()
        {
            if (loginName.Text.Length == 0 || loginPass.Text.Length == 0)
            {
                var error = "Credentials not given ";
                ErrorText.Text = error;
                Console.WriteLine(error);
                return false;
            }
            AuthenticationControler authenticationControler = new AuthenticationControler();
            var result = await authenticationControler.Login(_program._httpControler, loginName.Text, loginPass.Text);

            if (result.Length == 0)
            {
                return true;
            }            
            ErrorText.Text = result;
            Console.WriteLine("[" + loginName.Text + "   " + loginPass.Text + "]");
            Console.WriteLine(authenticationControler.errorCode);
            Console.WriteLine(authenticationControler.error);
            return false;
        }
    }
}

