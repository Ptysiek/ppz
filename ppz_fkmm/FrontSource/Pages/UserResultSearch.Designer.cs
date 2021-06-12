
namespace ppz_fkmm.FrontSource.Pages
{
    partial class UserResultSearch
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
            this.RSUserBeerName = new System.Windows.Forms.Label();
            this.labeluvolume = new System.Windows.Forms.Label();
            this.RSUserVolume = new System.Windows.Forms.Label();
            this.labelupercentage = new System.Windows.Forms.Label();
            this.labelMl = new System.Windows.Forms.Label();
            this.RSUserPercentage = new System.Windows.Forms.Label();
            this.labeludescrip = new System.Windows.Forms.Label();
            this.labelpercent = new System.Windows.Forms.Label();
            this.RSUserDescription = new System.Windows.Forms.Label();
            this.RSUserAddBeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RSUserBeerName
            // 
            this.RSUserBeerName.AutoSize = true;
            this.RSUserBeerName.Location = new System.Drawing.Point(3, 17);
            this.RSUserBeerName.Name = "RSUserBeerName";
            this.RSUserBeerName.Size = new System.Drawing.Size(40, 13);
            this.RSUserBeerName.TabIndex = 0;
            this.RSUserBeerName.Text = "Nazwa";
            // 
            // labeluvolume
            // 
            this.labeluvolume.AutoSize = true;
            this.labeluvolume.Location = new System.Drawing.Point(3, 40);
            this.labeluvolume.Name = "labeluvolume";
            this.labeluvolume.Size = new System.Drawing.Size(62, 13);
            this.labeluvolume.TabIndex = 1;
            this.labeluvolume.Text = "Pojemność:";
            // 
            // RSUserVolume
            // 
            this.RSUserVolume.AutoSize = true;
            this.RSUserVolume.Location = new System.Drawing.Point(71, 40);
            this.RSUserVolume.Name = "RSUserVolume";
            this.RSUserVolume.Size = new System.Drawing.Size(13, 13);
            this.RSUserVolume.TabIndex = 2;
            this.RSUserVolume.Text = "0";
            // 
            // labelupercentage
            // 
            this.labelupercentage.AutoSize = true;
            this.labelupercentage.Location = new System.Drawing.Point(3, 53);
            this.labelupercentage.Name = "labelupercentage";
            this.labelupercentage.Size = new System.Drawing.Size(47, 13);
            this.labelupercentage.TabIndex = 3;
            this.labelupercentage.Text = "Procent:";
            // 
            // labelMl
            // 
            this.labelMl.AutoSize = true;
            this.labelMl.Location = new System.Drawing.Point(112, 40);
            this.labelMl.Name = "labelMl";
            this.labelMl.Size = new System.Drawing.Size(17, 13);
            this.labelMl.TabIndex = 4;
            this.labelMl.Text = "ml";
            // 
            // RSUserPercentage
            // 
            this.RSUserPercentage.AutoSize = true;
            this.RSUserPercentage.Location = new System.Drawing.Point(71, 53);
            this.RSUserPercentage.Name = "RSUserPercentage";
            this.RSUserPercentage.Size = new System.Drawing.Size(22, 13);
            this.RSUserPercentage.TabIndex = 5;
            this.RSUserPercentage.Text = "0.0";
            // 
            // labeludescrip
            // 
            this.labeludescrip.AutoSize = true;
            this.labeludescrip.Location = new System.Drawing.Point(3, 86);
            this.labeludescrip.Name = "labeludescrip";
            this.labeludescrip.Size = new System.Drawing.Size(28, 13);
            this.labeludescrip.TabIndex = 6;
            this.labeludescrip.Text = "Opis";
            // 
            // labelpercent
            // 
            this.labelpercent.AutoSize = true;
            this.labelpercent.Location = new System.Drawing.Point(112, 53);
            this.labelpercent.Name = "labelpercent";
            this.labelpercent.Size = new System.Drawing.Size(15, 13);
            this.labelpercent.TabIndex = 7;
            this.labelpercent.Text = "%";
            // 
            // RSUserDescription
            // 
            this.RSUserDescription.AutoSize = true;
            this.RSUserDescription.Location = new System.Drawing.Point(3, 99);
            this.RSUserDescription.Name = "RSUserDescription";
            this.RSUserDescription.Size = new System.Drawing.Size(10, 13);
            this.RSUserDescription.TabIndex = 8;
            this.RSUserDescription.Text = ".";
            // 
            // RSUserAddBeer
            // 
            this.RSUserAddBeer.Location = new System.Drawing.Point(314, 12);
            this.RSUserAddBeer.Name = "RSUserAddBeer";
            this.RSUserAddBeer.Size = new System.Drawing.Size(113, 23);
            this.RSUserAddBeer.TabIndex = 9;
            this.RSUserAddBeer.Text = "Dodaj do ulubionych";
            this.RSUserAddBeer.UseVisualStyleBackColor = true;
            // 
            // UserResultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RSUserAddBeer);
            this.Controls.Add(this.RSUserDescription);
            this.Controls.Add(this.labelpercent);
            this.Controls.Add(this.labeludescrip);
            this.Controls.Add(this.RSUserPercentage);
            this.Controls.Add(this.labelMl);
            this.Controls.Add(this.labelupercentage);
            this.Controls.Add(this.RSUserVolume);
            this.Controls.Add(this.labeluvolume);
            this.Controls.Add(this.RSUserBeerName);
            this.Name = "UserResultSearch";
            this.Size = new System.Drawing.Size(450, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RSUserBeerName;
        private System.Windows.Forms.Label labeluvolume;
        private System.Windows.Forms.Label RSUserVolume;
        private System.Windows.Forms.Label labelupercentage;
        private System.Windows.Forms.Label labelMl;
        private System.Windows.Forms.Label RSUserPercentage;
        private System.Windows.Forms.Label labeludescrip;
        private System.Windows.Forms.Label labelpercent;
        private System.Windows.Forms.Label RSUserDescription;
        private System.Windows.Forms.Button RSUserAddBeer;
    }
}
