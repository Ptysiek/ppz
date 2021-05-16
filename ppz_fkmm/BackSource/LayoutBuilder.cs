using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ppz_fkmm.FrontSource.Structures;
using System.Windows.Forms;


namespace ppz_fkmm.BackSource
{
    class LayoutBuilder
    {
        private Form _parentForm;

        public LayoutBuilder(Form parentForm)
        {
            _parentForm = parentForm;
        }

        public PlainLayout GetPlainLayout()
        {
            _parentForm.Controls.Clear();

            PlainLayout result = new PlainLayout();
            _parentForm.Controls.Add(result._panel);
            return result;
        }

        public ThreeWingedLayout GetThreeWingedLayout()
        {
            _parentForm.Controls.Clear();

            ThreeWingedLayout result = new ThreeWingedLayout();
            _parentForm.Controls.Add(result._horizontalSplitContainer);
            return result;
        }
    }
}
