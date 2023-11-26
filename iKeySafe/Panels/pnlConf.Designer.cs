
namespace BankPunk.Panel
{
    partial class pnlConf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtMinimSaldo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelMacros = new MetroFramework.Controls.MetroLabel();
            this.dataGridMacros = new MetroFramework.Controls.MetroGrid();
            this.txtMacroContain = new MetroFramework.Controls.MetroTextBox();
            this.cmbSendTo = new MetroFramework.Controls.MetroComboBox();
            this.cmbTarge = new MetroFramework.Controls.MetroComboBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.ColumnContain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnviar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBank = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddBank = new MetroFramework.Controls.MetroButton();
            this.cmbBanks = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.cmbFormat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMacros)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Mínim saldo";
            // 
            // TxtMinimSaldo
            // 
            // 
            // 
            // 
            this.TxtMinimSaldo.CustomButton.Image = null;
            this.TxtMinimSaldo.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.TxtMinimSaldo.CustomButton.Name = "";
            this.TxtMinimSaldo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtMinimSaldo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMinimSaldo.CustomButton.TabIndex = 1;
            this.TxtMinimSaldo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMinimSaldo.CustomButton.UseSelectable = true;
            this.TxtMinimSaldo.CustomButton.Visible = false;
            this.TxtMinimSaldo.Lines = new string[0];
            this.TxtMinimSaldo.Location = new System.Drawing.Point(38, 80);
            this.TxtMinimSaldo.MaxLength = 32767;
            this.TxtMinimSaldo.Name = "TxtMinimSaldo";
            this.TxtMinimSaldo.PasswordChar = '\0';
            this.TxtMinimSaldo.PromptText = "Valor mínim en el compte";
            this.TxtMinimSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMinimSaldo.SelectedText = "";
            this.TxtMinimSaldo.SelectionLength = 0;
            this.TxtMinimSaldo.SelectionStart = 0;
            this.TxtMinimSaldo.ShortcutsEnabled = true;
            this.TxtMinimSaldo.Size = new System.Drawing.Size(152, 29);
            this.TxtMinimSaldo.TabIndex = 1;
            this.TxtMinimSaldo.UseSelectable = true;
            this.TxtMinimSaldo.WaterMark = "Valor mínim en el compte";
            this.TxtMinimSaldo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMinimSaldo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMinimSaldo.TextChanged += new System.EventHandler(this.TxtMinimSaldo_TextChanged);
            this.TxtMinimSaldo.Click += new System.EventHandler(this.TxtMinimSaldo_Click);
            // 
            // metroLabelMacros
            // 
            this.metroLabelMacros.AutoSize = true;
            this.metroLabelMacros.Location = new System.Drawing.Point(33, 189);
            this.metroLabelMacros.Name = "metroLabelMacros";
            this.metroLabelMacros.Size = new System.Drawing.Size(52, 19);
            this.metroLabelMacros.TabIndex = 3;
            this.metroLabelMacros.Text = "Macros";
            // 
            // dataGridMacros
            // 
            this.dataGridMacros.AllowUserToAddRows = false;
            this.dataGridMacros.AllowUserToDeleteRows = false;
            this.dataGridMacros.AllowUserToResizeRows = false;
            this.dataGridMacros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMacros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridMacros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMacros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridMacros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMacros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMacros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContain,
            this.ColumnEnviar,
            this.ColTarget});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMacros.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridMacros.EnableHeadersVisualStyles = false;
            this.dataGridMacros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridMacros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridMacros.Location = new System.Drawing.Point(33, 263);
            this.dataGridMacros.Name = "dataGridMacros";
            this.dataGridMacros.ReadOnly = true;
            this.dataGridMacros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMacros.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMacros.Size = new System.Drawing.Size(567, 72);
            this.dataGridMacros.TabIndex = 9;
            // 
            // txtMacroContain
            // 
            // 
            // 
            // 
            this.txtMacroContain.CustomButton.Image = null;
            this.txtMacroContain.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtMacroContain.CustomButton.Name = "";
            this.txtMacroContain.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMacroContain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMacroContain.CustomButton.TabIndex = 1;
            this.txtMacroContain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMacroContain.CustomButton.UseSelectable = true;
            this.txtMacroContain.CustomButton.Visible = false;
            this.txtMacroContain.Lines = new string[0];
            this.txtMacroContain.Location = new System.Drawing.Point(38, 217);
            this.txtMacroContain.MaxLength = 32767;
            this.txtMacroContain.Name = "txtMacroContain";
            this.txtMacroContain.PasswordChar = '\0';
            this.txtMacroContain.PromptText = "Que contingui";
            this.txtMacroContain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMacroContain.SelectedText = "";
            this.txtMacroContain.SelectionLength = 0;
            this.txtMacroContain.SelectionStart = 0;
            this.txtMacroContain.ShortcutsEnabled = true;
            this.txtMacroContain.Size = new System.Drawing.Size(152, 29);
            this.txtMacroContain.TabIndex = 5;
            this.txtMacroContain.UseSelectable = true;
            this.txtMacroContain.WaterMark = "Que contingui";
            this.txtMacroContain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMacroContain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbSendTo
            // 
            this.cmbSendTo.FormattingEnabled = true;
            this.cmbSendTo.ItemHeight = 23;
            this.cmbSendTo.Items.AddRange(new object[] {
            "Atribuible",
            "Sector"});
            this.cmbSendTo.Location = new System.Drawing.Point(197, 217);
            this.cmbSendTo.Name = "cmbSendTo";
            this.cmbSendTo.Size = new System.Drawing.Size(152, 29);
            this.cmbSendTo.TabIndex = 6;
            this.cmbSendTo.UseSelectable = true;
            this.cmbSendTo.SelectedIndexChanged += new System.EventHandler(this.cmbSendTo_SelectedIndexChanged);
            // 
            // cmbTarge
            // 
            this.cmbTarge.Enabled = false;
            this.cmbTarge.FormattingEnabled = true;
            this.cmbTarge.ItemHeight = 23;
            this.cmbTarge.Location = new System.Drawing.Point(356, 217);
            this.cmbTarge.Name = "cmbTarge";
            this.cmbTarge.Size = new System.Drawing.Size(152, 29);
            this.cmbTarge.TabIndex = 7;
            this.cmbTarge.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(516, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Afegir";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ColumnContain
            // 
            this.ColumnContain.HeaderText = "Que contigui ..";
            this.ColumnContain.Name = "ColumnContain";
            this.ColumnContain.ReadOnly = true;
            this.ColumnContain.Width = 200;
            // 
            // ColumnEnviar
            // 
            this.ColumnEnviar.HeaderText = "Enviar a..";
            this.ColumnEnviar.Name = "ColumnEnviar";
            this.ColumnEnviar.ReadOnly = true;
            this.ColumnEnviar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEnviar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnEnviar.Width = 150;
            // 
            // ColTarget
            // 
            this.ColTarget.HeaderText = "Destí";
            this.ColTarget.Name = "ColTarget";
            this.ColTarget.ReadOnly = true;
            this.ColTarget.Width = 150;
            // 
            // txtBank
            // 
            // 
            // 
            // 
            this.txtBank.CustomButton.Image = null;
            this.txtBank.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.txtBank.CustomButton.Name = "";
            this.txtBank.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBank.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBank.CustomButton.TabIndex = 1;
            this.txtBank.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBank.CustomButton.UseSelectable = true;
            this.txtBank.CustomButton.Visible = false;
            this.txtBank.Lines = new string[0];
            this.txtBank.Location = new System.Drawing.Point(38, 146);
            this.txtBank.MaxLength = 32767;
            this.txtBank.Name = "txtBank";
            this.txtBank.PasswordChar = '\0';
            this.txtBank.PromptText = "Nom del banc o font";
            this.txtBank.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBank.SelectedText = "";
            this.txtBank.SelectionLength = 0;
            this.txtBank.SelectionStart = 0;
            this.txtBank.ShortcutsEnabled = true;
            this.txtBank.Size = new System.Drawing.Size(152, 29);
            this.txtBank.TabIndex = 2;
            this.txtBank.UseSelectable = true;
            this.txtBank.WaterMark = "Nom del banc o font";
            this.txtBank.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBank.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Bancs";
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(231, 146);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(84, 28);
            this.btnAddBank.TabIndex = 3;
            this.btnAddBank.Text = "Afegir";
            this.btnAddBank.UseSelectable = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // cmbBanks
            // 
            this.cmbBanks.FormattingEnabled = true;
            this.cmbBanks.ItemHeight = 23;
            this.cmbBanks.Location = new System.Drawing.Point(356, 145);
            this.cmbBanks.Name = "cmbBanks";
            this.cmbBanks.Size = new System.Drawing.Size(152, 29);
            this.cmbBanks.TabIndex = 4;
            this.cmbBanks.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 367);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Macros";
            this.metroLabel3.Visible = false;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(356, 389);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Nom del banc o font";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(152, 29);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMark = "Nom del banc o font";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.ItemHeight = 23;
            this.cmbFormat.Location = new System.Drawing.Point(197, 389);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(152, 29);
            this.cmbFormat.TabIndex = 12;
            this.cmbFormat.UseSelectable = true;
            this.cmbFormat.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel4.Location = new System.Drawing.Point(197, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(305, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "S\'executaran automàticament al importar registres";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // pnlConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbBanks);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTarge);
            this.Controls.Add(this.cmbSendTo);
            this.Controls.Add(this.txtMacroContain);
            this.Controls.Add(this.dataGridMacros);
            this.Controls.Add(this.metroLabelMacros);
            this.Controls.Add(this.TxtMinimSaldo);
            this.Controls.Add(this.metroLabel1);
            this.Name = "pnlConf";
            this.Size = new System.Drawing.Size(637, 371);
            this.Load += new System.EventHandler(this.pnlConf_Load);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.TxtMinimSaldo, 0);
            this.Controls.SetChildIndex(this.metroLabelMacros, 0);
            this.Controls.SetChildIndex(this.dataGridMacros, 0);
            this.Controls.SetChildIndex(this.txtMacroContain, 0);
            this.Controls.SetChildIndex(this.cmbSendTo, 0);
            this.Controls.SetChildIndex(this.cmbTarge, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.txtBank, 0);
            this.Controls.SetChildIndex(this.btnAddBank, 0);
            this.Controls.SetChildIndex(this.cmbBanks, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.metroTextBox1, 0);
            this.Controls.SetChildIndex(this.cmbFormat, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMacros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtMinimSaldo;
        private MetroFramework.Controls.MetroLabel metroLabelMacros;
        private MetroFramework.Controls.MetroGrid dataGridMacros;
        private MetroFramework.Controls.MetroTextBox txtMacroContain;
        private MetroFramework.Controls.MetroComboBox cmbSendTo;
        private MetroFramework.Controls.MetroComboBox cmbTarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTarget;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtBank;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAddBank;
        private MetroFramework.Controls.MetroComboBox cmbBanks;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox cmbFormat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
