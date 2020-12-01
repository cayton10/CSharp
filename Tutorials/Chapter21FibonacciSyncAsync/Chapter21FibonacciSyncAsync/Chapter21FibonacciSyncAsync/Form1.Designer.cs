namespace Chapter21FibonacciSyncAsync
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSequential = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sequentil Calls to Fibonacci(46) and then Fibonacci(45)";
            // 
            // buttonSequential
            // 
            this.buttonSequential.Location = new System.Drawing.Point(32, 76);
            this.buttonSequential.Name = "buttonSequential";
            this.buttonSequential.Size = new System.Drawing.Size(489, 49);
            this.buttonSequential.TabIndex = 1;
            this.buttonSequential.Text = "Sequential Calls";
            this.buttonSequential.UseVisualStyleBackColor = true;
            this.buttonSequential.Click += new System.EventHandler(this.buttonSequential_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(32, 257);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(490, 284);
            this.textBoxResults.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(489, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "\"Parallel\" (Asynchronous) Calls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonSequential);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSequential;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button button1;
    }
}

