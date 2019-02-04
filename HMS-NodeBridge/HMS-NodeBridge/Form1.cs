using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using LiveCharts; //Core of the library
using LiveCharts.WinForms; //the WinForm wrappers
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
//using System.Windows.Media;

namespace HMS_NodeBridge
{
    public partial class NodeBridge : Form
    {
        //Global Variables
        public static List<double[]> ListToGraph = new List<double[]>();
        public static double GraphRange = 0;        

        public NodeBridge()
        {
            InitializeComponent();
            //Initialize_GraphicalUpdate();
        }

        private int addNewNodePanel()
        {
            Panel newPanel = new Panel();
            newPanel.Name = "NodePanel" + NM.NodeDict.Count.ToString();
            newPanel.BorderStyle = BorderStyle.FixedSingle;
            newPanel.Height = 100;
            newPanel.Width = 175;            
            newPanel.BackgroundImage = HiddenBGPanel.BackgroundImage;

            Label newLabel = new Label();
            newLabel.Name = "NodeLabel" + NM.NodeDict.Count.ToString();            
            newLabel.Text = "Testing";            
            newLabel.Font = new Font(newLabel.Font.FontFamily, 8);            
            newLabel.Font = new Font(newLabel.Font, FontStyle.Bold);
            newLabel.Height = newLabel.Height;
            newLabel.BackColor = Color.Transparent;
            newPanel.Controls.Add(newLabel);

            Label newSNLabel = new Label();
            newSNLabel.Name = "NodeSNLabel" + NM.NodeDict.Count.ToString();
            newSNLabel.Text = "SN00000000";
            newSNLabel.Font = new Font(newSNLabel.Font.FontFamily, 8);
            newSNLabel.Height = newSNLabel.Height;
            newSNLabel.Location = new Point(newSNLabel.Location.X, newSNLabel.Location.Y + 25);
            newSNLabel.BackColor = Color.Transparent;
            newPanel.Controls.Add(newSNLabel);

            RichTextBox newColorRTB = new RichTextBox();
            newColorRTB.Name = "NodeColorRTB" + NM.NodeDict.Count.ToString();
            newColorRTB.Height = newColorRTB.Height - 60;
            newColorRTB.Width = newColorRTB.Width + 81;
            newColorRTB.Location = new Point(newColorRTB.Location.X-5, newColorRTB.Location.Y + 74);
            newColorRTB.BorderStyle = BorderStyle.FixedSingle;
            newColorRTB.BackColor = Color.Gold;
            newColorRTB.ReadOnly = true;
            newPanel.Controls.Add(newColorRTB);

            Button newButton = new Button();
            newButton.Name = "NodeInfoButton" + NM.NodeDict.Count.ToString();
            newButton.Text = "View Node Info";
            newButton.Font = new Font(newButton.Font.FontFamily, 8);
            newButton.Location = new Point(newButton.Location.X + 27, newButton.Location.Y + 48);
            newButton.Height = 27;
            newButton.Width = 115;
            newPanel.Controls.Add(newButton);
            newButton.Click += newPanelButton_Click;
            newButton.Tag = NM.NodeDict.Count;
            

            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Name = "NodeCheckBox" + NM.NodeDict.Count.ToString();
            newCheckBox.BackColor = Color.Transparent;
            newCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            newCheckBox.TextAlign = ContentAlignment.MiddleRight;
            newCheckBox.Text = "";
            newCheckBox.Location = new Point(newCheckBox.Location.X + 60, newCheckBox.Location.Y + 25);
            newPanel.Controls.Add(newCheckBox);                        

            nodeFlowLayoutPanel.Controls.Add(newPanel);

            return NM.NodeDict.Count;
        }

