namespace CircularMotionWinForms
{
    partial class Duplicate
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
            components = new System.ComponentModel.Container();
            tangentialInput = new TextBox();
            massInput = new TextBox();
            radiusInput = new TextBox();
            clearBtn = new Button();
            angularInput = new TextBox();
            btnSubmit = new Button();
            label10 = new Label();
            option = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            massLabel = new ComboBox();
            groupBox2 = new GroupBox();
            radiusLabel = new ComboBox();
            groupBox3 = new GroupBox();
            tangentialLabel = new ComboBox();
            groupBox4 = new GroupBox();
            angularLabel = new ComboBox();
            MassError = new ErrorProvider(components);
            TangentialError = new ErrorProvider(components);
            RadiusError = new ErrorProvider(components);
            AngularError = new ErrorProvider(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            answer = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MassError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TangentialError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadiusError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngularError).BeginInit();
            SuspendLayout();
            // 
            // tangentialInput
            // 
            tangentialInput.Anchor = AnchorStyles.None;
            tangentialInput.Cursor = Cursors.IBeam;
            tangentialInput.ForeColor = SystemColors.Desktop;
            tangentialInput.Location = new Point(11, 26);
            tangentialInput.Multiline = true;
            tangentialInput.Name = "tangentialInput";
            tangentialInput.Size = new Size(160, 23);
            tangentialInput.TabIndex = 1;
            tangentialInput.TextChanged += tangentialInput_TextChanged;
            tangentialInput.KeyPress += tangentialInput_KeyPress;
            tangentialInput.KeyUp += tangentialInput_KeyUp;
            // 
            // massInput
            // 
            massInput.Anchor = AnchorStyles.None;
            massInput.Cursor = Cursors.IBeam;
            massInput.ForeColor = SystemColors.Desktop;
            massInput.Location = new Point(18, 24);
            massInput.Multiline = true;
            massInput.Name = "massInput";
            massInput.Size = new Size(160, 23);
            massInput.TabIndex = 3;
            massInput.TextChanged += massInput_TextChanged;
            massInput.KeyPress += massInput_KeyPress;
            // 
            // radiusInput
            // 
            radiusInput.Anchor = AnchorStyles.None;
            radiusInput.Cursor = Cursors.IBeam;
            radiusInput.ForeColor = SystemColors.Desktop;
            radiusInput.Location = new Point(18, 27);
            radiusInput.Multiline = true;
            radiusInput.Name = "radiusInput";
            radiusInput.Size = new Size(160, 23);
            radiusInput.TabIndex = 5;
            radiusInput.TextChanged += radiusInput_TextChanged;
            radiusInput.KeyPress += radiusInput_KeyPress;
            radiusInput.KeyUp += radiusInput_KeyUp;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.None;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(367, 375);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 22);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear All";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += submitBtn_Click;
            // 
            // angularInput
            // 
            angularInput.Anchor = AnchorStyles.None;
            angularInput.Cursor = Cursors.IBeam;
            angularInput.ForeColor = SystemColors.Desktop;
            angularInput.Location = new Point(11, 27);
            angularInput.Multiline = true;
            angularInput.Name = "angularInput";
            angularInput.Size = new Size(160, 23);
            angularInput.TabIndex = 8;
            angularInput.TextChanged += angularInput_TextChanged;
            angularInput.KeyPress += angularInput_KeyPress;
            angularInput.KeyUp += angularInput_KeyUp;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(367, 321);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 22;
            btnSubmit.Text = "Calculate";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.System;
            label10.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.InfoText;
            label10.Location = new Point(322, 297);
            label10.Name = "label10";
            label10.Size = new Size(43, 16);
            label10.TabIndex = 13;
            label10.Text = "Option";
            // 
            // option
            // 
            option.Anchor = AnchorStyles.None;
            option.BackColor = Color.FromArgb(55, 58, 64);
            option.Cursor = Cursors.Hand;
            option.DropDownStyle = ComboBoxStyle.DropDownList;
            option.FlatStyle = FlatStyle.Flat;
            option.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            option.ForeColor = Color.FromArgb(238, 238, 238);
            option.FormattingEnabled = true;
            option.Items.AddRange(new object[] { "Centripetal Force", "Acceleration", "Linear Velocity" });
            option.Location = new Point(367, 294);
            option.Margin = new Padding(2);
            option.Name = "option";
            option.Size = new Size(129, 22);
            option.TabIndex = 23;
            option.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(220, 95, 0);
            label11.Location = new Point(167, 88);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(506, 35);
            label11.TabIndex = 24;
            label11.Text = "KJK CIRCULAR MOTION CALCULATOR";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.System;
            label12.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.InfoText;
            label12.Location = new Point(313, 353);
            label12.Name = "label12";
            label12.Size = new Size(52, 16);
            label12.TabIndex = 25;
            label12.Text = "Answer";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(104, 109, 118);
            groupBox1.Controls.Add(massLabel);
            groupBox1.Controls.Add(massInput);
            groupBox1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox1.Location = new Point(158, 138);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(259, 69);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mass";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // massLabel
            // 
            massLabel.Anchor = AnchorStyles.None;
            massLabel.Cursor = Cursors.Hand;
            massLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            massLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            massLabel.FormattingEnabled = true;
            massLabel.Items.AddRange(new object[] { "kg", "g" });
            massLabel.Location = new Point(181, 24);
            massLabel.Margin = new Padding(2);
            massLabel.Name = "massLabel";
            massLabel.Size = new Size(60, 22);
            massLabel.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = Color.FromArgb(104, 109, 118);
            groupBox2.Controls.Add(radiusLabel);
            groupBox2.Controls.Add(radiusInput);
            groupBox2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox2.Location = new Point(158, 212);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(259, 69);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Radius";
            // 
            // radiusLabel
            // 
            radiusLabel.Anchor = AnchorStyles.None;
            radiusLabel.Cursor = Cursors.Hand;
            radiusLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            radiusLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radiusLabel.FormattingEnabled = true;
            radiusLabel.Items.AddRange(new object[] { "m", "cm", "km", "in" });
            radiusLabel.Location = new Point(181, 27);
            radiusLabel.Margin = new Padding(2);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(60, 22);
            radiusLabel.TabIndex = 31;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.FromArgb(104, 109, 118);
            groupBox3.Controls.Add(tangentialLabel);
            groupBox3.Controls.Add(tangentialInput);
            groupBox3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox3.Location = new Point(425, 138);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(259, 69);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tangential Velocity";
            // 
            // tangentialLabel
            // 
            tangentialLabel.Anchor = AnchorStyles.None;
            tangentialLabel.Cursor = Cursors.Hand;
            tangentialLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            tangentialLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tangentialLabel.FormattingEnabled = true;
            tangentialLabel.Items.AddRange(new object[] { "m/s", "km/h" });
            tangentialLabel.Location = new Point(175, 26);
            tangentialLabel.Margin = new Padding(2);
            tangentialLabel.Name = "tangentialLabel";
            tangentialLabel.Size = new Size(60, 22);
            tangentialLabel.TabIndex = 31;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.BackColor = Color.FromArgb(104, 109, 118);
            groupBox4.Controls.Add(angularLabel);
            groupBox4.Controls.Add(angularInput);
            groupBox4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.FromArgb(238, 238, 238);
            groupBox4.Location = new Point(425, 212);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(259, 69);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Angular Velocity";
            // 
            // angularLabel
            // 
            angularLabel.Anchor = AnchorStyles.None;
            angularLabel.Cursor = Cursors.Hand;
            angularLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            angularLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            angularLabel.FormattingEnabled = true;
            angularLabel.Items.AddRange(new object[] { "rad/s", "rpm" });
            angularLabel.Location = new Point(175, 27);
            angularLabel.Margin = new Padding(2);
            angularLabel.Name = "angularLabel";
            angularLabel.Size = new Size(60, 22);
            angularLabel.TabIndex = 31;
            // 
            // MassError
            // 
            MassError.ContainerControl = this;
            // 
            // TangentialError
            // 
            TangentialError.ContainerControl = this;
            // 
            // RadiusError
            // 
            RadiusError.ContainerControl = this;
            // 
            // AngularError
            // 
            AngularError.ContainerControl = this;
            // 
            // answer
            // 
            answer.Anchor = AnchorStyles.None;
            answer.BackColor = Color.FromArgb(55, 58, 64);
            answer.Font = new Font("Bahnschrift", 11F, FontStyle.Regular, GraphicsUnit.Point);
            answer.ForeColor = Color.FromArgb(238, 238, 238);
            answer.Location = new Point(367, 351);
            answer.Margin = new Padding(2, 0, 2, 0);
            answer.Name = "answer";
            answer.Size = new Size(129, 21);
            answer.TabIndex = 30;
            // 
            // Duplicate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(845, 501);
            Controls.Add(answer);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(option);
            Controls.Add(btnSubmit);
            Controls.Add(label10);
            Controls.Add(clearBtn);
            Name = "Duplicate";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MassError).EndInit();
            ((System.ComponentModel.ISupportInitialize)TangentialError).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadiusError).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngularError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tangentialInput;
        private TextBox massInput;
        private TextBox radiusInput;
        private Button clearBtn;
        private TextBox angularInput;
        private Button btnSubmit;
        private Label label10;
        private ComboBox option;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ErrorProvider MassError;
        private ErrorProvider TangentialError;
        private ErrorProvider RadiusError;
        private ErrorProvider AngularError;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox massLabel;
        private ComboBox radiusLabel;
        private ComboBox tangentialLabel;
        private ComboBox angularLabel;
        private Label answer;
    }
}
