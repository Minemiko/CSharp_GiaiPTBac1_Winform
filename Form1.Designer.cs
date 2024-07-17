namespace CSharp_GiaiPTBac1_Winform
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
            lblA = new Label();
            txtA = new TextBox();
            label1 = new Label();
            txtB = new TextBox();
            label2 = new Label();
            txtKQ = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(28, 25);
            lblA.Name = "lblA";
            lblA.Size = new Size(67, 33);
            lblA.TabIndex = 0;
            lblA.Text = "Số a";
            // 
            // txtA
            // 
            txtA.Location = new Point(157, 22);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 40);
            txtA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 71);
            label1.Name = "label1";
            label1.Size = new Size(68, 33);
            label1.TabIndex = 0;
            label1.Text = "Số b";
            // 
            // txtB
            // 
            txtB.Location = new Point(157, 68);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 40);
            txtB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 117);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 0;
            label2.Text = "Kết quả";
            label2.Click += label2_Click;
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(157, 114);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(520, 40);
            txtKQ.TabIndex = 1;
            txtKQ.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(28, 209);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 3;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(567, 209);
            button2.Name = "button2";
            button2.Size = new Size(110, 41);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 264);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtKQ);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Label label1;
        private TextBox txtB;
        private Label label2;
        private TextBox txtKQ;
        private Button button1;
        private Button button2;
    }
}
