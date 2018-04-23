Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ReportViewer1.Report = New XtraReport1()

		If Session("skippedDetailBands") IsNot Nothing Then
			Dim ht As Hashtable = CType(Session("skippedDetailBands"), Hashtable)

			CType(ReportViewer1.Report, XtraReport1).skippedDetailBands = ht

			If Request("grpid") IsNot Nothing AndAlso (Not Page.IsCallback) Then
				If ht.Contains(Request("grpid")) Then
					ht(Request("grpid")) = Not Convert.ToBoolean(ht(Request("grpid")))
				Else
					ht.Add(Request("grpid"), True)
				End If
			End If
		Else
			Session("skippedDetailBands") = New Hashtable()
		End If

	End Sub
End Class
