
namespace ppz_fkmm.FrontSource.Pages
{
    partial class MenuUserPanel
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
            this.MenuBtnUserSearch = new System.Windows.Forms.Button();
            this.MenuBtnUserBeer = new System.Windows.Forms.Button();
            this.MenuBtnUserSettings = new System.Windows.Forms.Button();
            this.MenuBtnUserLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBtnUserSearch
            // 
            this.MenuBtnUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnUserSearch.Location = new System.Drawing.Point(4, 4);
            this.MenuBtnUserSearch.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserSearch.Name = "MenuBtnUserSearch";
            this.MenuBtnUserSearch.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnUserSearch.TabIndex = 0;
            this.MenuBtnUserSearch.Text = "Browse For Beer";
            this.MenuBtnUserSearch.UseVisualStyleBackColor = true;
            this.MenuBtnUserSearch.Click += new System.EventHandler(this.MenuBtnUserSearch_Click);
            // 
            // MenuBtnUserBeer
            // 
            this.MenuBtnUserBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnUserBeer.Location = new System.Drawing.Point(4, 54);
            this.MenuBtnUserBeer.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserBeer.Name = "MenuBtnUserBeer";
            this.MenuBtnUserBeer.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnUserBeer.TabIndex = 1;
            this.MenuBtnUserBeer.Text = "Your Catalog";
            this.MenuBtnUserBeer.UseVisualStyleBackColor = true;
            // 
            // MenuBtnUserSettings
            // 
            this.MenuBtnUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnUserSettings.Location = new System.Drawing.Point(4, 104);
            this.MenuBtnUserSettings.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserSettings.Name = "MenuBtnUserSettings";
            this.MenuBtnUserSettings.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnUserSettings.TabIndex = 2;
            this.MenuBtnUserSettings.Text = "Settings";
            this.MenuBtnUserSettings.UseVisualStyleBackColor = true;
            this.MenuBtnUserSettings.Click += new System.EventHandler(this.MenuBtnUserSettings_Click);
            // 
            // MenuBtnUserLogout
            // 
            this.MenuBtnUserLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.MenuBtnUserLogout.Location = new System.Drawing.Point(4, 154);
            this.MenuBtnUserLogout.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserLogout.Name = "MenuBtnUserLogout";
            this.MenuBtnUserLogout.Size = new System.Drawing.Size(226, 42);
            this.MenuBtnUserLogout.TabIndex = 3;
            this.MenuBtnUserLogout.Text = "Log Out";
            this.MenuBtnUserLogout.UseVisualStyleBackColor = true;
            this.MenuBtnUserLogout.Click += new System.EventHandler(this.MenuBtnUserLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 287);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnUserSearch);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnUserBeer);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnUserSettings);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtnUserLogout);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 231);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MenuUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuUserPanel";
            this.Size = new System.Drawing.Size(260, 294);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuBtnUserSearch;
        private System.Windows.Forms.Button MenuBtnUserBeer;
        private System.Windows.Forms.Button MenuBtnUserSettings;
        private System.Windows.Forms.Button MenuBtnUserLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
