
namespace ppz_fkmm.FrontSource.Pages
{
    partial class RegisterPanel
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
            this.registerName = new System.Windows.Forms.TextBox();
            this.registerAdress = new System.Windows.Forms.TextBox();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.registerPass = new System.Windows.Forms.TextBox();
            this.registerBtnRegister = new System.Windows.Forms.Button();
            this.registerBtnCancel = new System.Windows.Forms.Button();
            this.registerUser = new System.Windows.Forms.RadioButton();
            this.registerShop = new System.Windows.Forms.RadioButton();
            this.labelRLogin = new System.Windows.Forms.Label();
            this.labelRAdress = new System.Windows.Forms.Label();
            this.labelREmail = new System.Windows.Forms.Label();
            this.labelRPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerName
            // 
            this.registerName.Location = new System.Drawing.Point(175, 51);
            this.registerName.Name = "registerName";
            this.registerName.Size = new System.Drawing.Size(100, 20);
            this.registerName.TabIndex = 0;
            // 
            // registerAdress
            // 
            this.registerAdress.Location = new System.Drawing.Point(175, 129);
            this.registerAdress.Name = "registerAdress";
            this.registerAdress.Size = new System.Drawing.Size(100, 20);
            this.registerAdress.TabIndex = 1;
            // 
            // registerEmail
            // 
            this.registerEmail.Location = new System.Drawing.Point(175, 103);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(100, 20);
            this.registerEmail.TabIndex = 2;
            // 
            // registerPass
            // 
            this.registerPass.Location = new System.Drawing.Point(175, 77);
            this.registerPass.Name = "registerPass";
            this.registerPass.Size = new System.Drawing.Size(100, 20);
            this.registerPass.TabIndex = 3;
            // 
            // registerBtnRegister
            // 
            this.registerBtnRegister.Location = new System.Drawing.Point(124, 250);
            this.registerBtnRegister.Name = "registerBtnRegister";
            this.registerBtnRegister.Size = new System.Drawing.Size(75, 23);
            this.registerBtnRegister.TabIndex = 4;
            this.registerBtnRegister.Text = "ZAREJESTRUJ";
            this.registerBtnRegister.UseVisualStyleBackColor = true;
            // 
            // registerBtnCancel
            // 
            this.registerBtnCancel.Location = new System.Drawing.Point(233, 250);
            this.registerBtnCancel.Name = "registerBtnCancel";
            this.registerBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.registerBtnCancel.TabIndex = 5;
            this.registerBtnCancel.Text = "Anuluj";
            this.registerBtnCancel.UseVisualStyleBackColor = true;
            // 
            // registerUser
            // 
            this.registerUser.AutoSize = true;
            this.registerUser.Location = new System.Drawing.Point(175, 168);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(78, 17);
            this.registerUser.TabIndex = 6;
            this.registerUser.TabStop = true;
            this.registerUser.Text = "użytkownik";
            this.registerUser.UseVisualStyleBackColor = true;
            // 
            // registerShop
            // 
            this.registerShop.AutoSize = true;
            this.registerShop.Location = new System.Drawing.Point(175, 191);
            this.registerShop.Name = "registerShop";
            this.registerShop.Size = new System.Drawing.Size(50, 17);
            this.registerShop.TabIndex = 7;
            this.registerShop.TabStop = true;
            this.registerShop.Text = "sklep";
            this.registerShop.UseVisualStyleBackColor = true;
            // 
            // labelRLogin
            // 
            this.labelRLogin.AutoSize = true;
            this.labelRLogin.Location = new System.Drawing.Point(121, 54);
            this.labelRLogin.Name = "labelRLogin";
            this.labelRLogin.Size = new System.Drawing.Size(36, 13);
            this.labelRLogin.TabIndex = 8;
            this.labelRLogin.Text = "Login:";
            // 
            // labelRAdress
            // 
            this.labelRAdress.AutoSize = true;
            this.labelRAdress.Location = new System.Drawing.Point(121, 132);
            this.labelRAdress.Name = "labelRAdress";
            this.labelRAdress.Size = new System.Drawing.Size(37, 13);
            this.labelRAdress.TabIndex = 9;
            this.labelRAdress.Text = "Adres:";
            // 
            // labelREmail
            // 
            this.labelREmail.AutoSize = true;
            this.labelREmail.Location = new System.Drawing.Point(121, 106);
            this.labelREmail.Name = "labelREmail";
            this.labelREmail.Size = new System.Drawing.Size(35, 13);
            this.labelREmail.TabIndex = 10;
            this.labelREmail.Text = "Email:";
            // 
            // labelRPass
            // 
            this.labelRPass.AutoSize = true;
            this.labelRPass.Location = new System.Drawing.Point(121, 80);
            this.labelRPass.Name = "labelRPass";
            this.labelRPass.Size = new System.Drawing.Size(39, 13);
            this.labelRPass.TabIndex = 11;
            this.labelRPass.Text = "Hasło:";
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRPass);
            this.Controls.Add(this.labelREmail);
            this.Controls.Add(this.labelRAdress);
            this.Controls.Add(this.labelRLogin);
            this.Controls.Add(this.registerShop);
            this.Controls.Add(this.registerUser);
            this.Controls.Add(this.registerBtnCancel);
            this.Controls.Add(this.registerBtnRegister);
            this.Controls.Add(this.registerPass);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.registerAdress);
            this.Controls.Add(this.registerName);
            this.Name = "RegisterPanel";
            this.Size = new System.Drawing.Size(508, 428);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registerName;
        private System.Windows.Forms.TextBox registerAdress;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.TextBox registerPass;
        private System.Windows.Forms.Button registerBtnRegister;
        private System.Windows.Forms.Button registerBtnCancel;
        private System.Windows.Forms.RadioButton registerUser;
        private System.Windows.Forms.RadioButton registerShop;
        private System.Windows.Forms.Label labelRLogin;
        private System.Windows.Forms.Label labelRAdress;
        private System.Windows.Forms.Label labelREmail;
        private System.Windows.Forms.Label labelRPass;
    }
}
