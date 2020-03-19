namespace VRTSGUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trialPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.txtContinuousCarSpeed = new System.Windows.Forms.TextBox();
            this.lblContinuousCarSpeed = new System.Windows.Forms.Label();
            this.trialTypeLabel = new System.Windows.Forms.Label();
            this.cbTrialType = new System.Windows.Forms.ComboBox();
            this.cbCarBehaviour = new System.Windows.Forms.ComboBox();
            this.carBehaviourLabel = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.trialPropertiesGroupBox.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(194, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 46);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of Directions";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(157, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Two Directions";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One Direction";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Space:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(2, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Spaces";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(23, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(613, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right Facing Cars";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seconds:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(420, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meters:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(420, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(25, 484);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(820, 146);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Left Facing Cars";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(700, 73);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "None";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Offset";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seconds:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(420, 22);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Meters:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 73);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(420, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(206, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Space:";
            // 
            // trialPropertiesGroupBox
            // 
            this.trialPropertiesGroupBox.Controls.Add(this.txtContinuousCarSpeed);
            this.trialPropertiesGroupBox.Controls.Add(this.lblContinuousCarSpeed);
            this.trialPropertiesGroupBox.Controls.Add(this.trialTypeLabel);
            this.trialPropertiesGroupBox.Controls.Add(this.cbTrialType);
            this.trialPropertiesGroupBox.Controls.Add(this.cbCarBehaviour);
            this.trialPropertiesGroupBox.Controls.Add(this.carBehaviourLabel);
            this.trialPropertiesGroupBox.Location = new System.Drawing.Point(13, 2);
            this.trialPropertiesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.trialPropertiesGroupBox.Name = "trialPropertiesGroupBox";
            this.trialPropertiesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.trialPropertiesGroupBox.Size = new System.Drawing.Size(641, 261);
            this.trialPropertiesGroupBox.TabIndex = 11;
            this.trialPropertiesGroupBox.TabStop = false;
            this.trialPropertiesGroupBox.Text = "Trial Properties";
            // 
            // txtContinuousCarSpeed
            // 
            this.txtContinuousCarSpeed.Location = new System.Drawing.Point(266, 159);
            this.txtContinuousCarSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.txtContinuousCarSpeed.Name = "txtContinuousCarSpeed";
            this.txtContinuousCarSpeed.Size = new System.Drawing.Size(81, 22);
            this.txtContinuousCarSpeed.TabIndex = 2;
            // 
            // lblContinuousCarSpeed
            // 
            this.lblContinuousCarSpeed.Location = new System.Drawing.Point(137, 162);
            this.lblContinuousCarSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContinuousCarSpeed.Name = "lblContinuousCarSpeed";
            this.lblContinuousCarSpeed.Size = new System.Drawing.Size(155, 16);
            this.lblContinuousCarSpeed.TabIndex = 42;
            this.lblContinuousCarSpeed.Text = "Car Speed (km/h):";
            // 
            // trialTypeLabel
            // 
            this.trialTypeLabel.AutoSize = true;
            this.trialTypeLabel.Location = new System.Drawing.Point(211, 68);
            this.trialTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trialTypeLabel.Name = "trialTypeLabel";
            this.trialTypeLabel.Size = new System.Drawing.Size(44, 17);
            this.trialTypeLabel.TabIndex = 3;
            this.trialTypeLabel.Text = "Type:";
            // 
            // cbTrialType
            // 
            this.cbTrialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrialType.FormattingEnabled = true;
            this.cbTrialType.Items.AddRange(new object[] {
            "Evasive",
            "Pilot",
            "Practice",
            "SpeedTest_Walking",
            "SpeedTest_Running",
            "TimePressureOn-Pre",
            "TimePressureOn-Post",
            "Standard-ConstantGap-Pre",
            "Standard-ConstantGap-Post",
            "Standard-Familiarity-Pre",
            "Standard-Familiarity-Post",
            "Standard-VariableGap-Pre",
            "Standard-VariableGap-Post",
            "Standard-IncrementalGap-Pre",
            "Standard-IncrementalGap-Post"});
            this.cbTrialType.Location = new System.Drawing.Point(266, 65);
            this.cbTrialType.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrialType.Name = "cbTrialType";
            this.cbTrialType.Size = new System.Drawing.Size(196, 24);
            this.cbTrialType.TabIndex = 0;
            this.cbTrialType.SelectedIndexChanged += new System.EventHandler(this.cbTrialType_SelectedIndexChanged);
            // 
            // cbCarBehaviour
            // 
            this.cbCarBehaviour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarBehaviour.FormattingEnabled = true;
            this.cbCarBehaviour.Items.AddRange(new object[] {
            "Spawn On Enter Road",
            "Spawn On Start Trial"});
            this.cbCarBehaviour.Location = new System.Drawing.Point(266, 109);
            this.cbCarBehaviour.Margin = new System.Windows.Forms.Padding(4);
            this.cbCarBehaviour.Name = "cbCarBehaviour";
            this.cbCarBehaviour.Size = new System.Drawing.Size(196, 24);
            this.cbCarBehaviour.TabIndex = 1;
            this.cbCarBehaviour.SelectedIndexChanged += new System.EventHandler(this.cbCarBehaviour_SelectedIndexChanged);
            // 
            // carBehaviourLabel
            // 
            this.carBehaviourLabel.AutoSize = true;
            this.carBehaviourLabel.Location = new System.Drawing.Point(153, 112);
            this.carBehaviourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carBehaviourLabel.Name = "carBehaviourLabel";
            this.carBehaviourLabel.Size = new System.Drawing.Size(102, 17);
            this.carBehaviourLabel.TabIndex = 0;
            this.carBehaviourLabel.Text = "Car Behaviour:";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnOk);
            this.Panel1.Controls.Add(this.btnCancel);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 642);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1258, 43);
            this.Panel1.TabIndex = 12;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(1022, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1130, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 685);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.trialPropertiesGroupBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Edit Trial";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.trialPropertiesGroupBox.ResumeLayout(false);
            this.trialPropertiesGroupBox.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox trialPropertiesGroupBox;
        internal System.Windows.Forms.TextBox txtContinuousCarSpeed;
        internal System.Windows.Forms.Label lblContinuousCarSpeed;
        internal System.Windows.Forms.ComboBox cbCarBehaviour;
        internal System.Windows.Forms.Label carBehaviourLabel;
        internal System.Windows.Forms.Label trialTypeLabel;
        internal System.Windows.Forms.ComboBox cbTrialType;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
    }
}