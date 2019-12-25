using OnlineStore.App.Stores.Data;

namespace OnlineStore.App.Stores
{
    public class Store
    {
        public UserStoreData storeData;

        public Store()
        {
            this.storeData = new UserStoreData();
        }

        public Store(UserStoreData storeData)
        {
            this.storeData = storeData;
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
