using System;
using System.Data;
using System.Collections;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1 {
    public class E1759 {
        private static DataTable GetData() {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Price", typeof(float));
            dt.Columns.Add("Quantity", typeof(float));

            dt.Rows.Add(new object[] { 1, "Beverages", "Chai", 1.6, 319 });
            dt.Rows.Add(new object[] { 2, "Beverages", "Chai", 6295.5, 399 });
            dt.Rows.Add(new object[] { 3, "Beverages", "Ipoh Coffee", 10034.9, 228 });
            dt.Rows.Add(new object[] { 4, "Confections", "Chocolade", 1282.1, 130 });
            dt.Rows.Add(new object[] { 5, "Confections", "Chocolade", 86.7, 8 });
            dt.Rows.Add(new object[] { 6, "Confections", "Scottish Longbreads", 3909.0, 380 });
            return dt;
        }
        public static void Init(Form form) {
            form.Text = "E1759";
            GridView.GuessAutoFilterRowValuesFromFilterAfterRestoreLayout = true;
            GridControl grid = new GridControl();
            grid.Dock = DockStyle.Fill;
            form.Controls.Add(grid);
            grid.DataSource = GetData();
            grid.ForceInitialize();
            GridView gridView = (GridView)grid.DefaultView;
            gridView.RestoreLayoutFromStream(typeof(E1759).Assembly.GetManifestResourceStream("WindowsApplication1.layout.xml"));
            //gridView.GuessAutoFilterRowValuesFromFilter();
        }
    }
}