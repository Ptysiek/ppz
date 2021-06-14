using System.Collections.Generic;
using System.Windows.Forms;
using ppz_fkmm.FrontSource.Pages;
using ppz_fkmm.FrontSource.Structures;

namespace ppz_fkmm.BackSource
{
    public class PagesControler
    {
        private readonly Program _program;
        private readonly Dictionary<string, UserControl> _dictionary;

        public PagesControler(Program program)
        {
            _program = program;

            _dictionary = new Dictionary<string, UserControl>()
            {
                { "LoginPage",      new LoginPanel(_program) },
                { "RegisterPage",   new RegisterPanel(_program) },
                { "MainPage",       new MainPage() },
                { "SettingsPage",   new SettingsPanel() },
                { "ShopSearchPage", new ShopSearchPanel() },
                { "UserSearchPage", new UserSearchPanel() }
            };
        }
        public Layout GetLayout()
        {
            return _program._mainWindow._layout;
        }

        public bool PushPage(string key)
        {
            var page = GetValue(key);
            if (page == null)
            {
                return false;
            }
            _program._mainWindow._layout.PushPage(page);
            return true;
        }

        public void PopPage()
        {
            _program._mainWindow._layout.PopPage();
        }

        public UserControl GetValue(string key)
        {
            if (!_dictionary.ContainsKey(key))
            {
                return null;
            }
            if (_dictionary[key] == null)
            {
                return null;
            }
            return _dictionary[key];
        }

        public List<string> Keys()
        {
            if (_dictionary == null) { 
                return null; 
            }

            List<string> result = new List<string>();
            foreach (string key in _dictionary.Keys)
            {
                result.Add(key);
            }
            result.Sort();
            return result;
        }
    }
}
