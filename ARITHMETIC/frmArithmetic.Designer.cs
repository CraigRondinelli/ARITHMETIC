namespace ARITHMETIC
{
    partial class frmArithmetic
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
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.btnChallenge = new System.Windows.Forms.Button();
            this.picChallenge = new System.Windows.Forms.PictureBox();
            this.picMath = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picChallenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMath)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIn2
            // 
            this.txtIn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIn2.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn2.Location = new System.Drawing.Point(37, 84);
            this.txtIn2.Multiline = true;
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(203, 36);
            this.txtIn2.TabIndex = 9;
            this.txtIn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIn1
            // 
            this.txtIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIn1.Font = new System.Drawing.Font("Moire", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn1.Location = new System.Drawing.Point(37, 22);
            this.txtIn1.Multiline = true;
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(203, 36);
            this.txtIn1.TabIndex = 8;
            this.txtIn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(296, 22);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(97, 98);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "Random Fill";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(223, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(198, 215);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(97, 87);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(356, 215);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(97, 87);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(517, 215);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(97, 87);
            this.btnMax.TabIndex = 13;
            this.btnMax.Text = "Bigger";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Salmon;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 87);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOut.Font = new System.Drawing.Font("Moire", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(37, 321);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(576, 64);
            this.lblOut.TabIndex = 17;
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChallenge
            // 
            this.btnChallenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChallenge.Location = new System.Drawing.Point(572, 402);
            this.btnChallenge.Name = "btnChallenge";
            this.btnChallenge.Size = new System.Drawing.Size(78, 48);
            this.btnChallenge.TabIndex = 19;
            this.btnChallenge.Text = "Challenge";
            this.btnChallenge.UseVisualStyleBackColor = false;
            this.btnChallenge.Click += new System.EventHandler(this.btnChallenge_Click);
            // 
            // picChallenge
            // 
            this.picChallenge.Image = global::ARITHMETIC.Properties.Resources.xkcd_compiling_resize_4449;
            this.picChallenge.Location = new System.Drawing.Point(688, 12);
            this.picChallenge.Name = "picChallenge";
            this.picChallenge.Size = new System.Drawing.Size(160, 141);
            this.picChallenge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChallenge.TabIndex = 20;
            this.picChallenge.TabStop = false;
            // 
            // picMath
            // 
            this.picMath.Image = global::ARITHMETIC.Properties.Resources._5_15_math_iStock_630x532;
            this.picMath.Location = new System.Drawing.Point(460, 12);
            this.picMath.Name = "picMath";
            this.picMath.Size = new System.Drawing.Size(154, 131);
            this.picMath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMath.TabIndex = 18;
            this.picMath.TabStop = false;
            this.picMath.Click += new System.EventHandler(this.picMath_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmArithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.picChallenge);
            this.Controls.Add(this.btnChallenge);
            this.Controls.Add(this.picMath);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtIn2);
            this.Controls.Add(this.txtIn1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmArithmetic";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmArithmetic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picChallenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.PictureBox picMath;
        private System.Windows.Forms.Button btnChallenge;
        private System.Windows.Forms.PictureBox picChallenge;
        private System.Windows.Forms.Timer timer1;
    }
}

