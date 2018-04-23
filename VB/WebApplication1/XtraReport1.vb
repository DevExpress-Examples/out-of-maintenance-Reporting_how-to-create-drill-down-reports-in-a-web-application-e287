Imports DevExpress.XtraReports.UI

Namespace WebApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lbShowHide.BeforePrint
            TryCast(sender, XRLabel).Text = If(DetailReport.DrillDownExpanded, "Hide Details", "Show Details")
        End Sub

    End Class
End Namespace
