using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NodeBridge
{
    public class CM
    {
        public static bool HUBRequest_Connect()
        {
            //Construct test message
            //Find way to get IP, port.. fixed maybe?
            //Open client socket and send test message
            //If successful, save these parameters globally
            //return success/failure
            return true;        //Temporary
        }

        public static bool HUBRequest_AddNode(int NewSN)
        {
            //Construct Specific Message
            //Open global client socket and send message
            //return success/failure
            return true;        //Temporary
        }

        public static bool HUBRequest_NewSampleTime(int SN, int sampleTime)
        {
            //Construct specific message
            //Open global client socket and send message
            //return success/failure
            return true;        //Temporary
        }
    }
}
