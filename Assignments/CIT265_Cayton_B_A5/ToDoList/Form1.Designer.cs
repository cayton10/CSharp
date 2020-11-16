namespace ToDoList
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
            this.quitButton = new System.Windows.Forms.Button();
            this.addActivity = new System.Windows.Forms.Button();
            this.removeActivity = new System.Windows.Forms.Button();
            this.sortName = new System.Windows.Forms.Button();
            this.sortDate = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.activityListLabel = new System.Windows.Forms.Label();
            this.acceptList = new System.Windows.Forms.Button();
            this.cancelList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(295, 416);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // addActivity
            // 
            this.addActivity.Location = new System.Drawing.Point(12, 41);
            this.addActivity.Name = "addActivity";
            this.addActivity.Size = new System.Drawing.Size(75, 23);
            this.addActivity.TabIndex = 1;
            this.addActivity.Text = "&Add";
            this.addActivity.UseVisualStyleBackColor = true;
            this.addActivity.Click += new System.EventHandler(this.addActivity_Click);
            // 
            // removeActivity
            // 
            this.removeActivity.Enabled = false;
            this.removeActivity.Location = new System.Drawing.Point(12, 70);
            this.removeActivity.Name = "removeActivity";
            this.removeActivity.Size = new System.Drawing.Size(75, 23);
            this.removeActivity.TabIndex = 2;
            this.removeActivity.Text = "&Remove";
            this.removeActivity.UseVisualStyleBackColor = true;
            this.removeActivity.Click += new System.EventHandler(this.removeActivity_Click);
            // 
            // sortName
            // 
            this.sortName.Location = new System.Drawing.Point(12, 99);
            this.sortName.Name = "sortName";
            this.sortName.Size = new System.Drawing.Size(75, 23);
            this.sortName.TabIndex = 3;
            this.sortName.Text = "Sort &Name";
            this.sortName.UseVisualStyleBackColor = true;
            this.sortName.Click += new System.EventHandler(this.sortName_Click);
            // 
            // sortDate
            // 
            this.sortDate.Location = new System.Drawing.Point(12, 126);
            this.sortDate.Name = "sortDate";
            this.sortDate.Size = new System.Drawing.Size(75, 23);
            this.sortDate.TabIndex = 4;
            this.sortDate.Text = "Sort &Date";
            this.sortDate.UseVisualStyleBackColor = true;
            this.sortDate.Click += new System.EventHandler(this.sortDate_Click);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.nameField.Location = new System.Drawing.Point(133, 41);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(398, 20);
            this.nameField.TabIndex = 5;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 89);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(398, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(133, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(398, 173);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(133, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Enter Activity Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(133, 70);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Select Date";
            // 
            // activityListLabel
            // 
            this.activityListLabel.AutoSize = true;
            this.activityListLabel.Location = new System.Drawing.Point(133, 131);
            this.activityListLabel.Name = "activityListLabel";
            this.activityListLabel.Size = new System.Drawing.Size(85, 13);
            this.activityListLabel.TabIndex = 10;
            this.activityListLabel.Text = "Your Activity List";
            // 
            // acceptList
            // 
            this.acceptList.Location = new System.Drawing.Point(157, 354);
            this.acceptList.Name = "acceptList";
            this.acceptList.Size = new System.Drawing.Size(75, 23);
            this.acceptList.TabIndex = 11;
            this.acceptList.Text = "Accept List";
            this.acceptList.UseVisualStyleBackColor = true;
            this.acceptList.Click += new System.EventHandler(this.acceptList_Click);
            // 
            // cancelList
            // 
            this.cancelList.Location = new System.Drawing.Point(429, 354);
            this.cancelList.Name = "cancelList";
            this.cancelList.Size = new System.Drawing.Size(75, 23);
            this.cancelList.TabIndex = 12;
            this.cancelList.Text = "Cancel List";
            this.cancelList.UseVisualStyleBackColor = true;
            this.cancelList.Click += new System.EventHandler(this.cancelList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 487);
            this.Controls.Add(this.cancelList);
            this.Controls.Add(this.acceptList);
            this.Controls.Add(this.activityListLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.sortDate);
            this.Controls.Add(this.sortName);
            this.Controls.Add(this.removeActivity);
            this.Controls.Add(this.addActivity);
            this.Controls.Add(this.quitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Quit button logic
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button addActivity;
        private System.Windows.Forms.Button removeActivity;
        private System.Windows.Forms.Button sortName;
        private System.Windows.Forms.Button sortDate;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label activityListLabel;
        private System.Windows.Forms.Button acceptList;
        private System.Windows.Forms.Button cancelList;
    }
}

