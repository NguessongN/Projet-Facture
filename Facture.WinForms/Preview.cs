using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facture.BO;
using Microsoft.Reporting.WinForms;


namespace Facture.WinForms
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportList.rdlc";
            //*/s
            double totalFacture = 0;
            int productsLength = Program.productsList.Count;
            for (int i = 0; i < productsLength; i++) {
                totalFacture += Program.productsList[i].GetTotal();                
            }
            
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Data1", Program.productsList));
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

            List<ReportParameter> parameters = new List<ReportParameter>() {
                new ReportParameter("Total", totalFacture + " F"),
            };

            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
