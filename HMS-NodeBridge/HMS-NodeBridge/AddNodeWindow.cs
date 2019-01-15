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
    public partial class AddNodeWindow : Form
    {
        public static int NodeSN = 0;
        private static bool AddNode = false;

        public AddNodeWindow()
        {
            InitializeComponent();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            NodeSN = -1;
            this.Close();
        }

        private void BT_Confirm_Click(object sender, EventArgs e)
        {
            string SNtext = TB_NodeSN.Text;
            int SN;
            try
            {
                if (SNtext.Substring(0, 2) == "SN") SNtext = SNtext.Substring(2);   //Remove SN characters if present
            }
            catch { }            

            try { SN = Convert.ToInt32(SNtext); }
            catch
            {
                SN = 0;                
                MessageBox.Show("Invalid Serial Number\nEnsure the following format is used:\n\nSN123456");
            }

            NodeSN = SN;
            AddNode = true;

            //On Success
            if(SN != 0)this.Close();
        }

        private void AddNodeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if(!AddNode) NodeSN = -1;
            AddNode = false;            
        }
    }
}