        private void newPanelButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
            {
                if (NM.NodeDict[node.Key].PanelNum.ToString() == clickedButton.Tag.ToString())
                {
                    LB_Main_NodeName.Text = NM.NodeDict[node.Key].NodeName;
                    LB_Main_SN.Text = "Serial Number: SN" + NM.NodeDict[node.Key].SN.ToString();
                    LB_Main_Battery.Text = "Battery Level: " + NM.NodeDict[node.Key].BatteryLevel.ToString();
                    LB_Main_SensorTypes.Text = "    ";                          
                    foreach (var sensor in NM.NodeDict[node.Key].DataTypes)
                    {
                        LB_Main_SensorTypes.Text += sensor.ToString();
                        if (!sensor.Equals(NM.NodeDict[node.Key].DataTypes.Last()))
                        {
                            LB_Main_SensorTypes.Text += ", ";
                        }
                    }
                    
                    LB_Main_WarnS1.Text = NM.NodeDict[node.Key].LowLimit.ToString() + " to " + NM.NodeDict[node.Key].HighLimit.ToString();
                }
            }

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
            NM.addNewNode(30000);
            NM.updateNode(30000, "North", 100, new List<double[]>(), new List<double[]>(), new List<double[]>(), new List<ErrorMsg>(), new List<DataType>(), false, false, 55, 10, 60, 0, null, null);
            int NodePanelNum1 = addNewNodePanel();

            NM.addNewNode(30001);
            NM.updateNode(30001, "South", 80, new List<double[]>(), new List<double[]>(), new List<double[]>(), new List<ErrorMsg>(), new List<DataType>(), false, false, 55, 10, null, null, null, null);
            int NodePanelNum2 = addNewNodePanel();

            NM.addNewNode(30002);
            NM.updateNode(30002, "West", 60, new List<double[]>(), new List<double[]>(), new List<double[]>(), new List<ErrorMsg>(), new List<DataType>(), false, false, 55, 10, null, null, null, null);
            int NodePanelNum3 = addNewNodePanel();

            NM.NodeDict[30000].PanelNum = NodePanelNum1;
            NM.NodeDict[30001].PanelNum = NodePanelNum2;
            NM.NodeDict[30002].PanelNum = NodePanelNum3;

            NM.NodeDict[30000].DataTypes.Add(DataType.Temperature);
            NM.NodeDict[30001].DataTypes.Add(DataType.Temperature);
            NM.NodeDict[30002].DataTypes.Add(DataType.Temperature);
            NM.NodeDict[30000].DataTypes.Add(DataType.Humidity);

            Label tb30000name = nodeFlowLayoutPanel.Controls.Find("NodeLabel1", true).FirstOrDefault() as Label;
            tb30000name.Text = NM.NodeDict[30000].NodeName;
            Label tb30001name = nodeFlowLayoutPanel.Controls.Find("NodeLabel2", true).FirstOrDefault() as Label;
            tb30001name.Text = NM.NodeDict[30001].NodeName;
            Label tb30002name = nodeFlowLayoutPanel.Controls.Find("NodeLabel3", true).FirstOrDefault() as Label;
            tb30002name.Text = NM.NodeDict[30002].NodeName;

            Label tb30000SN = nodeFlowLayoutPanel.Controls.Find("NodeSNLabel1", true).FirstOrDefault() as Label;
            tb30000SN.Text = "SN" + NM.NodeDict[30000].SN.ToString();
            Label tb30001SN = nodeFlowLayoutPanel.Controls.Find("NodeSNLabel2", true).FirstOrDefault() as Label;
            tb30001SN.Text = "SN" + NM.NodeDict[30001].SN.ToString();
            Label tb30002SN = nodeFlowLayoutPanel.Controls.Find("NodeSNLabel3", true).FirstOrDefault() as Label;
            tb30002SN.Text = "SN" + NM.NodeDict[30002].SN.ToString();

