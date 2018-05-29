namespace PONGY
{
    partial class SaveName
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IngresedName = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.PictureBox();
            this.WinnerImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoneButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresedName
            // 
            this.IngresedName.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.IngresedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IngresedName.Font = new System.Drawing.Font("Monaco for Powerline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresedName.ForeColor = System.Drawing.Color.Black;
            this.IngresedName.Location = new System.Drawing.Point(199, 205);
            this.IngresedName.MaxLength = 20;
            this.IngresedName.Name = "IngresedName";
            this.IngresedName.Size = new System.Drawing.Size(302, 42);
            this.IngresedName.TabIndex = 0;
            this.IngresedName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImage = global::PONGY.Properties.Resources.DoneButton;
            this.DoneButton.Location = new System.Drawing.Point(274, 293);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(132, 46);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.TabStop = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // WinnerImg
            // 
            this.WinnerImg.BackColor = System.Drawing.Color.Transparent;
            this.WinnerImg.Location = new System.Drawing.Point(69, 45);
            this.WinnerImg.Name = "WinnerImg";
            this.WinnerImg.Size = new System.Drawing.Size(540, 111);
            this.WinnerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WinnerImg.TabIndex = 2;
            this.WinnerImg.TabStop = false;
            // 
            // SaveName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PONGY.Properties.Resources.FondoVictory;
            this.ClientSize = new System.Drawing.Size(674, 380);
            this.Controls.Add(this.WinnerImg);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.IngresedName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveName";
            ((System.ComponentModel.ISupportInitialize)(this.DoneButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinnerImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IngresedName;
        private System.Windows.Forms.PictureBox DoneButton;
        private System.Windows.Forms.PictureBox WinnerImg;
    }
}