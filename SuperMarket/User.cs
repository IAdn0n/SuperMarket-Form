using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class User
    {
        private string ID;
        private string Name;
        public User(string ID, string Name) {
            this.ID = ID;
            this.Name = Name;
        }

        //gets the name of the user with id
        public static string getName(string id)
        {
            StreamReader file  = File.OpenText(Constants.FileMethods.USER_FILE);
            while (!file.EndOfStream)
            {
                string[] info = file.ReadLine().Split(',');
                if (id == info[0])
                {
                    file.Close();
                    return info[1];
                }
            }
            file.Close();
            return "";
        }

        public string getID() { return this.ID; }
        public string getName() { return this.Name;}
    }
}
