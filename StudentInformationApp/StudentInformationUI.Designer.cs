namespace StudentInformationApp
{
    partial class StudentInformationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.retrieveInfoButton = new System.Windows.Forms.Button();
            this.clearInfoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearInfoButton);
            this.groupBox1.Controls.Add(this.retrieveInfoButton);
            this.groupBox1.Controls.Add(this.showInfoButton);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstnameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(this.regNoTextBox);
            this.groupBox1.Controls.Add(this.regLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Location = new System.Drawing.Point(27, 31);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(44, 13);
            this.regLabel.TabIndex = 0;
            this.regLabel.Text = "Reg No";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(89, 31);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(291, 20);
            this.regNoTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 112);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(14, 75);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstnameLabel.TabIndex = 4;
            this.firstnameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 112);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(89, 148);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 6;
            this.showInfoButton.Text = "Show";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // retrieveInfoButton
            // 
            this.retrieveInfoButton.Location = new System.Drawing.Point(206, 148);
            this.retrieveInfoButton.Name = "retrieveInfoButton";
            this.retrieveInfoButton.Size = new System.Drawing.Size(75, 23);
            this.retrieveInfoButton.TabIndex = 7;
            this.retrieveInfoButton.Text = "Retrieve";
            this.retrieveInfoButton.UseVisualStyleBackColor = true;
            this.retrieveInfoButton.Click += new System.EventHandler(this.retrieveInfoButton_Click);
            // 
            // clearInfoButton
            // 
            this.clearInfoButton.Location = new System.Drawing.Point(312, 148);
            this.clearInfoButton.Name = "clearInfoButton";
            this.clearInfoButton.Size = new System.Drawing.Size(75, 23);
            this.clearInfoButton.TabIndex = 8;
            this.clearInfoButton.Text = "Clear";
            this.clearInfoButton.UseVisualStyleBackColor = true;
            this.clearInfoButton.Click += new System.EventHandler(this.clearInfoButton_Click);
            // 
            // StudentInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentInformationUI";
            this.Text = "Student Information  UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearInfoButton;
        private System.Windows.Forms.Button retrieveInfoButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label regLabel;
    }
}

