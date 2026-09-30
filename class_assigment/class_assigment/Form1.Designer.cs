namespace class_assigment
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
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcalculate = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(507, 56);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(233, 26);
            this.txtfood1.TabIndex = 0;
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(507, 104);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(233, 26);
            this.txtprice1.TabIndex = 1;
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(507, 165);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(233, 26);
            this.txtfood2.TabIndex = 2;
            // 
            // txtprice2
            // 
            this.txtprice2.Location = new System.Drawing.Point(507, 219);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(233, 26);
            this.txtprice2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "enter food one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "enter food two";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "enter price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "enter price";
            // 
            // lblcalculate
            // 
            this.lblcalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcalculate.Location = new System.Drawing.Point(234, 264);
            this.lblcalculate.Name = "lblcalculate";
            this.lblcalculate.Size = new System.Drawing.Size(518, 76);
            this.lblcalculate.TabIndex = 8;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(234, 354);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(145, 75);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(507, 354);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(145, 75);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblcalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcalculate;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
    }
}

