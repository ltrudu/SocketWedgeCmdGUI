using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SocketWedgeCmdGUI
{
    internal class SocketWedgeConfig
    {
        public String mCommandWindowTitle = "";

        public Dictionary<String, String> mServerList = new Dictionary<string, string>();

        public Boolean mAddReturn = false;

        public Boolean mWedge = false;

        public String mWindowName = "";

        public String getCMDFileString()
        {
            String cmdFileString = "";
            cmdFileString += "title " + mCommandWindowTitle + "\n";
            cmdFileString += "call SocketWedge ";
            foreach(KeyValuePair<String, String> server in mServerList)
            {
                cmdFileString += "/Server=" + server.Key + ":" + server.Value + " ";
            }
            cmdFileString += "/AddReturn=" + (mAddReturn ? "1" : "0") + " ";
            cmdFileString += "/Wedge=" + (mWedge ? "1" : "0") + " ";
            cmdFileString += "/FocusWindow=" + mWindowName + "\n";

            return cmdFileString;
        }

    }
}
