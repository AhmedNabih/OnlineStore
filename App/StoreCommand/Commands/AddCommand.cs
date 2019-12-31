
using OnlineStore.App.Stores.Data;
using System;

namespace OnlineStore.App.StoreCommand.Commands
{
    public class AddCommand : IStoreCommand
    {
        private StoreCommandController controllerCommand;
        private StoreProductController controllerStoreProduct;

        public AddCommand()
        {
            controllerCommand = new StoreCommandController();
            controllerStoreProduct = new StoreProductController();
        }

        public bool Execute(CommandData data, StoreProduct storeProduct, bool CollabMode)
        {
            String SPID = controllerStoreProduct.AddStoreProduct(storeProduct.storeID, storeProduct);
            if (SPID == null)
                return false;
            data.ProductID = SPID;
            if (CollabMode)
                controllerCommand.SaveData(data);
            return true;
        }

        public bool undo(CommandData data)
        {
            controllerCommand.UnSaveData(data);
            return controllerStoreProduct.RemoveStoreProduct(data.StoreID, data.ProductID);
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
