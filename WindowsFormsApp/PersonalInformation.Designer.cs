namespace WindowsFormsApp
{
    partial class PersonalInformation
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showAllIfoButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parantNameButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mother\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Personal Information";
            // 
            // fastNameTextBox
            // 
            this.fastNameTextBox.Location = new System.Drawing.Point(140, 73);
            this.fastNameTextBox.Name = "fastNameTextBox";
            this.fastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.fastNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 118);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(140, 155);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.fatherNameTextBox.TabIndex = 8;
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(140, 198);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.motherNameTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(140, 247);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(138, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(121, 360);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(71, 25);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showAllIfoButton
            // 
            this.showAllIfoButton.Location = new System.Drawing.Point(252, 360);
            this.showAllIfoButton.Name = "showAllIfoButton";
            this.showAllIfoButton.Size = new System.Drawing.Size(123, 25);
            this.showAllIfoButton.TabIndex = 12;
            this.showAllIfoButton.Text = "Show All Information";
            this.showAllIfoButton.UseVisualStyleBackColor = true;
            this.showAllIfoButton.Click += new System.EventHandler(this.showAllIfoButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(72, 419);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(71, 25);
            this.nameButton.TabIndex = 13;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parantNameButton
            // 
            this.parantNameButton.Location = new System.Drawing.Point(189, 419);
            this.parantNameButton.Name = "parantNameButton";
            this.parantNameButton.Size = new System.Drawing.Size(100, 25);
            this.parantNameButton.TabIndex = 14;
            this.parantNameButton.Text = "Parants Name";
            this.parantNameButton.UseVisualStyleBackColor = true;
            this.parantNameButton.Click += new System.EventHandler(this.parantNameButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(338, 419);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(76, 25);
            this.addressButton.TabIndex = 15;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(385, 73);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(219, 269);
            this.resultRichTextBox.TabIndex = 16;
            this.resultRichTextBox.Text = "";
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 476);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parantNameButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.showAllIfoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.fastNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalInformation";
            this.Text = "PersonalInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fastNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showAllIfoButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parantNameButton;
        private System.Windows.Forms.Button addressButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
    }
}