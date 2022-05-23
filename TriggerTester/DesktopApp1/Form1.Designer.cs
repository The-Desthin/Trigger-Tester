namespace TriggerTester {

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
            this.triggerString = new System.Windows.Forms.TextBox();
            this.testTriggerButton = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // triggerString
            // 
            this.triggerString.Location = new System.Drawing.Point(92, 163);
            this.triggerString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.triggerString.Name = "triggerString";
            this.triggerString.Size = new System.Drawing.Size(355, 20);
            this.triggerString.TabIndex = 1;
            this.triggerString.Text = "You feel yourself starting to appear";
            // 
            // testTriggerButton
            // 
            this.testTriggerButton.Location = new System.Drawing.Point(207, 203);
            this.testTriggerButton.Margin = new System.Windows.Forms.Padding(2);
            this.testTriggerButton.Name = "testTriggerButton";
            this.testTriggerButton.Size = new System.Drawing.Size(97, 28);
            this.testTriggerButton.TabIndex = 2;
            this.testTriggerButton.Text = "Test Trigger";
            this.testTriggerButton.UseVisualStyleBackColor = true;
            this.testTriggerButton.Click += new System.EventHandler(this.testTriggerButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(71, 18);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(418, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Enter file path, input Text and hit Test Trigger";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "C:\\Users\\Public\\Daybreak Game Company\\Installed Games\\EverQuest\\Logs\\eqlog_Test_t" +
    "est.txt";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log File Path: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trigger Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.triggerString);
            this.Controls.Add(this.testTriggerButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Trigger Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox triggerString;
        private System.Windows.Forms.Button testTriggerButton;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

