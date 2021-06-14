

namespace ppz_fkmm.BackSource.Controls
{
    public class LayoutControler
    {
        Program _program;
        private MainWindow _mainWindow;
        private LayoutBuilder _layoutBuilder;

        public LayoutControler(MainWindow mainWindow, Program program)
        {
            _program = program;
            _mainWindow = mainWindow;
            _layoutBuilder = new LayoutBuilder(mainWindow._form, program);
        }

        public bool ChangeLayout(string key)
        {
            if (_mainWindow._layout == null)
            {
                return InitLayout(key);
            }
            var pages = _mainWindow._layout._pages;
            
            if (!InitLayout(key))
            {
                return false;
            }
            _mainWindow._layout._pages = pages;
            _mainWindow._layout.RestartPage();
            return true;
        }

        private bool InitLayout(string key)
        {
            if (key == "PlainLayout")
            {
                _mainWindow._layout = _layoutBuilder.GetPlainLayout();
                return true;
            }
            if (key == "ThreeWingedUserLayout")
            {
                _mainWindow._layout = _layoutBuilder.GetThreeWingedUserLayout();
                return true;
            }
            if (key == "ThreeWingedShopLayout")
            {
                _mainWindow._layout = _layoutBuilder.GetThreeWingedShopLayout();
                return true;
            }
            return false;
        }
    }
}
