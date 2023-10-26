using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace networkManager {
    class baseNetworkport {
        private int port;
        private string name;
        private string mac;
        private string attachedDevice;
        private string attachedMAC;
        private string attachedIP;


        public int getPort() {
            return port;
        }

        public string getPortname() {
            return name;
        }

        public string getMacAddress(int port) {
            return mac;
        }

        public void setPort(int value) {
            port = value;
        }

        public void setPortname(string value) {
            name = value;
        }

        public void setMacAddress(string value) {
            mac = value;
        }

        public void setAttachedDevice(string value) {
            attachedDevice = value;
        }

        public void setAttachedMAC(string value) {
            attachedMAC = value;
        }

        public void setAttachedIP(string value) {
            attachedIP = value;
        }

        public string getAttachedDevice() {
            return attachedDevice;
        }

        public string getAttachedMAC() {
            return attachedMAC;
        }

        public string getAttachedIP() {
            return attachedIP;
        }

    }
}
