namespace Attendence
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
            this.lblid = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.radioButtonpresent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldepart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonabsent = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdepart = new System.Windows.Forms.TextBox();
            this.record = new System.Windows.Forms.Button();
            this.btnfreadile = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexite = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(53, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(162, 29);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Employee ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(611, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 284);
            this.listBox1.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(254, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(267, 35);
            this.txtid.TabIndex = 2;
            // 
            // radioButtonpresent
            // 
            this.radioButtonpresent.AutoSize = true;
            this.radioButtonpresent.Location = new System.Drawing.Point(206, 237);
            this.radioButtonpresent.Name = "radioButtonpresent";
            this.radioButtonpresent.Size = new System.Drawing.Size(128, 33);
            this.radioButtonpresent.TabIndex = 3;
            this.radioButtonpresent.TabStop = true;
            this.radioButtonpresent.Text = "Present";
            this.radioButtonpresent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdepart);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.radioButtonabsent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbldepart);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.radioButtonpresent);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendence Information";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(9, 121);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(206, 29);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Employee Name";
            // 
            // lbldepart
            // 
            this.lbldepart.AutoSize = true;
            this.lbldepart.Location = new System.Drawing.Point(53, 168);
            this.lbldepart.Name = "lbldepart";
            this.lbldepart.Size = new System.Drawing.Size(148, 29);
            this.lbldepart.TabIndex = 5;
            this.lbldepart.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attendence";
            // 
            // radioButtonabsent
            // 
            this.radioButtonabsent.AutoSize = true;
            this.radioButtonabsent.Location = new System.Drawing.Point(372, 233);
            this.radioButtonabsent.Name = "radioButtonabsent";
            this.radioButtonabsent.Size = new System.Drawing.Size(118, 33);
            this.radioButtonabsent.TabIndex = 7;
            this.radioButtonabsent.TabStop = true;
            this.radioButtonabsent.Text = "Absent";
            this.radioButtonabsent.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(254, 115);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(267, 35);
            this.txtname.TabIndex = 8;
            // 
            // txtdepart
            // 
            this.txtdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepart.Location = new System.Drawing.Point(254, 165);
            this.txtdepart.Name = "txtdepart";
            this.txtdepart.Size = new System.Drawing.Size(267, 35);
            this.txtdepart.TabIndex = 9;
            // 
            // record
            // 
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(35, 452);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(153, 61);
            this.record.TabIndex = 5;
            this.record.Text = "Record attendebce";
            this.record.UseVisualStyleBackColor = true;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // btnfreadile
            // 
            this.btnfreadile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfreadile.Location = new System.Drawing.Point(194, 452);
            this.btnfreadile.Name = "btnfreadile";
            this.btnfreadile.Size = new System.Drawing.Size(153, 61);
            this.btnfreadile.TabIndex = 6;
            this.btnfreadile.Text = "View from file";
            this.btnfreadile.UseVisualStyleBackColor = true;
            this.btnfreadile.Click += new System.EventHandler(this.btnfreadile_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(361, 452);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(153, 61);
            this.btnremove.TabIndex = 7;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btncount
            // 
            this.btncount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncount.Location = new System.Drawing.Point(529, 452);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(153, 61);
            this.btncount.TabIndex = 8;
            this.btncount.Text = "count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(723, 452);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(153, 61);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexite
            // 
            this.btnexite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexite.Location = new System.Drawing.Point(927, 452);
            this.btnexite.Name = "btnexite";
            this.btnexite.Size = new System.Drawing.Size(153, 61);
            this.btnexite.TabIndex = 10;
            this.btnexite.Text = "Exit";
            this.btnexite.UseVisualStyleBackColor = true;
            this.btnexite.Click += new System.EventHandler(this.btnexite_Click);
            // 
            // lblcount
            // 
            this.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcount.Location = new System.Drawing.Point(622, 307);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(499, 60);
            this.lblcount.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 590);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btnexite);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnfreadile);
            this.Controls.Add(this.record);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.RadioButton radioButtonpresent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdepart;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton radioButtonabsent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldepart;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button btnfreadile;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexite;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

