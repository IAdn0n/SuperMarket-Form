using System;
using System.Collections.Generic;
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

        public string getID() { return this.ID; }
        public string getName() { return this.Name;}
    }
}
