
namespace ppz_fkmm.FrontSource.Pages
{
    partial class ShopSearchPanel
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
            this.ShopSearchTextbox = new System.Windows.Forms.TextBox();
            this.ShopSearchBtn = new System.Windows.Forms.Button();
            this.RSShopPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ShopSearchTextbox
            // 
            this.ShopSearchTextbox.Location = new System.Drawing.Point(3, 3);
            this.ShopSearchTextbox.Name = "ShopSearchTextbox";
            this.ShopSearchTextbox.Size = new System.Drawing.Size(403, 20);
            this.ShopSearchTextbox.TabIndex = 0;
            // 
            // ShopSearchBtn
            // 
            this.ShopSearchBtn.Location = new System.Drawing.Point(412, 3);
            this.ShopSearchBtn.Name = "ShopSearchBtn";
            this.ShopSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.ShopSearchBtn.TabIndex = 1;
            this.ShopSearchBtn.Text = "button1";
            this.ShopSearchBtn.UseVisualStyleBackColor = true;
            // 
            // RSShopPanel
            // 
            this.RSShopPanel.Location = new System.Drawing.Point(3, 29);
            this.RSShopPanel.Name = "RSShopPanel";
            this.RSShopPanel.Size = new System.Drawing.Size(484, 211);
            this.RSShopPanel.TabIndex = 2;
            // 
            // ShopSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RSShopPanel);
            this.Controls.Add(this.ShopSearchBtn);
            this.Controls.Add(this.ShopSearchTextbox);
            this.Name = "ShopSearchPanel";
            this.Size = new System.Drawing.Size(493, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShopSearchTextbox;
        private System.Windows.Forms.Button ShopSearchBtn;
        private System.Windows.Forms.Panel RSShopPanel;
    }
}
