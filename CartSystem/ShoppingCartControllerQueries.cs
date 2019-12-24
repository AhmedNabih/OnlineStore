using OnlineStore.Database_Files;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.CartSystem
{
    class ShoppingCartControllerQueries
    {
        public DataBase database;
        public ShoppingCartControllerQueries(IConnectionString connectionString)
        {
            this.database = DataBase.GetInstance(connectionString);
        }
        public DataTable isItFirstTime(string UserID)
        {
            string querie= "select * from Transactions where userID ='"+ UserID + "'";
            return database.Query(querie);
        }
        public void InsertIntoTransacations(string UserID, string ProductID)
        {
            string s = "insert into Transactions (UserID,ProductID) values('" + UserID + "' ,'"+ ProductID + "')";
            database.QueryExec(s);
        }
        public void UpdateAmount(string StoreID,string amount)
        {
            string s = "update StoreProducts set amount='" + amount + "' where StoreID='" + StoreID + "' ";
            database.QueryExec(s);
        }
    }
}
