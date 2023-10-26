namespace networkManager {
    partial class createSwitchForm {
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hostnameTextbox = new System.Windows.Forms.TextBox();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.portcountTextbox = new System.Windows.Forms.TextBox();
            this.infoTextbox = new System.Windows.Forms.TextBox();
            this.serialnumberTextbox = new System.Windows.Forms.TextBox();
            this.createSwitch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Info text:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Serialnumber:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Port count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Management IP address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hostname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hostnameTextbox
            // 
            this.hostnameTextbox.Location = new System.Drawing.Point(143, 7);
            this.hostnameTextbox.Name = "hostnameTextbox";
            this.hostnameTextbox.Size = new System.Drawing.Size(174, 20);
            this.hostnameTextbox.TabIndex = 17;
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(143, 33);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(174, 20);
            this.ipTextbox.TabIndex = 18;
            // 
            // portcountTextbox
            // 
            this.portcountTextbox.Location = new System.Drawing.Point(143, 59);
            this.portcountTextbox.Name = "portcountTextbox";
            this.portcountTextbox.Size = new System.Drawing.Size(174, 20);
            this.portcountTextbox.TabIndex = 19;
            // 
            // infoTextbox
            // 
            this.infoTextbox.Location = new System.Drawing.Point(143, 111);
            this.infoTextbox.Name = "infoTextbox";
            this.infoTextbox.Size = new System.Drawing.Size(174, 20);
            this.infoTextbox.TabIndex = 21;
            // 
            // serialnumberTextbox
            // 
            this.serialnumberTextbox.Location = new System.Drawing.Point(143, 85);
            this.serialnumberTextbox.Name = "serialnumberTextbox";
            this.serialnumberTextbox.Size = new System.Drawing.Size(174, 20);
            this.serialnumberTextbox.TabIndex = 20;
            // 
            // createSwitch
            // 
            this.createSwitch.Location = new System.Drawing.Point(242, 137);
            this.createSwitch.Name = "createSwitch";
            this.createSwitch.Size = new System.Drawing.Size(75, 23);
            this.createSwitch.TabIndex = 22;
            this.createSwitch.Text = "Apply";
            this.createSwitch.UseVisualStyleBackColor = true;
            this.createSwitch.Click += new System.EventHandler(this.createSwitch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // createSwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 171);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.createSwitch);
            this.Controls.Add(this.infoTextbox);
            this.Controls.Add(this.serialnumberTextbox);
            this.Controls.Add(this.portcountTextbox);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.hostnameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "createSwitchForm";
            this.Text = "Create Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hostnameTextbox;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.TextBox portcountTextbox;
        private System.Windows.Forms.TextBox infoTextbox;
        private System.Windows.Forms.TextBox serialnumberTextbox;
        private System.Windows.Forms.Button createSwitch;
        private System.Windows.Forms.Button button2;
    }
}