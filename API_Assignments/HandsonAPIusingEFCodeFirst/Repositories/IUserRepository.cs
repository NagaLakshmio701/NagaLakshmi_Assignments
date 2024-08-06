using HandsonAPIusingEFCodeFirst.Entities;
namespace HandsonAPIusingEFCodeFirst.Repositories

{
    public interface IUserRepository
    {
        void  Register(User user);
        User ValidUser(string email,string password);
    }
}
