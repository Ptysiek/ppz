using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppz_fkmm.FrontSource.Structures
{
    class PlainLayout : Layout
    {
        public Panel _panel;

        public PlainLayout()
        {
            _panel = new Panel()
            {
                Dock = DockStyle.Fill
            };
        }

        public override bool RestartPage()
        {
            if (_pages.Count == 0)
            {
                return false;
            }
            _panel.Controls.Clear();
            _panel.Controls.Add(_pages.Peek());
            return true;
        }
    }
}
