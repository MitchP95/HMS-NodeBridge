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
    public partial class DisplayNodeDataWindow : Form
    {        
        public DisplayNodeDataWindow()
        {
            InitializeComponent();
            DG_NodeData.DataSource = NM.dataTable;
        }
    }
}
