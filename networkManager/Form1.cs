using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace networkManager {
    public partial class form_Main : Form {
        public static form_Main instance;
        List<Switch> switches = new List<Switch>();
        List<baseNetworkport> ports = new List<baseNetworkport>();
        public string[] newSwitchSettings = new string[5];
        public form_Main() {
            InitializeComponent();
            instance = this;
        }

        void form_Main_Load(object sender, EventArgs e) {
            
        }

        void updateSwitchVars(int index) {
            string switchHostname = switches[index].getHostname();
            string switchMgmtIP = switches[index].getIP();
            int switchPortcount = switches[index].getPortcount();
            string switchSerialNumber = switches[index].getSerialnumber();
            string switchInfo = switches[index].getInfo();
            bool switchPowerstate = switches[index].getPowerstate();

            labelSwitchhostname.Text = switchHostname;
            labelSwitchIP.Text = switchMgmtIP;
            labelSwitchPortcount.Text = Convert.ToString(switchPortcount);
            labelSwitchSerial.Text = switchSerialNumber;
            labelSwitchInfo.Text = switchInfo;
            labelSwitchPowerstate.Text = Convert.ToString(switchPowerstate);

            switches[index].getPort();

            pgbUsedports.Maximum = switchPortcount;
        }

        string generateMAC() {
            string macAddress = "";

            Random rnd = new Random();
            int randomMACBlock;
            string[] macBlock = new string[6];

            //6 bytes
            for(int i = 0; i < 6; i++) {
                randomMACBlock = rnd.Next(0, 255);
                macBlock[i] = randomMACBlock.ToString("X2"); // convert int to 2 Hexadecimal characters
                Console.WriteLine("Generated random number: " + randomMACBlock);
                Console.WriteLine("Parsed into byte as: " + macBlock[i]);
            }

            //build mac
            macAddress = macBlock[0] + ":" + macBlock[1] + ":" + macBlock[2] + ":" + macBlock[3] + ":" + macBlock[4] + ":" + macBlock[5];

            return macAddress;
        }

        void updatePortListVars(int Portnumber) {
            string switchportnumber = ports[Portnumber].getPort().ToString();
            string switchportmac = ports[Portnumber].getMacAddress();

            labelPortNumber.Text = switchportnumber;
            labelPortMac.Text = switchportmac;
            Console.WriteLine(ports[Portnumber].getPortname());
        }
        
        public void label_createSwitch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            createSwitchForm showSwitchForm = new createSwitchForm();
            //createSwitchForm.ShowDialog();
            if(showSwitchForm.ShowDialog() == DialogResult.OK) {
                Console.WriteLine("success");
                Switch addSwitch = new Switch();

                //fill vars:
                //form_Main.instance.newSwitchSettings[0] = hostnameTextbox.Text;
                //form_Main.instance.newSwitchSettings[1] = ipTextbox.Text;
                //form_Main.instance.newSwitchSettings[2] = serialnumberTextbox.Text;
                //form_Main.instance.newSwitchSettings[3] = portcountTextbox.Text;
                //form_Main.instance.newSwitchSettings[4] = infoTextbox.Text;
                addSwitch.setHostname(newSwitchSettings[0]);
                addSwitch.setIP(newSwitchSettings[1]);
                addSwitch.setSerialnumber(newSwitchSettings[2]);
                addSwitch.setPortcount(int.Parse(newSwitchSettings[3]));
                addSwitch.setInfo(newSwitchSettings[4]);
                
                
                switches.Add(addSwitch);
                Console.WriteLine(switches);

                switchDropdown.Items.Add(newSwitchSettings[0]);
            } else {
                Console.WriteLine("didnt work");
            }
        }

        private void addPortButton_Click(object sender, EventArgs e) {

            if(switchDropdown.SelectedIndex == -1) {
                tooltiplabel.Text = "Select a switch first.";
            } else {
                if(switches[switchDropdown.SelectedIndex].getPortcount() < switches[switchDropdown.SelectedIndex].getUsedportcount()+1) {
                    tooltiplabel.ForeColor = Color.Red;
                    tooltiplabel.Text = "You cannot add anymore Ports.";
                } else {
                    switches[switchDropdown.SelectedIndex].createPort();
                    labelUsedports.Text = switches[switchDropdown.SelectedIndex].getUsedportcount().ToString();
                    pgbUsedports.Value = switches[switchDropdown.SelectedIndex].getUsedportcount();



                    tooltiplabel.Text = "Added a Port to the switch: " + switches[switchDropdown.SelectedIndex].getHostname();
                    //comboBoxPortSelect.Items.Add(switches[switchDropdown.SelectedIndex].getPortname());

                    // get port list
                    ports = switches[switchDropdown.SelectedIndex].getPortlist();
                    Console.WriteLine(switches[switchDropdown.SelectedIndex].getUsedportcount());
                    ports[switches[switchDropdown.SelectedIndex].getUsedportcount()-1].setMacAddress(generateMAC());
                    Console.WriteLine(ports);
                    comboBoxPortSelect.Items.Clear();

                    for(int i = 0; i < ports.Count; i++) {
                        comboBoxPortSelect.Items.Add(ports[i].getPortname());

                    }
                }
            }

        }

        private void switchDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            updateSwitchVars(switchDropdown.SelectedIndex);
        }

        private void labelTogglePowerstate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if(switches[switchDropdown.SelectedIndex].getPowerstate() == true) {
                switches[switchDropdown.SelectedIndex].setPowerstate(false);
            } else {
                switches[switchDropdown.SelectedIndex].setPowerstate(true);
            }
            labelSwitchPowerstate.Text = Convert.ToString(switches[switchDropdown.SelectedIndex].getPowerstate()); //update current view
        }

        private void comboBoxPortSelect_SelectedIndexChanged(object sender, EventArgs e) {
            updatePortListVars(comboBoxPortSelect.SelectedIndex);
        }
    }
}
