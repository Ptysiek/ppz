
namespace ppz_fkmm.FrontSource.Pages
{
    partial class LoginPanel
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
            this.loginName = new System.Windows.Forms.TextBox();
            this.loginPass = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.RadioButton();
            this.loginShop = new System.Windows.Forms.RadioButton();
            this.loginBtnLogin = new System.Windows.Forms.Button();
            this.loginBtnRegister = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(156, 75);
            this.loginName.Margin = new System.Windows.Forms.Padding(4);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(145, 22);
            this.loginName.TabIndex = 0;
            // 
            // loginPass
            // 
            this.loginPass.Location = new System.Drawing.Point(156, 107);
            this.loginPass.Margin = new System.Windows.Forms.Padding(4);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(145, 22);
            this.loginPass.TabIndex = 1;
            // 
            // loginUser
            // 
            this.loginUser.AutoSize = true;
            this.loginUser.Location = new System.Drawing.Point(156, 139);
            this.loginUser.Margin = new System.Windows.Forms.Padding(4);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(97, 21);
            this.loginUser.TabIndex = 2;
            this.loginUser.TabStop = true;
            this.loginUser.Text = "użytkownik";
            this.loginUser.UseVisualStyleBackColor = true;
            // 
            // loginShop
            // 
            this.loginShop.AutoSize = true;
            this.loginShop.Location = new System.Drawing.Point(156, 167);
            this.loginShop.Margin = new System.Windows.Forms.Padding(4);
            this.loginShop.Name = "loginShop";
            this.loginShop.Size = new System.Drawing.Size(62, 21);
            this.loginShop.TabIndex = 3;
            this.loginShop.TabStop = true;
            this.loginShop.Text = "sklep";
            this.loginShop.UseVisualStyleBackColor = true;
            // 
            // loginBtnLogin
            // 
            this.loginBtnLogin.Location = new System.Drawing.Point(156, 213);
            this.loginBtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtnLogin.Name = "loginBtnLogin";
            this.loginBtnLogin.Size = new System.Drawing.Size(100, 28);
            this.loginBtnLogin.TabIndex = 4;
            this.loginBtnLogin.Text = "ZALOGUJ";
            this.loginBtnLogin.UseVisualStyleBackColor = true;
            this.loginBtnLogin.Click += new System.EventHandler(this.loginBtnLogin_Click);
            // 
            // loginBtnRegister
            // 
            this.loginBtnRegister.Location = new System.Drawing.Point(156, 249);
            this.loginBtnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtnRegister.Name = "loginBtnRegister";
            this.loginBtnRegister.Size = new System.Drawing.Size(121, 28);
            this.loginBtnRegister.TabIndex = 5;
            this.loginBtnRegister.Text = "ZAREJESTRUJ";
            this.loginBtnRegister.UseVisualStyleBackColor = true;
            this.loginBtnRegister.Click += new System.EventHandler(this.loginBtnRegister_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(69, 85);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(69, 116);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 17);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Hasło:";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(153, 192);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 17);
            this.ErrorText.TabIndex = 8;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.loginBtnRegister);
            this.Controls.Add(this.loginBtnLogin);
            this.Controls.Add(this.loginShop);
            this.Controls.Add(this.loginUser);
            this.Controls.Add(this.loginPass);
            this.Controls.Add(this.loginName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(504, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.TextBox loginPass;
        private System.Windows.Forms.RadioButton loginUser;
        private System.Windows.Forms.RadioButton loginShop;
        private System.Windows.Forms.Button loginBtnLogin;
        private System.Windows.Forms.Button loginBtnRegister;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label ErrorText;
    }
}
