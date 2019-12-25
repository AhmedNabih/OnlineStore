using OnlineStore.Database_Files;
using OnlineStore.Queries_Controllers;
using System;
using System.Collections.Generic;
using System.Data;

namespace OnlineStore.Data
{
    public class CollaboratorController
    {
        private String OriginalUserID;
        public String StoreID;
        private CollaboratorControllerQueries queries;

        public CollaboratorController(String UserID, String StoreID)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.queries = new CollaboratorControllerQueries(connectionString);

            this.OriginalUserID = UserID;
            this.StoreID = StoreID;
        }
        
        public List<Collaborator> GetCollaborators(String storeid)
        {
            DataTable dataTable = queries.GetCollaborators(storeid);
            if (dataTable == null)
                return null;
            List<Collaborator> CollaboratorList = new List<Collaborator>();

            foreach (DataRow row in dataTable.Rows)
            {
                String[] tpStr = new String[dataTable.Columns.Count];
                int i = 0;
                foreach (DataColumn col in dataTable.Columns)
                {
                    tpStr[i] = row[col].ToString();
                    i++;
                }
                Collaborator tempData = new Collaborator();
                tempData.Handler(tpStr);
                CollaboratorList.Add(tempData);
            }

            return CollaboratorList;
        }

        public bool AddCollaborator(String UserID, String StoreID)
        {
            return queries.AddCollaborator(UserID, StoreID);
        }

        public bool EditCollaborator(String UserID)
        {
            return queries.EditCollaborator(UserID);
        }

        public bool RemoveCollaborator(String UserID, String StoreID)
        {
            return queries.RemoveCollaborator(UserID, StoreID);
        }

        public UserData CheckRole(String username)
        {
            DataTable datatable = queries.CheckRole(username);

            if (datatable == null)
                return null;

            String[] tpData = new String[datatable.Columns.Count];
            int i = 0;
            foreach (DataRow row in datatable.Rows)
            {
                foreach (DataColumn col in datatable.Columns)
                {
                    tpData[i] = row[col].ToString();
                    i++;
                }
            }
            UserData tpUD = new UserData(tpData[0], tpData[1], tpData[2], tpData[3], tpData[4], tpData[5]);
            return tpUD;
        }
    }
}
