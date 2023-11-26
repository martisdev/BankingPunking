using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankPunk
{
    public partial class FrmNew : MetroFramework.Forms.MetroForm
    {
        public AssetElement NewElmt;
        
        public FrmNew()
        {
            InitializeComponent();

            metroComboBoxAtribuible.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);
            metroComboBoxAtribuible.DisplayMember = "Value";
            metroComboBoxAtribuible.ValueMember = "Key";

            metroComboBoxSector.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListSectors, null);
            metroComboBoxSector.DisplayMember = "Value";
            metroComboBoxSector.ValueMember = "Key";

        }

        private void metroTileOK_Click(object sender, EventArgs e)
        {

            NewElmt = new AssetElement();

            NewElmt.Data_Moviment = this.metroDateTime.Value; 
            NewElmt.Data_Valor_Moviment = NewElmt.Data_Moviment;
            NewElmt.Concepte = this.metroTextBoxConcepte.Text;
            NewElmt.Import = double.Parse(this.metroTextBoxImport.Text);
            NewElmt.Saldo = 0;
            NewElmt.Atribuible = int.Parse(metroComboBoxAtribuible.SelectedValue.ToString());
            NewElmt.Sector = int.Parse(metroComboBoxSector.SelectedValue.ToString());
            NewElmt.Font = CManager.FONT_METALLIC;

            NewElmt.Hash = CManager.GetElemntHash(NewElmt);
            AssetElement ExistElmnt = CManager.dataPrj.Elements.FirstOrDefault(x => x.Hash == NewElmt.Hash);
            if (ExistElmnt == null)
            {
                this.DialogResult = DialogResult.OK;                
                return;
            }

            this.DialogResult = DialogResult.Abort;
        }

        private void metroTileCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
