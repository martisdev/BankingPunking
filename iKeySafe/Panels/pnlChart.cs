using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;

namespace BankPunk.Panel
{
    public partial class pnlChart : pnlSlider
    {
        
        private enum Charts
        {
            INGRESSOS_DESPESE,
            ESTALVI
        }
        
        public pnlChart(MetroPanel owner) : base(owner)
        {
            InitializeComponent();            
        }

        private void InicializeChart()
        {
            List<AssetElement> ListFilter = CManager.dataPrj.Elements;

            try
            {
                flowLayoutPanelChart.Controls.Clear();
                Charts TypeChart = (Charts)cmbTypeChart.SelectedIndex;                
                switch (TypeChart)
                {
                    case Charts.INGRESSOS_DESPESE:
                        int AtribuibleValue = int.Parse(metroComboBoxFilterAtribuible.SelectedValue.ToString());
                        if (AtribuibleValue > CManager.NO_DEFINIT)
                            ListFilter = ListFilter.Where(x => x.Atribuible == AtribuibleValue).ToList();


                        int Year = int.Parse(cmbYear.SelectedItem.ToString());
                        ChartInOut(ListFilter, Year, AtribuibleValue);                        
                            
                        break;
                    case Charts.ESTALVI:
                        ChartEstalvi();
                        break;
                }

            }
            catch { }
            
        }

