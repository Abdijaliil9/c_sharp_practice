namespace Reasearch_other_methods_using_files
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
            this.btn_readalllines = new System.Windows.Forms.Button();
            this.btn_deletefile = new System.Windows.Forms.Button();
            this.btn_deleteitem = new System.Windows.Forms.Button();
            this.listBox_items_from_thefile = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_readlines = new System.Windows.Forms.Button();
            this.btncreating = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_readalllines
            // 
            this.btn_readalllines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readalllines.Location = new System.Drawing.Point(67, 98);
            this.btn_readalllines.Name = "btn_readalllines";
            this.btn_readalllines.Size = new System.Drawing.Size(264, 54);
            this.btn_readalllines.TabIndex = 0;
            this.btn_readalllines.Text = "ReadAllLines";
            this.btn_readalllines.UseVisualStyleBackColor = true;
            this.btn_readalllines.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deletefile
            // 
            this.btn_deletefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletefile.Location = new System.Drawing.Point(92, 271);
            this.btn_deletefile.Name = "btn_deletefile";
            this.btn_deletefile.Size = new System.Drawing.Size(238, 67);
            this.btn_deletefile.TabIndex = 1;
            this.btn_deletefile.Text = "Delete The File";
            this.btn_deletefile.UseVisualStyleBackColor = true;
            this.btn_deletefile.Click += new System.EventHandler(this.btn_deletefile_Click);
            // 
            // btn_deleteitem
            // 
            this.btn_deleteitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitem.Location = new System.Drawing.Point(67, 207);
            this.btn_deleteitem.Name = "btn_deleteitem";
            this.btn_deleteitem.Size = new System.Drawing.Size(272, 58);
            this.btn_deleteitem.TabIndex = 2;
            this.btn_deleteitem.Text = "Delete items in the file";
            this.btn_deleteitem.UseVisualStyleBackColor = true;
            this.btn_deleteitem.Click += new System.EventHandler(this.btn_deleteitem_Click);
            // 
            // listBox_items_from_thefile
            // 
            this.listBox_items_from_thefile.FormattingEnabled = true;
            this.listBox_items_from_thefile.ItemHeight = 20;
            this.listBox_items_from_thefile.Location = new System.Drawing.Point(677, 12);
            this.listBox_items_from_thefile.Name = "listBox_items_from_thefile";
            this.listBox_items_from_thefile.Size = new System.Drawing.Size(316, 444);
            this.listBox_items_from_thefile.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(126, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 83);
            this.button4.TabIndex = 4;
            this.button4.Text = "Read the exist file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btncreating);
            this.groupBox1.Controls.Add(this.btn_readlines);
            this.groupBox1.Controls.Add(this.btn_deleteitem);
            this.groupBox1.Controls.Add(this.btn_readalllines);
            this.groupBox1.Controls.Add(this.btn_deletefile);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reasearch Functions";
            // 
            // btn_readlines
            // 
            this.btn_readlines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readlines.Location = new System.Drawing.Point(67, 158);
            this.btn_readlines.Name = "btn_readlines";
            this.btn_readlines.Size = new System.Drawing.Size(264, 54);
            this.btn_readlines.TabIndex = 6;
            this.btn_readlines.Text = "ReadLines";
            this.btn_readlines.UseVisualStyleBackColor = true;
            this.btn_readlines.Click += new System.EventHandler(this.btn_readlines_Click);
            // 
            // btncreating
            // 
            this.btncreating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreating.Location = new System.Drawing.Point(67, 34);
            this.btncreating.Name = "btncreating";
            this.btncreating.Size = new System.Drawing.Size(264, 54);
            this.btncreating.TabIndex = 7;
            this.btncreating.Text = "create";
            this.btncreating.UseVisualStyleBackColor = true;
            this.btncreating.Click += new System.EventHandler(this.btncreating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 611);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox_items_from_thefile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_readalllines;
        private System.Windows.Forms.Button btn_deletefile;
        private System.Windows.Forms.Button btn_deleteitem;
        private System.Windows.Forms.ListBox listBox_items_from_thefile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_readlines;
        private System.Windows.Forms.Button btncreating;
    }
}

