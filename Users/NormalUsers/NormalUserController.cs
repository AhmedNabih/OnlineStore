using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.Users.NormalUsers
{
    public class NormalUserController
    {
        private IUser normalUser;

        public NormalUserController(NormalUser normalUser)
        {
            this.normalUser = normalUser;
        }
    }
}
