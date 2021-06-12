
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
            this.SuspendLayout();
            // 
            // loginName
            // 
            this.loginName.Location = new System.Drawing.Point(117, 61);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(110, 20);
            this.loginName.TabIndex = 0;
            // 
            // loginPass
            // 
            this.loginPass.Location = new System.Drawing.Point(117, 87);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(110, 20);
            this.loginPass.TabIndex = 1;
            // 
            // loginUser
            // 
            this.loginUser.AutoSize = true;
            this.loginUser.Location = new System.Drawing.Point(117, 113);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(78, 17);
            this.loginUser.TabIndex = 2;
            this.loginUser.TabStop = true;
            this.loginUser.Text = "użytkownik";
            this.loginUser.UseVisualStyleBackColor = true;
            // 
            // loginShop
            // 
            this.loginShop.AutoSize = true;
            this.loginShop.Location = new System.Drawing.Point(117, 136);
            this.loginShop.Name = "loginShop";
            this.loginShop.Size = new System.Drawing.Size(50, 17);
            this.loginShop.TabIndex = 3;
            this.loginShop.TabStop = true;
            this.loginShop.Text = "sklep";
            this.loginShop.UseVisualStyleBackColor = true;
            // 
            // loginBtnLogin
            // 
            this.loginBtnLogin.Location = new System.Drawing.Point(127, 170);
            this.loginBtnLogin.Name = "loginBtnLogin";
            this.loginBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.loginBtnLogin.TabIndex = 4;
            this.loginBtnLogin.Text = "ZALOGUJ";
            this.loginBtnLogin.UseVisualStyleBackColor = true;
            // 
            // loginBtnRegister
            // 
            this.loginBtnRegister.Location = new System.Drawing.Point(250, 257);
            this.loginBtnRegister.Name = "loginBtnRegister";
            this.loginBtnRegister.Size = new System.Drawing.Size(91, 23);
            this.loginBtnRegister.TabIndex = 5;
            this.loginBtnRegister.Text = "ZAREJESTRUJ";
            this.loginBtnRegister.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(52, 69);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(52, 94);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(39, 13);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Hasło:";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.loginBtnRegister);
            this.Controls.Add(this.loginBtnLogin);
            this.Controls.Add(this.loginShop);
            this.Controls.Add(this.loginUser);
            this.Controls.Add(this.loginPass);
            this.Controls.Add(this.loginName);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(378, 360);
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
    }
}
