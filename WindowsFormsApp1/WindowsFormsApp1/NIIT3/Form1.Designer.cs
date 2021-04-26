namespace WindowsFormsApp4
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
            this.userControl11 = new WindowsFormsApp4.UserControl1();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.userControl12 = new WindowsFormsApp4.UserControl1();
            this.userControl13 = new WindowsFormsControlLibrary1.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.PASSWORD = null;
            this.userControl11.Size = new System.Drawing.Size(759, 440);
            this.userControl11.TabIndex = 0;
            this.userControl11.USERID = null;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(522, 104);
            this.maskedTextBox1.Mask = "(###)(##)";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(765, 25);
            this.userControl12.Name = "userControl12";
            this.userControl12.PASSWORD = null;
            this.userControl12.Size = new System.Drawing.Size(759, 527);
            this.userControl12.TabIndex = 2;
            this.userControl12.USERID = null;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(480, 184);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(100, 22);
            this.userControl13.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private UserControl1 userControl12;
        private WindowsFormsControlLibrary1.UserControl1 userControl13;
    }
}

