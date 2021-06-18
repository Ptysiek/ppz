using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ppz_fkmm.BackSource;
using ppz_fkmm.FrontSource.Structures;
using ppz_fkmm.FrontSource.Pages;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using ppz_fkmm.FrontSource;
using AutoMapper;



namespace ppz_fkmm.FrontSource.Structures
{
    class ThreeWingedShopLayout : Layout
    {
        public SplitContainer _horizontalSplitContainer;
        public SplitContainer _verticalSplitContainer;

        Program _program;
        readonly Color activeColor = Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
        readonly Color bgColor = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));

        public ThreeWingedShopLayout(Program program)
        {
            _program = program;
            _horizontalSplitContainer = GetHorizontalSplitContainer();
            _verticalSplitContainer = GetVerticalSplitContainer();

            Configure_Parenthood();
        }

        public override bool RestartPage()
        {
            if (_pages.Count == 0)
            {
                return false;
            }
            _verticalSplitContainer.Panel2.Controls.Clear();
            _verticalSplitContainer.Panel2.Controls.Add(_pages.Peek());
            return true;
        }


        // _____________________________________________________________________________________________________
        // #####################################################################################################

        private SplitContainer GetHorizontalSplitContainer()
        {
            SplitContainer result = new SplitContainer()
            {
                Name = "horizontalSplitContainer",
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Size = new Size(800, 450),

                Orientation = Orientation.Horizontal,
                SplitterDistance = 56,
                TabIndex = 0,

                BackColor = activeColor
            };
            result.Panel1.BackColor = bgColor; // SystemColors.ControlLight;
            result.Panel2.BackColor = activeColor;

            return result;
        }
        private SplitContainer GetVerticalSplitContainer()
        {
            SplitContainer result = new SplitContainer()
            {
                Name = "verticalSplitContainer",
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Size = new Size(800, 390),

                Orientation = Orientation.Vertical,
                SplitterDistance = 183,
                TabIndex = 0,

                BackColor = activeColor //SystemColors.ActiveCaption
            };
            result.Panel1.BackColor = bgColor; // SystemColors.ControlLight;
            result.Panel2.BackColor = bgColor; // SystemColors.ControlLight;

            var page = new MenuShopPanel(_program) {
                Dock = DockStyle.Fill
            };
            result.Panel1.Controls.Add(page);

            return result;
        }

        private void Configure_Parenthood()
        {            
            _horizontalSplitContainer.Panel2.Controls.Add(_verticalSplitContainer);


            /*
            result.Form.ControlsAdd(result.pageHandlersContainer);
            result.Form.ControlsAdd(result.menuStrip);

            result.Form.ControlsAdd(result.dragNdropContainer);
            result.dragNdropContainer.Controls.Add(result.dragNdropText1);
            result.dragNdropContainer.Controls.Add(result.dragNdropText2);

            result.Form.ControlsAdd(result.taskbar);
            */
        }
    }
}
