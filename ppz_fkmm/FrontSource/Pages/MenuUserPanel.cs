using ppz_fkmm.BackSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class MenuUserPanel : UserControl
    {
        Program _program;

        public MenuUserPanel(Program program)
        {
            _program = program;
            InitializeComponent();
        }

        private void MenuBtnUserLogout_Click(object sender, EventArgs e)
        {
            _program._layoutControler.ChangeLayout("PlainLayout");
            _program._pagesControler.PushPage("LoginPage");
        }

        private void MenuBtnUserSettings_Click(object sender, EventArgs e)
        {
            _program._pagesControler.PushPage("SettingsPage");
        }

        private void MenuBtnUserSearch_Click(object sender, EventArgs e)
        {
            _program._pagesControler.PushPage("UserSearchPage");
        }
    }
}
