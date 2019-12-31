
using OnlineStore.App.Stores.Data;
using System;

namespace OnlineStore.App.StoreCommand
{
    public interface IStoreCommand
    {
        public abstract bool Execute(CommandData data, StoreProduct storeProduct, bool collabMode);
        public abstract bool undo(CommandData data);


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
