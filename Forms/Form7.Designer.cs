
namespace _19021414.Forms
{
    partial class Form7
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
            this.btnPNG = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.btnBMP = new System.Windows.Forms.Button();
            this.btnGIF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPNG
            // 
            this.btnPNG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPNG.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPNG.Location = new System.Drawing.Point(20, 431);
            this.btnPNG.Name = "btnPNG";
            this.btnPNG.Size = new System.Drawing.Size(173, 37);
            this.btnPNG.TabIndex = 26;
            this.btnPNG.Text = "PNG";
            this.btnPNG.UseVisualStyleBackColor = true;
            this.btnPNG.Click += new System.EventHandler(this.btnPNG_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(606, 342);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 37);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "Show Image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(70, 344);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 35);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pathBox
            // 
            this.pathBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathBox.Location = new System.Drawing.Point(208, 344);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(336, 35);
            this.pathBox.TabIndex = 27;
            // 
            // btnJPEG
            // 
            this.btnJPEG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJPEG.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJPEG.Location = new System.Drawing.Point(221, 431);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(173, 37);
            this.btnJPEG.TabIndex = 28;
            this.btnJPEG.Text = "JPEG";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // btnBMP
            // 
            this.btnBMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBMP.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMP.Location = new System.Drawing.Point(415, 431);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(173, 37);
            this.btnBMP.TabIndex = 29;
            this.btnBMP.Text = "BMP";
            this.btnBMP.UseVisualStyleBackColor = true;
            this.btnBMP.Click += new System.EventHandler(this.btnBMP_Click);
            // 
            // btnGIF
            // 
            this.btnGIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGIF.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGIF.Location = new System.Drawing.Point(606, 431);
            this.btnGIF.Name = "btnGIF";
            this.btnGIF.Size = new System.Drawing.Size(173, 37);
            this.btnGIF.TabIndex = 30;
            this.btnGIF.Text = "GIF";
            this.btnGIF.UseVisualStyleBackColor = true;
            this.btnGIF.Click += new System.EventHandler(this.btnGIF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 301);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 496);
            this.Controls.Add(this.btnGIF);
            this.Controls.Add(this.btnBMP);
            this.Controls.Add(this.btnJPEG);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.btnPNG);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form7";
            this.Text = "File Convertor";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPNG;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button btnJPEG;
        private System.Windows.Forms.Button btnBMP;
        private System.Windows.Forms.Button btnGIF;
    }
}