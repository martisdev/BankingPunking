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

namespace BankPunk.Panel
{
    public partial class pnlChart : pnlSlider
    {
        public pnlChart(MetroPanel owner) : base(owner)
        {
            InitializeComponent();            
        }

        private void InicializeChart()
        {
            List<settlements> ListFilter = CManager.dataPrj.Elements;

            try
            {
                int AtribuibleValue = int.Parse(metroComboBoxFilterAtribuible.SelectedValue.ToString());
                if (AtribuibleValue > CManager.NO_DEFINIT)
                    ListFilter = ListFilter.Where(x => x.Atribuible == AtribuibleValue).ToList();

                flowLayoutPanelChart.Controls.Clear();
                int Year = int.Parse(cmbYear.SelectedItem.ToString());
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

                    double DespesesComunes = (from Elnt in CManager.dataPrj.Elements.Where(x => x.Import < 0
                                                                            && x.Data_Moviment.Month == Month
                                                                            && x.Data_Moviment.Year == Year
                                                                            && x.Atribuible == CManager.ATRIBUIBLE_TOTHOM)
                                              select Elnt.Import).Sum()/2;

                    double Estalvi = ingresos + (Despeses + DespesesComunes);

                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Month);
                    if (ingresos > 0 || Despeses > 0)
                    {
                        Chart mych = new Chart();
                        ChartArea ChartArea1 = new ChartArea();
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
                        dp.ToolTip = string.Format("{0} {1}", Estalvi, "Estalvi");

                        mych.Titles.Add(strMonthName);
                        mych.Width = 200;
                        mych.Height = 200;
                        mych.Visible = true;

                        flowLayoutPanelChart.Controls.Add(mych);
                        mych.Show();
                    }
                }
            }
            catch { }
            
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
            cmbYear.SelectedItem = DateTime.Now.Year;
            
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializeChart();
        }
    }
}
