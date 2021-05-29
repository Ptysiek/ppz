using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using ppz_fkmm.FrontSource.Pages;
using ppz_fkmm.BackSource.Controls;

namespace ppz_fkmm.BackSource
{
    public class Program
    {
        public MainWindow _mainWindow;

        public AuthenticationControler _authenticationControler;
        public LayoutControler _layoutControler;
        public PagesControler _pagesControler;
        private readonly HttpControler _httpControler;


        public Program()
        {
            _mainWindow = new MainWindow();

            _authenticationControler = new AuthenticationControler();
            _layoutControler = new LayoutControler(_mainWindow);
            _pagesControler = new PagesControler(this);
            _httpControler = new HttpControler();

            _layoutControler.ChangeLayout("PlainLayout");
            _pagesControler.PushPage("LoginPage");
            _httpControler.InitializeClient();

            Application.Run(_mainWindow._form);
        }
    }
}
