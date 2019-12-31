using System;

namespace OnlineStore.App.StoreCommand.Commands
{
    public class StoreCommandFactory
    {

        public static IStoreCommand CreateCommand(String s)
        {
            if (s == "Add")
                return new AddCommand();
            else if (s == "Delete")
                return new DeleteCommand();
            else
                throw new NotSupportedException();
        }
    }
}
