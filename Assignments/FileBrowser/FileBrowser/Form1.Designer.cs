namespace FileBrowser
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.browseDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.countSubCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(47, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(315, 323);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // browseDirectory
            // 
            this.browseDirectory.Location = new System.Drawing.Point(145, 368);
            this.browseDirectory.Name = "browseDirectory";
            this.browseDirectory.Size = new System.Drawing.Size(118, 28);
            this.browseDirectory.TabIndex = 1;
            this.browseDirectory.Text = "Browse Directories";
            this.browseDirectory.UseVisualStyleBackColor = true;
            this.browseDirectory.Click += new System.EventHandler(this.browseDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Tree Browser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Directories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Files";
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(437, 198);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(100, 20);
            this.fileBox.TabIndex = 7;
            this.fileBox.TextChanged += new System.EventHandler(this.fileBox_TextChanged);
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(437, 124);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(100, 20);
            this.directoryBox.TabIndex = 9;
            this.directoryBox.TextChanged += new System.EventHandler(this.directoryBox_TextChanged);
            // 
            // countSubCheckBox
            // 
            this.countSubCheckBox.AutoSize = true;
            this.countSubCheckBox.Location = new System.Drawing.Point(437, 52);
            this.countSubCheckBox.Name = "countSubCheckBox";
            this.countSubCheckBox.Size = new System.Drawing.Size(124, 17);
            this.countSubCheckBox.TabIndex = 10;
            this.countSubCheckBox.Text = "Count Subdirectories";
            this.countSubCheckBox.UseVisualStyleBackColor = true;
            this.countSubCheckBox.CheckedChanged += new System.EventHandler(this.countSubCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countSubCheckBox);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseDirectory);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button browseDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.CheckBox countSubCheckBox;
    }
}

