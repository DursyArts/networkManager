using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace networkManager {
    class baseNetworkdevice : baseNetworkport{
        protected string hostname { get; set; }
        protected string ip { get; set; }
        protected string serialnumber { get; set; }
        protected string mac { get; set; } //NIC MAC
        protected string info { get; set; }
        public baseNetworkdevice() {
        }
    }
}
