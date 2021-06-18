
namespace ppz_fkmm.FrontSource.Pages
{
    partial class MenuShopPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBtnShopSearch = new System.Windows.Forms.Button();
            this.MenuBtnShopBeer = new System.Windows.Forms.Button();
            this.MenuBtnShopSettings = new System.Windows.Forms.Button();
            this.MenuBtnShopLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBtnShopSearch
            // 
            this.MenuBtnShopSearch.AutoSize = true;
            this.MenuBtnShopSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnShopSearch.Location = new System.Drawing.Point(4, 4);
            this.MenuBtnShopSearch.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnShopSearch.Name = "MenuBtnShopSearch";
            this.MenuBtnShopSearch.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnShopSearch.TabIndex = 0;
            this.MenuBtnShopSearch.Text = "Browse For Beer";
            this.MenuBtnShopSearch.UseVisualStyleBackColor = true;
            this.MenuBtnShopSearch.Click += new System.EventHandler(this.MenuBtnShopSearch_Click);
            // 
            // MenuBtnShopBeer
            // 
            this.MenuBtnShopBeer.AutoSize = true;
            this.MenuBtnShopBeer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MenuBtnShopBeer.Enabled = false;
            this.MenuBtnShopBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnShopBeer.Location = new System.Drawing.Point(4, 54);
            this.MenuBtnShopBeer.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnShopBeer.Name = "MenuBtnShopBeer";
            this.MenuBtnShopBeer.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnShopBeer.TabIndex = 1;
            this.MenuBtnShopBeer.Text = "Store Catalog ";
            this.MenuBtnShopBeer.UseVisualStyleBackColor = false;
            // 
            // MenuBtnShopSettings
            // 
            this.MenuBtnShopSettings.AutoSize = true;
            this.MenuBtnShopSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnShopSettings.Location = new System.Drawing.Point(4, 104);
            this.MenuBtnShopSettings.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnShopSettings.Name = "MenuBtnShopSettings";
            this.MenuBtnShopSettings.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnShopSettings.TabIndex = 2;
            this.MenuBtnShopSettings.Text = "Settings";
            this.MenuBtnShopSettings.UseVisualStyleBackColor = true;
            this.MenuBtnShopSettings.Click += new System.EventHandler(this.MenuBtnShopSettings_Click);
            // 
            // MenuBtnShopLogout
            // 
            this.MenuBtnShopLogout.AutoSize = true;
            this.MenuBtnShopLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnShopLogout.Location = new System.Drawing.Point(4, 154);
            this.MenuBtnShopLogout.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnShopLogout.Name = "MenuBtnShopLogout";
            this.MenuBtnShopLogout.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnShopLogout.TabIndex = 3;
            this.MenuBtnShopLogout.Text = "Log Out";
            this.MenuBtnShopLogout.UseVisualStyleBackColor = true;
            this.MenuBtnShopLogout.Click += new System.EventHandler(this.MenuBtnShopLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 287);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnShopSearch);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnShopBeer);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnShopSettings);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnShopLogout);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 231);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MenuShopPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuShopPanel";
            this.Size = new System.Drawing.Size(262, 340);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuBtnShopSearch;
        private System.Windows.Forms.Button MenuBtnShopBeer;
        private System.Windows.Forms.Button MenuBtnShopSettings;
        private System.Windows.Forms.Button MenuBtnShopLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
