using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.BL
{
    class Muser
    {
        private string username;
        private string password;
        private string role;

        public Muser(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string getUserName()
        {
            return username;
        } 
        
        public string getPassWord()
        {
            return password;
        }

        public string getRole()
        {
            return role;
        }
    }
}
