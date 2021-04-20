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
        List<UserControl> listPanel = new List<UserControl>();
        int index = 0;
        
        private Button BtnBack;
        private Button BtnNext;
        private FrontSource.uc1 uc11;
        private FrontSource.uc2 uc21;
        private FrontSource.uc3 uc31;
        private System.ComponentModel.IContainer components = null;

        public MainWindow()
        {
            InitializeComponent();
        }
        // _____________________________________________________________________________________________________
        // #####################################################################################################
        private void InitializeComponent()
        {
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.uc21 = new ppz_fkmm.FrontSource.uc2();
            this.uc11 = new ppz_fkmm.FrontSource.uc1();
            this.uc31 = new ppz_fkmm.FrontSource.uc3();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBack.Location = new System.Drawing.Point(12, 218);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "BACK";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Location = new System.Drawing.Point(195, 218);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = "NEXT";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // uc21
            // 
            this.uc21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uc21.Location = new System.Drawing.Point(12, 12);
            this.uc21.Name = "uc21";
            this.uc21.Size = new System.Drawing.Size(258, 169);
            this.uc21.TabIndex = 3;
            this.uc21.Visible = false;
            // 
            // uc11
            // 
            this.uc11.BackColor = System.Drawing.Color.Red;
            this.uc11.Location = new System.Drawing.Point(12, 12);
            this.uc11.Name = "uc11";
            this.uc11.Size = new System.Drawing.Size(258, 169);
            this.uc11.TabIndex = 0;
            this.uc11.Visible = false;
            // 
            // uc31
            // 
            this.uc31.BackColor = System.Drawing.Color.Blue;
            this.uc31.Location = new System.Drawing.Point(12, 12);
            this.uc31.Name = "uc31";
            this.uc31.Size = new System.Drawing.Size(258, 169);
            this.uc31.TabIndex = 4;
            this.uc31.Visible = false;
            //
            //
            //
            listPanel.Add(uc11);
            listPanel.Add(uc21);
            listPanel.Add(uc31);
            listPanel[index].Visible = true;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.uc31);
            this.Controls.Add(this.uc21);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.uc11);
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

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[index].Visible = false;
                listPanel[++index].Visible = true;

            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[index].Visible = false;
                listPanel[--index].Visible = true;

            }
        }
    }
}