        private void ChartInOut(List<AssetElement> ListFilter, int Year, int AtribuibleValue)
        {
            for (int Month = 1; Month <= 12; Month++)
            {
                double ingresos = (from Elnt in ListFilter.Where(x => x.Import > 0
                                                                        && x.Data_Moviment.Month == Month
                                                                        && x.Data_Moviment.Year == Year)
                                   select Elnt.Import).Sum();

                double Despeses = (from Elnt in ListFilter.Where(x => x.Import < 0
                                                                        && x.Data_Moviment.Month == Month
                                                                        && x.Data_Moviment.Year == Year)
                                   select Elnt.Import).Sum();

                if (ingresos == 0 || Despeses == 0)
                    break;


                double DespesesComunes = 0;
                if (AtribuibleValue > CManager.NO_DEFINIT)
                {
                    DespesesComunes = (from Elnt in CManager.dataPrj.Elements.Where(x => x.Import < 0
                                                                        && x.Data_Moviment.Month == Month
                                                                        && x.Data_Moviment.Year == Year
                                                                        && x.Atribuible == CManager.ATRIBUIBLE_TOTHOM)
                                       select Elnt.Import).Sum() / 2;
                }

                double Estalvi = ingresos + (Despeses + DespesesComunes);
                string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Month);

                Chart mych = new Chart();
                ChartArea ChartArea1 = new ChartArea();
                ChartArea1.AxisY.Maximum = 4000;
                ChartArea1.AxisY.Title = "€";
                mych.ChartAreas.Add(ChartArea1);
                mych.Series.Add("Ingresos");
                mych.Series["Ingresos"].SetDefault(true);
                mych.Series["Ingresos"].Enabled = true;
                DataPoint dp = mych.Series["Ingresos"].Points.Add(ingresos);
                dp.ToolTip = string.Format("{0} {1}", ingresos, "Ingresos");

                mych.Series.Add("Despeses");
                mych.Series["Despeses"].SetDefault(true);
                mych.Series["Despeses"].Enabled = true;
                dp = mych.Series["Despeses"].Points.Add(Despeses);
                dp.ToolTip = string.Format("{0} {1}", Despeses, "Despeses");

                mych.Series.Add("Estalvi");
                mych.Series["Estalvi"].SetDefault(true);
                mych.Series["Estalvi"].Enabled = true;
                dp = mych.Series["Estalvi"].Points.Add(Estalvi);
                if (AtribuibleValue > CManager.NO_DEFINIT)
                    dp.ToolTip = string.Format("{0} {1}", Estalvi, "Estalvi (ingresos - (despeses + despeses comunes))");
                else
                    dp.ToolTip = string.Format("{0} {1}", Estalvi, "Estalvi");

                mych.Titles.Add(strMonthName);
                mych.Width = 200;
                mych.Height = 200;
                mych.Visible = true;

                flowLayoutPanelChart.Controls.Add(mych);
                mych.Show();
                
            }
        }

        
        private void ChartEstalvi()
        {
            
            DateTime MinDate = (from Elnt in CManager.dataPrj.Elements.Where(x => x.Font == 4).OrderBy(y => y.Data_Moviment)
                                select Elnt.Data_Moviment).FirstOrDefault();
            DateTime MaxDate = (from Elnt in CManager.dataPrj.Elements.Where(x => x.Font == 4).OrderByDescending(y => y.Data_Moviment)
                                select Elnt.Data_Moviment).FirstOrDefault();


            List<AssetElement> ListFilter = CManager.dataPrj.Elements.Where(x => x.Font == 4).ToList();

            //double saldoMesAnterior = (from Elnt in ListFilter.Where(x => x.Font == 4).OrderBy(y => y.Data_Moviment)
            //                           select Elnt.Saldo).FirstOrDefault();
            double saldoMesAnterior = 0;

            for (var day = MinDate; day <= MaxDate; day = day.AddMonths(1))
            {                
                int lastday = DateTime.DaysInMonth(day.Year, day.Month);
                double Saldo = 0;
                do
                {
                    //Saldo = (from Elnt in ListFilter.Where(x => 
                    //                                            x.Data_Moviment.Month == Month
                    //                                            && x.Data_Moviment.Day == lastday
                    //                                            && x.Data_Moviment.Year == Year)
                    //                  select Elnt.Saldo).FirstOrDefault();
                    AssetElement Elmt = ListFilter.FirstOrDefault(x =>
                                                                x.Data_Moviment.Month == day.Month
                                                                && x.Data_Moviment.Day == lastday
                                                                && x.Data_Moviment.Year == day.Year );
                    if (Elmt != null)
                        Saldo = Elmt.Saldo;

                    lastday--;
                } while (Saldo == 0 && lastday > 1);

                if (Saldo > 0)
                {
                    double estalvi = 0;
                    if(saldoMesAnterior>0 )
                        estalvi = Saldo - saldoMesAnterior;

                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(day.Month);
                    Chart mych = new Chart();
                    ChartArea ChartArea1 = new ChartArea();
                    ChartArea1.AxisY.Maximum = 3000;
                    ChartArea1.AxisY.Title = "€";
                    mych.ChartAreas.Add(ChartArea1);
                    mych.Series.Add("Saldo");
                    mych.Series["Saldo"].SetDefault(true);
                    mych.Series["Saldo"].Enabled = true;

                    // Create a new legend called "Legend2".
                    //mych.Legends.Add(new Legend("Legend2"));

                    //// Set Docking of the Legend chart to the Default Chart Area.
                    //mych.Legends["Legend2"].DockedToChartArea = "Default";

                    //// Assign the legend to Series1.
                    //mych.Series["Saldo"].Legend = "Legend2";
                    //mych.Series["Saldo"].IsVisibleInLegend = true;

                    DataPoint dp = mych.Series["Saldo"].Points.Add(Saldo);
                    dp.ToolTip = string.Format("{0} {1}", Saldo, "Saldo");

                    mych.Series.Add("Estalvi");
                    mych.Series["Estalvi"].SetDefault(true);
                    mych.Series["Estalvi"].Enabled = true;                    
                    dp = mych.Series["Estalvi"].Points.Add(estalvi);
                    dp.ToolTip = string.Format("{0} {1}", estalvi, "Estalvi");


                    mych.Titles.Add(strMonthName);
                    mych.Width = 200;
                    mych.Height = 200;
                    mych.Visible = true;

                    flowLayoutPanelChart.Controls.Add(mych);
                    mych.Show();
                    saldoMesAnterior = Saldo;
                }
            }
                         
        }
        private void pnlChart_Load(object sender, EventArgs e)
        {
            metroComboBoxFilterAtribuible.DataSource = CManager.dataPrj.Configuration.ListAtribuibles.ToArray();
            metroComboBoxFilterAtribuible.DataSource = new BindingSource(CManager.dataPrj.Configuration.ListAtribuibles, null);
            metroComboBoxFilterAtribuible.DisplayMember = "Name";
            metroComboBoxFilterAtribuible.ValueMember = "ID";
            metroComboBoxFilterAtribuible.SelectedItem = CManager.dataPrj.Configuration.ListAtribuibles.First();


            base.Title =  "Gràfic resum";
            cmbYear.Items.Clear();
            var Years =  CManager.dataPrj.Elements.OrderBy(y => y.Data_Moviment).GroupBy(x => x.Data_Moviment.Year).ToList();
            foreach (var year in Years)
            {
                cmbYear.Items.Add(year.Key);
            }
            cmbTypeChart.SelectedIndex = 0;
            this.cmbTypeChart.SelectedIndexChanged += new System.EventHandler(this.cmbTypeChart_SelectedIndexChanged);
            cmbYear.SelectedItem = DateTime.Now.Year;
            
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializeChart();
        }

        private void cmbTypeChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializeChart();
        }
    }
}
