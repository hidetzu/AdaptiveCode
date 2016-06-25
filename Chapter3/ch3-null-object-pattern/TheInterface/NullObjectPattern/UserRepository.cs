using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class UserRepository : IUserRepository
    {
        private ICollection<User> users;

        public UserRepository()
        {
            users = new List<User>
            {
                new User(Guid.NewGuid())
                {
                    Name = "Test1,"
                },
                new User(Guid.NewGuid())
                {
                    Name = "Test2,"
                },
                new User(Guid.NewGuid())
                {
                    Name = "Test3,"
                },
                new User(Guid.NewGuid())
                {
                    Name = "Test4,"
                },

            };
        }

        public IUser GetByID(Guid userID)
        {
            IUser userFound = users.SingleOrDefault(user => user.ID == userID);
            if( userFound == null)
            {
                userFound = new NullUser();
            }
            return userFound;
        }
    }
}
