using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace networkManager {
    public partial class createSwitchForm : Form {
        public static createSwitchForm instance;
        public createSwitchForm() {
            InitializeComponent();
            instance = this;
        }

        private void createSwitch_Click(object sender, EventArgs e) {
            form_Main.instance.newSwitchSettings[0] = hostnameTextbox.Text;
            form_Main.instance.newSwitchSettings[1] = ipTextbox.Text;
            form_Main.instance.newSwitchSettings[2] = serialnumberTextbox.Text;
            form_Main.instance.newSwitchSettings[3] = portcountTextbox.Text;
            form_Main.instance.newSwitchSettings[4] = infoTextbox.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
