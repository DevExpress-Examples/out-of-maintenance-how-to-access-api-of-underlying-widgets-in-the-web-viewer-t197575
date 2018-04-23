using System;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_WidgetAccess_Web {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, 
            ConfigureDataConnectionWebEventArgs e) {
            if (e.ConnectionName == "nwindConnection") {

                // Gets connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/nwind.mdb");

                // Specifies the path to a database file.                    
                parameters.FileName = databasePath;
            }
        }
    }
}