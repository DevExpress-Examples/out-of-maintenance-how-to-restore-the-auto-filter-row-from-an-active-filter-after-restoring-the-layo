Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Collections
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1
	Public Class E1759
		Private Shared Function GetData() As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("ID", GetType(Integer))
			dt.Columns.Add("Category", GetType(String))
			dt.Columns.Add("Product", GetType(String))
			dt.Columns.Add("Price", GetType(Single))
			dt.Columns.Add("Quantity", GetType(Single))

			dt.Rows.Add(New Object() { 1, "Beverages", "Chai", 1.6, 319 })
			dt.Rows.Add(New Object() { 2, "Beverages", "Chai", 6295.5, 399 })
			dt.Rows.Add(New Object() { 3, "Beverages", "Ipoh Coffee", 10034.9, 228 })
			dt.Rows.Add(New Object() { 4, "Confections", "Chocolade", 1282.1, 130 })
			dt.Rows.Add(New Object() { 5, "Confections", "Chocolade", 86.7, 8 })
			dt.Rows.Add(New Object() { 6, "Confections", "Scottish Longbreads", 3909.0, 380 })
			Return dt
		End Function
		Public Shared Sub Init(ByVal form As Form)
			form.Text = "E1759"
			DevExpress.XtraGrid.Views.Grid.GridView.GuessAutoFilterRowValuesFromFilterAfterRestoreLayout = True
			Dim grid As New GridControl()
			grid.Dock = DockStyle.Fill
			form.Controls.Add(grid)
			grid.DataSource = GetData()
			grid.ForceInitialize()
			Dim gridView As GridView = CType(grid.DefaultView, GridView)
			gridView.RestoreLayoutFromStream(GetType(E1759).Assembly.GetManifestResourceStream("layout.xml"))
			'gridView.GuessAutoFilterRowValuesFromFilter();
		End Sub
	End Class
End Namespace