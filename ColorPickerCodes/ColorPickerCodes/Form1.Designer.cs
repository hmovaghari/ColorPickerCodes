namespace ColorPickerCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.btnShowCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Hex",
            "RGB"});
            this.cmbMode.Location = new System.Drawing.Point(13, 166);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(202, 21);
            this.cmbMode.TabIndex = 2;
            this.cmbMode.Text = "Hex";
            // 
            // btnShowCode
            // 
            this.btnShowCode.Location = new System.Drawing.Point(221, 166);
            this.btnShowCode.Name = "btnShowCode";
            this.btnShowCode.Size = new System.Drawing.Size(75, 23);
            this.btnShowCode.TabIndex = 3;
            this.btnShowCode.Text = "Show Code";
            this.btnShowCode.UseVisualStyleBackColor = true;
            this.btnShowCode.Click += new System.EventHandler(this.btnShowCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(13, 195);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(202, 20);
            this.txtCode.TabIndex = 4;
            // 
            // btnShowColor
            // 
            this.btnShowColor.Location = new System.Drawing.Point(221, 195);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(75, 23);
            this.btnShowColor.TabIndex = 5;
            this.btnShowColor.Text = "Show Color";
            this.btnShowColor.UseVisualStyleBackColor = true;
            this.btnShowColor.Click += new System.EventHandler(this.btnShowColor_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 134);
            this.listBox1.TabIndex = 6;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 230);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnShowColor);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnShowCode);
            this.Controls.Add(this.cmbMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 269);
            this.MinimumSize = new System.Drawing.Size(326, 269);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Colors Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Button btnShowCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.ListBox listBox1;
    }
}

