
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.UserSearchBtn.Location = new System.Drawing.Point(655, 12);
            this.UserSearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(100, 36);
            this.UserSearchBtn.TabIndex = 0;
            this.UserSearchBtn.Text = "Search";
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            // 
            // UserSearchTextbox
            // 
            this.UserSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserSearchTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.UserSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.UserSearchTextbox.Location = new System.Drawing.Point(13, 14);
            this.UserSearchTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserSearchTextbox.Name = "UserSearchTextbox";
            this.UserSearchTextbox.Size = new System.Drawing.Size(634, 32);
            this.UserSearchTextbox.TabIndex = 1;
            // 
            // RSUserPanel
            // 
            this.RSUserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RSUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RSUserPanel.Location = new System.Drawing.Point(13, 70);
            this.RSUserPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RSUserPanel.Name = "RSUserPanel";
            this.RSUserPanel.Size = new System.Drawing.Size(742, 241);
            this.RSUserPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserSearchTextbox);
            this.panel1.Controls.Add(this.RSUserPanel);
            this.panel1.Controls.Add(this.UserSearchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 326);
            this.panel1.TabIndex = 3;
            // 
            // UserSearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserSearchPanel";
            this.Size = new System.Drawing.Size(769, 326);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.TextBox UserSearchTextbox;
        private System.Windows.Forms.Panel RSUserPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
