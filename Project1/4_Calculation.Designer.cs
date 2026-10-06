namespace Project1
{
    partial class Calculation
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
            label1 = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            tong3 = new Label();
            tong2 = new Label();
            tong1 = new Label();
            giaithuab = new Label();
            giaithuaa = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(543, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            label2.Click += label2_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(201, 61);
            txtA.Margin = new Padding(4, 3, 4, 3);
            txtA.Name = "txtA";
            txtA.Size = new Size(155, 30);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(618, 61);
            txtB.Margin = new Padding(4, 3, 4, 3);
            txtB.Name = "txtB";
            txtB.Size = new Size(155, 30);
            txtB.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(112, 137);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(392, 40);
            button1.TabIndex = 5;
            button1.Text = "Tính các giá trị ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(543, 138);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 40);
            button2.TabIndex = 6;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(707, 138);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(118, 40);
            button3.TabIndex = 7;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tong3);
            groupBox1.Controls.Add(tong2);
            groupBox1.Controls.Add(tong1);
            groupBox1.Controls.Add(giaithuab);
            groupBox1.Controls.Add(giaithuaa);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(106, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 209);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết Quả";
            // 
            // tong3
            // 
            tong3.AutoSize = true;
            tong3.ForeColor = SystemColors.Highlight;
            tong3.Location = new Point(33, 170);
            tong3.Name = "tong3";
            tong3.Size = new Size(47, 23);
            tong3.TabIndex = 4;
            tong3.Text = "S3 =";
            // 
            // tong2
            // 
            tong2.AutoSize = true;
            tong2.ForeColor = SystemColors.Highlight;
            tong2.Location = new Point(33, 130);
            tong2.Name = "tong2";
            tong2.Size = new Size(47, 23);
            tong2.TabIndex = 3;
            tong2.Text = "S2 =";
            tong2.Click += tong2_Click;
            // 
            // tong1
            // 
            tong1.AutoSize = true;
            tong1.ForeColor = SystemColors.Highlight;
            tong1.Location = new Point(33, 89);
            tong1.Name = "tong1";
            tong1.Size = new Size(47, 23);
            tong1.TabIndex = 2;
            tong1.Text = "S1 =";
            // 
            // giaithuab
            // 
            giaithuab.AutoSize = true;
            giaithuab.ForeColor = SystemColors.Highlight;
            giaithuab.Location = new Point(378, 48);
            giaithuab.Name = "giaithuab";
            giaithuab.Size = new Size(44, 23);
            giaithuab.TabIndex = 1;
            giaithuab.Text = "B! =";
            // 
            // giaithuaa
            // 
            giaithuaa.AutoSize = true;
            giaithuaa.ForeColor = SystemColors.Highlight;
            giaithuaa.Location = new Point(33, 48);
            giaithuaa.Name = "giaithuaa";
            giaithuaa.Size = new Size(45, 23);
            giaithuaa.TabIndex = 0;
            giaithuaa.Text = "A! =";
            giaithuaa.Click += giaithuaa_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 444);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label giaithuaa;
        private Label giaithuab;
        private Label tong2;
        private Label tong1;
        private Label tong3;
    }
}