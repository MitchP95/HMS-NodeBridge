namespace HMS_NodeBridge
{
    partial class DisplayNodeDataWindow
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
            this.DG_NodeData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DG_NodeData)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_NodeData
            // 
            this.DG_NodeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_NodeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_NodeData.Location = new System.Drawing.Point(0, 0);
            this.DG_NodeData.Name = "DG_NodeData";
            this.DG_NodeData.Size = new System.Drawing.Size(362, 296);
            this.DG_NodeData.TabIndex = 0;
            // 
            // DisplayNodeDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 295);
            this.Controls.Add(this.DG_NodeData);
            this.Name = "DisplayNodeDataWindow";
            this.Text = "DisplayNodeDataWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DG_NodeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_NodeData;
    }
}