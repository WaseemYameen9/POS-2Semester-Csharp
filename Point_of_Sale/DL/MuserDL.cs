using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale.BL;
using System.IO;

namespace Point_of_Sale.DL
{
    class MuserDL
    {
       public  static List<Muser> users = new List<Muser>();
        public static string checkuser(string username1,string password1)
        { 
            for (int m = 0; m < users.Count; m++)
            {
                if ((users[m].getUserName() == username1) && (users[m].getPassWord() == password1))
                {
                    return users[m].getRole();
                }
            }
            return "false";
        }

        public static void storeMuser()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\Muser.txt";
            StreamWriter f = new StreamWriter(path);
            for(int i = 0; i < users.Count; i++)
            {
                f.WriteLine("{0},{1},{2}",users[i].getUserName(), users[i].getPassWord(), users[i].getRole());
            }
            f.Flush();
            f.Close();
        }

        public static void loadMuser()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Point_of_Sale\\Muser.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string username = splittedrecord[0];
                string password = splittedrecord[1];
                string role = splittedrecord[2];
                Muser userr = new Muser(username, password, role);
                users.Add(userr);
            }
            f.Close();
        }

    }  
}
