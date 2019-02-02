namespace HMS_NodeBridge
{
    partial class AddNodeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNodeWindow));
            this.BT_Confirm = new System.Windows.Forms.Button();
            this.TB_NodeSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Confirm
            // 
            this.BT_Confirm.Location = new System.Drawing.Point(11, 66);
            this.BT_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Confirm.Name = "BT_Confirm";
            this.BT_Confirm.Size = new System.Drawing.Size(50, 22);
            this.BT_Confirm.TabIndex = 0;
            this.BT_Confirm.Text = "Confirm";
            this.BT_Confirm.UseVisualStyleBackColor = true;
            this.BT_Confirm.Click += new System.EventHandler(this.BT_Confirm_Click);
            // 
            // TB_NodeSN
            // 
            this.TB_NodeSN.Location = new System.Drawing.Point(11, 45);
            this.TB_NodeSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_NodeSN.Name = "TB_NodeSN";
            this.TB_NodeSN.Size = new System.Drawing.Size(259, 20);
            this.TB_NodeSN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the new Node\'s Serial Number";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(65, 66);
            this.BT_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(50, 22);
            this.BT_Cancel.TabIndex = 4;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // AddNodeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMS_NodeBridge.Properties.Resources._45050754_abstract_background_light_red_color;
            this.ClientSize = new System.Drawing.Size(281, 117);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_NodeSN);
            this.Controls.Add(this.BT_Confirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNodeWindow";
            this.Text = "Add New Node";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNodeWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Confirm;
        private System.Windows.Forms.TextBox TB_NodeSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Cancel;
    }
}