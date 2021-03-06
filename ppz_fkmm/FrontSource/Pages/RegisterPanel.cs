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
using ppz_fkmm.BackSource.Controls;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class RegisterPanel : UserControl
    {
        Program _program;

        public RegisterPanel(Program program)
        {
            _program = program;
            InitializeComponent();
        }
        public RegisterPanel()
        {
            InitializeComponent();
        }

        private void registerBtnCancel_Click(object sender, EventArgs e)
        {
            _program._pagesControler.PopPage();
        }

        private async void registerBtnRegister_Click(object sender, EventArgs e)
        {
            if (!await Register()) {
                return;
            }
            if (await Login()) {
                if (registerUser.Checked)
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedUserLayout");
                    //_program._pagesControler.PushPage("MainPage");
                    _program._pagesControler.PushPage("UserSearchPage");
                }
                else
                {
                    _program._layoutControler.ChangeLayout("ThreeWingedShopLayout");
                    //_program._pagesControler.PushPage("MainPage");
                    _program._pagesControler.PushPage("ShopSearchPage");
                }
            }
        }
         
        private async Task<bool> Register()
        {
            if (!registerUser.Checked && !registerShop.Checked) {
                errorText.Text = "Choose User/Shop Login";
                return false;
            } 
            AuthenticationControler authenticationControler = new AuthenticationControler();
            await authenticationControler.Register(_program._httpControler, registerName.Text, registerPass.Text, registerUser.Checked);
            return true;
        }

        private async Task<bool> Login()
        {
            if (!registerUser.Checked && !registerShop.Checked) {
                errorText.Text = "Choose User/Shop Login";
                return false;
            }                        
            AuthenticationControler authenticationControler = new AuthenticationControler();
            var result = await authenticationControler.Login(_program._httpControler, registerName.Text, registerPass.Text, registerUser.Checked);

            if (result.Length == 0)
            {
                return true;
            }
            errorText.Text = result;
            Console.WriteLine(authenticationControler.errorCode);
            Console.WriteLine(authenticationControler.error);
            return false;
        }
    }
}
