namespace Othello
{
    partial class main
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            im1 = new System.Windows.Forms.ImageList(components);
            label64 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            lb_player = new System.Windows.Forms.Label();
            lb_white = new System.Windows.Forms.Label();
            lb_black = new System.Windows.Forms.Label();
            lb_bc = new System.Windows.Forms.Label();
            lb_wc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // im1
            // 
            im1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            im1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("im1.ImageStream");
            im1.TransparentColor = System.Drawing.Color.Transparent;
            im1.Images.SetKeyName(0, "black.png");
            im1.Images.SetKeyName(1, "white.png");
            // 
            // label64
            // 
            label64.BackColor = System.Drawing.Color.FromArgb(26, 26, 26);
            label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label64.Location = new System.Drawing.Point(122, 53);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(500, 500);
            label64.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(245, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(14, 14);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
            pictureBox2.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(485, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(14, 14);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Location = new System.Drawing.Point(245, 415);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(14, 14);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
            pictureBox4.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox4.Location = new System.Drawing.Point(485, 415);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(14, 14);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lb_player
            // 
            lb_player.AutoSize = true;
            lb_player.BackColor = System.Drawing.Color.Transparent;
            lb_player.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_player.ForeColor = System.Drawing.Color.White;
            lb_player.Location = new System.Drawing.Point(287, 567);
            lb_player.Name = "lb_player";
            lb_player.Size = new System.Drawing.Size(167, 45);
            lb_player.TabIndex = 3;
            lb_player.Text = "1플레이어\r\n";
            lb_player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_white
            // 
            lb_white.BackColor = System.Drawing.Color.Transparent;
            lb_white.ImageList = im1;
            lb_white.Location = new System.Drawing.Point(562, 568);
            lb_white.Name = "lb_white";
            lb_white.Size = new System.Drawing.Size(60, 60);
            lb_white.TabIndex = 4;
            // 
            // lb_black
            // 
            lb_black.BackColor = System.Drawing.Color.Transparent;
            lb_black.ImageIndex = 0;
            lb_black.ImageList = im1;
            lb_black.Location = new System.Drawing.Point(122, 568);
            lb_black.Name = "lb_black";
            lb_black.Size = new System.Drawing.Size(60, 60);
            lb_black.TabIndex = 4;
            // 
            // lb_bc
            // 
            lb_bc.AutoSize = true;
            lb_bc.BackColor = System.Drawing.Color.Transparent;
            lb_bc.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_bc.ForeColor = System.Drawing.Color.White;
            lb_bc.Location = new System.Drawing.Point(201, 568);
            lb_bc.Name = "lb_bc";
            lb_bc.Size = new System.Drawing.Size(0, 45);
            lb_bc.TabIndex = 3;
            lb_bc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_wc
            // 
            lb_wc.AutoSize = true;
            lb_wc.BackColor = System.Drawing.Color.Transparent;
            lb_wc.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_wc.ForeColor = System.Drawing.Color.White;
            lb_wc.Location = new System.Drawing.Point(485, 567);
            lb_wc.Name = "lb_wc";
            lb_wc.Size = new System.Drawing.Size(0, 45);
            lb_wc.TabIndex = 3;
            lb_wc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(734, 661);
            Controls.Add(lb_black);
            Controls.Add(lb_white);
            Controls.Add(lb_wc);
            Controls.Add(lb_bc);
            Controls.Add(lb_player);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label64);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximumSize = new System.Drawing.Size(750, 700);
            MinimumSize = new System.Drawing.Size(750, 700);
            Name = "main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Othello";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            startSetting();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ImageList im1;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_player;
        private System.Windows.Forms.Label lb_white;
        private System.Windows.Forms.Label lb_black;
        private System.Windows.Forms.Label lb_bc;
        private System.Windows.Forms.Label lb_wc;
    }
}
