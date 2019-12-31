using OnlineStore.App.Stores;
using OnlineStore.App.Stores.Data;
using System;
using System.Collections.Generic;

namespace OnlineStore.App.StoreCommand
{
    public class StoreCommandInvoker
    {
        public StoreCommandInvoker()
        {
        }

        public bool DoCommand(IStoreCommand cmd, CommandData data, bool CollabMode, StoreProduct storeProduct)
        {
            return cmd.Execute(data,storeProduct,CollabMode);
        }

        public bool UndoCommand(IStoreCommand cmd, CommandData data)
        {
            return cmd.undo(data);
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
