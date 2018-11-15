<!-- default file list -->
*Files to look at*:

* [E1759.cs](./CS/WindowsApplication1/E1759.cs) (VB: [E1759.vb](./VB/WindowsApplication1/E1759.vb))
* [layout.xml](./CS/WindowsApplication1/layout.xml) (VB: [layout.xml](./VB/WindowsApplication1/layout.xml))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to restore the Auto Filter Row from an active filter after restoring the layout


<p>If you are familiar with our <a href="http://documentation.devexpress.com/#AspNet/CustomDocument7873">ASPxGridView</a> component, then you might have noticed that, by default, it fills the auto filter row from the filter after restoring the grid's state. Our GridControl component also has this feature, but it is currently undocumented and is disabled by default.</p>
<p>To automatically enable this functionality after <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument772">restoring the grid's layout</a>, set the static <em>GuessAutoFilterRowValuesFromFilterAfterRestoreLayout</em> property of the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridViewsGridGridViewtopic">GridView</a> object to True.</p>
<p>If you want to enable this feature at runtime on demand, call the <em>GuessAutoFilterRowValuesFromFilter</em> method of the GridView object.</p>
<p><br><strong>IMPORTANT NOTES</strong><br>1. Both approaches are currently undocumented, because not all standard scenarios are supported. So, carefully test your application when using the aforementioned APIs to see whether this feature meets your business needs before releasing your app. Don't hesitate to contact us in case of any issues.</p>
<p>2. To use these solutions in an XAF WinForms app, consider the following ViewController:</p>


```cs
using System;
using DevExpress.XtraGrid;
using DevExpress.ExpressApp;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.ExpressApp.Win.Editors;

namespace MainDemo.Module.Win {
    public class B152594 : ViewController<ListView> {
        GridListEditor gridlistEditor = null;
        protected override void OnViewControlsCreated() {
            base.OnViewControlsCreated();
            gridlistEditor = View.Editor as GridListEditor;
            if(gridlistEditor != null) {
                gridlistEditor.Grid.HandleCreated += Grid_HandleCreated;
            }
        }
        private void Grid_HandleCreated(object sender, EventArgs args) {
            GridControl grid = (GridControl)sender;
            grid.HandleCreated -= Grid_HandleCreated;
            using(var criteriaScope = View.ObjectSpace.CreateParseCriteriaScope()) {
                ((GridView)grid.MainView).GuessAutoFilterRowValuesFromFilter();
            }
        }
    }
}

```


<p><br><strong>See Also:</strong></p>
<p><a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2567">Filtering via Code</a><br> <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument1428">Auto Filter Row</a></p>

<br/>


