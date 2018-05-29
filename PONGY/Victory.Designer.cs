namespace PONGY
{
    partial class Victory
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
            this.ContinueButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.VictoryName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContinueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryName)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.Transparent;
            this.ContinueButton.Image = global::PONGY.Properties.Resources.ContinueButton;
            this.ContinueButton.Location = new System.Drawing.Point(268, 275);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(160, 35);
            this.ContinueButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.TabStop = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = global::PONGY.Properties.Resources.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(300, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 35);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // VictoryName
            // 
            this.VictoryName.BackColor = System.Drawing.Color.Transparent;
            this.VictoryName.Location = new System.Drawing.Point(55, 65);
            this.VictoryName.Name = "VictoryName";
            this.VictoryName.Size = new System.Drawing.Size(582, 140);
            this.VictoryName.TabIndex = 2;
            this.VictoryName.TabStop = false;
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PONGY.Properties.Resources.FondoVictory;
            this.ClientSize = new System.Drawing.Size(674, 380);
            this.Controls.Add(this.VictoryName);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ContinueButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Victory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victory";
            ((System.ComponentModel.ISupportInitialize)(this.ContinueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VictoryName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ContinueButton;
        private System.Windows.Forms.PictureBox ExitButton;
        private System.Windows.Forms.PictureBox VictoryName;
    }
}