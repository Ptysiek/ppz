
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
            this.registerBtnRegister = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRLogin = new System.Windows.Forms.Label();
            this.registerName = new System.Windows.Forms.TextBox();
            this.labelRPass = new System.Windows.Forms.Label();
            this.registerPass = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.registerBtnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registerUser = new System.Windows.Forms.RadioButton();
            this.registerShop = new System.Windows.Forms.RadioButton();
            this.labelRCity = new System.Windows.Forms.Label();
            this.registerCity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerBtnRegister
            // 
            this.registerBtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtnRegister.AutoSize = true;
            this.registerBtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerBtnRegister.Location = new System.Drawing.Point(3, 361);
            this.registerBtnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerBtnRegister.Name = "registerBtnRegister";
            this.registerBtnRegister.Size = new System.Drawing.Size(334, 46);
            this.registerBtnRegister.TabIndex = 4;
            this.registerBtnRegister.Text = "Register";
            this.registerBtnRegister.UseVisualStyleBackColor = true;
            this.registerBtnRegister.Click += new System.EventHandler(this.registerBtnRegister_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel2.Controls.Add(this.labelRLogin);
            this.flowLayoutPanel2.Controls.Add(this.registerName);
            this.flowLayoutPanel2.Controls.Add(this.labelRPass);
            this.flowLayoutPanel2.Controls.Add(this.registerPass);
            this.flowLayoutPanel2.Controls.Add(this.labelRCity);
            this.flowLayoutPanel2.Controls.Add(this.registerCity);
            this.flowLayoutPanel2.Controls.Add(this.registerUser);
            this.flowLayoutPanel2.Controls.Add(this.registerShop);
            this.flowLayoutPanel2.Controls.Add(this.errorText);
            this.flowLayoutPanel2.Controls.Add(this.registerBtnRegister);
            this.flowLayoutPanel2.Controls.Add(this.registerBtnCancel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(338, 508);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // labelRLogin
            // 
            this.labelRLogin.AutoSize = true;
            this.labelRLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.labelRLogin.ForeColor = System.Drawing.Color.Snow;
            this.labelRLogin.Location = new System.Drawing.Point(3, 0);
            this.labelRLogin.Name = "labelRLogin";
            this.labelRLogin.Size = new System.Drawing.Size(94, 32);
            this.labelRLogin.TabIndex = 6;
            this.labelRLogin.Text = "Login:";
            // 
            // registerName
            // 
            this.registerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.registerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerName.Location = new System.Drawing.Point(3, 36);
            this.registerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerName.MinimumSize = new System.Drawing.Size(334, 22);
            this.registerName.Name = "registerName";
            this.registerName.Size = new System.Drawing.Size(334, 39);
            this.registerName.TabIndex = 0;
            // 
            // labelRPass
            // 
            this.labelRPass.AutoSize = true;
            this.labelRPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.labelRPass.ForeColor = System.Drawing.Color.Snow;
            this.labelRPass.Location = new System.Drawing.Point(3, 79);
            this.labelRPass.Name = "labelRPass";
            this.labelRPass.Size = new System.Drawing.Size(147, 32);
            this.labelRPass.TabIndex = 7;
            this.labelRPass.Text = "Password:";
            // 
            // registerPass
            // 
            this.registerPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.registerPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerPass.Location = new System.Drawing.Point(3, 115);
            this.registerPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerPass.MinimumSize = new System.Drawing.Size(334, 22);
            this.registerPass.Name = "registerPass";
            this.registerPass.Size = new System.Drawing.Size(334, 39);
            this.registerPass.TabIndex = 1;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(3, 325);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 32);
            this.errorText.TabIndex = 8;
            // 
            // registerBtnCancel
            // 
            this.registerBtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtnCancel.AutoSize = true;
            this.registerBtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerBtnCancel.Location = new System.Drawing.Point(3, 414);
            this.registerBtnCancel.Name = "registerBtnCancel";
            this.registerBtnCancel.Size = new System.Drawing.Size(334, 46);
            this.registerBtnCancel.TabIndex = 5;
            this.registerBtnCancel.Text = "Cancel";
            this.registerBtnCancel.UseVisualStyleBackColor = true;
            this.registerBtnCancel.Click += new System.EventHandler(this.registerBtnCancel_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(4, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 516);
            this.panel2.TabIndex = 15;
            // 
            // registerUser
            // 
            this.registerUser.AutoSize = true;
            this.registerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerUser.ForeColor = System.Drawing.Color.Snow;
            this.registerUser.Location = new System.Drawing.Point(3, 241);
            this.registerUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerUser.Name = "registerUser";
            this.registerUser.Size = new System.Drawing.Size(95, 36);
            this.registerUser.TabIndex = 2;
            this.registerUser.TabStop = true;
            this.registerUser.Text = "User";
            this.registerUser.UseVisualStyleBackColor = true;
            // 
            // registerShop
            // 
            this.registerShop.AutoSize = true;
            this.registerShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerShop.ForeColor = System.Drawing.Color.Snow;
            this.registerShop.Location = new System.Drawing.Point(3, 285);
            this.registerShop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerShop.Name = "registerShop";
            this.registerShop.Size = new System.Drawing.Size(103, 36);
            this.registerShop.TabIndex = 3;
            this.registerShop.TabStop = true;
            this.registerShop.Text = "Shop";
            this.registerShop.UseVisualStyleBackColor = true;
            // 
            // labelRCity
            // 
            this.labelRCity.AutoSize = true;
            this.labelRCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.labelRCity.ForeColor = System.Drawing.Color.Snow;
            this.labelRCity.Location = new System.Drawing.Point(3, 158);
            this.labelRCity.Name = "labelRCity";
            this.labelRCity.Size = new System.Drawing.Size(72, 32);
            this.labelRCity.TabIndex = 9;
            this.labelRCity.Text = "City:";
            // 
            // registerCity
            // 
            this.registerCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.registerCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.registerCity.Location = new System.Drawing.Point(3, 194);
            this.registerCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerCity.MinimumSize = new System.Drawing.Size(334, 22);
            this.registerCity.Name = "registerCity";
            this.registerCity.Size = new System.Drawing.Size(334, 39);
            this.registerCity.TabIndex = 10;
            // 
            // RegisterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "RegisterPanel";
            this.Size = new System.Drawing.Size(351, 548);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registerBtnRegister;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelRLogin;
        private System.Windows.Forms.TextBox registerName;
        private System.Windows.Forms.Label labelRPass;
        private System.Windows.Forms.TextBox registerPass;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button registerBtnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton registerUser;
        private System.Windows.Forms.RadioButton registerShop;
        private System.Windows.Forms.Label labelRCity;
        private System.Windows.Forms.TextBox registerCity;
    }
}
