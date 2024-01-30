using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        public User(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this.Name = name;
            }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        private string _name = "user";
    }
}
