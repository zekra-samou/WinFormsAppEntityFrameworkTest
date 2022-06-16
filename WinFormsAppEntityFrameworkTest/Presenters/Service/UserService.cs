using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest.Presenters.User
{
   static  class UserService
    {
        public static ApplicationDbContext _context = new ApplicationDbContext();
        
        public static void insert(UserModel user)
        {
             _context.Users.Add(user);
             _context.SaveChanges();
        }

        public static void update(UserModel user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public static void delete(UserModel user)
        {
            _context.Users.Remove( user);
            _context.SaveChanges();
        }

        public static List<UserModel> getAllUsers()
        {
            return _context.Users.ToList<UserModel>();

        }

    }
}
