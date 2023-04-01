namespace BankPunk
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnSettings = new MetroFramework.Controls.MetroTile();
            this.BtnImport = new MetroFramework.Controls.MetroTile();
            this.PanelContainer = new MetroFramework.Controls.MetroPanel();
            this.metroTileExit = new MetroFramework.Controls.MetroTile();
            this.BtnChart = new MetroFramework.Controls.MetroTile();
            this.BtnConf = new MetroFramework.Controls.MetroTile();
            this.metroTileSave = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BtnSettings
            // 
            this.BtnSettings.ActiveControl = null;
            this.BtnSettings.Location = new System.Drawing.Point(11, 102);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(125, 39);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Tag = "else";
            this.BtnSettings.Text = "Edita";
            this.BtnSettings.UseSelectable = true;
            this.BtnSettings.Click += new System.EventHandler(this.metroTilePanel_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.ActiveControl = null;
            this.BtnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnImport.Location = new System.Drawing.Point(11, 224);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(125, 39);
            this.BtnImport.TabIndex = 1;
            this.BtnImport.Tag = "Importa";
            this.BtnImport.Text = "Importa";
            this.BtnImport.UseSelectable = true;
            this.BtnImport.Click += new System.EventHandler(this.metroTilePanel_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContainer.HorizontalScrollbarBarColor = true;
            this.PanelContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelContainer.HorizontalScrollbarSize = 10;
            this.PanelContainer.Location = new System.Drawing.Point(162, 46);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(655, 372);
            this.PanelContainer.TabIndex = 2;
            this.PanelContainer.VerticalScrollbarBarColor = true;
            this.PanelContainer.VerticalScrollbarHighlightOnWheel = false;
            this.PanelContainer.VerticalScrollbarSize = 10;
            // 
            // metroTileExit
            // 
            this.metroTileExit.ActiveControl = null;
            this.metroTileExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTileExit.Location = new System.Drawing.Point(11, 388);
            this.metroTileExit.Name = "metroTileExit";
            this.metroTileExit.Size = new System.Drawing.Size(125, 39);
            this.metroTileExit.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileExit.TabIndex = 3;
            this.metroTileExit.Tag = "Exit";
            this.metroTileExit.Text = "Salva i tanca";
            this.metroTileExit.UseSelectable = true;
            this.metroTileExit.Click += new System.EventHandler(this.metroTileExit_Click);
            // 
            // BtnChart
            // 
            this.BtnChart.ActiveControl = null;
            this.BtnChart.Location = new System.Drawing.Point(11, 147);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(125, 39);
            this.BtnChart.TabIndex = 4;
            this.BtnChart.Tag = "Resum";
            this.BtnChart.Text = "Resum";
            this.BtnChart.UseSelectable = true;
            this.BtnChart.Click += new System.EventHandler(this.metroTilePanel_Click);
            // 
            // BtnConf
            // 
            this.BtnConf.ActiveControl = null;
            this.BtnConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConf.Location = new System.Drawing.Point(11, 269);
            this.BtnConf.Name = "BtnConf";
            this.BtnConf.Size = new System.Drawing.Size(125, 39);
            this.BtnConf.TabIndex = 5;
            this.BtnConf.Tag = "Configuracio";
            this.BtnConf.Text = "Configuració";
            this.BtnConf.UseSelectable = true;
            this.BtnConf.Click += new System.EventHandler(this.metroTilePanel_Click);
            // 
            // metroTileSave
            // 
            this.metroTileSave.ActiveControl = null;
            this.metroTileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTileSave.Location = new System.Drawing.Point(11, 343);
            this.metroTileSave.Name = "metroTileSave";
            this.metroTileSave.Size = new System.Drawing.Size(125, 39);
            this.metroTileSave.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileSave.TabIndex = 6;
            this.metroTileSave.Tag = "Exit";
            this.metroTileSave.Text = "Salva";
            this.metroTileSave.UseSelectable = true;
            this.metroTileSave.Click += new System.EventHandler(this.metroTileSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.metroTileSave);
            this.Controls.Add(this.BtnConf);
            this.Controls.Add(this.BtnChart);
            this.Controls.Add(this.metroTileExit);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.BtnSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Bank Punk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile BtnSettings;
        private MetroFramework.Controls.MetroTile BtnImport;
        private MetroFramework.Controls.MetroPanel PanelContainer;
        private MetroFramework.Controls.MetroTile metroTileExit;
        private MetroFramework.Controls.MetroTile BtnChart;
        private MetroFramework.Controls.MetroTile BtnConf;
        private MetroFramework.Controls.MetroTile metroTileSave;
    }
}

