using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Linq;
using System.Collections.Generic;

namespace BankPunk.Panel
{
    public partial class pnlImport : pnlSlider
    {
        #region CLASS
        class MyProgressData
        {
            public int Value { get; set; }
            public int MaxValue { get; set; }
            public MyProgressData(int mValue, int mMaxValue)
            {
                Value = mValue;
                MaxValue = mMaxValue;
            }

        }
        #endregion
        
        #region FIELS

        
        
        #endregion

        #region CONSTRUCTOR

        public pnlImport(MetroPanel Owner) : base(Owner)
        {
            InitializeComponent();            
        }

        #endregion

        #region EVENTS
        
        private void txtFiletoImport_ButtonClick(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = path,
                Title = "Busca el fitxer a importar",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "fitxer xlsx (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFiletoImport.Text = openFileDialog1.FileName;            
        }

        private async void metroTilePreImport_Click(object sender, EventArgs e)
        {
            EnableDisableControls(false);

            string ErrMessage = string.Empty;
            string FileToImport = txtFiletoImport.Text;
            string NameFulla = txtNameFulla.Text;
            string Entitat = metroComboBoxEntitats.Text;
            //string Entitat = ((KeyValuePair<int, string>)metroComboBoxEntitats.SelectedValue).Value.ToString();

            DataTable DataImport = null;

            IProgress<MyProgressData> progress = new Progress<MyProgressData>(msg =>
            {
                metroProgressSpinner.Value = msg.Value;
                metroProgressSpinner.Maximum = msg.MaxValue;
            });
            var PopulateTask = Task<Boolean>.Factory.StartNew(() => PupulateDataGrid(Entitat, FileToImport, NameFulla, progress, ref ErrMessage, out DataImport));
            await PopulateTask;

            
            if (PopulateTask.Result)
                MetroFramework.MetroMessageBox.Show(this, "Pre-importació finalitzada", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

            else
                MetroFramework.MetroMessageBox.Show(this, "Errors en la importació: " + ErrMessage, "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);

            metroGridData.DataSource = DataImport;

            EnableDisableControls(true);
        }

        private void txtFiletoImport_TextChanged(object sender, EventArgs e)
        {
            metroTilePreImport.Enabled = File.Exists(txtFiletoImport.Text);
        }

        private void metroTileExport_Click(object sender, EventArgs e)
        {
            int repetits = 0;
            for (int r = 0; r < metroGridData.Rows.Count; r++)
            {
                AssetElement NewElmt = new AssetElement();
                
                NewElmt.Data_Moviment = DateTime.Parse(metroGridData.Rows[r].Cells["col_Data_Moviment"].Value.ToString());
                NewElmt.Data_Valor_Moviment = DateTime.Parse(metroGridData.Rows[r].Cells["col_DataValor_Moviment"].Value.ToString());
                NewElmt.Concepte = metroGridData.Rows[r].Cells["col_Concepte_Moviment"].Value.ToString();
                NewElmt.Import = double.Parse(metroGridData.Rows[r].Cells["col_Import_Moviment"].Value.ToString());
                NewElmt.Saldo = double.Parse(metroGridData.Rows[r].Cells["col_Saldo_Moviment"].Value.ToString());
                NewElmt.Font = int.Parse(metroComboBoxEntitats.SelectedValue.ToString());

                NewElmt.Hash = CManager.GetElemntHash(NewElmt);
                AssetElement ExistElmnt = CManager.dataPrj.Elements.FirstOrDefault(x => x.Hash == NewElmt.Hash);
                if (ExistElmnt == null)
                {
                    foreach (Macros macro in CManager.dataPrj.Configuration.ListMacros)
                    {
                        if (NewElmt.Concepte.ToLower().Contains(macro.StrToFind.ToLower()))
                        {
                            switch (macro.sendType)
                            {
                                case 0:
                                    NewElmt.Atribuible = macro.Target;
                                    break;
                                case 1:
                                    NewElmt.Sector = macro.Target;
                                    break;
                            }
                        }
                    }
                    CManager.dataPrj.Elements.Add(NewElmt);
                }                    
                else
                    repetits++;
            }
            metroGridData.DataSource = null;
            if (repetits == 0)
                MetroFramework.MetroMessageBox.Show(this, "Importació finalitzada", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            else
                MetroFramework.MetroMessageBox.Show(this, "Importació finalitzada, però s'han trobat " + repetits + " registres repetits.", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
        }

        private void pnlImport_Load(object sender, EventArgs e)
        {
            base.Title = "Importa els moviments bancaris";
            IEnumerable<Banks> aas =  CManager.dataPrj.Configuration.ListBanks.Where(x => x.Enable == true);
            metroComboBoxEntitats.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListBanks.Where(x => x.Enable== true), null);
            metroComboBoxEntitats.DisplayMember = "Name";
            metroComboBoxEntitats.ValueMember = "ID";
            metroComboBoxEntitats.SelectedItem = CManager.dataPrj.Configuration.ListBanks.First();

            SetColumns();
        }
    
        #endregion

        #region METHODS

        private void SetColumns()
        {
            DataTable dataImport = GetDataTableImport();
            
            foreach(DataColumn Column in dataImport.Columns)
            {
                DataGridViewTextBoxColumn NewCol = new DataGridViewTextBoxColumn();
                NewCol.Name = Column.ColumnName;
                NewCol.DataPropertyName = Column.ColumnName;

                switch(Column.ColumnName)
                {
                    case "col_Data_Moviment":
                        NewCol.HeaderText = "Data Moviment";
                        NewCol.Width = 100;
                        break;

                    case "col_DataValor_Moviment":
                        NewCol.HeaderText = "Data Valor Moviment";
                        NewCol.Width = 100;
                        break;
                    
                    case "col_Concepte_Moviment":
                        NewCol.HeaderText = "Concepte";
                        NewCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    
                    case "col_Import_Moviment":
                        NewCol.HeaderText = "Import";
                        NewCol.Width = 70;
                        break;

                    case "col_Saldo_Moviment":
                        NewCol.HeaderText = "Saldo";
                        NewCol.Width = 70;
                        break;

                    default:
                        break;
                }
                metroGridData.Columns.Add(NewCol);

            }
        }


        private DataTable GetDataTableImport()
        {
            DataTable dataImport = new DataTable("DataToImport");

            dataImport.Columns.Add("col_Data_Moviment", typeof(DateTime));
            dataImport.Columns.Add("col_DataValor_Moviment", typeof(DateTime));
            dataImport.Columns.Add("col_Concepte_Moviment", typeof(String));
            dataImport.Columns.Add("col_Import_Moviment", typeof(String));
            dataImport.Columns.Add("col_Saldo_Moviment", typeof(String));

            return dataImport;
        }

        private Boolean PupulateDataGrid(string Entitat,  string FileToImport,string NameFulla, IProgress<MyProgressData> progress, ref string ErrMessage, out DataTable dataImport)
        {

            dataImport = GetDataTableImport();
            DataTable data = dataImport.Clone();

            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            FileToImport +
                            ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + NameFulla + "$]", con);

            try
            {
                con.Open();
            }
            catch (OleDbException ex)
            {                
                ErrMessage = ex.Message;
                return false;
            }

            try
            {
                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                sda.Fill(data);
            }
            catch(Exception ex)
            {
                ErrMessage = ex.Message;
                return false;
            }            

            data = data.DefaultView.ToTable();
            int inx= 0;
            foreach (DataRow row in data.Rows)
            {
                try
                {
                    inx++;
                    DateTime Data_Moviment;
                    DateTime Data_Valor_Moviment;// = row[ColName.col_price].ToString();
                    string Concepte_Moviment;// BBVA = Concepte+ moviment + observacions
                    String Import_Moviment;
                    String Saldo_Moviment;

                    if (row[1] == null )
                        continue;
                    
                    switch (Entitat)
                    {
                        case "Triodos":
                            Data_Moviment = DateTime.Parse(row[5].ToString());
                            Data_Valor_Moviment = DateTime.Parse(row[6].ToString());
                            Concepte_Moviment = row[7].ToString();
                            Import_Moviment = row[8].ToString().Replace(".", ",");
                            Saldo_Moviment = row[9].ToString().Replace(".", ",");
                            break;
                        case "BBVA":
                            Data_Moviment = DateTime.Parse(row[5].ToString());
                            Data_Valor_Moviment = DateTime.Parse(row[6].ToString());
                            Concepte_Moviment = string.Format("{0}, {1} ({2})", row[7].ToString(), row[8].ToString(), row[13].ToString());
                            Import_Moviment = row[9].ToString().Replace(".", ",");
                            Saldo_Moviment = row[11].ToString().Replace(".", ",");
                            break;
                        case "(Comú) Caixa Enginiers":
                        case "Caixa Enginiers":
                            Data_Moviment = DateTime.Parse(row[5].ToString());
                            Data_Valor_Moviment = DateTime.Parse(row[7].ToString());
                            Concepte_Moviment = row[6].ToString();
                            Import_Moviment = row[8].ToString().Replace(".", ",");
                            Saldo_Moviment = row[9].ToString().Replace(".", ",");
                            break;
                        default:
                            Data_Moviment = default(DateTime);
                            Data_Valor_Moviment = default(DateTime);
                            Concepte_Moviment = default(string);
                            Import_Moviment = default(string);
                            Saldo_Moviment = default(string);
                            break;
                    }
                    //Add Row
                    DataRow NewRow = dataImport.NewRow();
                    NewRow["col_Data_Moviment"] = Data_Moviment;
                    NewRow["col_DataValor_Moviment"] = Data_Valor_Moviment;
                    NewRow["col_Concepte_Moviment"] = Concepte_Moviment;
                    NewRow["col_Import_Moviment"] = Import_Moviment;
                    NewRow["col_Saldo_Moviment"] = Saldo_Moviment;

                    dataImport.Rows.Add(NewRow);
                    progress.Report(new MyProgressData(inx, data.Rows.Count));
                }
                catch (Exception Ex)
                {
                    ErrMessage = Ex.Message;
                    return false;
                }
            }

            return true;
        }

        private void EnableDisableControls(Boolean Value)
        {
            this.txtFiletoImport.Enabled = Value;
            this.txtNameFulla.Enabled = Value;
            this.metroTilePreImport.Enabled = Value;
            this.metroComboBoxEntitats.Enabled = Value;
        }

        #endregion

    }
}
