using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ppz_fkmm.BackSource;


namespace ppz_fkmm.FrontSource.Pages
{
    public partial class RegisterPanel : UserControl
    {
        Program _program;

        public RegisterPanel(Program program)
        {
            _program = program;
            InitializeComponent();
        }
        public RegisterPanel()
        {
            InitializeComponent();
        }

        private void registerBtnCancel_Click(object sender, EventArgs e)
        {
            _program._pagesControler.PopPage();
        }
    }
}
