
namespace BankPunk.Panel
{
    partial class pnlChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelChart = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbYear = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxFilterAtribuible = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChart
            // 
            this.flowLayoutPanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChart.AutoScroll = true;
            this.flowLayoutPanelChart.Location = new System.Drawing.Point(17, 38);
            this.flowLayoutPanelChart.Name = "flowLayoutPanelChart";
            this.flowLayoutPanelChart.Size = new System.Drawing.Size(871, 415);
            this.flowLayoutPanelChart.TabIndex = 1;
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(776, 6);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(111, 29);
            this.cmbYear.TabIndex = 2;
            this.cmbYear.UseSelectable = true;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // metroComboBoxFilterAtribuible
            // 
            this.metroComboBoxFilterAtribuible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxFilterAtribuible.FormattingEnabled = true;
            this.metroComboBoxFilterAtribuible.ItemHeight = 23;
            this.metroComboBoxFilterAtribuible.Location = new System.Drawing.Point(649, 6);
            this.metroComboBoxFilterAtribuible.Name = "metroComboBoxFilterAtribuible";
            this.metroComboBoxFilterAtribuible.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxFilterAtribuible.TabIndex = 4;
            this.metroComboBoxFilterAtribuible.UseSelectable = true;
            this.metroComboBoxFilterAtribuible.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // pnlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroComboBoxFilterAtribuible);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.flowLayoutPanelChart);
            this.Name = "pnlChart";
            this.Size = new System.Drawing.Size(905, 468);
            this.Load += new System.EventHandler(this.pnlChart_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanelChart, 0);
            this.Controls.SetChildIndex(this.cmbYear, 0);
            this.Controls.SetChildIndex(this.metroComboBoxFilterAtribuible, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChart;
        private MetroFramework.Controls.MetroComboBox cmbYear;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFilterAtribuible;
    }
}
