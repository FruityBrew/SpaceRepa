using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdentityDb.API.Model
{
    public class UserActions
    {
        private static void _ValidateUserData(User user)
        {
            if (String.IsNullOrWhiteSpace(user.Login)
                && String.IsNullOrWhiteSpace(user.Mail))
            {
                throw new InvalidOperationException(
                    "Не указан логин или адрес электронной почты.");
            }

            if(String.IsNullOrWhiteSpace(user.Pass))
                throw new InvalidOperationException("Не указан пароль.");

            if(user.RegistrationDt.HasValue == false)
                throw new InvalidOperationException(
                    "Не указана дата регистрации.");
        }

        internal static Boolean _AddUser(User added)
        {
            if(added == null)
                throw new ArgumentNullException(nameof(added));

            try
            {
                added.RegistrationDt = DateTime.Now;
                _ValidateUserData(added);

                using (IdentityContext dbContext = new IdentityContext(new DbContextOptions<IdentityContext>()
                    ))
                {
                    dbContext.Users.Add(added);

                    dbContext.SaveChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        internal static IEnumerable<User> _GetUsers()
        {
            DbContextOptions<IdentityContext> options = 
                new DbContextOptions<IdentityContext>();

            using (IdentityContext dbContext = new IdentityContext(options))
            {
                return dbContext.Users.ToList();
            }

        }
    }
}
