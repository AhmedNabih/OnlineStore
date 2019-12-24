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
        public void UpdateViews(string StatID)
        {
            string s = "update Statistic set NumOfViews=NumOfViews+1 where StatID='"+ StatID + "'  ";
            database.QueryExec(s);
        }
        public DataTable GetStatID(string storeID)
        {
            string s= "select StatID from StoreProducts where StoreID='"+ storeID+"' ";
            return database.Query(s);
        }
        public void UpdateNumOfSold(string StatID,string amount)
        {
            string s = "update Statistic set NumOfSold=NumOfSold + '" + amount+"' where StatID='" + StatID + "' ";
            database.QueryExec(s);
        }
    }
}
