namespace Comics
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
            this.btn_WTR = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Re = new System.Windows.Forms.Button();
            this.btn_P = new System.Windows.Forms.Button();
            this.btn_N = new System.Windows.Forms.Button();
            this.btn_R = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_WTR
            // 
            this.btn_WTR.Location = new System.Drawing.Point(167, 415);
            this.btn_WTR.Name = "btn_WTR";
            this.btn_WTR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_WTR.Size = new System.Drawing.Size(112, 23);
            this.btn_WTR.TabIndex = 0;
            this.btn_WTR.Text = "Want to Read";
            this.btn_WTR.UseVisualStyleBackColor = true;
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(319, 415);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(112, 23);
            this.btn_C.TabIndex = 1;
            this.btn_C.Text = "Completed ";
            this.btn_C.UseVisualStyleBackColor = true;
            // 
            // btn_Re
            // 
            this.btn_Re.Location = new System.Drawing.Point(12, 415);
            this.btn_Re.Name = "btn_Re";
            this.btn_Re.Size = new System.Drawing.Size(112, 23);
            this.btn_Re.TabIndex = 2;
            this.btn_Re.Text = "Reading";
            this.btn_Re.UseVisualStyleBackColor = true;
            // 
            // btn_P
            // 
            this.btn_P.Location = new System.Drawing.Point(21, 12);
            this.btn_P.Name = "btn_P";
            this.btn_P.Size = new System.Drawing.Size(75, 23);
            this.btn_P.TabIndex = 3;
            this.btn_P.Text = "Previous ";
            this.btn_P.UseVisualStyleBackColor = true;
            // 
            // btn_N
            // 
            this.btn_N.Location = new System.Drawing.Point(342, 12);
            this.btn_N.Name = "btn_N";
            this.btn_N.Size = new System.Drawing.Size(75, 23);
            this.btn_N.TabIndex = 4;
            this.btn_N.Text = "Next";
            this.btn_N.UseVisualStyleBackColor = true;
            // 
            // btn_R
            // 
            this.btn_R.Location = new System.Drawing.Point(89, 386);
            this.btn_R.Name = "btn_R";
            this.btn_R.Size = new System.Drawing.Size(75, 23);
            this.btn_R.TabIndex = 5;
            this.btn_R.Text = "Remove ";
            this.btn_R.UseVisualStyleBackColor = true;
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(275, 386);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(75, 23);
            this.btn_A.TabIndex = 6;
            this.btn_A.Text = "Add";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 352);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_R);
            this.Controls.Add(this.btn_N);
            this.Controls.Add(this.btn_P);
            this.Controls.Add(this.btn_Re);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_WTR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_WTR;
        private Button btn_C;
        private Button btn_Re;
        private Button btn_P;
        private Button btn_N;
        private Button btn_R;
        private Button btn_A;
        private PictureBox pictureBox1;
    }
}