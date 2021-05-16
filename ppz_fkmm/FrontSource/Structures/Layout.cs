using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppz_fkmm.FrontSource.Structures
{
    public abstract class Layout 
    {
        public Stack<UserControl> _pages = new Stack<UserControl>();

        public abstract bool RestartPage();

        public void PushPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            _pages.Push(page);
            RestartPage();
        }

        public void PopPage()
        {
            _pages.Pop();
            RestartPage();
        }
    }            
}
