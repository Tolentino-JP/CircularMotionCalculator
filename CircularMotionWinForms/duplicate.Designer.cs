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
            submitBtn = new Button();
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
            tangentialInput.Location = new Point(16, 44);
            tangentialInput.Margin = new Padding(4, 5, 4, 5);
            tangentialInput.Multiline = true;
            tangentialInput.Name = "tangentialInput";
            tangentialInput.Size = new Size(227, 36);
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
            massInput.Location = new Point(25, 40);
            massInput.Margin = new Padding(4, 5, 4, 5);
            massInput.Multiline = true;
            massInput.Name = "massInput";
            massInput.Size = new Size(227, 36);
            massInput.TabIndex = 3;
            massInput.TextChanged += massInput_TextChanged;
            massInput.KeyPress += massInput_KeyPress;
            // 
            // radiusInput
            // 
            radiusInput.Anchor = AnchorStyles.None;
            radiusInput.Cursor = Cursors.IBeam;
            radiusInput.ForeColor = SystemColors.Desktop;
            radiusInput.Location = new Point(25, 45);
            radiusInput.Margin = new Padding(4, 5, 4, 5);
            radiusInput.Multiline = true;
            radiusInput.Name = "radiusInput";
            radiusInput.Size = new Size(227, 36);
            radiusInput.TabIndex = 5;
            radiusInput.TextChanged += radiusInput_TextChanged;
            radiusInput.KeyPress += radiusInput_KeyPress;
            radiusInput.KeyUp += radiusInput_KeyUp;
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.None;
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.Location = new Point(532, 491);
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
            angularInput.Cursor = Cursors.IBeam;
            angularInput.ForeColor = SystemColors.Desktop;
            angularInput.Location = new Point(16, 45);
            angularInput.Margin = new Padding(4, 5, 4, 5);
            angularInput.Multiline = true;
            angularInput.Name = "angularInput";
            angularInput.Size = new Size(227, 36);
            angularInput.TabIndex = 8;
            angularInput.TextChanged += angularInput_TextChanged;
            angularInput.KeyPress += angularInput_KeyPress;
            angularInput.KeyUp += angularInput_KeyUp;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(413, 491);
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
            label10.Location = new Point(170, 382);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 25);
            label10.TabIndex = 13;
            label10.Text = "Option";
            // 
            // option
            // 
            option.Anchor = AnchorStyles.None;
            option.BackColor = SystemColors.ActiveCaption;
            option.Cursor = Cursors.Hand;
            option.DropDownStyle = ComboBoxStyle.DropDownList;
            option.FlatStyle = FlatStyle.Flat;
            option.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            option.FormattingEnabled = true;
            option.Items.AddRange(new object[] { "Centripetal Force", "Acceleration", "Linear Velocity" });
            option.Location = new Point(170, 412);
            option.Name = "option";
            option.Size = new Size(370, 36);
            option.TabIndex = 23;
            option.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(133, 32);
            label11.Name = "label11";
            label11.Size = new Size(781, 54);
            label11.TabIndex = 24;
            label11.Text = "KJK CIRCULAR MOTION CALCULATOR";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Location = new Point(552, 382);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 25;
            label12.Text = "Answer";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(massLabel);
            groupBox1.Controls.Add(massInput);
            groupBox1.Location = new Point(170, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 115);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mass";
            // 
            // massLabel
            // 
            massLabel.Anchor = AnchorStyles.None;
            massLabel.Cursor = Cursors.Hand;
            massLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            massLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            massLabel.FormattingEnabled = true;
            massLabel.Items.AddRange(new object[] { "kg", "g" });
            massLabel.Location = new Point(258, 40);
            massLabel.Name = "massLabel";
            massLabel.Size = new Size(84, 36);
            massLabel.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(radiusLabel);
            groupBox2.Controls.Add(radiusInput);
            groupBox2.Location = new Point(170, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 115);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Radius";
            // 
            // radiusLabel
            // 
            radiusLabel.Anchor = AnchorStyles.None;
            radiusLabel.Cursor = Cursors.Hand;
            radiusLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            radiusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radiusLabel.FormattingEnabled = true;
            radiusLabel.Items.AddRange(new object[] { "m", "cm", "km", "in" });
            radiusLabel.Location = new Point(258, 45);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(84, 36);
            radiusLabel.TabIndex = 31;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = SystemColors.ActiveCaption;
            groupBox3.Controls.Add(tangentialLabel);
            groupBox3.Controls.Add(tangentialInput);
            groupBox3.Location = new Point(552, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(370, 115);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tangential Velocity";
            // 
            // tangentialLabel
            // 
            tangentialLabel.Anchor = AnchorStyles.None;
            tangentialLabel.Cursor = Cursors.Hand;
            tangentialLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            tangentialLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tangentialLabel.FormattingEnabled = true;
            tangentialLabel.Items.AddRange(new object[] { "m/s", "km/h" });
            tangentialLabel.Location = new Point(250, 44);
            tangentialLabel.Name = "tangentialLabel";
            tangentialLabel.Size = new Size(84, 36);
            tangentialLabel.TabIndex = 31;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.BackColor = SystemColors.ActiveCaption;
            groupBox4.Controls.Add(angularLabel);
            groupBox4.Controls.Add(angularInput);
            groupBox4.Location = new Point(552, 240);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(370, 115);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Angular Velocity";
            // 
            // angularLabel
            // 
            angularLabel.Anchor = AnchorStyles.None;
            angularLabel.Cursor = Cursors.Hand;
            angularLabel.DropDownStyle = ComboBoxStyle.DropDownList;
            angularLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            angularLabel.FormattingEnabled = true;
            angularLabel.Items.AddRange(new object[] { "rad/s", "rpm" });
            angularLabel.Location = new Point(250, 45);
            angularLabel.Name = "angularLabel";
            angularLabel.Size = new Size(84, 36);
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
            answer.BackColor = SystemColors.ActiveCaption;
            answer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            answer.Location = new Point(552, 412);
            answer.Name = "answer";
            answer.Size = new Size(370, 36);
            answer.TabIndex = 30;
            // 
            // Duplicate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 656);
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
            Controls.Add(submitBtn);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button submitBtn;
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
