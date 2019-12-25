using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Queries_Controllers
{
    public class CollaboratorControllerQueries
    {
        private DataBase dataBase;

        public CollaboratorControllerQueries(IConnectionString connectionString)
        {
            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public DataTable GetCollaborators(String storeid)
        {
            try
            {
                String cmd = "select c.UserID, mu.UserName from collaborators c inner join MyUser mu on c.UserID = mu.UserID and c.StoreID = " + storeid;
                DataTable datatable = dataBase.Query(cmd);

                if (datatable.Rows.Count <= 0)
                    return null;
                return datatable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable CheckRole(String username)
        {
            try
            {
                String cmd = "select * from MyUser where UserName = '" + username + "' and Role = 'StoreOwner'";
                DataTable dataTable = dataBase.Query(cmd);
                if (dataTable.Rows.Count <= 0)
                    return null;
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public bool AddCollaborator(String UserID, String StoreID)
        {
            try
            {
                String cmd = "insert into Collaborators values(" + UserID + "," + StoreID + ")";
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditCollaborator(String UserID)
        {
            //TODO
            return false;
        }

        public bool RemoveCollaborator(String UserID, String StoreID)
        {
            try
            {
                String cmd = "delete from Collaborators where UserID = " + UserID + " and StoreID = " + StoreID;
                dataBase.QueryExec(cmd);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
