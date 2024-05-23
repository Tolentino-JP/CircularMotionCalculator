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
            label9 = new Label();
            centripetalInput = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            velocityInput = new TextBox();
            label13 = new Label();
            accelerationInput = new TextBox();
            label14 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 145);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Tangential Velocity";
            // 
            // tangentialInput
            // 
            tangentialInput.Location = new Point(64, 160);
            tangentialInput.Multiline = true;
            tangentialInput.Name = "tangentialInput";
            tangentialInput.Size = new Size(160, 23);
            tangentialInput.TabIndex = 1;
            tangentialInput.TextChanged += tangentialInput_TextChanged;
            tangentialInput.KeyPress += tangentialInput_KeyPress;
            // 
            // massInput
            // 
            massInput.Location = new Point(63, 81);
            massInput.Multiline = true;
            massInput.Name = "massInput";
            massInput.Size = new Size(160, 23);
            massInput.TabIndex = 3;
            massInput.TextChanged += massInput_TextChanged;
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
            radiusInput.TextChanged += radiusInput_TextChanged;
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
            // angularInput
            // 
            angularInput.Location = new Point(64, 205);
            angularInput.Multiline = true;
            angularInput.Name = "angularInput";
            angularInput.Size = new Size(160, 23);
            angularInput.TabIndex = 8;
            angularInput.TextChanged += angularInput_TextChanged;
            angularInput.KeyPress += angularInput_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 190);
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
            label7.Location = new Point(224, 163);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 11;
            label7.Text = "(m/s)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 208);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 12;
            label8.Text = "(rad/s)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(482, 84);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 15;
            label9.Text = "(N)";
            // 
            // centripetalInput
            // 
            centripetalInput.Location = new Point(321, 81);
            centripetalInput.Multiline = true;
            centripetalInput.Name = "centripetalInput";
            centripetalInput.Size = new Size(160, 23);
            centripetalInput.TabIndex = 14;
            centripetalInput.TextChanged += centripetalInput_TextChanged;
            centripetalInput.KeyPress += centripetalInput_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(320, 66);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 13;
            label10.Text = "Centripetal Force";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(481, 166);
            label11.Name = "label11";
            label11.Size = new Size(50, 15);
            label11.TabIndex = 21;
            label11.Text = "(m/s^2)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(482, 125);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 20;
            label12.Text = "(m/s)";
            // 
            // velocityInput
            // 
            velocityInput.Location = new Point(321, 122);
            velocityInput.Multiline = true;
            velocityInput.Name = "velocityInput";
            velocityInput.Size = new Size(160, 23);
            velocityInput.TabIndex = 19;
            velocityInput.TextChanged += velocityInput_TextChanged;
            velocityInput.KeyPress += velocityInput_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(320, 107);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 18;
            label13.Text = "Velocity";
            // 
            // accelerationInput
            // 
            accelerationInput.Location = new Point(321, 163);
            accelerationInput.Multiline = true;
            accelerationInput.Name = "accelerationInput";
            accelerationInput.Size = new Size(160, 23);
            accelerationInput.TabIndex = 17;
            accelerationInput.TextChanged += accelerationInput_TextChanged;
            accelerationInput.KeyPress += accelerationInput_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(320, 148);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 16;
            label14.Text = "Acceleration";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(velocityInput);
            Controls.Add(label13);
            Controls.Add(accelerationInput);
            Controls.Add(label14);
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
            Name = "index";
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
        private Label label9;
        private TextBox centripetalInput;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox velocityInput;
        private Label label13;
        private TextBox accelerationInput;
        private Label label14;
    }
}
