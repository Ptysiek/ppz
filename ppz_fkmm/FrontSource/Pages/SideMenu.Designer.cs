
namespace ppz_fkmm.FrontSource.Pages
{
    partial class SideMenu
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
            this.MenuPiwoSzukaj = new System.Windows.Forms.Button();
            this.MenuTwojePiwa = new System.Windows.Forms.Button();
            this.MenuNews = new System.Windows.Forms.Button();
            this.MenuUstawienia = new System.Windows.Forms.Button();
            this.MenuLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuPiwoSzukaj
            // 
            this.MenuPiwoSzukaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPiwoSzukaj.BackColor = System.Drawing.Color.Purple;
            this.MenuPiwoSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuPiwoSzukaj.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuPiwoSzukaj.Location = new System.Drawing.Point(3, 3);
            this.MenuPiwoSzukaj.Name = "MenuPiwoSzukaj";
            this.MenuPiwoSzukaj.Size = new System.Drawing.Size(325, 70);
            this.MenuPiwoSzukaj.TabIndex = 0;
            this.MenuPiwoSzukaj.Text = "Wyszukiwanie piw";
            this.MenuPiwoSzukaj.UseVisualStyleBackColor = false;
            // 
            // MenuTwojePiwa
            // 
            this.MenuTwojePiwa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuTwojePiwa.BackColor = System.Drawing.Color.Purple;
            this.MenuTwojePiwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuTwojePiwa.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuTwojePiwa.Location = new System.Drawing.Point(3, 79);
            this.MenuTwojePiwa.Name = "MenuTwojePiwa";
            this.MenuTwojePiwa.Size = new System.Drawing.Size(325, 76);
            this.MenuTwojePiwa.TabIndex = 1;
            this.MenuTwojePiwa.Text = "Twoje piwa";
            this.MenuTwojePiwa.UseVisualStyleBackColor = false;
            // 
            // MenuNews
            // 
            this.MenuNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuNews.BackColor = System.Drawing.Color.Purple;
            this.MenuNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuNews.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuNews.Location = new System.Drawing.Point(3, 161);
            this.MenuNews.Name = "MenuNews";
            this.MenuNews.Size = new System.Drawing.Size(325, 66);
            this.MenuNews.TabIndex = 2;
            this.MenuNews.Text = "News";
            this.MenuNews.UseVisualStyleBackColor = false;
            // 
            // MenuUstawienia
            // 
            this.MenuUstawienia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuUstawienia.BackColor = System.Drawing.Color.Purple;
            this.MenuUstawienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuUstawienia.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuUstawienia.Location = new System.Drawing.Point(3, 233);
            this.MenuUstawienia.Name = "MenuUstawienia";
            this.MenuUstawienia.Size = new System.Drawing.Size(325, 68);
            this.MenuUstawienia.TabIndex = 3;
            this.MenuUstawienia.Text = "Ustawienia";
            this.MenuUstawienia.UseVisualStyleBackColor = false;
            // 
            // MenuLogout
            // 
            this.MenuLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuLogout.BackColor = System.Drawing.Color.Purple;
            this.MenuLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MenuLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuLogout.Location = new System.Drawing.Point(3, 307);
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(325, 70);
            this.MenuLogout.TabIndex = 4;
            this.MenuLogout.Text = "Wyloguj";
            this.MenuLogout.UseVisualStyleBackColor = false;
            // 
            // SideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MenuLogout);
            this.Controls.Add(this.MenuUstawienia);
            this.Controls.Add(this.MenuNews);
            this.Controls.Add(this.MenuTwojePiwa);
            this.Controls.Add(this.MenuPiwoSzukaj);
            this.Name = "SideMenu";
            this.Size = new System.Drawing.Size(331, 382);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MenuPiwoSzukaj;
        private System.Windows.Forms.Button MenuTwojePiwa;
        private System.Windows.Forms.Button MenuNews;
        private System.Windows.Forms.Button MenuUstawienia;
        private System.Windows.Forms.Button MenuLogout;
    }
}