            RichTextBox rtb30000colorstatus = nodeFlowLayoutPanel.Controls.Find("NodeColorRTB1", true).FirstOrDefault() as RichTextBox;
            rtb30000colorstatus.BackColor = Color.Lime;
            RichTextBox rtb30001colorstatus = nodeFlowLayoutPanel.Controls.Find("NodeColorRTB2", true).FirstOrDefault() as RichTextBox;
            rtb30001colorstatus.BackColor = Color.Lime;
            RichTextBox rtb30002colorstatus = nodeFlowLayoutPanel.Controls.Find("NodeColorRTB3", true).FirstOrDefault() as RichTextBox;
            rtb30002colorstatus.BackColor = Color.Lime;

            //Start new data update thread(DEMO ONLY)
            //      Push new node data on 3 sec cycle
            BW_DEMO1_DataStream.RunWorkerAsync();

            Initialize_GraphicalUpdate();
            Timer_Updates.Enabled = true;
            //Start form update thread cycle at 0.5s
            //
        }

        private void splitter1_Splitteroved(object sender, SplitterEventArgs e)
        {

        }

        private void CB_Graph_DataSource_DropDown(object sender, EventArgs e)
        {
            CB_Graph_DataSource.Items.Clear();
            CB_Graph_DataSource.Items.Add("All Nodes");
            foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
            {
                CB_Graph_DataSource.Items.Add(NM.NodeDict[node.Key].NodeName);                
            }
        }

        private void BT_Main_ViewNodeData_Click(object sender, EventArgs e)
        {
            DataTable newdataTable = new DataTable();

            int NodeSN = Convert.ToInt32(LB_Main_SN.Text.Substring(17));                       
            int MaxRows = Math.Max(NM.NodeDict[NodeSN].Data.Count, Math.Max(NM.NodeDict[NodeSN].Data2.Count, NM.NodeDict[NodeSN].Data3.Count));
                       
            foreach (var dataTypes in NM.NodeDict[NodeSN].DataTypes)
            {
                newdataTable.Columns.Add(dataTypes.ToString());
                newdataTable.Columns.Add(dataTypes.ToString() + " Timestamp");

                while (newdataTable.Rows.Count < MaxRows + 1)
                {
                    newdataTable.Rows.Add();
                }

                for (int i = 0; i < MaxRows; i++)
                {
                    try
                    {
                        newdataTable.Rows[i + 1][0] = NM.NodeDict[NodeSN].Data[i][0];
                        newdataTable.Rows[i + 1][1] = NM.NodeDict[NodeSN].Data[i][1];
                    }
                    catch { }

                    try
                    {
                        newdataTable.Rows[i + 1][2] = NM.NodeDict[NodeSN].Data2[i][0];
                        newdataTable.Rows[i + 1][3] = NM.NodeDict[NodeSN].Data2[i][1];
                    }
                    catch { }

                    try
                    {
                        newdataTable.Rows[i + 1][4] = NM.NodeDict[NodeSN].Data3[i][0];
                        newdataTable.Rows[i + 1][5] = NM.NodeDict[NodeSN].Data3[i][1];
                    }
                    catch { }
                }                                
            }

            NM.dataTable = newdataTable;
            new DisplayNodeDataWindow().Show();
        }

        private void BW_DEMO1_DataStream_DoWork(object sender, DoWorkEventArgs e)
        {            
            Random random = new Random();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
           
            while (true)
            {
                foreach (KeyValuePair<int, NM.Node> node in NM.NodeDict)
                {
                    double[] DEMO_Data = new double[2];

                    double R = random.Next(-4, 4);
                    Thread.Sleep(1);

                    DEMO_Data[0] = 20 + R;
                    DEMO_Data[1] = stopwatch.ElapsedMilliseconds;

                    NM.updateNodeData(DEMO_Data, node.Key);

                    Thread.Sleep(1000);
                }
                
                //Thread.Sleep(1000);
            }                                  
        }        

