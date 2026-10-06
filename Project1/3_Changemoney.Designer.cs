namespace Project1
{
    partial class Changemoney
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
            label3 = new Label();
            txttien1 = new TextBox();
            boxloaitien1 = new ComboBox();
            txttien2 = new TextBox();
            buttonchuyen = new Button();
            boxloaitien2 = new ComboBox();
            labletygia = new Label();
            labeltygia = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 75);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Số tiền cần đổi ";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 226);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tiền đã đổi";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 306);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Tỷ giá quy đổi ";
            label3.UseWaitCursor = true;
            // 
            // txttien1
            // 
            txttien1.Location = new Point(228, 72);
            txttien1.Name = "txttien1";
            txttien1.Size = new Size(125, 27);
            txttien1.TabIndex = 3;
            txttien1.UseWaitCursor = true;
            // 
            // boxloaitien1
            // 
            boxloaitien1.FormattingEnabled = true;
            boxloaitien1.Items.AddRange(new object[] { "USD (Đô-la Mỹ)", "EUR (Euro)", "GBD (Bảng Anh)", "SGD (Đô-la Singapore)", "JPY (Yên Nhật)", "VND (Việt Nam Đồng)" });
            boxloaitien1.Location = new Point(378, 72);
            boxloaitien1.Name = "boxloaitien1";
            boxloaitien1.Size = new Size(151, 28);
            boxloaitien1.TabIndex = 4;
            boxloaitien1.UseWaitCursor = true;
            // 
            // txttien2
            // 
            txttien2.Location = new Point(228, 223);
            txttien2.Name = "txttien2";
            txttien2.Size = new Size(125, 27);
            txttien2.TabIndex = 5;
            txttien2.UseWaitCursor = true;
            // 
            // buttonchuyen
            // 
            buttonchuyen.BackColor = SystemColors.ButtonFace;
            buttonchuyen.Location = new Point(76, 144);
            buttonchuyen.Name = "buttonchuyen";
            buttonchuyen.Size = new Size(277, 36);
            buttonchuyen.TabIndex = 6;
            buttonchuyen.Text = "Chuyển đổi ";
            buttonchuyen.UseVisualStyleBackColor = false;
            buttonchuyen.UseWaitCursor = true;
            buttonchuyen.Click += button1_Click;
            // 
            // boxloaitien2
            // 
            boxloaitien2.FormattingEnabled = true;
            boxloaitien2.Items.AddRange(new object[] { "USD (Đô-la Mỹ)", "EUR (Euro)", "GBD (Bảng Anh)", "SGD (Đô-la Singapore)", "JPY (Yên Nhật)", "VND (Việt Nam Đồng)" });
            boxloaitien2.Location = new Point(379, 222);
            boxloaitien2.Name = "boxloaitien2";
            boxloaitien2.Size = new Size(151, 28);
            boxloaitien2.TabIndex = 7;
            boxloaitien2.UseWaitCursor = true;
            // 
            // labletygia
            // 
            labletygia.AutoSize = true;
            labletygia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labletygia.Location = new Point(264, 306);
            labletygia.Name = "labletygia";
            labletygia.Size = new Size(0, 20);
            labletygia.TabIndex = 8;
            labletygia.UseWaitCursor = true;
            // 
            // labeltygia
            // 
            labeltygia.AutoSize = true;
            labeltygia.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labeltygia.Location = new Point(264, 306);
            labeltygia.Name = "labeltygia";
            labeltygia.Size = new Size(17, 20);
            labeltygia.TabIndex = 9;
            labeltygia.Text = "0";
            labeltygia.UseWaitCursor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(labeltygia);
            Controls.Add(labletygia);
            Controls.Add(boxloaitien2);
            Controls.Add(buttonchuyen);
            Controls.Add(txttien2);
            Controls.Add(boxloaitien1);
            Controls.Add(txttien1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Bảng chuyển đổi tiền tệ ";
            UseWaitCursor = true;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttien1;
        private ComboBox boxloaitien1;
        private TextBox txttien2;
        private Button buttonchuyen;
        private ComboBox boxloaitien2;
        private Label labletygia;
        private Label labeltygia;
    }
}