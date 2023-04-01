using System;
using System.IO;
using System.Linq;
using BankPunk.Panel;
using MetroFramework.Controls;

namespace BankPunk
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region FIELS
        
        pnlSlider CurrentPanel ;

        Boolean SaveChanges = false;
        #endregion

        #region CONSTRUCTOR

        public MainForm()
        {
            InitializeComponent();

            if (!Directory.Exists(CManager.PATH_DIR_FIELS))
                Directory.CreateDirectory(CManager.PATH_DIR_FIELS);
            String[] Files = Directory.GetFiles(CManager.PATH_DIR_FIELS);
            if (Files.Count() == 0)
            {
                CManager.CreateFirstFile();
                CManager.InitDocument();
            }            
            else
            {
                CManager.FileSource = Files[0];
                CManager.LoadDocument();
            }
                

                        
            
            //CManager.Params.MinimSaldo = 900;            
        }

        #endregion

        #region EVENTS

        private void metroTilePanel_Click(object sender, EventArgs e)
        {
            MetroTile mTile = sender as MetroTile;
            if (sender == null)
                return;

            pnlSlider Panel;
            
            switch (mTile.Tag.ToString())
            {
                case "Importa":
                    Panel = new pnlImport(PanelContainer);                    
                    break;
                case "Edita":
                    Panel = new pnlEdit(PanelContainer);                    
                    break;
                
                case "Resum":
                    Panel = new pnlChart(PanelContainer);                    
                    break;
                case "Configuracio":
                    Panel = new pnlConf(PanelContainer);
                    break;

                default:
                    Panel = new pnlEdit(PanelContainer);
                    break;
            }
                
            if (CurrentPanel != null && CurrentPanel.Name == Panel.Name)
                return;

            if (CurrentPanel != null)
                CurrentPanel.swipe(false);
                        
            CurrentPanel = Panel;

            Panel.Closed += _pnl_Closed;
            Panel.Shown += _pnl_Show;
            

            Panel.swipe(true);
            //BtnImport.Enabled = false;
        }

        private void metroTileExit_Click(object sender, EventArgs e)
        {
            SaveChanges = true;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(SaveChanges)
                CManager.SaveDocument();
        }

        private void metroTileSave_Click(object sender, EventArgs e)
        {
            CManager.SaveDocument();
        }

        #endregion

        #region EVENTS Panels
        
        void _pnl_Closed(object sender, EventArgs e)
        {
            //BtnSettings.Enabled = true;
        }

        void _pnl_Show(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}
