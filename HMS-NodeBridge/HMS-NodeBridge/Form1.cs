using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NodeBridge
{
    public partial class NodeBridge : Form
    {
        public NodeBridge()
        {
            InitializeComponent();
        }

        private void BT_AddNode_Click(object sender, EventArgs e)
        {
            Panel newPanel = new Panel();
            newPanel.Name = "Node1Panel";
            newPanel.BorderStyle = BorderStyle.FixedSingle;

            nodeFlowLayoutPanel.Controls.Add(newPanel);
        }
    }
}
