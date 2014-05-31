using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcApplication3.Controllers
{
    class BdData
    {
        Models.bd_bankirEntities _context = new bd_bankirEntities();

        public bool Validate(string log, string pass)
        {
            try
            {
                return _context.Users.Where(X => X.Login == log && X.Password == pass).Count() > 0;
            }
            catch
            {
            }

            return false;
        }


        public void registered (string email, string name, string surname,  string phone, string password)
        {

            User user2 = new User();
            user2.Login = email;
            user2.Password = password;
            user2.Name = name;
            user2.SurName = surname;
            user2.Phone = phone;
            user2.Date = DateTime.Now;
            _context.Users.Add(user2);
            _context.SaveChanges();
        }

        public List<Transaction> GetUserTransaction(long userId)
        {
            return _context.Transactions.Where(x => x.UserId == userId).ToList();
        }

        public List<Good> GetAllGood(long userId)
        {
            return _context.Goods.Where(x => x.UserId == userId).ToList();
        }

    }
}
