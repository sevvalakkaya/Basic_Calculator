namespace hesap_makinesi
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
            this.components = new System.ComponentModel.Container();
            this.number1 = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.number2 = new System.Windows.Forms.MaskedTextBox();
            this.operations = new System.Windows.Forms.ComboBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.reslt_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(146, 87);
            this.number1.Mask = "00000";
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(167, 22);
            this.number1.TabIndex = 0;
            this.number1.ValidatingType = typeof(int);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(146, 139);
            this.number2.Mask = "00000";
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(167, 22);
            this.number2.TabIndex = 2;
            this.number2.ValidatingType = typeof(int);
            // 
            // operations
            // 
            this.operations.FormattingEnabled = true;
            this.operations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operations.Location = new System.Drawing.Point(45, 200);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(121, 24);
            this.operations.TabIndex = 3;
            this.operations.Tag = "";
            this.operations.Text = "Operations";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(306, 200);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // reslt_listBox
            // 
            this.reslt_listBox.FormattingEnabled = true;
            this.reslt_listBox.ItemHeight = 16;
            this.reslt_listBox.Location = new System.Drawing.Point(146, 255);
            this.reslt_listBox.Name = "reslt_listBox";
            this.reslt_listBox.Size = new System.Drawing.Size(167, 100);
            this.reslt_listBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(488, 418);
            this.Controls.Add(this.reslt_listBox);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox number1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox number2;
        private System.Windows.Forms.ComboBox operations;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.ListBox reslt_listBox;
    }
}

