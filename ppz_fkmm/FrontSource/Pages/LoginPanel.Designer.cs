
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.loginName = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.loginPass = new System.Windows.Forms.TextBox();
            this.loginUser = new System.Windows.Forms.RadioButton();
            this.loginShop = new System.Windows.Forms.RadioButton();
            this.ErrorText = new System.Windows.Forms.Label();
            this.loginBtnLogin = new System.Windows.Forms.Button();
            this.loginBtnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.labelLogin);
            this.flowLayoutPanel1.Controls.Add(this.loginName);
            this.flowLayoutPanel1.Controls.Add(this.labelPass);
            this.flowLayoutPanel1.Controls.Add(this.loginPass);
            this.flowLayoutPanel1.Controls.Add(this.loginUser);
            this.flowLayoutPanel1.Controls.Add(this.loginShop);
            this.flowLayoutPanel1.Controls.Add(this.ErrorText);
            this.flowLayoutPanel1.Controls.Add(this.loginBtnLogin);
            this.flowLayoutPanel1.Controls.Add(this.loginBtnRegister);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 541);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.labelLogin.ForeColor = System.Drawing.Color.Snow;
            this.labelLogin.Location = new System.Drawing.Point(4, 0);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(94, 32);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login:";
            // 
            // loginName
            // 
            this.loginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.loginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginName.Location = new System.Drawing.Point(4, 36);
            this.loginName.Margin = new System.Windows.Forms.Padding(4);
            this.loginName.MinimumSize = new System.Drawing.Size(445, 22);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(445, 39);
            this.loginName.TabIndex = 0;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.labelPass.ForeColor = System.Drawing.Color.Snow;
            this.labelPass.Location = new System.Drawing.Point(4, 79);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(147, 32);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "Password:";
            // 
            // loginPass
            // 
            this.loginPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.loginPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginPass.Location = new System.Drawing.Point(4, 115);
            this.loginPass.Margin = new System.Windows.Forms.Padding(4);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(445, 39);
            this.loginPass.TabIndex = 1;
            // 
            // loginUser
            // 
            this.loginUser.AutoSize = true;
            this.loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginUser.ForeColor = System.Drawing.Color.Snow;
            this.loginUser.Location = new System.Drawing.Point(4, 162);
            this.loginUser.Margin = new System.Windows.Forms.Padding(4);
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(95, 36);
            this.loginUser.TabIndex = 2;
            this.loginUser.TabStop = true;
            this.loginUser.Text = "User";
            this.loginUser.UseVisualStyleBackColor = true;
            // 
            // loginShop
            // 
            this.loginShop.AutoSize = true;
            this.loginShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginShop.ForeColor = System.Drawing.Color.Snow;
            this.loginShop.Location = new System.Drawing.Point(4, 206);
            this.loginShop.Margin = new System.Windows.Forms.Padding(4);
            this.loginShop.Name = "loginShop";
            this.loginShop.Size = new System.Drawing.Size(103, 36);
            this.loginShop.TabIndex = 3;
            this.loginShop.TabStop = true;
            this.loginShop.Text = "Shop";
            this.loginShop.UseVisualStyleBackColor = true;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(4, 246);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 32);
            this.ErrorText.TabIndex = 8;
            // 
            // loginBtnLogin
            // 
            this.loginBtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtnLogin.AutoSize = true;
            this.loginBtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginBtnLogin.Location = new System.Drawing.Point(4, 282);
            this.loginBtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtnLogin.Name = "loginBtnLogin";
            this.loginBtnLogin.Size = new System.Drawing.Size(445, 42);
            this.loginBtnLogin.TabIndex = 4;
            this.loginBtnLogin.Text = "Log In";
            this.loginBtnLogin.UseVisualStyleBackColor = true;
            this.loginBtnLogin.Click += new System.EventHandler(this.loginBtnLogin_Click);
            // 
            // loginBtnRegister
            // 
            this.loginBtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtnRegister.AutoSize = true;
            this.loginBtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.loginBtnRegister.Location = new System.Drawing.Point(4, 332);
            this.loginBtnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtnRegister.Name = "loginBtnRegister";
            this.loginBtnRegister.Size = new System.Drawing.Size(445, 42);
            this.loginBtnRegister.TabIndex = 5;
            this.loginBtnRegister.Text = "Sign In";
            this.loginBtnRegister.UseVisualStyleBackColor = true;
            this.loginBtnRegister.Click += new System.EventHandler(this.loginBtnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 547);
            this.panel1.TabIndex = 11;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(489, 553);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox loginName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox loginPass;
        private System.Windows.Forms.RadioButton loginUser;
        private System.Windows.Forms.RadioButton loginShop;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Button loginBtnLogin;
        private System.Windows.Forms.Button loginBtnRegister;
        private System.Windows.Forms.Panel panel1;
    }
}
