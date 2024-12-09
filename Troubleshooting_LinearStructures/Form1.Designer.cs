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
            btnReverse = new Button();
            lblWord = new Label();
            txtWord = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAverage = new Button();
            lblAverage = new Label();
            txtQualification = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(36, 121);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(36, 15);
            lblWord.TabIndex = 2;
            lblWord.Text = "Word";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(78, 45);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 1;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnAverage);
            groupBox2.Controls.Add(lblAverage);
            groupBox2.Controls.Add(txtQualification);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(383, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 166);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(137, 117);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(75, 23);
            btnAverage.TabIndex = 1;
            btnAverage.Text = "Average";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(36, 121);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(16, 15);
            lblAverage.TabIndex = 2;
            lblAverage.Text = "...";
            lblAverage.Click += lblAverage_Click;
            // 
            // txtQualification
            // 
            txtQualification.Location = new Point(123, 45);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(100, 23);
            txtQualification.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 48);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 1;
            label3.Text = "Qualification: ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 293);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblWord;
        private TextBox txtWord;
        private Label label1;
        private Button btnReverse;
        private GroupBox groupBox2;
        private Button btnAverage;
        private Label lblAverage;
        private TextBox txtQualification;
        private Label label3;
        private Button btnAdd;
    }
}
