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


namespace ppz_fkmm
{
    public partial class MainWindow : Form
    {
        Program _backend;
        private System.ComponentModel.IContainer components = null;

        public MainWindow()
        {
            _backend = new Program();
            InitializeComponent();
        }
        // _____________________________________________________________________________________________________
        // #####################################################################################################
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }
        // _____________________________________________________________________________________________________
        // #####################################################################################################
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
