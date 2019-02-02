namespace HMS_NodeBridge
{
    partial class NodeBridge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeBridge));
            this.tabControl_HMS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.P_MainNMPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BT_ConnectDataHub = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LB_Main_SN = new System.Windows.Forms.Label();
            this.LB_Main_WarnS3 = new System.Windows.Forms.Label();
            this.LB_Main_WarnS2 = new System.Windows.Forms.Label();
            this.LB_Main_WarnS1 = new System.Windows.Forms.Label();
            this.LB_Main_Battery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Main_SensorTypes = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_Main_ViewNodeData = new System.Windows.Forms.Button();
            this.BT_Main_EditWarnPar = new System.Windows.Forms.Button();
            this.LB_Main_NodeName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BT_AddNode = new System.Windows.Forms.Button();
            this.nodeFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TEST_BT_Demo1 = new System.Windows.Forms.Button();
            this.TEST_BT_SendMessage = new System.Windows.Forms.Button();
            this.TEST_RTB_ReceivedMsg = new System.Windows.Forms.RichTextBox();
            this.TEST_RTB_MessagetoSend = new System.Windows.Forms.RichTextBox();
            this.TEST_TB_InputIP = new System.Windows.Forms.TextBox();
            this.TEST_BT_ConnectHUB = new System.Windows.Forms.Button();
            this.HiddenBGPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl_HMS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.P_MainNMPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_HMS
            // 
            this.tabControl_HMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_HMS.Controls.Add(this.tabPage1);
            this.tabControl_HMS.Controls.Add(this.tabPage2);
            this.tabControl_HMS.Controls.Add(this.tabPage3);
            this.tabControl_HMS.Controls.Add(this.tabPage4);
            this.tabControl_HMS.Location = new System.Drawing.Point(11, 8);
            this.tabControl_HMS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl_HMS.Name = "tabControl_HMS";
            this.tabControl_HMS.SelectedIndex = 0;
            this.tabControl_HMS.Size = new System.Drawing.Size(761, 389);
            this.tabControl_HMS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.P_MainNMPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(753, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Node Management";
            // 
            // P_MainNMPanel
            // 
            this.P_MainNMPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_MainNMPanel.BackColor = System.Drawing.Color.Ivory;
            this.P_MainNMPanel.BackgroundImage = global::HMS_NodeBridge.Properties.Resources._5957bd2767d5cad;
            this.P_MainNMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_MainNMPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_MainNMPanel.Controls.Add(this.panel4);
            this.P_MainNMPanel.Controls.Add(this.nodeFlowLayoutPanel);
            this.P_MainNMPanel.Controls.Add(this.splitter1);
            this.P_MainNMPanel.Location = new System.Drawing.Point(0, 0);
            this.P_MainNMPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.P_MainNMPanel.Name = "P_MainNMPanel";
            this.P_MainNMPanel.Size = new System.Drawing.Size(760, 369);
            this.P_MainNMPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.BT_ConnectDataHub);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.LB_Main_NodeName);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.BT_AddNode);
            this.panel4.Location = new System.Drawing.Point(527, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 378);
            this.panel4.TabIndex = 10;
            // 
            // BT_ConnectDataHub
            // 
            this.BT_ConnectDataHub.BackColor = System.Drawing.Color.Gold;
            this.BT_ConnectDataHub.FlatAppearance.BorderSize = 0;
            this.BT_ConnectDataHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ConnectDataHub.Location = new System.Drawing.Point(3, 304);
            this.BT_ConnectDataHub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_ConnectDataHub.Name = "BT_ConnectDataHub";
            this.BT_ConnectDataHub.Size = new System.Drawing.Size(221, 27);
            this.BT_ConnectDataHub.TabIndex = 17;
            this.BT_ConnectDataHub.Text = "Connect to DataHub";
            this.BT_ConnectDataHub.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LB_Main_SN);
            this.panel3.Controls.Add(this.LB_Main_WarnS3);
            this.panel3.Controls.Add(this.LB_Main_WarnS2);
            this.panel3.Controls.Add(this.LB_Main_WarnS1);
            this.panel3.Controls.Add(this.LB_Main_Battery);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.LB_Main_SensorTypes);
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 146);
            this.panel3.TabIndex = 16;
            // 
            // LB_Main_SN
            // 
            this.LB_Main_SN.AutoSize = true;
            this.LB_Main_SN.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_SN.Location = new System.Drawing.Point(3, 0);
            this.LB_Main_SN.Name = "LB_Main_SN";
            this.LB_Main_SN.Size = new System.Drawing.Size(90, 15);
            this.LB_Main_SN.TabIndex = 12;
            this.LB_Main_SN.Text = "Serial Number:";
            // 
            // LB_Main_WarnS3
            // 
            this.LB_Main_WarnS3.AutoSize = true;
            this.LB_Main_WarnS3.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_WarnS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_WarnS3.Location = new System.Drawing.Point(20, 125);
            this.LB_Main_WarnS3.Name = "LB_Main_WarnS3";
            this.LB_Main_WarnS3.Size = new System.Drawing.Size(56, 15);
            this.LB_Main_WarnS3.TabIndex = 11;
            this.LB_Main_WarnS3.Text = "Sensor 3";
            // 
            // LB_Main_WarnS2
            // 
            this.LB_Main_WarnS2.AutoSize = true;
            this.LB_Main_WarnS2.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_WarnS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_WarnS2.Location = new System.Drawing.Point(20, 110);
            this.LB_Main_WarnS2.Name = "LB_Main_WarnS2";
            this.LB_Main_WarnS2.Size = new System.Drawing.Size(56, 15);
            this.LB_Main_WarnS2.TabIndex = 10;
            this.LB_Main_WarnS2.Text = "Sensor 2";
            // 
            // LB_Main_WarnS1
            // 
            this.LB_Main_WarnS1.AutoSize = true;
            this.LB_Main_WarnS1.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_WarnS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_WarnS1.Location = new System.Drawing.Point(20, 95);
            this.LB_Main_WarnS1.Name = "LB_Main_WarnS1";
            this.LB_Main_WarnS1.Size = new System.Drawing.Size(56, 15);
            this.LB_Main_WarnS1.TabIndex = 9;
            this.LB_Main_WarnS1.Text = "Sensor 1";
            // 
            // LB_Main_Battery
            // 
            this.LB_Main_Battery.AutoSize = true;
            this.LB_Main_Battery.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_Battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_Battery.Location = new System.Drawing.Point(3, 24);
            this.LB_Main_Battery.Name = "LB_Main_Battery";
            this.LB_Main_Battery.Size = new System.Drawing.Size(79, 15);
            this.LB_Main_Battery.TabIndex = 6;
            this.LB_Main_Battery.Text = "Battery Level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Warning Parameters:";
            // 
            // LB_Main_SensorTypes
            // 
            this.LB_Main_SensorTypes.AutoSize = true;
            this.LB_Main_SensorTypes.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_SensorTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_SensorTypes.Location = new System.Drawing.Point(3, 48);
            this.LB_Main_SensorTypes.Name = "LB_Main_SensorTypes";
            this.LB_Main_SensorTypes.Size = new System.Drawing.Size(84, 15);
            this.LB_Main_SensorTypes.TabIndex = 7;
            this.LB_Main_SensorTypes.Text = "Sensor Types:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(174, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 24);
            this.button4.TabIndex = 14;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BT_Main_ViewNodeData);
            this.panel2.Controls.Add(this.BT_Main_EditWarnPar);
            this.panel2.Location = new System.Drawing.Point(3, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 104);
            this.panel2.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 76);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 24);
            this.button7.TabIndex = 14;
            this.button7.Text = "Show Current Mesh Pathway";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 24);
            this.button6.TabIndex = 13;
            this.button6.Text = "Set New Frequency";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Node Controls";
            // 
            // BT_Main_ViewNodeData
            // 
            this.BT_Main_ViewNodeData.Location = new System.Drawing.Point(114, 20);
            this.BT_Main_ViewNodeData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Main_ViewNodeData.Name = "BT_Main_ViewNodeData";
            this.BT_Main_ViewNodeData.Size = new System.Drawing.Size(103, 24);
            this.BT_Main_ViewNodeData.TabIndex = 6;
            this.BT_Main_ViewNodeData.Text = "View Data Set(s)";
            this.BT_Main_ViewNodeData.UseVisualStyleBackColor = true;
            // 
            // BT_Main_EditWarnPar
            // 
            this.BT_Main_EditWarnPar.Location = new System.Drawing.Point(3, 48);
            this.BT_Main_EditWarnPar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Main_EditWarnPar.Name = "BT_Main_EditWarnPar";
            this.BT_Main_EditWarnPar.Size = new System.Drawing.Size(211, 24);
            this.BT_Main_EditWarnPar.TabIndex = 5;
            this.BT_Main_EditWarnPar.Text = "Adjust Warning Parameters";
            this.BT_Main_EditWarnPar.UseVisualStyleBackColor = true;
            // 
            // LB_Main_NodeName
            // 
            this.LB_Main_NodeName.AutoSize = true;
            this.LB_Main_NodeName.BackColor = System.Drawing.Color.Transparent;
            this.LB_Main_NodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Main_NodeName.Location = new System.Drawing.Point(4, 15);
            this.LB_Main_NodeName.Name = "LB_Main_NodeName";
            this.LB_Main_NodeName.Size = new System.Drawing.Size(97, 18);
            this.LB_Main_NodeName.TabIndex = 12;
            this.LB_Main_NodeName.Text = "Node Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete Node";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BT_AddNode
            // 
            this.BT_AddNode.Location = new System.Drawing.Point(57, 335);
            this.BT_AddNode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_AddNode.Name = "BT_AddNode";
            this.BT_AddNode.Size = new System.Drawing.Size(73, 24);
            this.BT_AddNode.TabIndex = 10;
            this.BT_AddNode.Text = "Add Node";
            this.BT_AddNode.UseVisualStyleBackColor = true;
            this.BT_AddNode.Click += new System.EventHandler(this.BT_AddNode_Click);
            // 
            // nodeFlowLayoutPanel
            // 
            this.nodeFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeFlowLayoutPanel.BackgroundImage = global::HMS_NodeBridge.Properties.Resources._45202782_1336614119806943_3940037044109049856_n;
            this.nodeFlowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nodeFlowLayoutPanel.Location = new System.Drawing.Point(-2, -2);
            this.nodeFlowLayoutPanel.Name = "nodeFlowLayoutPanel";
            this.nodeFlowLayoutPanel.Size = new System.Drawing.Size(527, 363);
            this.nodeFlowLayoutPanel.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(526, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter1.Size = new System.Drawing.Size(230, 365);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_Splitteroved);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(753, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(753, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Charts/Graphing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BackgroundImage = global::HMS_NodeBridge.Properties.Resources._5957bd2767d5cad;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 369);
            this.panel1.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.comboBox6);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(527, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 378);
            this.panel5.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(209, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "Pause Auto Display";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Export Displayed Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.comboBox5);
            this.panel6.Controls.Add(this.comboBox4);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.comboBox3);
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(7, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 102);
            this.panel6.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow"});
            this.comboBox5.Location = new System.Drawing.Point(132, 69);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(63, 21);
            this.comboBox5.TabIndex = 21;
            this.comboBox5.Text = "Blue";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow"});
            this.comboBox4.Location = new System.Drawing.Point(132, 18);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(63, 21);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.Text = "Red";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Primary Data Type:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Temperature",
            "Humidity"});
            this.comboBox3.Location = new System.Drawing.Point(7, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 21);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Text = "None";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "None",
            "Temperature",
            "Humidity"});
            this.comboBox2.Location = new System.Drawing.Point(7, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Temperature";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Secondary Data Type:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Line",
            "Bar"});
            this.comboBox6.Location = new System.Drawing.Point(51, 123);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 17;
            this.comboBox6.Text = "Line";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Graph Style";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Nodes"});
            this.comboBox1.Location = new System.Drawing.Point(51, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "All Nodes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Show Data From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Graphing Controls";
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(526, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(230, 365);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TEST_BT_Demo1);
            this.tabPage4.Controls.Add(this.TEST_BT_SendMessage);
            this.tabPage4.Controls.Add(this.TEST_RTB_ReceivedMsg);
            this.tabPage4.Controls.Add(this.TEST_RTB_MessagetoSend);
            this.tabPage4.Controls.Add(this.TEST_TB_InputIP);
            this.tabPage4.Controls.Add(this.TEST_BT_ConnectHUB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(753, 363);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Testing Controls";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TEST_BT_Demo1
            // 
            this.TEST_BT_Demo1.Location = new System.Drawing.Point(16, 144);
            this.TEST_BT_Demo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_BT_Demo1.Name = "TEST_BT_Demo1";
            this.TEST_BT_Demo1.Size = new System.Drawing.Size(151, 23);
            this.TEST_BT_Demo1.TabIndex = 5;
            this.TEST_BT_Demo1.Text = "Demo 1";
            this.TEST_BT_Demo1.UseVisualStyleBackColor = true;
            this.TEST_BT_Demo1.Click += new System.EventHandler(this.TEST_BT_Demo1_Click);
            // 
            // TEST_BT_SendMessage
            // 
            this.TEST_BT_SendMessage.Location = new System.Drawing.Point(16, 40);
            this.TEST_BT_SendMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_BT_SendMessage.Name = "TEST_BT_SendMessage";
            this.TEST_BT_SendMessage.Size = new System.Drawing.Size(151, 23);
            this.TEST_BT_SendMessage.TabIndex = 4;
            this.TEST_BT_SendMessage.Text = "Send Message";
            this.TEST_BT_SendMessage.UseVisualStyleBackColor = true;
            this.TEST_BT_SendMessage.Click += new System.EventHandler(this.TEST_BT_SendMessage_Click);
            // 
            // TEST_RTB_ReceivedMsg
            // 
            this.TEST_RTB_ReceivedMsg.Location = new System.Drawing.Point(414, 40);
            this.TEST_RTB_ReceivedMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_RTB_ReceivedMsg.Name = "TEST_RTB_ReceivedMsg";
            this.TEST_RTB_ReceivedMsg.Size = new System.Drawing.Size(240, 64);
            this.TEST_RTB_ReceivedMsg.TabIndex = 3;
            this.TEST_RTB_ReceivedMsg.Text = "";
            // 
            // TEST_RTB_MessagetoSend
            // 
            this.TEST_RTB_MessagetoSend.Location = new System.Drawing.Point(171, 40);
            this.TEST_RTB_MessagetoSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_RTB_MessagetoSend.Name = "TEST_RTB_MessagetoSend";
            this.TEST_RTB_MessagetoSend.Size = new System.Drawing.Size(240, 64);
            this.TEST_RTB_MessagetoSend.TabIndex = 2;
            this.TEST_RTB_MessagetoSend.Text = "8012345";
            // 
            // TEST_TB_InputIP
            // 
            this.TEST_TB_InputIP.Location = new System.Drawing.Point(171, 16);
            this.TEST_TB_InputIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_TB_InputIP.Name = "TEST_TB_InputIP";
            this.TEST_TB_InputIP.Size = new System.Drawing.Size(240, 20);
            this.TEST_TB_InputIP.TabIndex = 1;
            this.TEST_TB_InputIP.Text = "192.168.1.107";
            // 
            // TEST_BT_ConnectHUB
            // 
            this.TEST_BT_ConnectHUB.Location = new System.Drawing.Point(16, 13);
            this.TEST_BT_ConnectHUB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TEST_BT_ConnectHUB.Name = "TEST_BT_ConnectHUB";
            this.TEST_BT_ConnectHUB.Size = new System.Drawing.Size(151, 23);
            this.TEST_BT_ConnectHUB.TabIndex = 0;
            this.TEST_BT_ConnectHUB.Text = "Connect with DataHub";
            this.TEST_BT_ConnectHUB.UseVisualStyleBackColor = true;
            this.TEST_BT_ConnectHUB.Click += new System.EventHandler(this.TEST_BT_ConnectHUB_Click);
            // 
            // HiddenBGPanel
            // 
            this.HiddenBGPanel.BackgroundImage = global::HMS_NodeBridge.Properties.Resources._45050754_abstract_background_light_red_color;
            this.HiddenBGPanel.Location = new System.Drawing.Point(439, 8);
            this.HiddenBGPanel.Name = "HiddenBGPanel";
            this.HiddenBGPanel.Size = new System.Drawing.Size(200, 100);
            this.HiddenBGPanel.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.chart1);
            this.panel7.Location = new System.Drawing.Point(-2, -2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(527, 363);
            this.panel7.TabIndex = 20;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Ivory;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(0, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chart1.Size = new System.Drawing.Size(527, 361);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // NodeBridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::HMS_NodeBridge.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.tabControl_HMS);
            this.Controls.Add(this.HiddenBGPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(795, 405);
            this.Name = "NodeBridge";
            this.Text = "Node Bridge";
            this.tabControl_HMS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.P_MainNMPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HMS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel P_MainNMPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel nodeFlowLayoutPanel;
        private System.Windows.Forms.Panel HiddenBGPanel;
        private System.Windows.Forms.TextBox TEST_TB_InputIP;
        private System.Windows.Forms.Button TEST_BT_ConnectHUB;
        private System.Windows.Forms.RichTextBox TEST_RTB_MessagetoSend;
        private System.Windows.Forms.RichTextBox TEST_RTB_ReceivedMsg;
        private System.Windows.Forms.Button TEST_BT_SendMessage;
        private System.Windows.Forms.Button TEST_BT_Demo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BT_ConnectDataHub;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LB_Main_SN;
        private System.Windows.Forms.Label LB_Main_WarnS3;
        private System.Windows.Forms.Label LB_Main_WarnS2;
        private System.Windows.Forms.Label LB_Main_WarnS1;
        private System.Windows.Forms.Label LB_Main_Battery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_Main_SensorTypes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_Main_ViewNodeData;
        private System.Windows.Forms.Button BT_Main_EditWarnPar;
        private System.Windows.Forms.Label LB_Main_NodeName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BT_AddNode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

