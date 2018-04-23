using DevExpress.XtraReports.UI;

namespace WebApplication1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void lbShowHide_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            (sender as XRLabel).Text = DetailReport.DrillDownExpanded ? "Hide Details" : "Show Details";
        }

    }
}
