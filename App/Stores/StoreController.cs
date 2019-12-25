using System;

namespace OnlineStore.App.Stores
{
    public class StoreController
    {
        public Store store;

        public StoreController(Store store)
        {
            this.store = store;
        }

        public String GetStoreID()
        {
            return this.store.storeData.storeData.ID;
        }

        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
