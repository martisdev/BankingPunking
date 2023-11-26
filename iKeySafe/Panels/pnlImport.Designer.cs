namespace BankPunk.Panel
{
    partial class pnlImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFiletoImport = new MetroFramework.Controls.MetroTextBox();
            this.txtNameFulla = new MetroFramework.Controls.MetroTextBox();
            this.metroTilePreImport = new MetroFramework.Controls.MetroTile();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroComboBoxEntitats = new MetroFramework.Controls.MetroComboBox();
            this.metroGridData = new MetroFramework.Controls.MetroGrid();
            this.metroTileExport = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiletoImport
            // 
            this.txtFiletoImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtFiletoImport.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtFiletoImport.CustomButton.Location = new System.Drawing.Point(568, 1);
            this.txtFiletoImport.CustomButton.Name = "";
            this.txtFiletoImport.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFiletoImport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiletoImport.CustomButton.TabIndex = 1;
            this.txtFiletoImport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiletoImport.CustomButton.UseSelectable = true;
            this.txtFiletoImport.Lines = new string[0];
            this.txtFiletoImport.Location = new System.Drawing.Point(30, 38);
            this.txtFiletoImport.MaxLength = 32767;
            this.txtFiletoImport.Name = "txtFiletoImport";
            this.txtFiletoImport.PasswordChar = '\0';
            //this.txtFiletoImport.PromptText = "Escull el fitxer a importar";
            this.txtFiletoImport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiletoImport.SelectedText = "";
            this.txtFiletoImport.SelectionLength = 0;
            this.txtFiletoImport.SelectionStart = 0;
            this.txtFiletoImport.ShortcutsEnabled = true;
            this.txtFiletoImport.ShowButton = true;
            this.txtFiletoImport.Size = new System.Drawing.Size(592, 25);
            this.txtFiletoImport.TabIndex = 30;
            this.txtFiletoImport.UseSelectable = true;
            this.txtFiletoImport.WaterMark = "Escull el fitxer a importar";
            this.txtFiletoImport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiletoImport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiletoImport.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtFiletoImport_ButtonClick);
            this.txtFiletoImport.TextChanged += new System.EventHandler(this.txtFiletoImport_TextChanged);
            // 
            // txtNameFulla
            // 
            // 
            // 
            // 
            this.txtNameFulla.CustomButton.Image = null;
            this.txtNameFulla.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtNameFulla.CustomButton.Name = "";
            this.txtNameFulla.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNameFulla.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameFulla.CustomButton.TabIndex = 1;
            this.txtNameFulla.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameFulla.CustomButton.UseSelectable = true;
            this.txtNameFulla.CustomButton.Visible = false;
            this.txtNameFulla.Lines = new string[0];
            this.txtNameFulla.Location = new System.Drawing.Point(30, 68);
            this.txtNameFulla.MaxLength = 32767;
            this.txtNameFulla.Name = "txtNameFulla";
            this.txtNameFulla.PasswordChar = '\0';
            //this.txtNameFulla.PromptText = "Nom de la fulla";
            this.txtNameFulla.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameFulla.SelectedText = "";
            this.txtNameFulla.SelectionLength = 0;
            this.txtNameFulla.SelectionStart = 0;
            this.txtNameFulla.ShortcutsEnabled = true;
            this.txtNameFulla.Size = new System.Drawing.Size(145, 29);
            this.txtNameFulla.TabIndex = 34;
            this.txtNameFulla.UseSelectable = true;
            this.txtNameFulla.WaterMark = "Nom de la fulla";
            this.txtNameFulla.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameFulla.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTilePreImport
            // 
            this.metroTilePreImport.ActiveControl = null;
            this.metroTilePreImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTilePreImport.Enabled = false;
            this.metroTilePreImport.Location = new System.Drawing.Point(419, 68);
            this.metroTilePreImport.Name = "metroTilePreImport";
            this.metroTilePreImport.Size = new System.Drawing.Size(203, 28);
            this.metroTilePreImport.TabIndex = 35;
            this.metroTilePreImport.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTilePreImport.TileImage")));
            this.metroTilePreImport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePreImport.UseSelectable = true;
            this.metroTilePreImport.UseTileImage = true;
            this.metroTilePreImport.Click += new System.EventHandler(this.metroTilePreImport_Click);
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner.Location = new System.Drawing.Point(182, 119);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.MinimumSize = new System.Drawing.Size(100, 100);
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(270, 193);
            this.metroProgressSpinner.TabIndex = 37;
            this.metroProgressSpinner.UseSelectable = true;
            // 
            // metroComboBoxEntitats
            // 
            this.metroComboBoxEntitats.FormattingEnabled = true;
            this.metroComboBoxEntitats.ItemHeight = 23;
            this.metroComboBoxEntitats.Location = new System.Drawing.Point(197, 68);
            this.metroComboBoxEntitats.Name = "metroComboBoxEntitats";
            this.metroComboBoxEntitats.Size = new System.Drawing.Size(198, 29);
            this.metroComboBoxEntitats.TabIndex = 38;
            this.metroComboBoxEntitats.UseSelectable = true;
            // 
            // metroGridData
            // 
            this.metroGridData.AllowUserToAddRows = false;
            this.metroGridData.AllowUserToDeleteRows = false;
            this.metroGridData.AllowUserToResizeRows = false;
            this.metroGridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridData.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridData.EnableHeadersVisualStyles = false;
            this.metroGridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridData.Location = new System.Drawing.Point(31, 114);
            this.metroGridData.Name = "metroGridData";
            this.metroGridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridData.Size = new System.Drawing.Size(590, 198);
            this.metroGridData.TabIndex = 39;
            // 
            // metroTileExport
            // 
            this.metroTileExport.ActiveControl = null;
            this.metroTileExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTileExport.Location = new System.Drawing.Point(220, 322);
            this.metroTileExport.Name = "metroTileExport";
            this.metroTileExport.Size = new System.Drawing.Size(193, 40);
            this.metroTileExport.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileExport.TabIndex = 40;
            this.metroTileExport.Text = "Importar";
            this.metroTileExport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileExport.UseSelectable = true;
            this.metroTileExport.UseTileImage = true;
            this.metroTileExport.Click += new System.EventHandler(this.metroTileExport_Click);
            // 
            // pnlImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTileExport);
            this.Controls.Add(this.metroGridData);
            this.Controls.Add(this.metroComboBoxEntitats);
            this.Controls.Add(this.metroProgressSpinner);
            this.Controls.Add(this.metroTilePreImport);
            this.Controls.Add(this.txtNameFulla);
            this.Controls.Add(this.txtFiletoImport);
            this.Name = "pnlImport";
            this.Size = new System.Drawing.Size(637, 374);
            this.Load += new System.EventHandler(this.pnlImport_Load);
            this.Controls.SetChildIndex(this.txtFiletoImport, 0);
            this.Controls.SetChildIndex(this.txtNameFulla, 0);
            this.Controls.SetChildIndex(this.metroTilePreImport, 0);
            this.Controls.SetChildIndex(this.metroProgressSpinner, 0);
            this.Controls.SetChildIndex(this.metroComboBoxEntitats, 0);
            this.Controls.SetChildIndex(this.metroGridData, 0);
            this.Controls.SetChildIndex(this.metroTileExport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtFiletoImport;
        private MetroFramework.Controls.MetroTextBox txtNameFulla;
        private MetroFramework.Controls.MetroTile metroTilePreImport;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEntitats;
        private MetroFramework.Controls.MetroGrid metroGridData;
        private MetroFramework.Controls.MetroTile metroTileExport;
    }
}
