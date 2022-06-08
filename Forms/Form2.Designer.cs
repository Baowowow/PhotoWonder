
namespace _19021414.Forms
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.RBut = new System.Windows.Forms.RadioButton();
            this.Gbut = new System.Windows.Forms.RadioButton();
            this.Bbut = new System.Windows.Forms.RadioButton();
            this.RGBbut = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnRGB = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 301);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Location = new System.Drawing.Point(415, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 301);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpen.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(24, 342);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(107, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(24, 392);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 37);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pathBox
            // 
            this.pathBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathBox.Location = new System.Drawing.Point(146, 342);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(336, 35);
            this.pathBox.TabIndex = 4;
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // RBut
            // 
            this.RBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBut.AutoSize = true;
            this.RBut.Location = new System.Drawing.Point(415, 400);
            this.RBut.Name = "RBut";
            this.RBut.Size = new System.Drawing.Size(39, 21);
            this.RBut.TabIndex = 5;
            this.RBut.Text = "R";
            this.RBut.UseVisualStyleBackColor = true;
            this.RBut.CheckedChanged += new System.EventHandler(this.RBut_CheckedChanged);
            // 
            // Gbut
            // 
            this.Gbut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gbut.AutoSize = true;
            this.Gbut.Location = new System.Drawing.Point(480, 400);
            this.Gbut.Name = "Gbut";
            this.Gbut.Size = new System.Drawing.Size(40, 21);
            this.Gbut.TabIndex = 6;
            this.Gbut.Text = "G";
            this.Gbut.UseVisualStyleBackColor = true;
            this.Gbut.CheckedChanged += new System.EventHandler(this.Gbut_CheckedChanged);
            // 
            // Bbut
            // 
            this.Bbut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bbut.AutoSize = true;
            this.Bbut.Location = new System.Drawing.Point(552, 400);
            this.Bbut.Name = "Bbut";
            this.Bbut.Size = new System.Drawing.Size(38, 21);
            this.Bbut.TabIndex = 7;
            this.Bbut.Text = "B";
            this.Bbut.UseVisualStyleBackColor = true;
            this.Bbut.CheckedChanged += new System.EventHandler(this.Bbut_CheckedChanged);
            // 
            // RGBbut
            // 
            this.RGBbut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RGBbut.AutoSize = true;
            this.RGBbut.Checked = true;
            this.RGBbut.Location = new System.Drawing.Point(608, 400);
            this.RGBbut.Name = "RGBbut";
            this.RGBbut.Size = new System.Drawing.Size(59, 21);
            this.RGBbut.TabIndex = 8;
            this.RGBbut.TabStop = true;
            this.RGBbut.Text = "RGB";
            this.RGBbut.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDel.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(24, 447);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 37);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete Image";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGray
            // 
            this.btnGray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGray.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.Location = new System.Drawing.Point(200, 447);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(173, 37);
            this.btnGray.TabIndex = 10;
            this.btnGray.Text = "Convert to Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnRGB
            // 
            this.btnRGB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRGB.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRGB.Location = new System.Drawing.Point(200, 392);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(173, 37);
            this.btnRGB.TabIndex = 11;
            this.btnRGB.Text = "Convert To RGB";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInvert.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvert.Location = new System.Drawing.Point(405, 447);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(173, 37);
            this.btnInvert.TabIndex = 12;
            this.btnInvert.Text = "Invert Color";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Google Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(608, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 37);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 496);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnRGB);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.RGBbut);
            this.Controls.Add(this.Bbut);
            this.Controls.Add(this.Gbut);
            this.Controls.Add(this.RBut);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Color Convertor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.RadioButton RBut;
        private System.Windows.Forms.RadioButton Gbut;
        private System.Windows.Forms.RadioButton Bbut;
        private System.Windows.Forms.RadioButton RGBbut;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnSave;
    }
}