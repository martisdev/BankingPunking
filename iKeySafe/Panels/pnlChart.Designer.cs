
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
            this.cmbTypeChart = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanelChart
            // 
            this.flowLayoutPanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChart.AutoScroll = true;
            this.flowLayoutPanelChart.Location = new System.Drawing.Point(17, 74);
            this.flowLayoutPanelChart.Name = "flowLayoutPanelChart";
            this.flowLayoutPanelChart.Size = new System.Drawing.Size(641, 379);
            this.flowLayoutPanelChart.TabIndex = 1;
            // 
            // cmbYear
            // 
            this.cmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.ItemHeight = 23;
            this.cmbYear.Location = new System.Drawing.Point(547, 39);
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
            this.metroComboBoxFilterAtribuible.Location = new System.Drawing.Point(420, 39);
            this.metroComboBoxFilterAtribuible.Name = "metroComboBoxFilterAtribuible";
            this.metroComboBoxFilterAtribuible.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxFilterAtribuible.TabIndex = 4;
            this.metroComboBoxFilterAtribuible.UseSelectable = true;
            this.metroComboBoxFilterAtribuible.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbTypeChart
            // 
            this.cmbTypeChart.FormattingEnabled = true;
            this.cmbTypeChart.ItemHeight = 23;
            this.cmbTypeChart.Items.AddRange(new object[] {
            "Ingressos /despeses",
            "Estalvi"});
            this.cmbTypeChart.Location = new System.Drawing.Point(35, 38);
            this.cmbTypeChart.Name = "cmbTypeChart";
            this.cmbTypeChart.Size = new System.Drawing.Size(164, 29);
            this.cmbTypeChart.TabIndex = 5;
            this.cmbTypeChart.UseSelectable = true;
            // 
            // pnlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTypeChart);
            this.Controls.Add(this.metroComboBoxFilterAtribuible);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.flowLayoutPanelChart);
            this.Name = "pnlChart";
            this.Size = new System.Drawing.Size(675, 468);
            this.Load += new System.EventHandler(this.pnlChart_Load);
            this.Controls.SetChildIndex(this.flowLayoutPanelChart, 0);
            this.Controls.SetChildIndex(this.cmbYear, 0);
            this.Controls.SetChildIndex(this.metroComboBoxFilterAtribuible, 0);
            this.Controls.SetChildIndex(this.cmbTypeChart, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChart;
        private MetroFramework.Controls.MetroComboBox cmbYear;
        private MetroFramework.Controls.MetroComboBox metroComboBoxFilterAtribuible;
        private MetroFramework.Controls.MetroComboBox cmbTypeChart;
    }
}
