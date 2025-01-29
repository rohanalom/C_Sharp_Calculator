namespace Calculator
{
    partial class Calculator
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
            txt_display = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btn_equals = new Button();
            button11 = new Button();
            btn_point = new Button();
            btn_plus = new Button();
            btn_divide = new Button();
            btn_multiply = new Button();
            btn_minus = new Button();
            btn_clear = new Button();
            btn_backspace = new Button();
            SuspendLayout();
            // 
            // txt_display
            // 
            txt_display.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_display.Location = new Point(13, 17);
            txt_display.Name = "txt_display";
            txt_display.ReadOnly = true;
            txt_display.RightToLeft = RightToLeft.Yes;
            txt_display.Size = new Size(489, 43);
            txt_display.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(33, 134);
            button1.Name = "button1";
            button1.Size = new Size(82, 76);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_digit_click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(141, 134);
            button2.Name = "button2";
            button2.Size = new Size(82, 76);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_digit_click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(247, 134);
            button3.Name = "button3";
            button3.Size = new Size(82, 76);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_digit_click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(247, 238);
            button4.Name = "button4";
            button4.Size = new Size(82, 76);
            button4.TabIndex = 6;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_digit_click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(141, 238);
            button5.Name = "button5";
            button5.Size = new Size(82, 76);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_digit_click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(33, 238);
            button6.Name = "button6";
            button6.Size = new Size(82, 76);
            button6.TabIndex = 4;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_digit_click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(247, 334);
            button7.Name = "button7";
            button7.Size = new Size(82, 76);
            button7.TabIndex = 9;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_digit_click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(141, 334);
            button8.Name = "button8";
            button8.Size = new Size(82, 76);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_digit_click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(33, 334);
            button9.Name = "button9";
            button9.Size = new Size(82, 76);
            button9.TabIndex = 7;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btn_digit_click;
            // 
            // btn_equals
            // 
            btn_equals.Font = new Font("Segoe UI", 12F);
            btn_equals.ForeColor = SystemColors.ActiveCaptionText;
            btn_equals.Location = new Point(247, 432);
            btn_equals.Name = "btn_equals";
            btn_equals.Size = new Size(250, 76);
            btn_equals.TabIndex = 12;
            btn_equals.Text = "=";
            btn_equals.UseVisualStyleBackColor = true;
            btn_equals.Click += btn_equals_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 12F);
            button11.ForeColor = SystemColors.ActiveCaptionText;
            button11.Location = new Point(141, 432);
            button11.Name = "button11";
            button11.Size = new Size(82, 76);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btn_digit_click;
            // 
            // btn_point
            // 
            btn_point.Font = new Font("Segoe UI", 12F);
            btn_point.ForeColor = SystemColors.ActiveCaptionText;
            btn_point.Location = new Point(33, 432);
            btn_point.Name = "btn_point";
            btn_point.Size = new Size(82, 76);
            btn_point.TabIndex = 10;
            btn_point.Text = ".";
            btn_point.UseVisualStyleBackColor = true;
            btn_point.Click += btn_digit_click;
            // 
            // btn_plus
            // 
            btn_plus.BackColor = Color.White;
            btn_plus.Font = new Font("Segoe UI", 12F);
            btn_plus.ForeColor = SystemColors.ActiveCaptionText;
            btn_plus.Location = new Point(363, 134);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(134, 56);
            btn_plus.TabIndex = 13;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = false;
            btn_plus.Click += btn_operator_click;
            // 
            // btn_divide
            // 
            btn_divide.BackColor = Color.White;
            btn_divide.Font = new Font("Segoe UI", 12F);
            btn_divide.ForeColor = SystemColors.ActiveCaptionText;
            btn_divide.Location = new Point(363, 354);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(134, 56);
            btn_divide.TabIndex = 14;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = false;
            btn_divide.Click += btn_operator_click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.White;
            btn_multiply.Font = new Font("Segoe UI", 12F);
            btn_multiply.ForeColor = SystemColors.ActiveCaptionText;
            btn_multiply.Location = new Point(363, 281);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(134, 56);
            btn_multiply.TabIndex = 15;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_operator_click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.White;
            btn_minus.Font = new Font("Segoe UI", 12F);
            btn_minus.ForeColor = SystemColors.ActiveCaptionText;
            btn_minus.Location = new Point(363, 206);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(134, 56);
            btn_minus.TabIndex = 16;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_operator_click;
            // 
            // btn_clear
            // 
            btn_clear.ForeColor = SystemColors.ActiveCaptionText;
            btn_clear.Location = new Point(33, 83);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 34);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_backspace
            // 
            btn_backspace.BackColor = Color.Gray;
            btn_backspace.ForeColor = SystemColors.ButtonHighlight;
            btn_backspace.Location = new Point(422, 83);
            btn_backspace.Margin = new Padding(0);
            btn_backspace.Name = "btn_backspace";
            btn_backspace.Size = new Size(75, 34);
            btn_backspace.TabIndex = 18;
            btn_backspace.Text = "DEL";
            btn_backspace.UseVisualStyleBackColor = false;
            btn_backspace.Click += btn_backspace_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(523, 552);
            Controls.Add(btn_backspace);
            Controls.Add(btn_clear);
            Controls.Add(btn_minus);
            Controls.Add(btn_multiply);
            Controls.Add(btn_divide);
            Controls.Add(btn_plus);
            Controls.Add(btn_equals);
            Controls.Add(button11);
            Controls.Add(btn_point);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_display);
            Cursor = Cursors.No;
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            Click += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btn_equals;
        private Button button11;
        private Button btn_point;
        private Button btn_plus;
        private Button btn_divide;
        private Button btn_multiply;
        private Button btn_minus;
        private Button btn_clear;
        private Button btn_backspace;
    }
}
