namespace Troubleshooting_LinearStructures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtWord = new TextBox();
            lblWord = new Label();
            btnReverse = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReverse);
            groupBox1.Controls.Add(lblWord);
            groupBox1.Controls.Add(txtWord);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 48);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Word";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(78, 45);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 1;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(36, 121);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(36, 15);
            lblWord.TabIndex = 2;
            lblWord.Text = "Word";
            // 
            // btnReverse
            // 
            btnReverse.Location = new Point(103, 85);
            btnReverse.Name = "btnReverse";
            btnReverse.Size = new Size(75, 23);
            btnReverse.TabIndex = 1;
            btnReverse.Text = "Reverse";
            btnReverse.UseVisualStyleBackColor = true;
            btnReverse.Click += btnReverse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 293);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblWord;
        private TextBox txtWord;
        private Label label1;
        private Button btnReverse;
    }
}
