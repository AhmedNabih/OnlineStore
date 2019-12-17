using OnlineStore.Data;

namespace OnlineStore.Users.UserFactoryPattern
{
    public abstract class IUser
    {
        public UserData Data;
        public abstract void ConnectPage(UserData data);
    }
}
