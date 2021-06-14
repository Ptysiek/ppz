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
        Program _program;
        private Form _parentForm;

        public LayoutBuilder(Form parentForm, Program program)
        {
            _program = program;
            _parentForm = parentForm;
        }

        public PlainLayout GetPlainLayout()
        {
            _parentForm.Controls.Clear();

            PlainLayout result = new PlainLayout();
            _parentForm.Controls.Add(result._panel);
            return result;
        }

        public ThreeWingedUserLayout GetThreeWingedUserLayout()
        {
            _parentForm.Controls.Clear();

            ThreeWingedUserLayout result = new ThreeWingedUserLayout(_program);
            _parentForm.Controls.Add(result._horizontalSplitContainer);
            return result;
        }
        public ThreeWingedShopLayout GetThreeWingedShopLayout()
        {
            _parentForm.Controls.Clear();

            ThreeWingedShopLayout result = new ThreeWingedShopLayout(_program);
            _parentForm.Controls.Add(result._horizontalSplitContainer);
            return result;
        }
    }
}
