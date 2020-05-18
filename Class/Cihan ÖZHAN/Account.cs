using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Account
    {
        public Account()
        {

        }

        public string GetAccount(string userName)
        {
            if (!string.IsNullOrEmpty(userName))
            {

            }

            if (!string.IsNullOrWhiteSpace(userName))
            {

            }

            return "DİJİBİL";
        }

        public string GetAccount(int userId)
        {
            string result = string.Empty;

            if (userId > 0)
            {
                result = "Cihan ÖZHAN";
            }
            else
            {
                throw new Exception("Hata!");
            }
            return result;
        }
    }
}
