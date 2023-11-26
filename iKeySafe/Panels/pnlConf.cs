using System;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace BankPunk.Panel
{
    public partial class pnlConf : pnlSlider
    {
        #region CONSTRUCTOR

        public pnlConf(MetroPanel owner) : base(owner)
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTS
        
        private void pnlConf_Load(object sender, EventArgs e)
        {
            base.Title = "Paràmetres de configuració";
            TxtMinimSaldo.Text = CManager.dataPrj.Configuration.MinimSaldo.ToString();
                      
            foreach(Macros macro in CManager.dataPrj.Configuration.ListMacros)
            {
                string sendType = macro.sendType == 0 ? "Atribuible": "Sector";
                string Target = string.Empty;
                if (macro.sendType == 0)
                    Target = CManager.dataPrj.Configuration.ListAtribuibles.FirstOrDefault(x => x.ID == macro.Target).Name;                
                else
                    Target = CManager.dataPrj.Configuration.ListSectors.FirstOrDefault(x => x.ID == macro.Target).Name;                

                this.dataGridMacros.Rows.Add(macro.StrToFind, sendType, Target);
            }

            cmbBanks.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListBanks, null);
            cmbBanks.DisplayMember = "Name";
            cmbBanks.ValueMember = "ID";
        }

        private void TxtMinimSaldo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtMinimSaldo.Text, "[^0-9]"))
                TxtMinimSaldo.Text = TxtMinimSaldo.Text.Remove(TxtMinimSaldo.Text.Length - 1);
            
        }

        private void TxtMinimSaldo_Click(object sender, EventArgs e)
        {
            CManager.dataPrj.Configuration.MinimSaldo = long.Parse(TxtMinimSaldo.Text);
        }



        #endregion

        private void cmbSendTo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (cmbSendTo.SelectedItem.ToString() == "Atribuible")
                cmbTarge.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);            
            else//sector
                cmbTarge.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListSectors, null);
            
            cmbTarge.DisplayMember = "Name";
            cmbTarge.ValueMember = "ID";
            cmbTarge.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Macros NewMacro = new Macros();
            NewMacro.ID = NewIDMacro();
            NewMacro.StrToFind = this.txtMacroContain.Text;
            NewMacro.sendType = cmbSendTo.SelectedItem.ToString() == "Atribuible" ? 0 : 1;
            NewMacro.Target = int.Parse( cmbTarge.SelectedValue.ToString());
            CManager.dataPrj.Configuration.ListMacros.Add(NewMacro);
            
            this.dataGridMacros.Rows.Add(NewMacro.StrToFind, cmbSendTo.SelectedItem.ToString(), cmbTarge.Text);
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBank.Text))
                return;

            Banks NewBank = new Banks();
            NewBank.ID = NewIDBank();
            NewBank.Name = txtBank.Text;
            CManager.dataPrj.Configuration.ListBanks.Add(NewBank);
            
            cmbBanks.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListBanks, null);
            cmbTarge.DisplayMember = "Name";
            cmbTarge.ValueMember = "ID";
        }

        #region METHODS

        private int NewIDMacro()
        {
            int NewID = CManager.dataPrj.Configuration.ListMacros.Count;
            do
            {
                NewID++;
            }
            while (CManager.dataPrj.Configuration.ListMacros.Any(x => x.ID == NewID));

            return NewID;
        }

        private int NewIDBank()
        {
            int NewID = CManager.dataPrj.Configuration.ListBanks.Count;
            do
            {
                NewID++;
            }
            while (CManager.dataPrj.Configuration.ListBanks.Any(x => x.ID == NewID));

            return NewID;
        }

        #endregion


    }
}
