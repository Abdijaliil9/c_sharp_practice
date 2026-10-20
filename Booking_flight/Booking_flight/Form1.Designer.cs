namespace Booking_flight
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radiofirstclass = new System.Windows.Forms.RadioButton();
            this.radionormalclass = new System.Windows.Forms.RadioButton();
            this.radioBussnesclass = new System.Windows.Forms.RadioButton();
            this.checkbox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnclaculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(315, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(256, 26);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(315, 122);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(256, 26);
            this.txtage.TabIndex = 1;
            this.txtage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(315, 177);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(256, 26);
            this.txtTickets.TabIndex = 2;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(315, 236);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(256, 26);
            this.txtweight.TabIndex = 3;
            this.txtweight.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "passenger name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "passenager age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of tickts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baggage weight(kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Personal information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Travel class";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // radiofirstclass
            // 
            this.radiofirstclass.AutoSize = true;
            this.radiofirstclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofirstclass.Location = new System.Drawing.Point(61, 343);
            this.radiofirstclass.Name = "radiofirstclass";
            this.radiofirstclass.Size = new System.Drawing.Size(116, 24);
            this.radiofirstclass.TabIndex = 10;
            this.radiofirstclass.TabStop = true;
            this.radiofirstclass.Text = "First class";
            this.radiofirstclass.UseVisualStyleBackColor = true;
            // 
            // radionormalclass
            // 
            this.radionormalclass.AutoSize = true;
            this.radionormalclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionormalclass.Location = new System.Drawing.Point(224, 343);
            this.radionormalclass.Name = "radionormalclass";
            this.radionormalclass.Size = new System.Drawing.Size(136, 24);
            this.radionormalclass.TabIndex = 11;
            this.radionormalclass.TabStop = true;
            this.radionormalclass.Text = "Normal class";
            this.radionormalclass.UseVisualStyleBackColor = true;
            // 
            // radioBussnesclass
            // 
            this.radioBussnesclass.AutoSize = true;
            this.radioBussnesclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBussnesclass.Location = new System.Drawing.Point(403, 343);
            this.radioBussnesclass.Name = "radioBussnesclass";
            this.radioBussnesclass.Size = new System.Drawing.Size(162, 24);
            this.radioBussnesclass.TabIndex = 12;
            this.radioBussnesclass.TabStop = true;
            this.radioBussnesclass.Text = "Bussiness class";
            this.radioBussnesclass.UseVisualStyleBackColor = true;
            this.radioBussnesclass.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSize = true;
            this.checkbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox1.Location = new System.Drawing.Point(46, 396);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(542, 36);
            this.checkbox1.TabIndex = 13;
            this.checkbox1.Text = "Add Travel insurance ($25 Per Ticket";
            this.checkbox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(613, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 384);
            this.listBox1.TabIndex = 14;
            // 
            // btnclaculate
            // 
            this.btnclaculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclaculate.Location = new System.Drawing.Point(46, 455);
            this.btnclaculate.Name = "btnclaculate";
            this.btnclaculate.Size = new System.Drawing.Size(137, 43);
            this.btnclaculate.TabIndex = 15;
            this.btnclaculate.Text = "calculate";
            this.btnclaculate.UseVisualStyleBackColor = true;
            this.btnclaculate.Click += new System.EventHandler(this.btnclaculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(264, 455);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(137, 43);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(451, 455);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(137, 43);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 510);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclaculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkbox1);
            this.Controls.Add(this.radioBussnesclass);
            this.Controls.Add(this.radionormalclass);
            this.Controls.Add(this.radiofirstclass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiofirstclass;
        private System.Windows.Forms.RadioButton radionormalclass;
        private System.Windows.Forms.RadioButton radioBussnesclass;
        private System.Windows.Forms.CheckBox checkbox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnclaculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

