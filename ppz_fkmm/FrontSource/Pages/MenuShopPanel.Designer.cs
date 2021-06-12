
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
            this.SuspendLayout();
            // 
            // MenuBtnShopSearch
            // 
            this.MenuBtnShopSearch.Location = new System.Drawing.Point(3, 3);
            this.MenuBtnShopSearch.Name = "MenuBtnShopSearch";
            this.MenuBtnShopSearch.Size = new System.Drawing.Size(88, 23);
            this.MenuBtnShopSearch.TabIndex = 0;
            this.MenuBtnShopSearch.Text = "Wyszukaj Piwo";
            this.MenuBtnShopSearch.UseVisualStyleBackColor = true;
            // 
            // MenuBtnShopBeer
            // 
            this.MenuBtnShopBeer.Location = new System.Drawing.Point(3, 32);
            this.MenuBtnShopBeer.Name = "MenuBtnShopBeer";
            this.MenuBtnShopBeer.Size = new System.Drawing.Size(88, 23);
            this.MenuBtnShopBeer.TabIndex = 1;
            this.MenuBtnShopBeer.Text = "Oferta sklepu";
            this.MenuBtnShopBeer.UseVisualStyleBackColor = true;
            // 
            // MenuBtnShopSettings
            // 
            this.MenuBtnShopSettings.Location = new System.Drawing.Point(3, 61);
            this.MenuBtnShopSettings.Name = "MenuBtnShopSettings";
            this.MenuBtnShopSettings.Size = new System.Drawing.Size(88, 23);
            this.MenuBtnShopSettings.TabIndex = 2;
            this.MenuBtnShopSettings.Text = "Ustawienia";
            this.MenuBtnShopSettings.UseVisualStyleBackColor = true;
            // 
            // MenuBtnShopLogout
            // 
            this.MenuBtnShopLogout.Location = new System.Drawing.Point(3, 90);
            this.MenuBtnShopLogout.Name = "MenuBtnShopLogout";
            this.MenuBtnShopLogout.Size = new System.Drawing.Size(88, 23);
            this.MenuBtnShopLogout.TabIndex = 3;
            this.MenuBtnShopLogout.Text = "Wyloguj";
            this.MenuBtnShopLogout.UseVisualStyleBackColor = true;
            // 
            // MenuShopPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuBtnShopLogout);
            this.Controls.Add(this.MenuBtnShopSettings);
            this.Controls.Add(this.MenuBtnShopBeer);
            this.Controls.Add(this.MenuBtnShopSearch);
            this.Name = "MenuShopPanel";
            this.Size = new System.Drawing.Size(96, 118);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuBtnShopSearch;
        private System.Windows.Forms.Button MenuBtnShopBeer;
        private System.Windows.Forms.Button MenuBtnShopSettings;
        private System.Windows.Forms.Button MenuBtnShopLogout;
    }
}
