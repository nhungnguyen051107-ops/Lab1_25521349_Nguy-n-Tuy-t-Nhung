namespace Project1
{
    partial class Calculator
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
            txtresult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnequal = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            lbhistory = new Label();
            SuspendLayout();
            // 
            // txtresult
            // 
            txtresult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtresult.ForeColor = SystemColors.ControlText;
            txtresult.Location = new Point(2, 44);
            txtresult.Multiline = true;
            txtresult.Name = "txtresult";
            txtresult.ReadOnly = true;
            txtresult.RightToLeft = RightToLeft.Yes;
            txtresult.Size = new Size(390, 46);
            txtresult.TabIndex = 0;
            txtresult.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(2, 432);
            button1.Name = "button1";
            button1.Size = new Size(93, 82);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click_Number;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.Location = new Point(101, 432);
            button2.Name = "button2";
            button2.Size = new Size(93, 82);
            button2.TabIndex = 2;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click_Number;
            // 
            // btnequal
            // 
            btnequal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnequal.Location = new Point(200, 432);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(93, 82);
            btnequal.TabIndex = 3;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button4.Location = new Point(299, 432);
            button4.Name = "button4";
            button4.Size = new Size(93, 82);
            button4.TabIndex = 4;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Operator_CLick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button5.Location = new Point(2, 344);
            button5.Name = "button5";
            button5.Size = new Size(93, 82);
            button5.TabIndex = 5;
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click_Number;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button6.Location = new Point(101, 344);
            button6.Name = "button6";
            button6.Size = new Size(93, 82);
            button6.TabIndex = 6;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click_Number;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button7.Location = new Point(299, 168);
            button7.Name = "button7";
            button7.Size = new Size(93, 82);
            button7.TabIndex = 7;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Operator_CLick;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button8.Location = new Point(101, 168);
            button8.Name = "button8";
            button8.Size = new Size(93, 82);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click_Number;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button9.Location = new Point(200, 168);
            button9.Name = "button9";
            button9.Size = new Size(93, 82);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click_Number;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button10.Location = new Point(200, 256);
            button10.Name = "button10";
            button10.Size = new Size(93, 82);
            button10.TabIndex = 10;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button_Click_Number;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button11.Location = new Point(200, 344);
            button11.Name = "button11";
            button11.Size = new Size(93, 82);
            button11.TabIndex = 11;
            button11.Text = "3";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button_Click_Number;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button12.Location = new Point(299, 256);
            button12.Name = "button12";
            button12.Size = new Size(93, 82);
            button12.TabIndex = 12;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Operator_CLick;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button13.Location = new Point(101, 256);
            button13.Name = "button13";
            button13.Size = new Size(93, 82);
            button13.TabIndex = 13;
            button13.Text = "5";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_Click_Number;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button14.Location = new Point(299, 344);
            button14.Name = "button14";
            button14.Size = new Size(93, 82);
            button14.TabIndex = 14;
            button14.Text = "*";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operator_CLick;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button15.Location = new Point(2, 168);
            button15.Name = "button15";
            button15.Size = new Size(93, 82);
            button15.TabIndex = 15;
            button15.Text = "7";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button_Click_Number;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button16.Location = new Point(2, 256);
            button16.Name = "button16";
            button16.Size = new Size(93, 82);
            button16.TabIndex = 16;
            button16.Text = "4";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Button_Click_Number;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Location = new Point(265, 122);
            button17.Name = "button17";
            button17.Size = new Size(127, 40);
            button17.TabIndex = 17;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Location = new Point(132, 122);
            button18.Name = "button18";
            button18.Size = new Size(127, 40);
            button18.TabIndex = 18;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // lbhistory
            // 
            lbhistory.AutoSize = true;
            lbhistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbhistory.Location = new Point(2, 0);
            lbhistory.Name = "lbhistory";
            lbhistory.Size = new Size(19, 23);
            lbhistory.TabIndex = 19;
            lbhistory.Text = "0";
            lbhistory.Click += label1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 525);
            Controls.Add(lbhistory);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnequal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtresult);
            Name = "Form5";
            Text = "Form5";
            Click += Button_Click_Number;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtresult;
        private Button button1;
        private Button button2;
        private Button btnequal;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label lbhistory;
    }
}