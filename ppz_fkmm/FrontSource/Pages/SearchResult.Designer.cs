
namespace ppz_fkmm.FrontSource.Pages
{
    partial class SearchResult
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
            this.ResultName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlcCapacity = new System.Windows.Forms.Label();
            this.AlcValue = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultName
            // 
            this.ResultName.AutoSize = true;
            this.ResultName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultName.ForeColor = System.Drawing.Color.Red;
            this.ResultName.Location = new System.Drawing.Point(3, 15);
            this.ResultName.Name = "ResultName";
            this.ResultName.Size = new System.Drawing.Size(62, 20);
            this.ResultName.TabIndex = 0;
            this.ResultName.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pojemność";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "procent";
            // 
            // AlcCapacity
            // 
            this.AlcCapacity.AutoSize = true;
            this.AlcCapacity.Location = new System.Drawing.Point(71, 37);
            this.AlcCapacity.Name = "AlcCapacity";
            this.AlcCapacity.Size = new System.Drawing.Size(26, 13);
            this.AlcCapacity.TabIndex = 4;
            this.AlcCapacity.Text = "0 ml";
            // 
            // AlcValue
            // 
            this.AlcValue.AutoSize = true;
            this.AlcValue.Location = new System.Drawing.Point(71, 59);
            this.AlcValue.Name = "AlcValue";
            this.AlcValue.Size = new System.Drawing.Size(30, 13);
            this.AlcValue.TabIndex = 5;
            this.AlcValue.Text = "0.0%";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(10, 99);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(58, 13);
            this.Description.TabIndex = 6;
            this.Description.Text = "treść opisu";
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Description);
            this.Controls.Add(this.AlcValue);
            this.Controls.Add(this.AlcCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultName);
            this.Name = "SearchResult";
            this.Size = new System.Drawing.Size(619, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AlcCapacity;
        private System.Windows.Forms.Label AlcValue;
        private System.Windows.Forms.Label Description;
    }
}
