namespace networkManager {
    partial class form_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addPortButton = new System.Windows.Forms.Button();
            this.comboBoxPortSelect = new System.Windows.Forms.ComboBox();
            this.labelTogglePowerstate = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label_createSwitch = new System.Windows.Forms.LinkLabel();
            this.labelSwitchPowerstate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelUsedports = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pgbUsedports = new System.Windows.Forms.ProgressBar();
            this.labelSwitchInfo = new System.Windows.Forms.Label();
            this.labelSwitchSerial = new System.Windows.Forms.Label();
            this.labelSwitchPortcount = new System.Windows.Forms.Label();
            this.labelSwitchIP = new System.Windows.Forms.Label();
            this.labelSwitchhostname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchDropdown = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label_autosavestatus = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tooltiplabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAttachedDevice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelAttachedIP = new System.Windows.Forms.Label();
            this.labelAttachedMac = new System.Windows.Forms.Label();
            this.labelPortMac = new System.Windows.Forms.Label();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Computers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Switches";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelPortNumber);
            this.groupBox1.Controls.Add(this.labelPortMac);
            this.groupBox1.Controls.Add(this.labelAttachedMac);
            this.groupBox1.Controls.Add(this.labelAttachedIP);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelAttachedDevice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.addPortButton);
            this.groupBox1.Controls.Add(this.comboBoxPortSelect);
            this.groupBox1.Controls.Add(this.labelTogglePowerstate);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.label_createSwitch);
            this.groupBox1.Controls.Add(this.labelSwitchPowerstate);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labelUsedports);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pgbUsedports);
            this.groupBox1.Controls.Add(this.labelSwitchInfo);
            this.groupBox1.Controls.Add(this.labelSwitchSerial);
            this.groupBox1.Controls.Add(this.labelSwitchPortcount);
            this.groupBox1.Controls.Add(this.labelSwitchIP);
            this.groupBox1.Controls.Add(this.labelSwitchhostname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.switchDropdown);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display switch Properties";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "port count";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "apply";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(137, 148);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // addPortButton
            // 
            this.addPortButton.Location = new System.Drawing.Point(11, 200);
            this.addPortButton.Name = "addPortButton";
            this.addPortButton.Size = new System.Drawing.Size(56, 23);
            this.addPortButton.TabIndex = 21;
            this.addPortButton.Text = "add Port";
            this.addPortButton.UseVisualStyleBackColor = true;
            this.addPortButton.Click += new System.EventHandler(this.addPortButton_Click);
            // 
            // comboBoxPortSelect
            // 
            this.comboBoxPortSelect.FormattingEnabled = true;
            this.comboBoxPortSelect.Location = new System.Drawing.Point(135, 229);
            this.comboBoxPortSelect.Name = "comboBoxPortSelect";
            this.comboBoxPortSelect.Size = new System.Drawing.Size(87, 21);
            this.comboBoxPortSelect.TabIndex = 20;
            this.comboBoxPortSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortSelect_SelectedIndexChanged);
            // 
            // labelTogglePowerstate
            // 
            this.labelTogglePowerstate.AutoSize = true;
            this.labelTogglePowerstate.Location = new System.Drawing.Point(36, 137);
            this.labelTogglePowerstate.Name = "labelTogglePowerstate";
            this.labelTogglePowerstate.Size = new System.Drawing.Size(95, 13);
            this.labelTogglePowerstate.TabIndex = 19;
            this.labelTogglePowerstate.TabStop = true;
            this.labelTogglePowerstate.Text = "Toggle powerstate";
            this.labelTogglePowerstate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelTogglePowerstate_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(359, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(78, 13);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "change Switch";
            // 
            // label_createSwitch
            // 
            this.label_createSwitch.AutoSize = true;
            this.label_createSwitch.Location = new System.Drawing.Point(365, 35);
            this.label_createSwitch.Name = "label_createSwitch";
            this.label_createSwitch.Size = new System.Drawing.Size(72, 13);
            this.label_createSwitch.TabIndex = 17;
            this.label_createSwitch.TabStop = true;
            this.label_createSwitch.Text = "create Switch";
            this.label_createSwitch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_createSwitch_LinkClicked);
            // 
            // labelSwitchPowerstate
            // 
            this.labelSwitchPowerstate.AutoSize = true;
            this.labelSwitchPowerstate.Location = new System.Drawing.Point(132, 124);
            this.labelSwitchPowerstate.Name = "labelSwitchPowerstate";
            this.labelSwitchPowerstate.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchPowerstate.TabIndex = 16;
            this.labelSwitchPowerstate.Text = "-";
            this.labelSwitchPowerstate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Powerstate:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsedports
            // 
            this.labelUsedports.AutoSize = true;
            this.labelUsedports.Location = new System.Drawing.Point(132, 184);
            this.labelUsedports.Name = "labelUsedports";
            this.labelUsedports.Size = new System.Drawing.Size(10, 13);
            this.labelUsedports.TabIndex = 14;
            this.labelUsedports.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Used ports:";
            // 
            // pgbUsedports
            // 
            this.pgbUsedports.Location = new System.Drawing.Point(73, 200);
            this.pgbUsedports.Name = "pgbUsedports";
            this.pgbUsedports.Size = new System.Drawing.Size(364, 23);
            this.pgbUsedports.TabIndex = 12;
            // 
            // labelSwitchInfo
            // 
            this.labelSwitchInfo.AutoSize = true;
            this.labelSwitchInfo.Location = new System.Drawing.Point(132, 111);
            this.labelSwitchInfo.Name = "labelSwitchInfo";
            this.labelSwitchInfo.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchInfo.TabIndex = 11;
            this.labelSwitchInfo.Text = "-";
            this.labelSwitchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSwitchSerial
            // 
            this.labelSwitchSerial.AutoSize = true;
            this.labelSwitchSerial.Location = new System.Drawing.Point(132, 98);
            this.labelSwitchSerial.Name = "labelSwitchSerial";
            this.labelSwitchSerial.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchSerial.TabIndex = 10;
            this.labelSwitchSerial.Text = "-";
            this.labelSwitchSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSwitchPortcount
            // 
            this.labelSwitchPortcount.AutoSize = true;
            this.labelSwitchPortcount.Location = new System.Drawing.Point(132, 85);
            this.labelSwitchPortcount.Name = "labelSwitchPortcount";
            this.labelSwitchPortcount.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchPortcount.TabIndex = 9;
            this.labelSwitchPortcount.Text = "-";
            this.labelSwitchPortcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSwitchIP
            // 
            this.labelSwitchIP.AutoSize = true;
            this.labelSwitchIP.Location = new System.Drawing.Point(132, 72);
            this.labelSwitchIP.Name = "labelSwitchIP";
            this.labelSwitchIP.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchIP.TabIndex = 8;
            this.labelSwitchIP.Text = "-";
            this.labelSwitchIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSwitchhostname
            // 
            this.labelSwitchhostname.AutoSize = true;
            this.labelSwitchhostname.Location = new System.Drawing.Point(132, 59);
            this.labelSwitchhostname.Name = "labelSwitchhostname";
            this.labelSwitchhostname.Size = new System.Drawing.Size(10, 13);
            this.labelSwitchhostname.TabIndex = 7;
            this.labelSwitchhostname.Text = "-";
            this.labelSwitchhostname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Info text:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Serialnumber:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Management IP address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hostname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select switch:";
            // 
            // switchDropdown
            // 
            this.switchDropdown.FormattingEnabled = true;
            this.switchDropdown.Location = new System.Drawing.Point(85, 19);
            this.switchDropdown.Name = "switchDropdown";
            this.switchDropdown.Size = new System.Drawing.Size(268, 21);
            this.switchDropdown.TabIndex = 0;
            this.switchDropdown.SelectedIndexChanged += new System.EventHandler(this.switchDropdown_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(459, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Routers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.label_autosavestatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(491, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.creditsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Auto save";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.onToolStripMenuItem.Text = "on";
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.offToolStripMenuItem.Text = "off";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Exit";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Autosave:";
            // 
            // label_autosavestatus
            // 
            this.label_autosavestatus.Name = "label_autosavestatus";
            this.label_autosavestatus.Size = new System.Drawing.Size(22, 22);
            this.label_autosavestatus.Text = "off";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooltiplabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(491, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tooltiplabel
            // 
            this.tooltiplabel.Name = "tooltiplabel";
            this.tooltiplabel.Size = new System.Drawing.Size(39, 17);
            this.tooltiplabel.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Select port:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Attached Device:";
            // 
            // labelAttachedDevice
            // 
            this.labelAttachedDevice.AutoSize = true;
            this.labelAttachedDevice.Location = new System.Drawing.Point(132, 261);
            this.labelAttachedDevice.Name = "labelAttachedDevice";
            this.labelAttachedDevice.Size = new System.Drawing.Size(10, 13);
            this.labelAttachedDevice.TabIndex = 27;
            this.labelAttachedDevice.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Attached IP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Attached MAC:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Port MAC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Port number:";
            // 
            // labelAttachedIP
            // 
            this.labelAttachedIP.AutoSize = true;
            this.labelAttachedIP.Location = new System.Drawing.Point(132, 274);
            this.labelAttachedIP.Name = "labelAttachedIP";
            this.labelAttachedIP.Size = new System.Drawing.Size(10, 13);
            this.labelAttachedIP.TabIndex = 32;
            this.labelAttachedIP.Text = "-";
            // 
            // labelAttachedMac
            // 
            this.labelAttachedMac.AutoSize = true;
            this.labelAttachedMac.Location = new System.Drawing.Point(132, 287);
            this.labelAttachedMac.Name = "labelAttachedMac";
            this.labelAttachedMac.Size = new System.Drawing.Size(10, 13);
            this.labelAttachedMac.TabIndex = 33;
            this.labelAttachedMac.Text = "-";
            // 
            // labelPortMac
            // 
            this.labelPortMac.AutoSize = true;
            this.labelPortMac.Location = new System.Drawing.Point(132, 300);
            this.labelPortMac.Name = "labelPortMac";
            this.labelPortMac.Size = new System.Drawing.Size(10, 13);
            this.labelPortMac.TabIndex = 34;
            this.labelPortMac.Text = "-";
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(132, 313);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(10, 13);
            this.labelPortNumber.TabIndex = 35;
            this.labelPortNumber.Text = "-";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 462);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Manager";
            this.Load += new System.EventHandler(this.form_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel label_createSwitch;
        private System.Windows.Forms.Label labelSwitchPowerstate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelUsedports;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pgbUsedports;
        private System.Windows.Forms.Label labelSwitchInfo;
        private System.Windows.Forms.Label labelSwitchSerial;
        private System.Windows.Forms.Label labelSwitchPortcount;
        private System.Windows.Forms.Label labelSwitchIP;
        private System.Windows.Forms.Label labelSwitchhostname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox switchDropdown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel label_autosavestatus;
        private System.Windows.Forms.LinkLabel labelTogglePowerstate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button addPortButton;
        private System.Windows.Forms.ComboBox comboBoxPortSelect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tooltiplabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAttachedDevice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.Label labelPortMac;
        private System.Windows.Forms.Label labelAttachedMac;
        private System.Windows.Forms.Label labelAttachedIP;
        private System.Windows.Forms.Label label14;
    }
}

