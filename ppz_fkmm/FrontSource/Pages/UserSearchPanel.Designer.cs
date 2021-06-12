
namespace ppz_fkmm.FrontSource.Pages
{
    partial class UserSearchPanel
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
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.UserSearchTextbox = new System.Windows.Forms.TextBox();
            this.RSUserPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Location = new System.Drawing.Point(491, 19);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.UserSearchBtn.TabIndex = 0;
            this.UserSearchBtn.Text = "button1";
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            // 
            // UserSearchTextbox
            // 
            this.UserSearchTextbox.Location = new System.Drawing.Point(28, 19);
            this.UserSearchTextbox.Name = "UserSearchTextbox";
            this.UserSearchTextbox.Size = new System.Drawing.Size(457, 20);
            this.UserSearchTextbox.TabIndex = 1;
            // 
            // RSUserPanel
            // 
            this.RSUserPanel.Location = new System.Drawing.Point(3, 48);
            this.RSUserPanel.Name = "RSUserPanel";
            this.RSUserPanel.Size = new System.Drawing.Size(563, 214);
            this.RSUserPanel.TabIndex = 2;
            // 
            // UserSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RSUserPanel);
            this.Controls.Add(this.UserSearchTextbox);
            this.Controls.Add(this.UserSearchBtn);
            this.Name = "UserSearchPanel";
            this.Size = new System.Drawing.Size(577, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.TextBox UserSearchTextbox;
        private System.Windows.Forms.Panel RSUserPanel;
    }
}
