namespace Range_checker
{
    partial class Form1
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
            this.lblask = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtinputuser = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lbldecision = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblshowdecision = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblask
            // 
            this.lblask.AutoSize = true;
            this.lblask.Location = new System.Drawing.Point(70, 53);
            this.lblask.Name = "lblask";
            this.lblask.Size = new System.Drawing.Size(479, 26);
            this.lblask.TabIndex = 0;
            this.lblask.Text = "Enter an integer in the range of 1 throught 10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblshowdecision);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.lbldecision);
            this.groupBox1.Controls.Add(this.btncalculate);
            this.groupBox1.Controls.Add(this.txtinputuser);
            this.groupBox1.Controls.Add(this.lblask);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(180, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ranger checker application";
            // 
            // txtinputuser
            // 
            this.txtinputuser.Location = new System.Drawing.Point(164, 100);
            this.txtinputuser.Name = "txtinputuser";
            this.txtinputuser.Size = new System.Drawing.Size(263, 35);
            this.txtinputuser.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(95, 249);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(151, 90);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "&Check qualification";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lbldecision
            // 
            this.lbldecision.AutoSize = true;
            this.lbldecision.Location = new System.Drawing.Point(207, 151);
            this.lbldecision.Name = "lbldecision";
            this.lbldecision.Size = new System.Drawing.Size(166, 26);
            this.lbldecision.TabIndex = 4;
            this.lbldecision.Text = "Range decision";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(252, 295);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(121, 44);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(252, 249);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 40);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblshowdecision
            // 
            this.lblshowdecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshowdecision.Location = new System.Drawing.Point(57, 190);
            this.lblshowdecision.Name = "lblshowdecision";
            this.lblshowdecision.Size = new System.Drawing.Size(415, 43);
            this.lblshowdecision.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 584);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbldecision;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtinputuser;
        private System.Windows.Forms.Label lblshowdecision;
    }
}

