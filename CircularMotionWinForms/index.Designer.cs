namespace CircularMotionWinForms
{
    partial class index
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
            velocityInput = new TextBox();
            massInput = new TextBox();
            label2 = new Label();
            radiusInput = new TextBox();
            label3 = new Label();
            submitBtn = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 145);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Tangential Velocity";
            // 
            // velocityInput
            // 
            velocityInput.Location = new Point(65, 160);
            velocityInput.Multiline = true;
            velocityInput.Name = "velocityInput";
            velocityInput.Size = new Size(160, 23);
            velocityInput.TabIndex = 1;
            velocityInput.KeyPress += velocityInput_KeyPress;
            // 
            // massInput
            // 
            massInput.Location = new Point(63, 81);
            massInput.Multiline = true;
            massInput.Name = "massInput";
            massInput.Size = new Size(160, 23);
            massInput.TabIndex = 3;
            massInput.KeyPress += massInput_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 66);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Mass";
            // 
            // radiusInput
            // 
            radiusInput.Location = new Point(63, 119);
            radiusInput.Multiline = true;
            radiusInput.Name = "radiusInput";
            radiusInput.Size = new Size(160, 23);
            radiusInput.TabIndex = 5;
            radiusInput.KeyPress += radiusInput_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 104);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Radius";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(150, 254);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 6;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 205);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 190);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Angular Velocity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 84);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 9;
            label5.Text = "(kg)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 122);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 10;
            label6.Text = "(m)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 163);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 11;
            label7.Text = "(m/s)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 208);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 12;
            label8.Text = "(rad/s)";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(submitBtn);
            Controls.Add(radiusInput);
            Controls.Add(label3);
            Controls.Add(massInput);
            Controls.Add(label2);
            Controls.Add(velocityInput);
            Controls.Add(label1);
            Name = "index";
            Text = "Index";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox velocityInput;
        private TextBox massInput;
        private Label label2;
        private TextBox radiusInput;
        private Label label3;
        private Button submitBtn;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
