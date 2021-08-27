<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580050/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T197575)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WidgetsCustomization.js](./CS/Dashboard_WidgetAccess_Web/Scripts/WidgetsCustomization.js) (VB: [WidgetsCustomization.js](./VB/Dashboard_WidgetAccess_Web/Scripts/WidgetsCustomization.js))
* [WebForm1.aspx](./CS/Dashboard_WidgetAccess_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_WidgetAccess_Web/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_WidgetAccess_Web/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_WidgetAccess_Web/WebForm1.aspx.vb))
<!-- default file list end -->
# How to access API of underlying widgets in the Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t197575/)**
<!-- run online end -->


<p><strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>This example demonstrates how to customize client widgets used to visualize data within dashboard items at runtime using <a href="http://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWebScriptsASPxClientDashboardViewertopic">ASPxClientDashboardViewer</a>'s API. This approach is described in greater detail in the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument18020">Access to Underlying Widgets</a> help topic. <br>The following options are changed

* Highlighting of the hovered grid row is enabled in the underlying dxDataGrid in the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemWidgetCreatedtopic">ItemWidgetCreated</a> event handler.
* A standard tooltip that is invoked when an end-user hovers over a chart series point is disabled. You can invoke a tooltip by clicking the required label on the argument axis. The argumentAxisClick event is used for this purpose. Subscription and unsubscription to/from the argumentAxisClick event are performed in the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemWidgetCreatedtopic">ItemWidgetCreated</a> and <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemBeforeWidgetDisposedtopic">ItemBeforeWidgetDisposed</a> event handlers respectively.
* A pie legend is shown for the underlying dxPieChart.</p>

<br/>


