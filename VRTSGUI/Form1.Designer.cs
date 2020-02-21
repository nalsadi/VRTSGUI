namespace VRTSGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbProgramConfiguration = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblVrPath = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxPitchAngle = new System.Windows.Forms.TextBox();
            this.txtPartialCheckAngle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFullCheckAngle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPartialCheckAngle = new System.Windows.Forms.Label();
            this.lblFullCheckAngle = new System.Windows.Forms.Label();
            this.lblNearMissDistance = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRespawnEndDistance = new System.Windows.Forms.TextBox();
            this.lblRespawnEndDistance = new System.Windows.Forms.Label();
            this.txtRespawnStartDistance = new System.Windows.Forms.TextBox();
            this.lblRespawnStartDistance = new System.Windows.Forms.Label();
            this.lblMeters = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtNearMissDistance = new System.Windows.Forms.TextBox();
            this.txtDataCollectionPeriod = new System.Windows.Forms.TextBox();
            this.lblDataCollectionPeriod = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPreset = new System.Windows.Forms.ComboBox();
            this.btnSetPreset = new System.Windows.Forms.Button();
            this.btnRenamePreset = new System.Windows.Forms.Button();
            this.btnRemovePreset = new System.Windows.Forms.Button();
            this.btnAddPreset = new System.Windows.Forms.Button();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbXboxController = new System.Windows.Forms.RadioButton();
            this.rbHeadset = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.chkRandomize = new System.Windows.Forms.CheckBox();
            this.chkRandomizeCarOrder = new System.Windows.Forms.CheckBox();
            this.btnCopyTrial = new System.Windows.Forms.Button();
            this.btnEditTrial = new System.Windows.Forms.Button();
            this.btnRemoveTrial = new System.Windows.Forms.Button();
            this.btnAddTrial = new System.Windows.Forms.Button();
            this.btnVisualTest = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProgramConfiguration.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participant Variables";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(349, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height (m):";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quick Conversion";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set As Height";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inches:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = " Feet:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Height (m):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(69, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(93, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(69, 22);
            this.textBox6.TabIndex = 1;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 469);
            this.dataGridView1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trials:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gbProgramConfiguration
            // 
            this.gbProgramConfiguration.Controls.Add(this.gbOptions);
            this.gbProgramConfiguration.Controls.Add(this.label9);
            this.gbProgramConfiguration.Controls.Add(this.label10);
            this.gbProgramConfiguration.Controls.Add(this.txtMaxPitchAngle);
            this.gbProgramConfiguration.Controls.Add(this.txtPartialCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.label11);
            this.gbProgramConfiguration.Controls.Add(this.txtFullCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.label12);
            this.gbProgramConfiguration.Controls.Add(this.lblPartialCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.lblFullCheckAngle);
            this.gbProgramConfiguration.Controls.Add(this.lblNearMissDistance);
            this.gbProgramConfiguration.Controls.Add(this.label13);
            this.gbProgramConfiguration.Controls.Add(this.label14);
            this.gbProgramConfiguration.Controls.Add(this.txtRespawnEndDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblRespawnEndDistance);
            this.gbProgramConfiguration.Controls.Add(this.txtRespawnStartDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblRespawnStartDistance);
            this.gbProgramConfiguration.Controls.Add(this.lblMeters);
            this.gbProgramConfiguration.Controls.Add(this.lblSeconds);
            this.gbProgramConfiguration.Controls.Add(this.txtNearMissDistance);
            this.gbProgramConfiguration.Controls.Add(this.txtDataCollectionPeriod);
            this.gbProgramConfiguration.Controls.Add(this.lblDataCollectionPeriod);
            this.gbProgramConfiguration.Location = new System.Drawing.Point(886, 164);
            this.gbProgramConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.gbProgramConfiguration.Name = "gbProgramConfiguration";
            this.gbProgramConfiguration.Padding = new System.Windows.Forms.Padding(4);
            this.gbProgramConfiguration.Size = new System.Drawing.Size(485, 324);
            this.gbProgramConfiguration.TabIndex = 13;
            this.gbProgramConfiguration.TabStop = false;
            this.gbProgramConfiguration.Text = "Program Config";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblExtension);
            this.gbOptions.Controls.Add(this.textBox7);
            this.gbOptions.Controls.Add(this.btnBrowsePath);
            this.gbOptions.Controls.Add(this.txtPath);
            this.gbOptions.Controls.Add(this.lblVrPath);
            this.gbOptions.Location = new System.Drawing.Point(8, 215);
            this.gbOptions.Margin = new System.Windows.Forms.Padding(4);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Padding = new System.Windows.Forms.Padding(4);
            this.gbOptions.Size = new System.Drawing.Size(469, 98);
            this.gbOptions.TabIndex = 14;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "File Saving Directory";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(11, 27);
            this.lblExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(126, 17);
            this.lblExtension.TabIndex = 12;
            this.lblExtension.Text = "VR File Extension :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(139, 23);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(84, 22);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = " ";
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Location = new System.Drawing.Point(385, 53);
            this.btnBrowsePath.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(72, 28);
            this.btnBrowsePath.TabIndex = 10;
            this.btnBrowsePath.Text = "Browse...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(139, 55);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(241, 22);
            this.txtPath.TabIndex = 9;
            // 
            // lblVrPath
            // 
            this.lblVrPath.AutoSize = true;
            this.lblVrPath.Location = new System.Drawing.Point(12, 59);
            this.lblVrPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrPath.Name = "lblVrPath";
            this.lblVrPath.Size = new System.Drawing.Size(118, 17);
            this.lblVrPath.TabIndex = 8;
            this.lblVrPath.Text = "Path to VR Data :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "degrees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "degrees";
            // 
            // txtMaxPitchAngle
            // 
            this.txtMaxPitchAngle.Location = new System.Drawing.Point(183, 183);
            this.txtMaxPitchAngle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxPitchAngle.Name = "txtMaxPitchAngle";
            this.txtMaxPitchAngle.Size = new System.Drawing.Size(48, 22);
            this.txtMaxPitchAngle.TabIndex = 18;
            // 
            // txtPartialCheckAngle
            // 
            this.txtPartialCheckAngle.Location = new System.Drawing.Point(183, 154);
            this.txtPartialCheckAngle.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartialCheckAngle.Name = "txtPartialCheckAngle";
            this.txtPartialCheckAngle.Size = new System.Drawing.Size(48, 22);
            this.txtPartialCheckAngle.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "degrees";
            // 
            // txtFullCheckAngle
            // 
            this.txtFullCheckAngle.Location = new System.Drawing.Point(183, 128);
            this.txtFullCheckAngle.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullCheckAngle.Name = "txtFullCheckAngle";
            this.txtFullCheckAngle.Size = new System.Drawing.Size(48, 22);
            this.txtFullCheckAngle.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Max Pitch Angle:";
            // 
            // lblPartialCheckAngle
            // 
            this.lblPartialCheckAngle.AutoSize = true;
            this.lblPartialCheckAngle.Location = new System.Drawing.Point(8, 162);
            this.lblPartialCheckAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPartialCheckAngle.Name = "lblPartialCheckAngle";
            this.lblPartialCheckAngle.Size = new System.Drawing.Size(135, 17);
            this.lblPartialCheckAngle.TabIndex = 13;
            this.lblPartialCheckAngle.Text = "Partial Check Angle:";
            // 
            // lblFullCheckAngle
            // 
            this.lblFullCheckAngle.AutoSize = true;
            this.lblFullCheckAngle.Location = new System.Drawing.Point(8, 134);
            this.lblFullCheckAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullCheckAngle.Name = "lblFullCheckAngle";
            this.lblFullCheckAngle.Size = new System.Drawing.Size(117, 17);
            this.lblFullCheckAngle.TabIndex = 12;
            this.lblFullCheckAngle.Text = "Full Check Angle:";
            // 
            // lblNearMissDistance
            // 
            this.lblNearMissDistance.AutoSize = true;
            this.lblNearMissDistance.Location = new System.Drawing.Point(8, 50);
            this.lblNearMissDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNearMissDistance.Name = "lblNearMissDistance";
            this.lblNearMissDistance.Size = new System.Drawing.Size(135, 17);
            this.lblNearMissDistance.TabIndex = 2;
            this.lblNearMissDistance.Text = "Near-Miss Distance:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 107);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "meters";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "meters";
            // 
            // txtRespawnEndDistance
            // 
            this.txtRespawnEndDistance.Location = new System.Drawing.Point(183, 102);
            this.txtRespawnEndDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespawnEndDistance.Name = "txtRespawnEndDistance";
            this.txtRespawnEndDistance.Size = new System.Drawing.Size(48, 22);
            this.txtRespawnEndDistance.TabIndex = 9;
            // 
            // lblRespawnEndDistance
            // 
            this.lblRespawnEndDistance.AutoSize = true;
            this.lblRespawnEndDistance.Location = new System.Drawing.Point(8, 107);
            this.lblRespawnEndDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespawnEndDistance.Name = "lblRespawnEndDistance";
            this.lblRespawnEndDistance.Size = new System.Drawing.Size(158, 17);
            this.lblRespawnEndDistance.TabIndex = 8;
            this.lblRespawnEndDistance.Text = "Respawn End Distance:";
            // 
            // txtRespawnStartDistance
            // 
            this.txtRespawnStartDistance.Location = new System.Drawing.Point(183, 76);
            this.txtRespawnStartDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespawnStartDistance.Name = "txtRespawnStartDistance";
            this.txtRespawnStartDistance.Size = new System.Drawing.Size(48, 22);
            this.txtRespawnStartDistance.TabIndex = 7;
            // 
            // lblRespawnStartDistance
            // 
            this.lblRespawnStartDistance.AutoSize = true;
            this.lblRespawnStartDistance.Location = new System.Drawing.Point(8, 79);
            this.lblRespawnStartDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespawnStartDistance.Name = "lblRespawnStartDistance";
            this.lblRespawnStartDistance.Size = new System.Drawing.Size(163, 17);
            this.lblRespawnStartDistance.TabIndex = 6;
            this.lblRespawnStartDistance.Text = "Respawn Start Distance:";
            // 
            // lblMeters
            // 
            this.lblMeters.AutoSize = true;
            this.lblMeters.Location = new System.Drawing.Point(240, 53);
            this.lblMeters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeters.Name = "lblMeters";
            this.lblMeters.Size = new System.Drawing.Size(51, 17);
            this.lblMeters.TabIndex = 5;
            this.lblMeters.Text = "meters";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(240, 26);
            this.lblSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(61, 17);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "seconds";
            // 
            // txtNearMissDistance
            // 
            this.txtNearMissDistance.Location = new System.Drawing.Point(183, 50);
            this.txtNearMissDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtNearMissDistance.Name = "txtNearMissDistance";
            this.txtNearMissDistance.Size = new System.Drawing.Size(48, 22);
            this.txtNearMissDistance.TabIndex = 3;
            this.txtNearMissDistance.TextChanged += new System.EventHandler(this.txtNearMissDistance_TextChanged);
            // 
            // txtDataCollectionPeriod
            // 
            this.txtDataCollectionPeriod.Location = new System.Drawing.Point(183, 22);
            this.txtDataCollectionPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCollectionPeriod.Name = "txtDataCollectionPeriod";
            this.txtDataCollectionPeriod.Size = new System.Drawing.Size(48, 22);
            this.txtDataCollectionPeriod.TabIndex = 1;
            this.txtDataCollectionPeriod.TextChanged += new System.EventHandler(this.txtDataCollectionPeriod_TextChanged);
            // 
            // lblDataCollectionPeriod
            // 
            this.lblDataCollectionPeriod.AutoSize = true;
            this.lblDataCollectionPeriod.Location = new System.Drawing.Point(8, 23);
            this.lblDataCollectionPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCollectionPeriod.Name = "lblDataCollectionPeriod";
            this.lblDataCollectionPeriod.Size = new System.Drawing.Size(152, 17);
            this.lblDataCollectionPeriod.TabIndex = 0;
            this.lblDataCollectionPeriod.Text = "Data Collection Period:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Location = new System.Drawing.Point(871, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 103);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed Conversion";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = " km/hr:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(34, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "m/s:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(77, 62);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(69, 22);
            this.textBox9.TabIndex = 2;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(77, 23);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(69, 22);
            this.textBox10.TabIndex = 1;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPreset);
            this.groupBox4.Controls.Add(this.btnSetPreset);
            this.groupBox4.Controls.Add(this.btnRenamePreset);
            this.groupBox4.Controls.Add(this.btnRemovePreset);
            this.groupBox4.Controls.Add(this.btnAddPreset);
            this.groupBox4.Controls.Add(this.conditionLabel);
            this.groupBox4.Location = new System.Drawing.Point(1087, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(311, 102);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preset Conditions";
            // 
            // cbPreset
            // 
            this.cbPreset.DisplayMember = "Name";
            this.cbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPreset.FormattingEnabled = true;
            this.cbPreset.Location = new System.Drawing.Point(89, 25);
            this.cbPreset.Margin = new System.Windows.Forms.Padding(4);
            this.cbPreset.Name = "cbPreset";
            this.cbPreset.Size = new System.Drawing.Size(212, 24);
            this.cbPreset.TabIndex = 0;
            // 
            // btnSetPreset
            // 
            this.btnSetPreset.Location = new System.Drawing.Point(240, 60);
            this.btnSetPreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPreset.Name = "btnSetPreset";
            this.btnSetPreset.Size = new System.Drawing.Size(63, 28);
            this.btnSetPreset.TabIndex = 4;
            this.btnSetPreset.Text = "Set";
            this.btnSetPreset.UseVisualStyleBackColor = true;
            // 
            // btnRenamePreset
            // 
            this.btnRenamePreset.Location = new System.Drawing.Point(161, 60);
            this.btnRenamePreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenamePreset.Name = "btnRenamePreset";
            this.btnRenamePreset.Size = new System.Drawing.Size(73, 28);
            this.btnRenamePreset.TabIndex = 3;
            this.btnRenamePreset.Text = "Rename";
            this.btnRenamePreset.UseVisualStyleBackColor = true;
            // 
            // btnRemovePreset
            // 
            this.btnRemovePreset.Location = new System.Drawing.Point(76, 60);
            this.btnRemovePreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemovePreset.Name = "btnRemovePreset";
            this.btnRemovePreset.Size = new System.Drawing.Size(80, 28);
            this.btnRemovePreset.TabIndex = 2;
            this.btnRemovePreset.Text = "Remove";
            this.btnRemovePreset.UseVisualStyleBackColor = true;
            // 
            // btnAddPreset
            // 
            this.btnAddPreset.Location = new System.Drawing.Point(8, 60);
            this.btnAddPreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPreset.Name = "btnAddPreset";
            this.btnAddPreset.Size = new System.Drawing.Size(63, 28);
            this.btnAddPreset.TabIndex = 1;
            this.btnAddPreset.Text = "Add...";
            this.btnAddPreset.UseVisualStyleBackColor = true;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(8, 27);
            this.conditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(71, 17);
            this.conditionLabel.TabIndex = 18;
            this.conditionLabel.Text = "Condition:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbXboxController);
            this.groupBox5.Controls.Add(this.rbHeadset);
            this.groupBox5.Controls.Add(this.rbMouse);
            this.groupBox5.Location = new System.Drawing.Point(886, 510);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(291, 92);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // rbXboxController
            // 
            this.rbXboxController.AutoSize = true;
            this.rbXboxController.Location = new System.Drawing.Point(117, 31);
            this.rbXboxController.Margin = new System.Windows.Forms.Padding(4);
            this.rbXboxController.Name = "rbXboxController";
            this.rbXboxController.Size = new System.Drawing.Size(125, 21);
            this.rbXboxController.TabIndex = 2;
            this.rbXboxController.TabStop = true;
            this.rbXboxController.Text = "Xbox Controller";
            this.rbXboxController.UseVisualStyleBackColor = true;
            // 
            // rbHeadset
            // 
            this.rbHeadset.AutoSize = true;
            this.rbHeadset.Checked = true;
            this.rbHeadset.Location = new System.Drawing.Point(21, 59);
            this.rbHeadset.Margin = new System.Windows.Forms.Padding(4);
            this.rbHeadset.Name = "rbHeadset";
            this.rbHeadset.Size = new System.Drawing.Size(82, 21);
            this.rbHeadset.TabIndex = 1;
            this.rbHeadset.TabStop = true;
            this.rbHeadset.Text = "Headset";
            this.rbHeadset.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(21, 31);
            this.rbMouse.Margin = new System.Windows.Forms.Padding(4);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(71, 21);
            this.rbMouse.TabIndex = 0;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // chkRandomize
            // 
            this.chkRandomize.AutoSize = true;
            this.chkRandomize.Location = new System.Drawing.Point(649, 648);
            this.chkRandomize.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomize.Name = "chkRandomize";
            this.chkRandomize.Size = new System.Drawing.Size(140, 21);
            this.chkRandomize.TabIndex = 22;
            this.chkRandomize.Text = "Randomize Trials";
            this.chkRandomize.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeCarOrder
            // 
            this.chkRandomizeCarOrder.AutoSize = true;
            this.chkRandomizeCarOrder.Location = new System.Drawing.Point(649, 673);
            this.chkRandomizeCarOrder.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandomizeCarOrder.Name = "chkRandomizeCarOrder";
            this.chkRandomizeCarOrder.Size = new System.Drawing.Size(168, 21);
            this.chkRandomizeCarOrder.TabIndex = 23;
            this.chkRandomizeCarOrder.Text = "Randomize Car Order";
            this.chkRandomizeCarOrder.UseVisualStyleBackColor = true;
            // 
            // btnCopyTrial
            // 
            this.btnCopyTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyTrial.Location = new System.Drawing.Point(132, 659);
            this.btnCopyTrial.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopyTrial.Name = "btnCopyTrial";
            this.btnCopyTrial.Size = new System.Drawing.Size(100, 28);
            this.btnCopyTrial.TabIndex = 21;
            this.btnCopyTrial.Text = "Copy Trial";
            this.btnCopyTrial.UseVisualStyleBackColor = true;
            // 
            // btnEditTrial
            // 
            this.btnEditTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTrial.Location = new System.Drawing.Point(480, 659);
            this.btnEditTrial.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTrial.Name = "btnEditTrial";
            this.btnEditTrial.Size = new System.Drawing.Size(100, 28);
            this.btnEditTrial.TabIndex = 20;
            this.btnEditTrial.Text = "Edit Trial...";
            this.btnEditTrial.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTrial
            // 
            this.btnRemoveTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTrial.Location = new System.Drawing.Point(348, 659);
            this.btnRemoveTrial.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveTrial.Name = "btnRemoveTrial";
            this.btnRemoveTrial.Size = new System.Drawing.Size(124, 28);
            this.btnRemoveTrial.TabIndex = 19;
            this.btnRemoveTrial.Text = "Remove Trial...";
            this.btnRemoveTrial.UseVisualStyleBackColor = true;
            // 
            // btnAddTrial
            // 
            this.btnAddTrial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTrial.Location = new System.Drawing.Point(240, 659);
            this.btnAddTrial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrial.Name = "btnAddTrial";
            this.btnAddTrial.Size = new System.Drawing.Size(100, 28);
            this.btnAddTrial.TabIndex = 18;
            this.btnAddTrial.Text = "Add Trial...";
            this.btnAddTrial.UseVisualStyleBackColor = true;
            this.btnAddTrial.Click += new System.EventHandler(this.btnAddTrial_Click);
            // 
            // btnVisualTest
            // 
            this.btnVisualTest.Location = new System.Drawing.Point(911, 655);
            this.btnVisualTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualTest.Name = "btnVisualTest";
            this.btnVisualTest.Size = new System.Drawing.Size(100, 41);
            this.btnVisualTest.TabIndex = 25;
            this.btnVisualTest.Text = "Visual Test";
            this.btnVisualTest.UseVisualStyleBackColor = true;
            this.btnVisualTest.Click += new System.EventHandler(this.btnVisualTest_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(1058, 655);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 39);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 758);
            this.Controls.Add(this.btnVisualTest);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkRandomize);
            this.Controls.Add(this.chkRandomizeCarOrder);
            this.Controls.Add(this.btnCopyTrial);
            this.Controls.Add(this.btnEditTrial);
            this.Controls.Add(this.btnRemoveTrial);
            this.Controls.Add(this.btnAddTrial);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbProgramConfiguration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VRTS GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProgramConfiguration.ResumeLayout(false);
            this.gbProgramConfiguration.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.GroupBox gbProgramConfiguration;
        internal System.Windows.Forms.GroupBox gbOptions;
        internal System.Windows.Forms.Label lblExtension;
        internal System.Windows.Forms.TextBox textBox7;
        internal System.Windows.Forms.Button btnBrowsePath;
        internal System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.Label lblVrPath;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtMaxPitchAngle;
        internal System.Windows.Forms.TextBox txtPartialCheckAngle;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtFullCheckAngle;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblPartialCheckAngle;
        internal System.Windows.Forms.Label lblFullCheckAngle;
        internal System.Windows.Forms.Label lblNearMissDistance;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtRespawnEndDistance;
        internal System.Windows.Forms.Label lblRespawnEndDistance;
        internal System.Windows.Forms.TextBox txtRespawnStartDistance;
        internal System.Windows.Forms.Label lblRespawnStartDistance;
        internal System.Windows.Forms.Label lblMeters;
        internal System.Windows.Forms.Label lblSeconds;
        internal System.Windows.Forms.TextBox txtNearMissDistance;
        internal System.Windows.Forms.TextBox txtDataCollectionPeriod;
        internal System.Windows.Forms.Label lblDataCollectionPeriod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.ComboBox cbPreset;
        internal System.Windows.Forms.Button btnSetPreset;
        internal System.Windows.Forms.Button btnRenamePreset;
        internal System.Windows.Forms.Button btnRemovePreset;
        internal System.Windows.Forms.Button btnAddPreset;
        internal System.Windows.Forms.Label conditionLabel;
        internal System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.RadioButton rbXboxController;
        internal System.Windows.Forms.RadioButton rbHeadset;
        internal System.Windows.Forms.RadioButton rbMouse;
        internal System.Windows.Forms.CheckBox chkRandomize;
        internal System.Windows.Forms.CheckBox chkRandomizeCarOrder;
        internal System.Windows.Forms.Button btnCopyTrial;
        internal System.Windows.Forms.Button btnEditTrial;
        internal System.Windows.Forms.Button btnRemoveTrial;
        internal System.Windows.Forms.Button btnAddTrial;
        internal System.Windows.Forms.Button btnVisualTest;
        internal System.Windows.Forms.Button btnStart;
    }
}

