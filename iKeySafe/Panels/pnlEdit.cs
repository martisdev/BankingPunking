using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Net.Http.Headers;
using NPOI.SS.Formula.Functions;

namespace BankPunk.Panel
{
    public partial class pnlEdit : pnlSlider
    {

        #region CONTRUCTOR

        public pnlEdit(MetroPanel owner):base(owner)
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTS

        private void pnlEdit_Load(object sender, EventArgs e)
        {

            base.Title = "Edita els moviments bancaris";

            metroComboBoxAtribuible.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);
            metroComboBoxAtribuible.DisplayMember = "Name";
            metroComboBoxAtribuible.ValueMember = "ID";
            
            metroComboBoxSector.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListSectors, null);
            metroComboBoxSector.DisplayMember = "Name";
            metroComboBoxSector.ValueMember = "ID";

            
            metroComboBoxFilterAtribuible.DataSource = CManager.dataPrj.Configuration.ListAtribuibles.ToArray();
            metroComboBoxFilterAtribuible.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);
            metroComboBoxFilterAtribuible.DisplayMember = "Name";
            metroComboBoxFilterAtribuible.ValueMember = "ID";
            metroComboBoxFilterAtribuible.SelectedItem = CManager.dataPrj.Configuration.ListAtribuibles.First();

            metroComboBoxFilterSector.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListSectors, null);
            metroComboBoxFilterSector.DisplayMember = "Name";
            metroComboBoxFilterSector.ValueMember = "ID";
            metroComboBoxFilterSector.SelectedItem = CManager.dataPrj.Configuration.ListSectors.First();

            //macros
            Dictionary<int, string> ListShortMacros = new Dictionary<int, string>();
            foreach(Macros macro in CManager.dataPrj.Configuration.ListMacros)
            {
                string Target = string.Empty;
                if (macro.sendType == 0)
                    Target = CManager.dataPrj.Configuration.ListAtribuibles.FirstOrDefault(x => x.ID == macro.Target).Name;
                else
                    Target = CManager.dataPrj.Configuration.ListSectors.FirstOrDefault(x => x.ID == macro.Target).Name;

                string name = string.Format("{0} => {1}", macro.StrToFind, Target);
                ListShortMacros.Add(macro.ID, name);
            }

            cmbMacros.DataSource = new BindingSource(ListShortMacros, null);
            cmbMacros.DisplayMember = "Value";
            cmbMacros.ValueMember = "Key";


            SetColumns();

            SetDataBase();

            this.metroComboBoxFilterAtribuible.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxFilter_SelectedIndexChanged);
            this.metroComboBoxFilterSector.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxFilter_SelectedIndexChanged);
            
        }

        private void metroToggleAtribuible_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxAtribuible.Enabled = metroToggleAtribuible.Checked;
        }

        private void metroToggleSector_CheckedChanged(object sender, EventArgs e)
        {
            metroComboBoxSector.Enabled = metroToggleSector.Checked;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in metroGridEdit.Rows)
            {
                if (row.Cells["Col_Check"].Value == null || !bool.Parse(row.Cells["Col_Check"].Value.ToString()))
                    continue;

                if (metroComboBoxAtribuible.Enabled)
                    row.Cells["Atribuible"].Value = metroComboBoxAtribuible.SelectedValue;

                if(metroComboBoxSector.Enabled)
                    row.Cells["Sector"].Value = metroComboBoxSector.SelectedValue;

            }
        }

        private void metroTextBoxFilterText_TextChanged(object sender, EventArgs e)
        {
            SetDataBase();
        }

        private void metroComboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDataBase();
        }

        private void metroGridEdit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewCellStyle styleRed = new DataGridViewCellStyle();
            styleRed.ForeColor = Color.Red;

            DataGridViewCellStyle styleOrange = new DataGridViewCellStyle();
            styleOrange.ForeColor = Color.Orange;
            foreach (DataGridViewRow row in metroGridEdit.Rows)
            {
                if(row.Cells["Import"].Value.ToString().Contains("-"))
                    row.Cells["Import"].Style = styleRed;

                long Saldo = (long)Convert.ToDouble(row.Cells["Saldo"].Value.ToString().Replace(".", ","));                    
                if (Saldo < CManager.dataPrj.Configuration.MinimSaldo)
                    row.Cells["Saldo"].Style = styleOrange;

                if (row.Cells["Saldo"].Value.ToString().Contains("-"))
                    row.Cells["Saldo"].Style = styleRed;

            }
        }

        private void mnuSelectAll_Click(object sender, EventArgs e)
        {
            mnuSelectAll.Checked = !mnuSelectAll.Checked;
            foreach (DataGridViewRow row in metroGridEdit.Rows)
                row.Cells["Col_Check"].Value = mnuSelectAll.Checked;         
        }

        private void metroCheckBoxDespeses_CheckedChanged(object sender, EventArgs e)
        {
            SetDataBase();
        }

        private void metroTileAdd_Click(object sender, EventArgs e)
        {
            FrmNew NewElemet = new FrmNew();

            DialogResult result = NewElemet.ShowDialog();
            if (result == DialogResult.OK)
            {
                CManager.dataPrj.Elements.Add(NewElemet.NewElmt);
                SetDataBase();
            }
            else if(result == DialogResult.Abort)
            {

            }
        }    

        private void btnExeMacro_Click(object sender, EventArgs e)
        {

            Macros Macro = CManager.dataPrj.Configuration.ListMacros.FirstOrDefault(x => x.ID ==  int.Parse(this.cmbMacros.SelectedValue.ToString()));
            
            foreach (DataGridViewRow row in metroGridEdit.Rows)
            {
                if (row.Cells["Col_Check"].Value == null || !bool.Parse(row.Cells["Col_Check"].Value.ToString()))
                    continue;
                
                if(row.Cells["Concepte"].Value.ToString().ToLower() .Contains(Macro.StrToFind.ToLower()))
                {
                    switch(Macro.sendType)
                    {
                        case 0:
                            row.Cells["Atribuible"].Value = Macro.Target;
                            break;
                        case 1:
                            row.Cells["Sector"].Value = Macro.Target;
                            break;
                    }


                }            
            }
        }

        #endregion

        #region METHODS

        private void SetColumns()        
        {
            DataGridViewCheckBoxColumn ColCheck = new DataGridViewCheckBoxColumn();
            ColCheck.Name = "Col_Check";
            ColCheck.HeaderText = "";
            ColCheck.Width = 25;
            this.metroGridEdit.Columns.Add(ColCheck);

            //settlements Dummy = new settlements();
            DataGridViewTextBoxColumn NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Data_Moviment";
            NewCol.DataPropertyName = "Data_Moviment";
            NewCol.HeaderText = "Data Moviment";
            NewCol.Width = 100;
            NewCol.ReadOnly = true;
            this.metroGridEdit.Columns.Add(NewCol);

            NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Data_Valor_Moviment";
            NewCol.DataPropertyName = "Data_Valor_Moviment";
            NewCol.HeaderText = "Data Valor Moviment";            
            NewCol.Width = 100;
            NewCol.ReadOnly = true;
            this.metroGridEdit.Columns.Add(NewCol);

            NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Concepte";
            NewCol.DataPropertyName = "Concepte";
            NewCol.HeaderText = "Concepte";
            NewCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NewCol.ReadOnly = false;
            this.metroGridEdit.Columns.Add(NewCol);

            NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Import";
            NewCol.DataPropertyName = "Import";
            NewCol.HeaderText = "Import";
            NewCol.Width = 70;
            NewCol.ReadOnly = true;
            this.metroGridEdit.Columns.Add(NewCol);

            NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Saldo";
            NewCol.DataPropertyName = "Saldo";
            NewCol.HeaderText = "Saldo";
            NewCol.Width = 70;
            NewCol.ReadOnly = true;
            this.metroGridEdit.Columns.Add(NewCol);

            DataGridViewComboBoxColumn NewColCombo = new DataGridViewComboBoxColumn();
            NewColCombo.Name = "Sector";
            NewColCombo.DataPropertyName = "Sector";
            NewColCombo.HeaderText = "Sector";
            NewColCombo.DisplayMember = "Name";
            NewColCombo.ValueMember = "ID";
            NewColCombo.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListSectors, null);
            NewColCombo.Width = 150;
            NewColCombo.ReadOnly = false;
            this.metroGridEdit.Columns.Add(NewColCombo);

            NewColCombo = new DataGridViewComboBoxColumn();
            NewColCombo.Name = "Atribuible";
            NewColCombo.DataPropertyName = "Atribuible";
            NewColCombo.HeaderText = "Atribuible";
            NewColCombo.DisplayMember = "Name";
            NewColCombo.ValueMember = "ID";
            NewColCombo.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);            
            NewColCombo.Width = 100;
            NewColCombo.ReadOnly = false;
            this.metroGridEdit.Columns.Add(NewColCombo);

            NewColCombo = new DataGridViewComboBoxColumn();
            NewColCombo.Name = "Font";
            NewColCombo.DataPropertyName = "Font";
            NewColCombo.HeaderText = "Font";
            NewColCombo.DisplayMember = "Name";
            NewColCombo.ValueMember = "ID";
            NewColCombo.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListBanks, null);
            NewColCombo.Width = 75;
            NewColCombo.ReadOnly = true;
            this.metroGridEdit.Columns.Add(NewColCombo);

            NewCol = new DataGridViewTextBoxColumn();
            NewCol.Name = "Hash";
            NewCol.DataPropertyName = "Hash";
            NewCol.HeaderText = "Hash";
            NewCol.Width = 70;
            NewCol.Visible = false;
            this.metroGridEdit.Columns.Add(NewCol);

        }


        private List<int> ListSectorsFiltres = new List<int>();
        private void SetDataBase()
        {
            //filtre si és necessari
            AssetElement[] ListFilter = CManager.dataPrj.Elements.ToArray();

            if (metroTextBoxFilterText.Text.Length > 0)
                ListFilter = ListFilter.Where(x => x.Concepte.ToLower().Contains(metroTextBoxFilterText.Text.ToLower())).ToArray();

            if (metroCheckBoxDespeses.Checked)
                ListFilter = ListFilter.Where(x => x.Import < 0).ToArray();

            try
            {                
                int AtribuibleValue = int.Parse( metroComboBoxFilterAtribuible.SelectedValue.ToString());
                if (AtribuibleValue > CManager.NO_DEFINIT)
                    ListFilter = ListFilter.Where(x => x.Atribuible == AtribuibleValue).ToArray();
                
                int SectorValue = int.Parse(metroComboBoxFilterSector.SelectedValue.ToString());                                
                if (SectorValue > CManager.NO_DEFINIT)
                {
                    if(!CheckBoxAddFilter.Checked)
                        ListSectorsFiltres.Clear();

                    ListSectorsFiltres.Add(SectorValue);
                    //todo:
                    ListFilter = ListFilter.Where(x => x.Sector == SectorValue).ToArray();
                }
                    
            }
            catch { }            

            this.metroGridEdit.DataSource = ListFilter.OrderByDescending(x => x.Saldo).OrderBy(x => x.Data_Moviment).ToList();
            
            mnuSelectAll.Checked = false;
            metroLabelRows.Text = string.Format("Nº de registres: {0}", ListFilter.Count());

            this.metroLabelNumDespeses.Text = ListFilter.Where(x => x.Import < 0).Sum( y => y.Import).ToString("0,##");
            this.metroLabelNumIngresos.Text = ListFilter.Where(x => x.Import > 0).Sum(y => y.Import).ToString("0,##");

        }


        #endregion

        private void metroGridEdit_SelectionChanged(object sender, EventArgs e)
        {
            double despeses = 0;
            double ingresos = 0;
            foreach(DataGridViewRow row in metroGridEdit.SelectedRows)
            {
                string Value = row.Cells["Import"].Value.ToString();

                if (double.Parse(Value) > 0)
                    ingresos += double.Parse(Value);
                else
                    despeses += double.Parse(Value);
            }
            this.metroLabelNumDespeses.Text = despeses.ToString("0,##");
            this.metroLabelNumIngresos.Text = ingresos.ToString("0,##");
        }
    }
}

