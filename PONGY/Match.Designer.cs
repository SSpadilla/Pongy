namespace PONGY
{
    partial class Match
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
            this.components = new System.ComponentModel.Container();
            this.LeftRacket = new System.Windows.Forms.PictureBox();
            this.RightRacket = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.LeftMarker = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RightMarker = new System.Windows.Forms.Label();
            this.RightAcMarker = new System.Windows.Forms.Label();
            this.LeftAcMarker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftRacket
            // 
            this.LeftRacket.BackColor = System.Drawing.Color.Transparent;
            this.LeftRacket.Image = global::PONGY.Properties.Resources.RaquetaIzquierda;
            this.LeftRacket.Location = new System.Drawing.Point(40, 235);
            this.LeftRacket.Name = "LeftRacket";
            this.LeftRacket.Size = new System.Drawing.Size(12, 73);
            this.LeftRacket.TabIndex = 0;
            this.LeftRacket.TabStop = false;
            // 
            // RightRacket
            // 
            this.RightRacket.BackColor = System.Drawing.Color.Transparent;
            this.RightRacket.BackgroundImage = global::PONGY.Properties.Resources.RaquetaDerecha;
            this.RightRacket.Location = new System.Drawing.Point(900, 248);
            this.RightRacket.Name = "RightRacket";
            this.RightRacket.Size = new System.Drawing.Size(12, 66);
            this.RightRacket.TabIndex = 1;
            this.RightRacket.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::PONGY.Properties.Resources.Bola;
            this.Ball.Location = new System.Drawing.Point(461, 247);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(40, 40);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // LeftMarker
            // 
            this.LeftMarker.AutoSize = true;
            this.LeftMarker.BackColor = System.Drawing.Color.Transparent;
            this.LeftMarker.Font = new System.Drawing.Font("Monaco for Powerline", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMarker.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.LeftMarker.Location = new System.Drawing.Point(164, -4);
            this.LeftMarker.Name = "LeftMarker";
            this.LeftMarker.Size = new System.Drawing.Size(84, 105);
            this.LeftMarker.TabIndex = 3;
            this.LeftMarker.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RightMarker
            // 
            this.RightMarker.AutoSize = true;
            this.RightMarker.BackColor = System.Drawing.Color.Transparent;
            this.RightMarker.Font = new System.Drawing.Font("Monaco for Powerline", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightMarker.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.RightMarker.Location = new System.Drawing.Point(671, -4);
            this.RightMarker.Name = "RightMarker";
            this.RightMarker.Size = new System.Drawing.Size(84, 105);
            this.RightMarker.TabIndex = 4;
            this.RightMarker.Text = "0";
            // 
            // RightAcMarker
            // 
            this.RightAcMarker.AutoSize = true;
            this.RightAcMarker.BackColor = System.Drawing.Color.Transparent;
            this.RightAcMarker.Font = new System.Drawing.Font("Monaco for Powerline", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightAcMarker.ForeColor = System.Drawing.Color.Teal;
            this.RightAcMarker.Location = new System.Drawing.Point(728, 55);
            this.RightAcMarker.Name = "RightAcMarker";
            this.RightAcMarker.Size = new System.Drawing.Size(22, 26);
            this.RightAcMarker.TabIndex = 5;
            this.RightAcMarker.Text = "0";
            // 
            // LeftAcMarker
            // 
            this.LeftAcMarker.AutoSize = true;
            this.LeftAcMarker.BackColor = System.Drawing.Color.Transparent;
            this.LeftAcMarker.Font = new System.Drawing.Font("Monaco for Powerline", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftAcMarker.ForeColor = System.Drawing.Color.Teal;
            this.LeftAcMarker.Location = new System.Drawing.Point(160, 55);
            this.LeftAcMarker.Name = "LeftAcMarker";
            this.LeftAcMarker.Size = new System.Drawing.Size(0, 26);
            this.LeftAcMarker.TabIndex = 6;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PONGY.Properties.Resources.FondoPartido;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.RightRacket);
            this.Controls.Add(this.LeftRacket);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.LeftAcMarker);
            this.Controls.Add(this.RightAcMarker);
            this.Controls.Add(this.RightMarker);
            this.Controls.Add(this.LeftMarker);
            this.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Match";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Match_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Match_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.LeftRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftRacket;
        private System.Windows.Forms.PictureBox RightRacket;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label LeftMarker;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label RightMarker;
        private System.Windows.Forms.Label RightAcMarker;
        private System.Windows.Forms.Label LeftAcMarker;
    }
}