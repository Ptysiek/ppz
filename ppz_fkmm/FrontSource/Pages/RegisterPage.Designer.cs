using System.Windows.Forms;
using ppz_fkmm.FrontSource.Components;


namespace ppz_fkmm.FrontSource.Pages
{
    partial class RegisterPage
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
            this.RegisterBtn = new ppz_fkmm.FrontSource.Components.GeneralButton();
            this.LogInBtn = new ppz_fkmm.FrontSource.Components.GeneralButton();
            this.Spacing = new System.Windows.Forms.Label();
            this.ConfPasswTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.ConfirmPasswdLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LogInBtn);
            this.flowLayoutPanel1.Controls.Add(this.RegisterBtn);
            this.flowLayoutPanel1.Controls.Add(this.Spacing);
            this.flowLayoutPanel1.Controls.Add(this.ConfPasswTxt);
            this.flowLayoutPanel1.Controls.Add(this.ConfirmPasswdLbl);
            this.flowLayoutPanel1.Controls.Add(this.PasswordTxt);
            this.flowLayoutPanel1.Controls.Add(this.PasswordLbl);
            this.flowLayoutPanel1.Controls.Add(this.UsernameTxt);
            this.flowLayoutPanel1.Controls.Add(this.UsernameLbl);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TitleLbl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(420, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(346, 476);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(23, 327);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(300, 50);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Sign up";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(23, 383);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(300, 50);
            this.LogInBtn.TabIndex = 4;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // Spacing
            // 
            this.Spacing.AutoSize = true;
            this.Spacing.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Spacing.Location = new System.Drawing.Point(23, 296);
            this.Spacing.Name = "Spacing";
            this.Spacing.Size = new System.Drawing.Size(0, 28);
            this.Spacing.TabIndex = 4;
            // 
            // ConfPasswTxt
            // 
            this.ConfPasswTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfPasswTxt.Location = new System.Drawing.Point(23, 271);
            this.ConfPasswTxt.Name = "ConfPasswTxt";
            this.ConfPasswTxt.PasswordChar = '*';
            this.ConfPasswTxt.Size = new System.Drawing.Size(300, 22);
            this.ConfPasswTxt.TabIndex = 2;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLbl.Location = new System.Drawing.Point(23, 184);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(116, 28);
            this.PasswordLbl.TabIndex = 5;
            this.PasswordLbl.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTxt.Location = new System.Drawing.Point(23, 215);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(300, 22);
            this.PasswordTxt.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsernameLbl.Location = new System.Drawing.Point(23, 128);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(123, 28);
            this.UsernameLbl.TabIndex = 6;
            this.UsernameLbl.Text = "Username";
            // 
            // ConfirmPasswdLbl
            // 
            this.ConfirmPasswdLbl.AutoSize = true;
            this.ConfirmPasswdLbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswdLbl.Location = new System.Drawing.Point(23, 240);
            this.ConfirmPasswdLbl.Name = "ConfirmPasswdLbl";
            this.ConfirmPasswdLbl.Size = new System.Drawing.Size(210, 28);
            this.ConfirmPasswdLbl.TabIndex = 8;
            this.ConfirmPasswdLbl.Text = "Confirm Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTxt.Location = new System.Drawing.Point(23, 159);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(300, 22);
            this.UsernameTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 10;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.TitleLbl.Location = new System.Drawing.Point(23, 30);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(140, 42);
            this.TitleLbl.TabIndex = 11;
            this.TitleLbl.Text = "Sign up";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RegisterPage";
            this.Size = new System.Drawing.Size(766, 476);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GeneralButton RegisterBtn;
        private GeneralButton LogInBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox ConfPasswTxt;
        private TextBox PasswordTxt;
        private Label Spacing;
        private Label PasswordLbl;
        private Label UsernameLbl;
        private Label ConfirmPasswdLbl;
        private TextBox UsernameTxt;
        private Label label2;
        private Label label1;
        private Label TitleLbl;
    }
}