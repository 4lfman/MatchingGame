
namespace MatchingGame
{
    partial class OwnTextBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptTextBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.MaximumSize = new System.Drawing.Size(186, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter 8 characters (no spaces) Some interesting characters: \r\n! N , k b v " +
    "w z";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptTextBoxBtn
            // 
            this.acceptTextBoxBtn.Enabled = false;
            this.acceptTextBoxBtn.Location = new System.Drawing.Point(100, 126);
            this.acceptTextBoxBtn.Name = "acceptTextBoxBtn";
            this.acceptTextBoxBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptTextBoxBtn.TabIndex = 2;
            this.acceptTextBoxBtn.Text = "Accept!";
            this.acceptTextBoxBtn.UseVisualStyleBackColor = true;
            this.acceptTextBoxBtn.Click += new System.EventHandler(this.acceptTextBoxBtn_Click);
            // 
            // OwnTextBox
            // 
            this.AcceptButton = this.acceptTextBoxBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.acceptTextBoxBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OwnTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icon Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptTextBoxBtn;
    }
}