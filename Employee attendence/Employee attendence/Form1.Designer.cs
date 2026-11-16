namespace Employee_attendence
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
            this.txtmpoId = new System.Windows.Forms.TextBox();
            this.txtemponame = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radiobtnpresent = new System.Windows.Forms.RadioButton();
            this.radioBtnabsent = new System.Windows.Forms.RadioButton();
            this.btnattendence = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtmpoId
            // 
            this.txtmpoId.Location = new System.Drawing.Point(180, 43);
            this.txtmpoId.Name = "txtmpoId";
            this.txtmpoId.Size = new System.Drawing.Size(203, 26);
            this.txtmpoId.TabIndex = 0;
            // 
            // txtemponame
            // 
            this.txtemponame.Location = new System.Drawing.Point(180, 83);
            this.txtemponame.Name = "txtemponame";
            this.txtemponame.Size = new System.Drawing.Size(203, 26);
            this.txtemponame.TabIndex = 1;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(180, 124);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(203, 26);
            this.txtDepartment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "attendence";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(161, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 48);
            this.label5.TabIndex = 7;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radiobtnpresent
            // 
            this.radiobtnpresent.Location = new System.Drawing.Point(161, 179);
            this.radiobtnpresent.Name = "radiobtnpresent";
            this.radiobtnpresent.Size = new System.Drawing.Size(104, 24);
            this.radiobtnpresent.TabIndex = 8;
            this.radiobtnpresent.TabStop = true;
            this.radiobtnpresent.Text = "Present";
            this.radiobtnpresent.UseVisualStyleBackColor = true;
            // 
            // radioBtnabsent
            // 
            this.radioBtnabsent.Location = new System.Drawing.Point(271, 179);
            this.radioBtnabsent.Name = "radioBtnabsent";
            this.radioBtnabsent.Size = new System.Drawing.Size(104, 24);
            this.radioBtnabsent.TabIndex = 9;
            this.radioBtnabsent.TabStop = true;
            this.radioBtnabsent.Text = "absent";
            this.radioBtnabsent.UseVisualStyleBackColor = true;
            // 
            // btnattendence
            // 
            this.btnattendence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattendence.Location = new System.Drawing.Point(12, 241);
            this.btnattendence.Name = "btnattendence";
            this.btnattendence.Size = new System.Drawing.Size(198, 40);
            this.btnattendence.TabIndex = 10;
            this.btnattendence.Text = "Record attendence";
            this.btnattendence.UseVisualStyleBackColor = true;
            this.btnattendence.Click += new System.EventHandler(this.btnattendence_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(210, 241);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(142, 40);
            this.btnview.TabIndex = 11;
            this.btnview.Text = "View from file";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(355, 241);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(179, 40);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "Remove selected";
            this.btnremove.UseVisualStyleBackColor = true;
            // 
            // btncount
            // 
            this.btncount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncount.Location = new System.Drawing.Point(530, 241);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(142, 40);
            this.btncount.TabIndex = 13;
            this.btncount.Text = "Count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(10, 287);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(142, 40);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(158, 287);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(142, 40);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(355, 309);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(361, 132);
            this.lblresult.TabIndex = 16;
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Attendence Records";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(422, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 184);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnattendence);
            this.Controls.Add(this.radioBtnabsent);
            this.Controls.Add(this.radiobtnpresent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtemponame);
            this.Controls.Add(this.txtmpoId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmpoId;
        private System.Windows.Forms.TextBox txtemponame;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radiobtnpresent;
        private System.Windows.Forms.RadioButton radioBtnabsent;
        private System.Windows.Forms.Button btnattendence;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}