        private void BW_DEMO1_DataStream_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void Initialize_GraphicalUpdate()
        {
            //Chart_Data.Series.Remove()

            if (CB_Graph_DataSource.Text == "All Nodes" && CB_Graph_SeriesOption.Text == "Single Series")
            {
                var mapper = Mappers.Xy<ObservablePoint>() //in this case value is of type <ObservablePoint>
                    .X(value => value.X) //use the X property as X
                    .Y(value => value.Y); //use the Y property as Y

                CartesianChart_Data.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Series 1",
                        //Values = new ChartValues<double> {4, 6, 5, 2, 7}
                        
                        Values = new ChartValues<ObservablePoint>() {
                                 //new ObservablePoint (10, 5) // x = 10, Y = 5
                                 }

                    }                    
                };
               
                CartesianChart_Data.AxisY.Add(new Axis
                {
                    Position = AxisPosition.LeftBottom,
                    Title = "Temperature"
                });

                CartesianChart_Data.AxisX.Add(new Axis
                {
                    Position = AxisPosition.LeftBottom,
                    Title = "Time"
                });
            }

            else if (CB_Graph_DataSource.Text == "All Nodes" && CB_Graph_SeriesOption.Text == "Seperate Series")
            {

                var mapper = Mappers.Xy<ObservablePoint>() //in this case value is of type <ObservablePoint>
                .X(value => value.X) //use the X property as X
                .Y(value => value.Y); //use the Y property as Y

                CartesianChart_Data.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Series 1",
                        //Values = new ChartValues<double> {4, 6, 5, 2, 7}
                        
                        Values = new ChartValues<ObservablePoint>() {
                                 //new ObservablePoint (10, 5) // x = 10, Y = 5
                                 }

                    },

                    new LineSeries
                    {
                        Title = "Series 2",
                        //Values = new ChartValues<double> {4, 6, 5, 2, 7}
                        
                        Values = new ChartValues<ObservablePoint>() {
                                 //new ObservablePoint (10, 5) // x = 10, Y = 5
                                 }

                    },

                    new LineSeries
                    {
                        Title = "Series 3",
                        //Values = new ChartValues<double> {4, 6, 5, 2, 7}
                        
                        Values = new ChartValues<ObservablePoint>() {
                                 //new ObservablePoint (10, 5) // x = 10, Y = 5
                                 }

                    }
                };

                CartesianChart_Data.AxisY.Add(new Axis
                {
                    Position = AxisPosition.LeftBottom,
                    Title = "Temperature"
                });

                CartesianChart_Data.AxisX.Add(new Axis
                {
                    Position = AxisPosition.LeftBottom,
                    Title = "Time"
                });
            }

            
        }

        private void tabControl_HMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_HMS.SelectedIndex == 2)
            {
                if (NM.NodeDict.Count > 0)
                {
                    //Initialize_GraphicalUpdate();                    
                }
            }
        }

        

        private void BT_DEMO_AddNewData_Click(object sender, EventArgs e)
        {
            CartesianChart_Data.Series[0].Values.Add(new ObservablePoint (3,2));
        }

        private void Timer_Updates_Tick(object sender, EventArgs e)
        {
            if (ListToGraph.Count > 0)
            {                
                foreach (var data in ListToGraph)
                {
                    if (CB_Graph_SeriesOption.Text == "Single Series") CartesianChart_Data.Series[0].Values.Add(new ObservablePoint(data[1], data[0]));
                    else if (CB_Graph_SeriesOption.Text == "Seperate Series")
                    {
                        if (data[2] == 0) { CartesianChart_Data.Series[0].Values.Add(new ObservablePoint(data[1], data[0]));  }
                        else if (data[2] == 1) { CartesianChart_Data.Series[1].Values.Add(new ObservablePoint(data[1], data[0]));  }
                        else if (data[2] == 2) { CartesianChart_Data.Series[2].Values.Add(new ObservablePoint(data[1], data[0]));  }
                    }
                }
                
                if (ListToGraph[0][1] > 10000)
                {
                    GraphRange = ListToGraph[0][1];
                    CartesianChart_Data.AxisX[0].MaxValue = GraphRange;
                    CartesianChart_Data.AxisX[0].MinValue = GraphRange - 10000;
                }
                ListToGraph.Clear();
            }
        }
    }
}
