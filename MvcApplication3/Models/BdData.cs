using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class BdData
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


    }
}