using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_NodeBridge
{
    public enum DataType { Temperature, Humidity }
    public enum ErrorMsg { TestError, Inactive, WaitingforInit }

    public class NM
    {
        public static Dictionary<int, Node> NodeDict = new Dictionary<int, Node>();
        public static DataTable dataTable = new DataTable();
        

        public static void addNewNode(int NodeSN)
        {
            Node newNode = new Node(NodeSN);

            if (!NodeDict.ContainsKey(newNode.SN))
            {
                NodeDict.Add(newNode.SN, newNode);
            }
        }

        public static void deleteNode(int NodeSN)
        {
            NodeDict[NodeSN] = null;
            NodeDict.Remove(NodeSN);
        }

        public static void updateNode(int NodeSN, string newNodeName, int? newBatteryLevel, List<double[]> newData, List<double[]> newData2, 
                                        List<double[]> newData3, List<ErrorMsg> newErrorMessages,
                                      List<DataType> newDataTypes, bool newInternalErrorFlag, bool newInactiveFlag, int? newHighLimit,
                                      int? newLowLimit, int? newHighLimit2, int? newLowLimit2, int? newHighLimit3, int? newLowLimit3)
        {
            NodeDict[NodeSN].NodeName = newNodeName;
            NodeDict[NodeSN].BatteryLevel = newBatteryLevel;
            NodeDict[NodeSN].Data = newData;
            NodeDict[NodeSN].Data2 = newData2;
            NodeDict[NodeSN].Data3 = newData3;
            NodeDict[NodeSN].ErrorMessages = newErrorMessages;
            if (NodeDict[NodeSN].ErrorMessages.Count > 0) NodeDict[NodeSN].WarningFlag = true;
            else NodeDict[NodeSN].WarningFlag = false;
            NodeDict[NodeSN].DataTypes = newDataTypes;
            NodeDict[NodeSN].InternalErrorFlag = newInternalErrorFlag;
            NodeDict[NodeSN].InactiveFlag = newInactiveFlag;
            NodeDict[NodeSN].HighLimit = newHighLimit;
            NodeDict[NodeSN].LowLimit = newLowLimit;
            NodeDict[NodeSN].HighLimit2 = newHighLimit2;
            NodeDict[NodeSN].LowLimit2 = newLowLimit2;
            NodeDict[NodeSN].HighLimit3 = newHighLimit3;
            NodeDict[NodeSN].LowLimit3 = newLowLimit3;
        }

        public static void updateNodeData(double[] Data, int NodeSN)
        {
            //double[] newData = new double[2];
            //newData = Data;

            double[] SpecificData = new double[3];
            SpecificData[0] = Data[0];
            SpecificData[1] = Data[1];
            SpecificData[2] = NodeDict[NodeSN].PanelNum - 1;

            NodeDict[NodeSN].Data.Add(Data);            
            NodeBridge.ListToGraph.Add(SpecificData);
        }

        public class Node
        {
            public int SN { get; }
            public int PanelNum { get; set; }

            public string NodeName { get; set; }
            public int? BatteryLevel { get; set; }

            //Lists contain Data, Timestamp
            public List<double[]> Data { get; set; }
            public List<double[]> Data2 { get; set; }
            public List<double[]> Data3 { get; set; }

            public List<ErrorMsg> ErrorMessages { get; set; }
            public List<DataType> DataTypes { get; set; }

            public bool InternalErrorFlag { get; set; }
            public bool InactiveFlag { get; set; }
            public bool WarningFlag { get; set; }

            public int? HighLimit { get; set; }
            public int? LowLimit { get; set; }
            public int? HighLimit2 { get; set; }
            public int? LowLimit2 { get; set; }
            public int? HighLimit3 { get; set; }
            public int? LowLimit3 { get; set; }

            public Node(int InitSN)
            {
                SN = InitSN;

                NodeName = "Blank";
                BatteryLevel = 0;

                Data = new List<double[]>();
                Data2 = new List<double[]>();
                Data3 = new List<double[]>();

                ErrorMessages = new List<ErrorMsg>();
                DataTypes = new List<DataType>();

                InternalErrorFlag = true;
                InactiveFlag = true;
                WarningFlag = true;

                HighLimit = 100;
                LowLimit = -100;
                HighLimit2 = 100;
                LowLimit2 = -100;
                HighLimit3 = 100;
                LowLimit3 = -100;
            }
        }
    }
}
