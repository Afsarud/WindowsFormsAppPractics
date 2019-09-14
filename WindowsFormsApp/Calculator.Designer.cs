namespace WindowsFormsApp
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addBottun = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.fstNumberTextBox = new System.Windows.Forms.TextBox();
            this.scndNumbertextBox2 = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secound Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // addBottun
            // 
            this.addBottun.Location = new System.Drawing.Point(58, 261);
            this.addBottun.Name = "addBottun";
            this.addBottun.Size = new System.Drawing.Size(75, 23);
            this.addBottun.TabIndex = 3;
            this.addBottun.Text = "Add";
            this.addBottun.UseVisualStyleBackColor = true;
            this.addBottun.Click += new System.EventHandler(this.addBottun_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(186, 261);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "Subtract";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(321, 261);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(75, 23);
            this.multButton.TabIndex = 5;
            this.multButton.Text = "Multiply";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(443, 261);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(75, 23);
            this.divButton.TabIndex = 6;
            this.divButton.Text = "Divide";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.divButton_Click);
            // 
            // fstNumberTextBox
            // 
            this.fstNumberTextBox.Location = new System.Drawing.Point(130, 58);
            this.fstNumberTextBox.Name = "fstNumberTextBox";
            this.fstNumberTextBox.Size = new System.Drawing.Size(131, 20);
            this.fstNumberTextBox.TabIndex = 7;
            // 
            // scndNumbertextBox2
            // 
            this.scndNumbertextBox2.Location = new System.Drawing.Point(130, 116);
            this.scndNumbertextBox2.Name = "scndNumbertextBox2";
            this.scndNumbertextBox2.Size = new System.Drawing.Size(131, 20);
            this.scndNumbertextBox2.TabIndex = 8;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(130, 168);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(131, 20);
            this.resultTextBox.TabIndex = 9;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 366);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.scndNumbertextBox2);
            this.Controls.Add(this.fstNumberTextBox);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addBottun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBottun;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.TextBox fstNumberTextBox;
        private System.Windows.Forms.TextBox scndNumbertextBox2;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}