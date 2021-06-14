
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
            this.SuspendLayout();
            // 
            // MenuBtnUserSearch
            // 
            this.MenuBtnUserSearch.Location = new System.Drawing.Point(4, 4);
            this.MenuBtnUserSearch.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserSearch.Name = "MenuBtnUserSearch";
            this.MenuBtnUserSearch.Size = new System.Drawing.Size(119, 28);
            this.MenuBtnUserSearch.TabIndex = 0;
            this.MenuBtnUserSearch.Text = "Wyszukaj Piwo";
            this.MenuBtnUserSearch.UseVisualStyleBackColor = true;
            this.MenuBtnUserSearch.Click += new System.EventHandler(this.MenuBtnUserSearch_Click);
            // 
            // MenuBtnUserBeer
            // 
            this.MenuBtnUserBeer.Location = new System.Drawing.Point(4, 39);
            this.MenuBtnUserBeer.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserBeer.Name = "MenuBtnUserBeer";
            this.MenuBtnUserBeer.Size = new System.Drawing.Size(119, 28);
            this.MenuBtnUserBeer.TabIndex = 1;
            this.MenuBtnUserBeer.Text = "Twoje Piwa";
            this.MenuBtnUserBeer.UseVisualStyleBackColor = true;
            // 
            // MenuBtnUserSettings
            // 
            this.MenuBtnUserSettings.Location = new System.Drawing.Point(4, 75);
            this.MenuBtnUserSettings.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserSettings.Name = "MenuBtnUserSettings";
            this.MenuBtnUserSettings.Size = new System.Drawing.Size(119, 28);
            this.MenuBtnUserSettings.TabIndex = 2;
            this.MenuBtnUserSettings.Text = "Ustawienia";
            this.MenuBtnUserSettings.UseVisualStyleBackColor = true;
            this.MenuBtnUserSettings.Click += new System.EventHandler(this.MenuBtnUserSettings_Click);
            // 
            // MenuBtnUserLogout
            // 
            this.MenuBtnUserLogout.Location = new System.Drawing.Point(4, 111);
            this.MenuBtnUserLogout.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtnUserLogout.Name = "MenuBtnUserLogout";
            this.MenuBtnUserLogout.Size = new System.Drawing.Size(119, 28);
            this.MenuBtnUserLogout.TabIndex = 3;
            this.MenuBtnUserLogout.Text = "Wyloguj";
            this.MenuBtnUserLogout.UseVisualStyleBackColor = true;
            this.MenuBtnUserLogout.Click += new System.EventHandler(this.MenuBtnUserLogout_Click);
            // 
            // MenuUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuBtnUserLogout);
            this.Controls.Add(this.MenuBtnUserSettings);
            this.Controls.Add(this.MenuBtnUserBeer);
            this.Controls.Add(this.MenuBtnUserSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuUserPanel";
            this.Size = new System.Drawing.Size(129, 149);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuBtnUserSearch;
        private System.Windows.Forms.Button MenuBtnUserBeer;
        private System.Windows.Forms.Button MenuBtnUserSettings;
        private System.Windows.Forms.Button MenuBtnUserLogout;
    }
}
