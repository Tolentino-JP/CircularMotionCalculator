﻿namespace CircularMotionWinForms
{
    partial class duplicate
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
            label1 = new Label();
            tangentialInput = new TextBox();
            massInput = new TextBox();
            label2 = new Label();
            radiusInput = new TextBox();
            label3 = new Label();
            submitBtn = new Button();
            angularInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSubmit = new Button();
            label10 = new Label();
            centripetalInput = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(225, 191);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Tangential Velocity";
            // 
            // tangentialInput
            // 
            tangentialInput.Anchor = AnchorStyles.None;
            tangentialInput.Location = new Point(226, 216);
            tangentialInput.Margin = new Padding(4, 5, 4, 5);
            tangentialInput.Multiline = true;
            tangentialInput.Name = "tangentialInput";
            tangentialInput.Size = new Size(227, 36);
            tangentialInput.TabIndex = 1;
            tangentialInput.TextChanged += tangentialInput_TextChanged;
            tangentialInput.KeyPress += tangentialInput_KeyPress;
            // 
            // massInput
            // 
            massInput.Anchor = AnchorStyles.None;
            massInput.Location = new Point(225, 84);
            massInput.Margin = new Padding(4, 5, 4, 5);
            massInput.Multiline = true;
            massInput.Name = "massInput";
            massInput.Size = new Size(227, 36);
            massInput.TabIndex = 3;
            massInput.TextChanged += massInput_TextChanged;
            massInput.KeyPress += massInput_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(224, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Mass";
            // 
            // radiusInput
            // 
            radiusInput.Anchor = AnchorStyles.None;
            radiusInput.Location = new Point(225, 147);
            radiusInput.Margin = new Padding(4, 5, 4, 5);
            radiusInput.Multiline = true;
            radiusInput.Name = "radiusInput";
            radiusInput.Size = new Size(227, 36);
            radiusInput.TabIndex = 5;
            radiusInput.TextChanged += radiusInput_TextChanged;
            radiusInput.KeyPress += radiusInput_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(224, 122);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Radius";
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Location = new Point(349, 372);
            submitBtn.Margin = new Padding(4, 5, 4, 5);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(107, 38);
            submitBtn.TabIndex = 6;
            submitBtn.Text = "Clear All";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // angularInput
            // 
            angularInput.Anchor = AnchorStyles.None;
            angularInput.Location = new Point(226, 291);
            angularInput.Margin = new Padding(4, 5, 4, 5);
            angularInput.Multiline = true;
            angularInput.Name = "angularInput";
            angularInput.Size = new Size(227, 36);
            angularInput.TabIndex = 8;
            angularInput.TextChanged += angularInput_TextChanged;
            angularInput.KeyPress += angularInput_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(225, 266);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 7;
            label4.Text = "Angular Velocity";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(455, 89);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 9;
            label5.Text = "(kg)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(455, 152);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 25);
            label6.TabIndex = 10;
            label6.Text = "(m)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(455, 221);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 11;
            label7.Text = "(m/s)";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(455, 296);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 12;
            label8.Text = "(rad/s)";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Location = new Point(234, 372);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 38);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(592, 59);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(145, 25);
            label10.TabIndex = 13;
            label10.Text = "Centripetal Force";
            // 
            // centripetalInput
            // 
            centripetalInput.Anchor = AnchorStyles.None;
            centripetalInput.Location = new Point(594, 84);
            centripetalInput.Margin = new Padding(4, 5, 4, 5);
            centripetalInput.Multiline = true;
            centripetalInput.Name = "centripetalInput";
            centripetalInput.Size = new Size(227, 36);
            centripetalInput.TabIndex = 14;
            centripetalInput.TextChanged += centripetalInput_TextChanged;
            centripetalInput.KeyPress += centripetalInput_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(824, 89);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(35, 25);
            label9.TabIndex = 15;
            label9.Text = "(N)";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Centripetal Force", "Acceleration", "Linear Velocity" });
            comboBox1.Location = new Point(592, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 33);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // duplicate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 568);
            Controls.Add(comboBox1);
            Controls.Add(btnSubmit);
            Controls.Add(label9);
            Controls.Add(centripetalInput);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(angularInput);
            Controls.Add(label4);
            Controls.Add(submitBtn);
            Controls.Add(radiusInput);
            Controls.Add(label3);
            Controls.Add(massInput);
            Controls.Add(label2);
            Controls.Add(tangentialInput);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "duplicate";
            Text = "Index";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tangentialInput;
        private TextBox massInput;
        private Label label2;
        private TextBox radiusInput;
        private Label label3;
        private Button submitBtn;
        private TextBox angularInput;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSubmit;
        private Label label10;
        private TextBox centripetalInput;
        private Label label9;
        private ComboBox comboBox1;
    }
}