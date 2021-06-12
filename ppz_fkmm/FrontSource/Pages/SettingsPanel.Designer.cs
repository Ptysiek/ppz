
namespace ppz_fkmm.FrontSource.Pages
{
    partial class SettingsPanel
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
            this.settingsBtnPass = new System.Windows.Forms.Button();
            this.settingsBtnAdress = new System.Windows.Forms.Button();
            this.settingsOldPass = new System.Windows.Forms.TextBox();
            this.settingsNewPass = new System.Windows.Forms.TextBox();
            this.settingsAdress = new System.Windows.Forms.TextBox();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelNewAdress = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsBtnPass
            // 
            this.settingsBtnPass.Location = new System.Drawing.Point(114, 86);
            this.settingsBtnPass.Name = "settingsBtnPass";
            this.settingsBtnPass.Size = new System.Drawing.Size(100, 23);
            this.settingsBtnPass.TabIndex = 0;
            this.settingsBtnPass.Text = "Zmień Hasło";
            this.settingsBtnPass.UseVisualStyleBackColor = true;
            // 
            // settingsBtnAdress
            // 
            this.settingsBtnAdress.Location = new System.Drawing.Point(114, 165);
            this.settingsBtnAdress.Name = "settingsBtnAdress";
            this.settingsBtnAdress.Size = new System.Drawing.Size(100, 23);
            this.settingsBtnAdress.TabIndex = 1;
            this.settingsBtnAdress.Text = "Zmień Adres";
            this.settingsBtnAdress.UseVisualStyleBackColor = true;
            // 
            // settingsOldPass
            // 
            this.settingsOldPass.Location = new System.Drawing.Point(114, 33);
            this.settingsOldPass.Name = "settingsOldPass";
            this.settingsOldPass.Size = new System.Drawing.Size(100, 20);
            this.settingsOldPass.TabIndex = 2;
            // 
            // settingsNewPass
            // 
            this.settingsNewPass.Location = new System.Drawing.Point(114, 59);
            this.settingsNewPass.Name = "settingsNewPass";
            this.settingsNewPass.Size = new System.Drawing.Size(100, 20);
            this.settingsNewPass.TabIndex = 4;
            // 
            // settingsAdress
            // 
            this.settingsAdress.Location = new System.Drawing.Point(114, 127);
            this.settingsAdress.Name = "settingsAdress";
            this.settingsAdress.Size = new System.Drawing.Size(100, 20);
            this.settingsAdress.TabIndex = 6;
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Location = new System.Drawing.Point(43, 36);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(65, 13);
            this.labelOldPass.TabIndex = 7;
            this.labelOldPass.Text = "Stare hasło:";
            // 
            // labelNewAdress
            // 
            this.labelNewAdress.AutoSize = true;
            this.labelNewAdress.Location = new System.Drawing.Point(43, 130);
            this.labelNewAdress.Name = "labelNewAdress";
            this.labelNewAdress.Size = new System.Drawing.Size(67, 13);
            this.labelNewAdress.TabIndex = 8;
            this.labelNewAdress.Text = "Nowy Adres:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(43, 62);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(68, 13);
            this.labelNewPass.TabIndex = 9;
            this.labelNewPass.Text = "Nowe hasło:";
            // 
            // SettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelNewAdress);
            this.Controls.Add(this.labelOldPass);
            this.Controls.Add(this.settingsAdress);
            this.Controls.Add(this.settingsNewPass);
            this.Controls.Add(this.settingsOldPass);
            this.Controls.Add(this.settingsBtnAdress);
            this.Controls.Add(this.settingsBtnPass);
            this.Name = "SettingsPanel";
            this.Size = new System.Drawing.Size(340, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsBtnPass;
        private System.Windows.Forms.Button settingsBtnAdress;
        private System.Windows.Forms.TextBox settingsOldPass;
        private System.Windows.Forms.TextBox settingsNewPass;
        private System.Windows.Forms.TextBox settingsAdress;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewAdress;
        private System.Windows.Forms.Label labelNewPass;
    }
}
