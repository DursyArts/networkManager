using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace networkManager {
    class Switch : baseNetworkdevice {
        private List<baseNetworkport> ports = new List<baseNetworkport>();
        private int portcount;
        private bool powerstate;

        public Switch() {
            powerstate = false;
        }
        public string getHostname() {
            return hostname;
        }

        public void setHostname(string value) {
            hostname = value;
        }

        public void setIP(string value) {
            ip = value;
        }

        public void setSerialnumber(string value) {
            serialnumber = value;
        }

        public void setMAC(string value) {
            mac = value;
        }

        public string getIP() {
            return ip;
        }

        public string getSerialnumber() {
            return serialnumber;
        }

        public string getMAC() {
            return mac;
        }

        public void createPort() {
            ports.Add(new baseNetworkport { });
            ports[0].setPort(ports.Count);
        }

        public void setPortcount(int value) {
            portcount = value;
        }

        public int getPortcount() {
            return portcount;
        }

        public void setPowerstate(bool value) {
            powerstate = value;
        }

        public bool getPowerstate() {
            return powerstate;
        }

        public void setInfo(string value) {
            info = value;
        }

        public string getInfo() {
            return info;
        }
    }
}
