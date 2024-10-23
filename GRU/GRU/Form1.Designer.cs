namespace GRU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.giu = new Button();
            this.reset = new Button();
            pictureBox2 = new PictureBox();
            applica = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // su
            // 
            this.su.Image = Properties.Resources.download;
            this.su.Location = new Point(-94, -38);
            this.su.Name = "su";
            this.su.Size = new Size(509, 605);
            this.su.TabIndex = 0;
            this.su.UseVisualStyleBackColor = true;
            // 
            // giu
            // 
            this.giu.Image = Properties.Resources.Senza_titolo;
            this.giu.Location = new Point(-20, 565);
            this.giu.Name = "giu";
            this.giu.Size = new Size(435, 542);
            this.giu.TabIndex = 1;
            this.giu.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Image = Properties.Resources.download__2_;
            this.reset.Location = new Point(409, 900);
            this.reset.Name = "reset";
            this.reset.Size = new Size(257, 147);
            this.reset.TabIndex = 2;
            this.reset.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(978, 351);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 203);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // applica
            // 
            applica.Location = new Point(458, 296);
            applica.Name = "applica";
            applica.Size = new Size(146, 69);
            applica.TabIndex = 5;
            applica.Text = "applica";
            applica.UseVisualStyleBackColor = true;
            applica.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(applica);
            Controls.Add(pictureBox2);
            Controls.Add(this.reset);
            Controls.Add(this.giu);
            Controls.Add(this.su);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button applica;
    }
}