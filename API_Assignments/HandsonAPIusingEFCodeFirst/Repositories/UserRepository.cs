using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Repositories

{
    public class UserRepository:IUserRepository
    {
        private readonly ECommContext UserOBJ;

        public UserRepository(ECommContext userOBJ)
        {
            UserOBJ = userOBJ;
        }

       /* public UserRepository()
        {
            UserOBJ = new ECommContext();
        }*/

        public void Register(User user)
        {
           UserOBJ.Users.Add(user);
           UserOBJ.SaveChanges();
        }

        public User ValidUser(string email, string password)
        { 
           return UserOBJ.Users.SingleOrDefault(u=>u.Email == email && u.Password ==password);
        }
    }
}
