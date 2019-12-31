
using OnlineStore.App.Stores.Data;

namespace OnlineStore.App.StoreCommand.Commands
{
    public class DeleteCommand : IStoreCommand
    {
        private StoreCommandController controller;
        private StoreProductController controllerStoreProduct;

        public DeleteCommand()
        {
            controller = new StoreCommandController();
            controllerStoreProduct = new StoreProductController();
        }

        public bool Execute(CommandData data, StoreProduct storeProduct, bool CollabMode)
        {
            if (CollabMode)
            {
                controller.SaveData(data);
                return controllerStoreProduct.RemoveStoreProductVisable(storeProduct.storeProductID);
            }
            
            return controllerStoreProduct.RemoveStoreProduct(storeProduct.storeID, storeProduct.storeProductID);
        }

        public bool undo(CommandData data)
        {
            controller.UnSaveData(data);

            return controllerStoreProduct.AddStoreProductVisable(data.ProductID);
        }


        ///////////////////////////////////// Class End /////////////////////////////////////
    }
}
