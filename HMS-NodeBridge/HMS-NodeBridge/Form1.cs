using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace HMS_NodeBridge
{
    public partial class NodeBridge : Form
    {
        public NodeBridge()
        {
            InitializeComponent();
        }

        private int addNewNodePanel()
        {
            Panel newPanel = new Panel();
            newPanel.Name = "NodePanel" + NM.NodeDict.Count.ToString();
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Height = 83;
            newPanel.Width = 123;
            newPanel.BackgroundImage = HiddenBGPanel.BackgroundImage;

                  Label newLabel = new Label();
            newLabel.Name = "NodeLabel" + NM.NodeDict.Count.ToString();            
            newLabel.Text = "Testing";            
            newLabel.Font = new Font(newLabel.Font.FontFamily, 8);            
            newLabel.Font = new Font(newLabel.Font, FontStyle.Bold);
            newLabel.Height = newLabel.Height - 9;
            newLabel.BackColor = Color.Transparent;
            newPanel.Controls.Add(newLabel);

            Label newSNLabel = new Label();
            newSNLabel.Name = "NodeSNLabel" + NM.NodeDict.Count.ToString();
            newSNLabel.Text = "SN00000000";
            newSNLabel.Font = new Font(newSNLabel.Font.FontFamily, 8);
            newSNLabel.Height = newSNLabel.Height - 9;
            newSNLabel.Location = new Point(newSNLabel.Location.X, newSNLabel.Location.Y + 15);
            newSNLabel.BackColor = Color.Transparent;
            newPanel.Controls.Add(newSNLabel);

            RichTextBox newColorRTB = new RichTextBox();
            newColorRTB.Name = "NodeColorRTB" + NM.NodeDict.Count.ToString();
            newColorRTB.Height = newColorRTB.Height - 60;
            newColorRTB.Width = newColorRTB.Width + 35;
            newColorRTB.Location = new Point(newColorRTB.Location.X-5, newColorRTB.Location.Y + 64);
            newColorRTB.BorderStyle = BorderStyle.FixedSingle;
            newColorRTB.BackColor = Color.Gold;
            newColorRTB.ReadOnly = true;
            newPanel.Controls.Add(newColorRTB);

            Button newButton = new Button();
            newButton.Name = "NodeInfoButton" + NM.NodeDict.Count.ToString();
            newButton.Text = "View Node Info";
            newButton.Font = new Font(newButton.Font.FontFamily, 8);
            newButton.Location = new Point(newButton.Location.X + 15, newButton.Location.Y + 44);
            newButton.Height = 20;
            newButton.Width = 90;
            newPanel.Controls.Add(newButton);

            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Name = "NodeCheckBox" + NM.NodeDict.Count.ToString();
            newCheckBox.BackColor = Color.Transparent;
            newCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            newCheckBox.TextAlign = ContentAlignment.MiddleRight;
            newCheckBox.Text = "Select Multiple";
            newCheckBox.Location = new Point(newCheckBox.Location.X + 6, newCheckBox.Location.Y + 25);
            newPanel.Controls.Add(newCheckBox);                        

            nodeFlowLayoutPanel.Controls.Add(newPanel);

            return NM.NodeDict.Count;
        }

        private void BT_AddNode_Click(object sender, EventArgs e)
        {
            new AddNodeWindow().ShowDialog(); //Spawn new window asking for Node SN
            int NewSN = AddNodeWindow.NodeSN; //Contains a valid structure SN, or -1 for cancellation
            if (NewSN == -1) return;

            //Check if SN already exists
            foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
            {
                if(NM.NodeDict[node.Key].SN == NewSN)
                {
                    MessageBox.Show("A Node of this Serial Number already exists.");
                    return;
                }
            }

            //Ask DataHub to send handshake Tx to NewSN
            if (!CM.HUBRequest_AddNode(NewSN))
            {
                MessageBox.Show("The Node could not be reached.");
                return;
            }

            //If proper rx, add node and update parameters
            int NodePanelNum = addNewNodePanel();      //Create new panel/embedded objects in flowlayoutpanel

            //Create an object for the new node - Update will come from form refresh, no data yet
            NM.addNewNode(NewSN);

            //Update node with blank data to be displayed until updated
            //NM.updateNode(NewSN, "Node"+NewSN.ToString(), null, null,  )

            //Make node object's NodePanelNumber equal to the above            
        }

        private void TEST_BT_ConnectHUB_Click(object sender, EventArgs e)
        {            
            Int32 port = 12345;
            TcpClient client = new TcpClient(TEST_TB_InputIP.Text, port);

            Byte[] data = System.Text.Encoding.ASCII.GetBytes("801231995");

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            TEST_RTB_ReceivedMsg.Text = ("Sent.\n");

            data = new byte[1024];

            String responseData = String.Empty;

            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            TEST_RTB_ReceivedMsg.Text = responseData;

            stream.Close();
            client.Close();
        }

        private void TEST_BT_SendMessage_Click(object sender, EventArgs e)
        {
            Int32 port = 12345;
            TcpClient client = new TcpClient(TEST_TB_InputIP.Text, port);

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(TEST_RTB_MessagetoSend.Text);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            TEST_RTB_ReceivedMsg.Text = ("Sent.\n");

            data = new byte[1024];

            String responseData = String.Empty;

            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            TEST_RTB_ReceivedMsg.Text = responseData;

            stream.Close();
            client.Close();
        }

        private void BT_ConnectDataHub_Click(object sender, EventArgs e)
        {
            Int32 port = 12345;
            TcpClient client = new TcpClient(TEST_TB_InputIP.Text, port);

            Byte[] data = System.Text.Encoding.ASCII.GetBytes("801231995");

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);            

            data = new byte[1024];

            String responseData = String.Empty;

            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            TEST_RTB_ReceivedMsg.Text = responseData;

            stream.Close();
            client.Close();
        }

        private void TEST_BT_Demo1_Click(object sender, EventArgs e)
        {
            //Add 3 nodes - all using temperature
            //Start new data update thread(DEMO ONLY)
            //      Push new node data on 3 sec cycle
            //     
            //Start form update thread cycle at 0.5s
            //
        }

        private void splitter1_Splitteroved(object sender, SplitterEventArgs e)
        {

        }

        
    }
}
