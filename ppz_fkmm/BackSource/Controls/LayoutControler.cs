

namespace ppz_fkmm.BackSource.Controls
{
    public class LayoutControler
    {
        private MainWindow _mainWindow;
        private LayoutBuilder _layoutBuilder;

        public LayoutControler(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            _layoutBuilder = new LayoutBuilder(mainWindow._form);
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
            if (key == "ThreeWingedLayout")
            {
                _mainWindow._layout = _layoutBuilder.GetThreeWingedLayout();
                return true;
            }
            return false;
        }
    }
}
