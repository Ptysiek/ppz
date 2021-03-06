using System.Windows.Forms;
using ppz_fkmm.BackSource.Controls;

namespace ppz_fkmm.BackSource
{
    public class Program
    {
        public MainWindow _mainWindow;

        public readonly LayoutControler _layoutControler;
        public readonly PagesControler _pagesControler;
        public readonly HttpControler _httpControler;

        public Program()
        {
            _mainWindow = new MainWindow();

            _layoutControler = new LayoutControler(_mainWindow, this);
            _pagesControler = new PagesControler(this);
            _httpControler = new HttpControler();

            _layoutControler.ChangeLayout("PlainLayout");
            _pagesControler.PushPage("LoginPage");
            _httpControler.InitializeClient();

            Application.Run(_mainWindow._form);
        }
    }
}
