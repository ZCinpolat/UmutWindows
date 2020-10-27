using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Umut_Glass
{
    public partial class frm_Print_Preview :MetroFramework.Forms.MetroForm
    {

        string reportName;
        string reportTitle;
        DataSet reportDataSet;
        public frm_Print_Preview( string _reportName, string _reportTitle, DataSet _reportDataSet)
        {
            reportName = _reportName;
            reportTitle = _reportTitle;
            reportDataSet = _reportDataSet;
            if (reportDataSet != null && reportDataSet .Tables.Count > 0)
            {
                this.Text = reportDataSet.Tables[0].Rows[0]["REFNO"].ToString();
            }
          
            InitializeComponent();
        }


        public frm_Print_Preview()
        {
            InitializeComponent();
        }
       
        private void frm_Print_Preview_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = System.AppDomain.CurrentDomain.BaseDirectory + "Print\\" + reportName;
            reportViewer1.LocalReport.DataSources.Clear();

            foreach (DataTable dt in reportDataSet.Tables)
            {
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(dt.TableName, dt));
            }
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("Title", reportTitle));
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 90;
            reportViewer1.LocalReport.DisplayName = reportTitle;
            this.reportViewer1.RefreshReport();
        }
    }
}
